using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel.Dispatcher;
using System.ServiceModel.Description;
using System.ServiceModel.Channels;
using System.ServiceModel;
using CorsEnabledService;

namespace SmartTVService
{

    public class CorsConstants
    {
        internal const string Origin = "Origin";
        internal const string AccessControlAllowOrigin = "Access-Control-Allow-Origin";
        internal const string AccessControlRequestMethod = "Access-Control-Request-Method";
        internal const string AccessControlRequestHeaders = "Access-Control-Request-Headers";
        internal const string AccessControlAllowMethods = "Access-Control-Allow-Methods";
        internal const string AccessControlAllowHeaders = "Access-Control-Allow-Headers";

        internal const string PreflightSuffix = "_preflight_";
    }
    class CorsEnabledMessageInspector : IDispatchMessageInspector
    {
        private List<string> corsEnabledOperationNames;

        public CorsEnabledMessageInspector(List<OperationDescription> corsEnabledOperations)
        {
            this.corsEnabledOperationNames = corsEnabledOperations.Select(o => o.Name).ToList();
        }

        public object AfterReceiveRequest(ref Message request, IClientChannel channel, InstanceContext instanceContext)
        {
            HttpRequestMessageProperty httpProp = (HttpRequestMessageProperty)request.Properties[HttpRequestMessageProperty.Name];
            object operationName;
            request.Properties.TryGetValue(WebHttpDispatchOperationSelector.HttpOperationNamePropertyName, out operationName);
            if (httpProp != null && operationName != null && this.corsEnabledOperationNames.Contains((string)operationName))
            {
                string origin = httpProp.Headers[CorsConstants.Origin];
                if (origin != null)
                {
                    return origin;
                }
            }

            return null;
        }

        public void BeforeSendReply(ref Message reply, object correlationState)
        {
            string origin = correlationState as string;
            if (origin != null)
            {
                HttpResponseMessageProperty httpProp = null;
                if (reply.Properties.ContainsKey(HttpResponseMessageProperty.Name))
                {
                    httpProp = (HttpResponseMessageProperty)reply.Properties[HttpResponseMessageProperty.Name];
                }
                else
                {
                    httpProp = new HttpResponseMessageProperty();
                    reply.Properties.Add(HttpResponseMessageProperty.Name, httpProp);
                }

                httpProp.Headers.Add(CorsConstants.AccessControlAllowOrigin, origin);
            }
        }
    }
}

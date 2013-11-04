using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace SmartTVService
{
    class CorsEnabledServiceHostFactory : ServiceHostFactory
    {
        protected override ServiceHost CreateServiceHost(Type serviceType, Uri[] baseAddresses)
        {
            return new CorsEnabledServiceHost(serviceType, baseAddresses);
        }
    }

    class CorsEnabledServiceHost : ServiceHost
    {
        Type contractType;
        public CorsEnabledServiceHost(Type serviceType, Uri[] baseAddresses)
            : base(serviceType, baseAddresses)
        {
            this.contractType = GetContractType(serviceType);
        }

        protected override void OnOpening()
        {
            ServiceEndpoint endpoint = this.AddServiceEndpoint(this.contractType, new WebHttpBinding(), "");

            List<OperationDescription> corsEnabledOperations = endpoint.Contract.Operations
                .Where(o => o.Behaviors.Find<CorsEnabledAttribute>() != null)
                .ToList();

            AddPreflightOperationSelectors(endpoint, corsEnabledOperations);

            endpoint.Behaviors.Add(new WebHttpBehavior());
            endpoint.Behaviors.Add(new EnableCorsEndpointBehavior());

            base.OnOpening();
        }

        private Type GetContractType(Type serviceType)
        {
            if (HasServiceContract(serviceType))
            {
                return serviceType;
            }

            Type[] possibleContractTypes = serviceType.GetInterfaces()
                .Where(i => HasServiceContract(i))
                .ToArray();

            switch (possibleContractTypes.Length)
            {
                case 0:
                    throw new InvalidOperationException("Service type " + serviceType.FullName + " does not implement any interface decorated with the ServiceContractAttribute.");
                case 1:
                    return possibleContractTypes[0];
                default:
                    throw new InvalidOperationException("Service type " + serviceType.FullName + " implements multiple interfaces decorated with the ServiceContractAttribute, not supported by this factory.");
            }
        }

        private static bool HasServiceContract(Type type)
        {
            return Attribute.IsDefined(type, typeof(ServiceContractAttribute), false);
        }
    }
}

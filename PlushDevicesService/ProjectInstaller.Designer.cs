namespace PlushService
{
    partial class ProjectInstaller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PlushServiceProcessInstaller = new System.ServiceProcess.ServiceProcessInstaller();
            this.PlushServiceInstaller = new System.ServiceProcess.ServiceInstaller();
            // 
            // MobileServiceProcessInstaller
            // 
            this.PlushServiceProcessInstaller.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.PlushServiceProcessInstaller.Password = null;
            this.PlushServiceProcessInstaller.Username = null;
            // 
            // MobileServiceInstaller
            // 
            this.PlushServiceInstaller.ServiceName = "PlushService";
            this.PlushServiceInstaller.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.PlushServiceProcessInstaller,
            this.PlushServiceInstaller});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller PlushServiceProcessInstaller;
        public System.ServiceProcess.ServiceInstaller PlushServiceInstaller;
    }
}
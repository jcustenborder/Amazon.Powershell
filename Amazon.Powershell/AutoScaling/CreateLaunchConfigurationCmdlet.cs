namespace Amazon.Powershell.AutoScaling
{
    using Amazon.AutoScaling.Model;
    using Amazon.AutoScaling;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.CREATE, AutoScalingNouns.LAUNCHCONFIGURATION)]
    public class CreateLaunchConfigurationCmdlet : AutoScalingCmdLet
    {
        private string _LaunchConfigurationName;
        private string _ImageId;
        private string _KeyName;
        private string _SecurityGroups;
        private string _UserData;
        private string _InstanceType;
        private string _KernelId;
        private string _RamdiskId;
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string LaunchConfigurationName
        {
            get
            {
                return this._LaunchConfigurationName;
            }
            set
            {
                this._LaunchConfigurationName = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string ImageId
        {
            get
            {
                return this._ImageId;
            }
            set
            {
                this._ImageId = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string KeyName
        {
            get
            {
                return this._KeyName;
            }
            set
            {
                this._KeyName = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string SecurityGroups
        {
            get
            {
                return this._SecurityGroups;
            }
            set
            {
                this._SecurityGroups = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string UserData
        {
            get
            {
                return this._UserData;
            }
            set
            {
                this._UserData = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string InstanceType
        {
            get
            {
                return this._InstanceType;
            }
            set
            {
                this._InstanceType = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string KernelId
        {
            get
            {
                return this._KernelId;
            }
            set
            {
                this._KernelId = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string RamdiskId
        {
            get
            {
                return this._RamdiskId;
            }
            set
            {
                this._RamdiskId = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonAutoScaling client = base.GetClient();
            Amazon.AutoScaling.Model.CreateLaunchConfigurationRequest request = new Amazon.AutoScaling.Model.CreateLaunchConfigurationRequest();
            request.LaunchConfigurationName = this._LaunchConfigurationName;
            request.ImageId = this._ImageId;
            request.KeyName = this._KeyName;
            if (string.IsNullOrEmpty(this._SecurityGroups))
            {
                request.SecurityGroups.Add(this._SecurityGroups);
            }
            request.UserData = this._UserData;
            request.InstanceType = this._InstanceType;
            request.KernelId = this._KernelId;
            request.RamdiskId = this._RamdiskId;
            Amazon.AutoScaling.Model.CreateLaunchConfigurationResponse response = client.CreateLaunchConfiguration(request);
        }
    }
}

namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.RUN, EC2Nouns.INSTANCES)]
    public class RunInstancesCmdlet : EC2CmdLet
    {
        private string _ImageId;
        private decimal _MinCount;
        private decimal _MaxCount;
        private string _KeyName;
        private string _SecurityGroup;
        private string _UserData;
        private string _InstanceType;
        private string _KernelId;
        private string _RamdiskId;
        private string _SubnetId;
        private string _AdditionalInfo;
        private bool _DisableApiTermination;
        private string _InstanceInitiatedShutdownBehavior;
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
        public decimal MinCount
        {
            get
            {
                return this._MinCount;
            }
            set
            {
                this._MinCount = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public decimal MaxCount
        {
            get
            {
                return this._MaxCount;
            }
            set
            {
                this._MaxCount = value;
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
        public string SecurityGroup
        {
            get
            {
                return this._SecurityGroup;
            }
            set
            {
                this._SecurityGroup = value;
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
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string SubnetId
        {
            get
            {
                return this._SubnetId;
            }
            set
            {
                this._SubnetId = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string AdditionalInfo
        {
            get
            {
                return this._AdditionalInfo;
            }
            set
            {
                this._AdditionalInfo = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public bool DisableApiTermination
        {
            get
            {
                return this._DisableApiTermination;
            }
            set
            {
                this._DisableApiTermination = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string InstanceInitiatedShutdownBehavior
        {
            get
            {
                return this._InstanceInitiatedShutdownBehavior;
            }
            set
            {
                this._InstanceInitiatedShutdownBehavior = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonEC2 client = base.GetClient();
            Amazon.EC2.Model.RunInstancesRequest request = new Amazon.EC2.Model.RunInstancesRequest();
            request.ImageId = this._ImageId;
            request.MinCount = this._MinCount;
            request.MaxCount = this._MaxCount;
            request.KeyName = this._KeyName;
            if (string.IsNullOrEmpty(this._SecurityGroup))
            {
                request.SecurityGroup.Add(this._SecurityGroup);
            }
            request.UserData = this._UserData;
            request.InstanceType = this._InstanceType;
            request.KernelId = this._KernelId;
            request.RamdiskId = this._RamdiskId;
            request.SubnetId = this._SubnetId;
            request.AdditionalInfo = this._AdditionalInfo;
            request.DisableApiTermination = this._DisableApiTermination;
            request.InstanceInitiatedShutdownBehavior = this._InstanceInitiatedShutdownBehavior;
            Amazon.EC2.Model.RunInstancesResponse response = client.RunInstances(request);
            base.WriteObject(response.RunInstancesResult.Reservation, true);
        }
    }
}

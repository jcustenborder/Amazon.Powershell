namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.SPOT, EC2Nouns.INSTANCES)]
    public class SpotInstancesCmdlet : EC2CmdLet
    {
        private string _SpotPrice;
        private decimal _InstanceCount;
        private string _Type;
        private string _ValidFrom;
        private string _ValidUntil;
        private string _LaunchGroup;
        private string _AvailabilityZoneGroup;
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string SpotPrice
        {
            get
            {
                return this._SpotPrice;
            }
            set
            {
                this._SpotPrice = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public decimal InstanceCount
        {
            get
            {
                return this._InstanceCount;
            }
            set
            {
                this._InstanceCount = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string Type
        {
            get
            {
                return this._Type;
            }
            set
            {
                this._Type = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string ValidFrom
        {
            get
            {
                return this._ValidFrom;
            }
            set
            {
                this._ValidFrom = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string ValidUntil
        {
            get
            {
                return this._ValidUntil;
            }
            set
            {
                this._ValidUntil = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string LaunchGroup
        {
            get
            {
                return this._LaunchGroup;
            }
            set
            {
                this._LaunchGroup = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string AvailabilityZoneGroup
        {
            get
            {
                return this._AvailabilityZoneGroup;
            }
            set
            {
                this._AvailabilityZoneGroup = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonEC2 client = base.GetClient();
            Amazon.EC2.Model.RequestSpotInstancesRequest request = new Amazon.EC2.Model.RequestSpotInstancesRequest();
            request.SpotPrice = this._SpotPrice;
            request.InstanceCount = this._InstanceCount;
            request.Type = this._Type;
            request.ValidFrom = this._ValidFrom;
            request.ValidUntil = this._ValidUntil;
            request.LaunchGroup = this._LaunchGroup;
            request.AvailabilityZoneGroup = this._AvailabilityZoneGroup;
            Amazon.EC2.Model.RequestSpotInstancesResponse response = client.RequestSpotInstances(request);
            base.WriteObject(response.RequestSpotInstancesResult, true);
        }
    }
}

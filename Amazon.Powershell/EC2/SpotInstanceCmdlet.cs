namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.SPOT, EC2Nouns.INSTANCE)]
    public class SpotInstanceCmdlet : EC2CmdLet
    {
        private string _SpotInstanceRequestId;
        private string _SpotPrice;
        private string _Type;
        private string _State;
        private string _ValidFrom;
        private string _ValidUntil;
        private string _LaunchGroup;
        private string _AvailabilityZoneGroup;
        private string _InstanceId;
        private string _CreateTime;
        private string _ProductDescription;
        public string SpotInstanceRequestId
        {
            get
            {
                return this._SpotInstanceRequestId;
            }
            set
            {
                this._SpotInstanceRequestId = value;
            }
        }
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
        public string State
        {
            get
            {
                return this._State;
            }
            set
            {
                this._State = value;
            }
        }
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
        public string InstanceId
        {
            get
            {
                return this._InstanceId;
            }
            set
            {
                this._InstanceId = value;
            }
        }
        public string CreateTime
        {
            get
            {
                return this._CreateTime;
            }
            set
            {
                this._CreateTime = value;
            }
        }
        public string ProductDescription
        {
            get
            {
                return this._ProductDescription;
            }
            set
            {
                this._ProductDescription = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonModel client = base.GetClient();
            Amazon.EC2.Model.SpotInstanceRequest request = new Amazon.EC2.Model.SpotInstanceRequest();
            request.SpotInstanceRequestId = this._SpotInstanceRequestId;
            request.SpotPrice = this._SpotPrice;
            request.Type = this._Type;
            request.State = this._State;
            request.ValidFrom = this._ValidFrom;
            request.ValidUntil = this._ValidUntil;
            request.LaunchGroup = this._LaunchGroup;
            request.AvailabilityZoneGroup = this._AvailabilityZoneGroup;
            request.InstanceId = this._InstanceId;
            request.CreateTime = this._CreateTime;
            request.ProductDescription = this._ProductDescription;
        }
    }
}

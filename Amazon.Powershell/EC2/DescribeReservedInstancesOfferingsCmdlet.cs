namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.DESCRIBE, EC2Nouns.RESERVEDINSTANCESOFFERINGS)]
    public class DescribeReservedInstancesOfferingsCmdlet : EC2CmdLet
    {
        private string _ReservedInstancesId;
        private string _InstanceType;
        private string _AvailabilityZone;
        private string _ProductDescription;
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string ReservedInstancesId
        {
            get
            {
                return this._ReservedInstancesId;
            }
            set
            {
                this._ReservedInstancesId = value;
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
        public string AvailabilityZone
        {
            get
            {
                return this._AvailabilityZone;
            }
            set
            {
                this._AvailabilityZone = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
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
            AmazonEC2 client = base.GetClient();
            Amazon.EC2.Model.DescribeReservedInstancesOfferingsRequest request = new Amazon.EC2.Model.DescribeReservedInstancesOfferingsRequest();
            if (string.IsNullOrEmpty(this._ReservedInstancesId))
            {
                request.ReservedInstancesId.Add(this._ReservedInstancesId);
            }
            request.InstanceType = this._InstanceType;
            request.AvailabilityZone = this._AvailabilityZone;
            request.ProductDescription = this._ProductDescription;
            Amazon.EC2.Model.DescribeReservedInstancesOfferingsResponse response = client.DescribeReservedInstancesOfferings(request);
            base.WriteObject(response.DescribeReservedInstancesOfferingsResult, true);
        }
    }
}

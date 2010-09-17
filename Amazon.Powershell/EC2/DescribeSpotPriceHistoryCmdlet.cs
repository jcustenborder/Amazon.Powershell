namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.DESCRIBE, EC2Nouns.SPOTPRICEHISTORY)]
    public class DescribeSpotPriceHistoryCmdlet : EC2CmdLet
    {
        private string _StartTime;
        private string _EndTime;
        private string _InstanceType;
        private string _ProductDescription;
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string StartTime
        {
            get
            {
                return this._StartTime;
            }
            set
            {
                this._StartTime = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string EndTime
        {
            get
            {
                return this._EndTime;
            }
            set
            {
                this._EndTime = value;
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
            Amazon.EC2.Model.DescribeSpotPriceHistoryRequest request = new Amazon.EC2.Model.DescribeSpotPriceHistoryRequest();
            request.StartTime = this._StartTime;
            request.EndTime = this._EndTime;
            if (string.IsNullOrEmpty(this._InstanceType))
            {
                request.InstanceType.Add(this._InstanceType);
            }
            if (string.IsNullOrEmpty(this._ProductDescription))
            {
                request.ProductDescription.Add(this._ProductDescription);
            }
            Amazon.EC2.Model.DescribeSpotPriceHistoryResponse response = client.DescribeSpotPriceHistory(request);
            base.WriteObject(response.DescribeSpotPriceHistoryResult.SpotPriceHistory, true);
        }
    }
}

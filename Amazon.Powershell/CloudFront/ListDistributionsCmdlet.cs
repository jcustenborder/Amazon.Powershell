namespace Amazon.Powershell.CloudFront
{
    using Amazon.CloudFront.Model;
    using Amazon.CloudFront;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.LIST, CloudFrontNouns.DISTRIBUTIONS)]
    public class ListDistributionsCmdlet : CloudFrontCmdLet
    {
        private string _Marker;
        private string _MaxItems;
        private string _Id;
        private string _ETag;
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string Marker
        {
            get
            {
                return this._Marker;
            }
            set
            {
                this._Marker = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string MaxItems
        {
            get
            {
                return this._MaxItems;
            }
            set
            {
                this._MaxItems = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this._Id = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string ETag
        {
            get
            {
                return this._ETag;
            }
            set
            {
                this._ETag = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonCloudFront client = base.GetClient();
            Amazon.CloudFront.Model.ListDistributionsRequest request = new Amazon.CloudFront.Model.ListDistributionsRequest();
            request.Marker = this._Marker;
            request.MaxItems = this._MaxItems;
            request.Id = this._Id;
            request.ETag = this._ETag;
            Amazon.CloudFront.Model.ListDistributionsResponse response = client.ListDistributions(request);
        }
    }
}

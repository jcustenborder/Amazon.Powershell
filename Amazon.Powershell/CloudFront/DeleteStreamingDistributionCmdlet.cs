namespace Amazon.Powershell.CloudFront
{
    using Amazon.CloudFront.Model;
    using Amazon.CloudFront;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.DELETE, CloudFrontNouns.STREAMINGDISTRIBUTION)]
    public class DeleteStreamingDistributionCmdlet : CloudFrontCmdLet
    {
        private string _Id;
        private string _ETag;
        private string _Marker;
        private string _MaxItems;
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
        protected override void ProcessRecord()
        {
            AmazonCloudFront client = base.GetClient();
            Amazon.CloudFront.Model.DeleteStreamingDistributionRequest request = new Amazon.CloudFront.Model.DeleteStreamingDistributionRequest();
            request.Id = this._Id;
            request.ETag = this._ETag;
            request.Marker = this._Marker;
            request.MaxItems = this._MaxItems;
            Amazon.CloudFront.Model.DeleteStreamingDistributionResponse response = client.DeleteStreamingDistribution(request);
        }
    }
}

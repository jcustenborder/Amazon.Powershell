namespace Amazon.Powershell.S3
{
    using Amazon.S3.Model;
    using Amazon.S3;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.GET, S3Nouns.OBJECTMETADATA)]
    public class GetObjectMetadataCmdlet : S3CmdLet
    {
        private string _BucketName;
        private string _Key;
        private System.DateTime _ModifiedSinceDate;
        private System.DateTime _UnmodifiedSinceDate;
        private string _ETagToMatch;
        private string _ETagToNotMatch;
        private string _VersionId;
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string BucketName
        {
            get
            {
                return this._BucketName;
            }
            set
            {
                this._BucketName = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string Key
        {
            get
            {
                return this._Key;
            }
            set
            {
                this._Key = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public System.DateTime ModifiedSinceDate
        {
            get
            {
                return this._ModifiedSinceDate;
            }
            set
            {
                this._ModifiedSinceDate = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public System.DateTime UnmodifiedSinceDate
        {
            get
            {
                return this._UnmodifiedSinceDate;
            }
            set
            {
                this._UnmodifiedSinceDate = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string ETagToMatch
        {
            get
            {
                return this._ETagToMatch;
            }
            set
            {
                this._ETagToMatch = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string ETagToNotMatch
        {
            get
            {
                return this._ETagToNotMatch;
            }
            set
            {
                this._ETagToNotMatch = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string VersionId
        {
            get
            {
                return this._VersionId;
            }
            set
            {
                this._VersionId = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonS3 client = base.GetClient();
            Amazon.S3.Model.GetObjectMetadataRequest request = new Amazon.S3.Model.GetObjectMetadataRequest();
            request.BucketName = this._BucketName;
            request.Key = this._Key;
            request.ModifiedSinceDate = this._ModifiedSinceDate;
            request.UnmodifiedSinceDate = this._UnmodifiedSinceDate;
            request.ETagToMatch = this._ETagToMatch;
            request.ETagToNotMatch = this._ETagToNotMatch;
            request.VersionId = this._VersionId;
            Amazon.S3.Model.GetObjectMetadataResponse response = client.GetObjectMetadata(request);
        }
    }
}

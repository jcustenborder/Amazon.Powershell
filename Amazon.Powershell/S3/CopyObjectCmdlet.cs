namespace Amazon.Powershell.S3
{
    using Amazon.S3.Model;
    using Amazon.S3;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.COPY, S3Nouns.OBJECT)]
    public class CopyObjectCmdlet : S3CmdLet
    {
        private string _SourceBucket;
        private string _SourceKey;
        private string _DestinationBucket;
        private string _DestinationKey;
        private string _ContentType;
        private string _ETagToMatch;
        private string _ETagToNotMatch;
        private System.DateTime _ModifiedSinceDate;
        private System.DateTime _UnmodifiedSinceDate;
        private int _Timeout;
        private string _SourceVersionId;
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string SourceBucket
        {
            get
            {
                return this._SourceBucket;
            }
            set
            {
                this._SourceBucket = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string SourceKey
        {
            get
            {
                return this._SourceKey;
            }
            set
            {
                this._SourceKey = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string DestinationBucket
        {
            get
            {
                return this._DestinationBucket;
            }
            set
            {
                this._DestinationBucket = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string DestinationKey
        {
            get
            {
                return this._DestinationKey;
            }
            set
            {
                this._DestinationKey = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string ContentType
        {
            get
            {
                return this._ContentType;
            }
            set
            {
                this._ContentType = value;
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
        public int Timeout
        {
            get
            {
                return this._Timeout;
            }
            set
            {
                this._Timeout = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string SourceVersionId
        {
            get
            {
                return this._SourceVersionId;
            }
            set
            {
                this._SourceVersionId = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonS3 client = base.GetClient();
            Amazon.S3.Model.CopyObjectRequest request = new Amazon.S3.Model.CopyObjectRequest();
            request.SourceBucket = this._SourceBucket;
            request.SourceKey = this._SourceKey;
            request.DestinationBucket = this._DestinationBucket;
            request.DestinationKey = this._DestinationKey;
            request.ContentType = this._ContentType;
            request.ETagToMatch = this._ETagToMatch;
            request.ETagToNotMatch = this._ETagToNotMatch;
            request.ModifiedSinceDate = this._ModifiedSinceDate;
            request.UnmodifiedSinceDate = this._UnmodifiedSinceDate;
            request.Timeout = this._Timeout;
            request.SourceVersionId = this._SourceVersionId;
            Amazon.S3.Model.CopyObjectResponse response = client.CopyObject(request);
        }
    }
}

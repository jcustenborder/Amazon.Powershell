namespace Amazon.Powershell.S3
{
    using Amazon.S3.Model;
    using Amazon.S3;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.GET, S3Nouns.PRESIGNEDURL)]
    public class GetPreSignedUrlCmdlet : S3CmdLet
    {
        private string _BucketName;
        private string _Key;
        private System.DateTime _Expires;
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
        public System.DateTime Expires
        {
            get
            {
                return this._Expires;
            }
            set
            {
                this._Expires = value;
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
            Amazon.S3.Model.GetPreSignedUrlRequest request = new Amazon.S3.Model.GetPreSignedUrlRequest();
            request.BucketName = this._BucketName;
            request.Key = this._Key;
            request.Expires = this._Expires;
            request.VersionId = this._VersionId;
            string response = client.GetPreSignedURL(request);
        }
    }
}

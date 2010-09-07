namespace Amazon.Powershell.S3
{
    using Amazon.S3.Model;
    using Amazon.S3;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.PUT, S3Nouns.OBJECT)]
    public class PutObjectCmdlet : S3CmdLet
    {
        private string _BucketName;
        private string _Key;
        private string _FilePath;
        private string _MD5Digest;
        private bool _GenerateMD5Digest;
        private string _ContentType;
        private string _ContentBody;
        private int _Timeout;
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
        public string FilePath
        {
            get
            {
                return this._FilePath;
            }
            set
            {
                this._FilePath = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string MD5Digest
        {
            get
            {
                return this._MD5Digest;
            }
            set
            {
                this._MD5Digest = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public bool GenerateMD5Digest
        {
            get
            {
                return this._GenerateMD5Digest;
            }
            set
            {
                this._GenerateMD5Digest = value;
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
        public string ContentBody
        {
            get
            {
                return this._ContentBody;
            }
            set
            {
                this._ContentBody = value;
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
        protected override void ProcessRecord()
        {
            AmazonS3 client = base.GetClient();
            Amazon.S3.Model.PutObjectRequest request = new Amazon.S3.Model.PutObjectRequest();
            request.BucketName = this._BucketName;
            request.Key = this._Key;
            request.FilePath = this._FilePath;
            request.MD5Digest = this._MD5Digest;
            request.GenerateMD5Digest = this._GenerateMD5Digest;
            request.ContentType = this._ContentType;
            request.ContentBody = this._ContentBody;
            request.Timeout = this._Timeout;
            Amazon.S3.Model.PutObjectResponse response = client.PutObject(request);
        }
    }
}

namespace Amazon.Powershell.S3
{
    using Amazon.S3.Model;
    using Amazon.S3;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.LIST, S3Nouns.VERSIONS)]
    public class ListVersionsCmdlet : S3CmdLet
    {
        private string _BucketName;
        private string _Prefix;
        private string _KeyMarker;
        private string _VersionIdMarker;
        private int _MaxKeys;
        private string _Delimiter;
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
        public string Prefix
        {
            get
            {
                return this._Prefix;
            }
            set
            {
                this._Prefix = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string KeyMarker
        {
            get
            {
                return this._KeyMarker;
            }
            set
            {
                this._KeyMarker = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string VersionIdMarker
        {
            get
            {
                return this._VersionIdMarker;
            }
            set
            {
                this._VersionIdMarker = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public int MaxKeys
        {
            get
            {
                return this._MaxKeys;
            }
            set
            {
                this._MaxKeys = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string Delimiter
        {
            get
            {
                return this._Delimiter;
            }
            set
            {
                this._Delimiter = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonS3 client = base.GetClient();
            Amazon.S3.Model.ListVersionsRequest request = new Amazon.S3.Model.ListVersionsRequest();
            request.BucketName = this._BucketName;
            request.Prefix = this._Prefix;
            request.KeyMarker = this._KeyMarker;
            request.VersionIdMarker = this._VersionIdMarker;
            request.MaxKeys = this._MaxKeys;
            request.Delimiter = this._Delimiter;
            Amazon.S3.Model.ListVersionsResponse response = client.ListVersions(request);
        }
    }
}

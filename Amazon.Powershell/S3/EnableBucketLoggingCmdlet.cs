namespace Amazon.Powershell.S3
{
    using Amazon.S3.Model;
    using Amazon.S3;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.ENABLE, S3Nouns.BUCKETLOGGING)]
    public class EnableBucketLoggingCmdlet : S3CmdLet
    {
        private string _BucketName;
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
        protected override void ProcessRecord()
        {
            AmazonS3 client = base.GetClient();
            Amazon.S3.Model.EnableBucketLoggingRequest request = new Amazon.S3.Model.EnableBucketLoggingRequest();
            request.BucketName = this._BucketName;
            Amazon.S3.Model.EnableBucketLoggingResponse response = client.EnableBucketLogging(request);
        }
    }
}

namespace Amazon.Powershell.S3
{
    using Amazon.S3.Model;
    using Amazon.S3;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.SET, S3Nouns.BUCKETVERSIONING)]
    public class SetBucketVersioningCmdlet : S3CmdLet
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
            Amazon.S3.Model.SetBucketVersioningRequest request = new Amazon.S3.Model.SetBucketVersioningRequest();
            request.BucketName = this._BucketName;
            Amazon.S3.Model.SetBucketVersioningResponse response = client.SetBucketVersioning(request);
        }
    }
}

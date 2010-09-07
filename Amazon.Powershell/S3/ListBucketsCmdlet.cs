namespace Amazon.Powershell.S3
{
    using Amazon.S3.Model;
    using Amazon.S3;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.LIST, S3Nouns.BUCKETS)]
    public class ListBucketsCmdlet : S3CmdLet
    {
        protected override void ProcessRecord()
        {
            AmazonS3 client = base.GetClient();
            Amazon.S3.Model.ListBucketsRequest request = new Amazon.S3.Model.ListBucketsRequest();
            Amazon.S3.Model.ListBucketsResponse response = client.ListBuckets(request);
        }
    }
}

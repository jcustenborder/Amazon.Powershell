namespace Amazon.Powershell.S3
{
    using Amazon.S3.Model;
    using Amazon.S3;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    public abstract class S3CmdLet : AmazonCmdLet
    {
        protected virtual AmazonS3 GetClient()
        {
            AmazonCredentials.KeyPair credentials = base.GetCredentials();
            AmazonS3 client = new AmazonS3Client(credentials.AwsAccessKeyId, credentials.AwsSecretAccessKey);
            return client;
        }
    }
}

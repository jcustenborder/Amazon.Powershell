namespace Amazon.Powershell.CloudFront
{
    using Amazon.CloudFront.Model;
    using Amazon.CloudFront;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    public abstract class CloudFrontCmdLet : AmazonCmdLet
    {
        protected virtual AmazonCloudFront GetClient()
        {
            AmazonCredentials.KeyPair credentials = base.GetCredentials();
            AmazonCloudFront client = new AmazonCloudFrontClient(credentials.AwsAccessKeyId, credentials.AwsSecretAccessKey);
            return client;
        }
    }
}

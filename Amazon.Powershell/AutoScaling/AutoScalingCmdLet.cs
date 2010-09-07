namespace Amazon.Powershell.AutoScaling
{
    using Amazon.AutoScaling.Model;
    using Amazon.AutoScaling;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    public abstract class AutoScalingCmdLet : AmazonCmdLet
    {
        protected virtual AmazonAutoScaling GetClient()
        {
            AmazonCredentials.KeyPair credentials = base.GetCredentials();
            AmazonAutoScaling client = new AmazonAutoScalingClient(credentials.AwsAccessKeyId, credentials.AwsSecretAccessKey);
            return client;
        }
    }
}

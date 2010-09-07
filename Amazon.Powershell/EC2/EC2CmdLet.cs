namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    public abstract class EC2CmdLet : AmazonCmdLet
    {
        protected virtual AmazonEC2 GetClient()
        {
            AmazonCredentials.KeyPair credentials = base.GetCredentials();
            AmazonEC2 client = new AmazonEC2Client(credentials.AwsAccessKeyId, credentials.AwsSecretAccessKey);
            return client;
        }
    }
}

namespace Amazon.Powershell.RDS
{
    using Amazon.RDS.Model;
    using Amazon.RDS;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    public abstract class RDSCmdLet : AmazonCmdLet
    {
        protected virtual AmazonRDS GetClient()
        {
            AmazonCredentials.KeyPair credentials = base.GetCredentials();
            AmazonRDS client = new AmazonRDSClient(credentials.AwsAccessKeyId, credentials.AwsSecretAccessKey);
            return client;
        }
    }
}

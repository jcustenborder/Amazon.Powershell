namespace Amazon.Powershell.SimpleDB
{
    using Amazon.SimpleDB.Model;
    using Amazon.SimpleDB;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    public abstract class SimpleDBCmdLet : AmazonCmdLet
    {
        protected virtual AmazonSimpleDB GetClient()
        {
            AmazonCredentials.KeyPair credentials = base.GetCredentials();
            AmazonSimpleDB client = new AmazonSimpleDBClient(credentials.AwsAccessKeyId, credentials.AwsSecretAccessKey);
            return client;
        }
    }
}

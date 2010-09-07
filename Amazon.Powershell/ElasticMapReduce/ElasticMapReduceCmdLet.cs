namespace Amazon.Powershell.ElasticMapReduce
{
    using Amazon.ElasticMapReduce.Model;
    using Amazon.ElasticMapReduce;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    public abstract class ElasticMapReduceCmdLet : AmazonCmdLet
    {
        protected virtual AmazonElasticMapReduce GetClient()
        {
            AmazonCredentials.KeyPair credentials = base.GetCredentials();
            AmazonElasticMapReduce client = new AmazonElasticMapReduceClient(credentials.AwsAccessKeyId, credentials.AwsSecretAccessKey);
            return client;
        }
    }
}

namespace Amazon.Powershell.ElasticLoadBalancing
{
    using Amazon.ElasticLoadBalancing.Model;
    using Amazon.ElasticLoadBalancing;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    public abstract class ElasticLoadBalancingCmdLet : AmazonCmdLet
    {
        protected virtual AmazonElasticLoadBalancing GetClient()
        {
            AmazonCredentials.KeyPair credentials = base.GetCredentials();
            AmazonElasticLoadBalancing client = new AmazonElasticLoadBalancingClient(credentials.AwsAccessKeyId, credentials.AwsSecretAccessKey);
            return client;
        }
    }
}

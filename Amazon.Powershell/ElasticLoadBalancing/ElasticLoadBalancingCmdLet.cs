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
            throw new System.NotSupportedException();
        }
    }
}

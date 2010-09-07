namespace Amazon.Powershell.ElasticLoadBalancing
{
    using Amazon.ElasticLoadBalancing.Model;
    using Amazon.ElasticLoadBalancing;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.SET, ElasticLoadBalancingNouns.LOADBALANCERPOLICIESOFLISTENER)]
    public class SetLoadBalancerPoliciesOfListenerCmdlet : ElasticLoadBalancingCmdLet
    {
        protected override void EndProcessing()
        {
            throw new System.NotImplementedException();
        }
    }
}

namespace Amazon.Powershell.ElasticLoadBalancing
{
    using Amazon.ElasticLoadBalancing.Model;
    using Amazon.ElasticLoadBalancing;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.DELETE, ElasticLoadBalancingNouns.LOADBALANCERPOLICY)]
    public class DeleteLoadBalancerPolicyCmdlet : ElasticLoadBalancingCmdLet
    {
        private string _LoadBalancerName;
        private string _PolicyName;
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string LoadBalancerName
        {
            get
            {
                return this._LoadBalancerName;
            }
            set
            {
                this._LoadBalancerName = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string PolicyName
        {
            get
            {
                return this._PolicyName;
            }
            set
            {
                this._PolicyName = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonElasticLoadBalancing client = base.GetClient();
            Amazon.ElasticLoadBalancing.Model.DeleteLoadBalancerPolicyRequest request = new Amazon.ElasticLoadBalancing.Model.DeleteLoadBalancerPolicyRequest();
            request.LoadBalancerName = this._LoadBalancerName;
            request.PolicyName = this._PolicyName;
            Amazon.ElasticLoadBalancing.Model.DeleteLoadBalancerPolicyResponse response = client.DeleteLoadBalancerPolicy(request);
        }
    }
}

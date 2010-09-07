namespace Amazon.Powershell.ElasticLoadBalancing
{
    using Amazon.ElasticLoadBalancing.Model;
    using Amazon.ElasticLoadBalancing;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.DELETE, ElasticLoadBalancingNouns.LOADBALANCER)]
    public class DeleteLoadBalancerCmdlet : ElasticLoadBalancingCmdLet
    {
        private string _LoadBalancerName;
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
        protected override void ProcessRecord()
        {
            AmazonElasticLoadBalancing client = base.GetClient();
            Amazon.ElasticLoadBalancing.Model.DeleteLoadBalancerRequest request = new Amazon.ElasticLoadBalancing.Model.DeleteLoadBalancerRequest();
            request.LoadBalancerName = this._LoadBalancerName;
            Amazon.ElasticLoadBalancing.Model.DeleteLoadBalancerResponse response = client.DeleteLoadBalancer(request);
            base.WriteObject(response.DeleteLoadBalancerResult, true);
        }
    }
}

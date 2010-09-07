namespace Amazon.Powershell.ElasticLoadBalancing
{
    using Amazon.ElasticLoadBalancing.Model;
    using Amazon.ElasticLoadBalancing;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.REGISTER, ElasticLoadBalancingNouns.INSTANCESWITHLOADBALANCER)]
    public class RegisterInstancesWithLoadBalancerCmdlet : ElasticLoadBalancingCmdLet
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
            Amazon.ElasticLoadBalancing.Model.RegisterInstancesWithLoadBalancerRequest request = new Amazon.ElasticLoadBalancing.Model.RegisterInstancesWithLoadBalancerRequest();
            request.LoadBalancerName = this._LoadBalancerName;
            Amazon.ElasticLoadBalancing.Model.RegisterInstancesWithLoadBalancerResponse response = client.RegisterInstancesWithLoadBalancer(request);
            base.WriteObject(response.RegisterInstancesWithLoadBalancerResult, true);
        }
    }
}

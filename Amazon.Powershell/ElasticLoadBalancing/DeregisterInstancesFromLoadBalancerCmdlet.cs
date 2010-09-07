namespace Amazon.Powershell.ElasticLoadBalancing
{
    using Amazon.ElasticLoadBalancing.Model;
    using Amazon.ElasticLoadBalancing;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.DEREGISTER, ElasticLoadBalancingNouns.INSTANCESFROMLOADBALANCER)]
    public class DeregisterInstancesFromLoadBalancerCmdlet : ElasticLoadBalancingCmdLet
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
            Amazon.ElasticLoadBalancing.Model.DeregisterInstancesFromLoadBalancerRequest request = new Amazon.ElasticLoadBalancing.Model.DeregisterInstancesFromLoadBalancerRequest();
            request.LoadBalancerName = this._LoadBalancerName;
            Amazon.ElasticLoadBalancing.Model.DeregisterInstancesFromLoadBalancerResponse response = client.DeregisterInstancesFromLoadBalancer(request);
            base.WriteObject(response.DeregisterInstancesFromLoadBalancerResult, true);
        }
    }
}

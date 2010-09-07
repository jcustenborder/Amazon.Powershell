namespace Amazon.Powershell.ElasticLoadBalancing
{
    using Amazon.ElasticLoadBalancing.Model;
    using Amazon.ElasticLoadBalancing;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.CREATE, ElasticLoadBalancingNouns.LOADBALANCER)]
    public class CreateLoadBalancerCmdlet : ElasticLoadBalancingCmdLet
    {
        private string _LoadBalancerName;
        private string _AvailabilityZones;
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
        public string AvailabilityZones
        {
            get
            {
                return this._AvailabilityZones;
            }
            set
            {
                this._AvailabilityZones = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonElasticLoadBalancing client = base.GetClient();
            Amazon.ElasticLoadBalancing.Model.CreateLoadBalancerRequest request = new Amazon.ElasticLoadBalancing.Model.CreateLoadBalancerRequest();
            request.LoadBalancerName = this._LoadBalancerName;
            if (string.IsNullOrEmpty(this._AvailabilityZones))
            {
                request.AvailabilityZones.Add(this._AvailabilityZones);
            }
            Amazon.ElasticLoadBalancing.Model.CreateLoadBalancerResponse response = client.CreateLoadBalancer(request);
            base.WriteObject(response.CreateLoadBalancerResult, true);
        }
    }
}

namespace Amazon.Powershell.ElasticLoadBalancing
{
    using Amazon.ElasticLoadBalancing.Model;
    using Amazon.ElasticLoadBalancing;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.ENABLE, ElasticLoadBalancingNouns.AVAILABILITYZONESFORLOADBALANCER)]
    public class EnableAvailabilityZonesForLoadBalancerCmdlet : ElasticLoadBalancingCmdLet
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
            Amazon.ElasticLoadBalancing.Model.EnableAvailabilityZonesForLoadBalancerRequest request = new Amazon.ElasticLoadBalancing.Model.EnableAvailabilityZonesForLoadBalancerRequest();
            request.LoadBalancerName = this._LoadBalancerName;
            if (string.IsNullOrEmpty(this._AvailabilityZones))
            {
                request.AvailabilityZones.Add(this._AvailabilityZones);
            }
            Amazon.ElasticLoadBalancing.Model.EnableAvailabilityZonesForLoadBalancerResponse response = client.EnableAvailabilityZonesForLoadBalancer(request);
            base.WriteObject(response.EnableAvailabilityZonesForLoadBalancerResult, true);
        }
    }
}

namespace Amazon.Powershell.ElasticLoadBalancing
{
    using Amazon.ElasticLoadBalancing.Model;
    using Amazon.ElasticLoadBalancing;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.DISABLE, ElasticLoadBalancingNouns.AVAILABILITYZONESFORLOADBALANCER)]
    public class DisableAvailabilityZonesForLoadBalancerCmdlet : ElasticLoadBalancingCmdLet
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
            Amazon.ElasticLoadBalancing.Model.DisableAvailabilityZonesForLoadBalancerRequest request = new Amazon.ElasticLoadBalancing.Model.DisableAvailabilityZonesForLoadBalancerRequest();
            request.LoadBalancerName = this._LoadBalancerName;
            if (string.IsNullOrEmpty(this._AvailabilityZones))
            {
                request.AvailabilityZones.Add(this._AvailabilityZones);
            }
            Amazon.ElasticLoadBalancing.Model.DisableAvailabilityZonesForLoadBalancerResponse response = client.DisableAvailabilityZonesForLoadBalancer(request);
            base.WriteObject(response.DisableAvailabilityZonesForLoadBalancerResult, true);
        }
    }
}

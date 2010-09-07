namespace Amazon.Powershell.ElasticLoadBalancing
{
    using Amazon.ElasticLoadBalancing.Model;
    using Amazon.ElasticLoadBalancing;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.CONFIGURE, ElasticLoadBalancingNouns.HEALTHCHECK)]
    public class ConfigureHealthCheckCmdlet : ElasticLoadBalancingCmdLet
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
            Amazon.ElasticLoadBalancing.Model.ConfigureHealthCheckRequest request = new Amazon.ElasticLoadBalancing.Model.ConfigureHealthCheckRequest();
            request.LoadBalancerName = this._LoadBalancerName;
            Amazon.ElasticLoadBalancing.Model.ConfigureHealthCheckResponse response = client.ConfigureHealthCheck(request);
            base.WriteObject(response.ConfigureHealthCheckResult, true);
        }
    }
}

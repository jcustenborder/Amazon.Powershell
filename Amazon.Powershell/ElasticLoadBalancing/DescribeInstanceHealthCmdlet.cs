namespace Amazon.Powershell.ElasticLoadBalancing
{
    using Amazon.ElasticLoadBalancing.Model;
    using Amazon.ElasticLoadBalancing;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.DESCRIBE, ElasticLoadBalancingNouns.INSTANCEHEALTH)]
    public class DescribeInstanceHealthCmdlet : ElasticLoadBalancingCmdLet
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
            Amazon.ElasticLoadBalancing.Model.DescribeInstanceHealthRequest request = new Amazon.ElasticLoadBalancing.Model.DescribeInstanceHealthRequest();
            request.LoadBalancerName = this._LoadBalancerName;
            Amazon.ElasticLoadBalancing.Model.DescribeInstanceHealthResponse response = client.DescribeInstanceHealth(request);
            base.WriteObject(response.DescribeInstanceHealthResult, true);
        }
    }
}

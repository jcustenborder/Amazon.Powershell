namespace Amazon.Powershell.ElasticLoadBalancing
{
    using Amazon.ElasticLoadBalancing.Model;
    using Amazon.ElasticLoadBalancing;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.DESCRIBE, ElasticLoadBalancingNouns.LOADBALANCERS)]
    public class DescribeLoadBalancersCmdlet : ElasticLoadBalancingCmdLet
    {
        private string _LoadBalancerNames;
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string LoadBalancerNames
        {
            get
            {
                return this._LoadBalancerNames;
            }
            set
            {
                this._LoadBalancerNames = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonElasticLoadBalancing client = base.GetClient();
            Amazon.ElasticLoadBalancing.Model.DescribeLoadBalancersRequest request = new Amazon.ElasticLoadBalancing.Model.DescribeLoadBalancersRequest();
            if (string.IsNullOrEmpty(this._LoadBalancerNames))
            {
                request.LoadBalancerNames.Add(this._LoadBalancerNames);
            }
            Amazon.ElasticLoadBalancing.Model.DescribeLoadBalancersResponse response = client.DescribeLoadBalancers(request);
            
            base.WriteObject(response.DescribeLoadBalancersResult.LoadBalancerDescriptions, true);
        }
    }
}

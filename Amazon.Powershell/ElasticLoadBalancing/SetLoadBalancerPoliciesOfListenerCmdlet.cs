namespace Amazon.Powershell.ElasticLoadBalancing
{
    using Amazon.ElasticLoadBalancing.Model;
    using Amazon.ElasticLoadBalancing;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.SET, ElasticLoadBalancingNouns.LOADBALANCERPOLICIESOFLISTENER)]
    public class SetLoadBalancerPoliciesOfListenerCmdlet : ElasticLoadBalancingCmdLet
    {
        private string _LoadBalancerName;
        private decimal _LoadBalancerPort;
        private string _PolicyNames;
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
        public decimal LoadBalancerPort
        {
            get
            {
                return this._LoadBalancerPort;
            }
            set
            {
                this._LoadBalancerPort = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string PolicyNames
        {
            get
            {
                return this._PolicyNames;
            }
            set
            {
                this._PolicyNames = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonElasticLoadBalancing client = base.GetClient();
            Amazon.ElasticLoadBalancing.Model.SetLoadBalancerPoliciesOfListenerRequest request = new Amazon.ElasticLoadBalancing.Model.SetLoadBalancerPoliciesOfListenerRequest();
            request.LoadBalancerName = this._LoadBalancerName;
            request.LoadBalancerPort = this._LoadBalancerPort;
            if (string.IsNullOrEmpty(this._PolicyNames))
            {
                request.PolicyNames.Add(this._PolicyNames);
            }
            Amazon.ElasticLoadBalancing.Model.SetLoadBalancerPoliciesOfListenerResponse response = client.SetLoadBalancerPoliciesOfListener(request);
        }
    }
}

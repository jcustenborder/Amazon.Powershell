namespace Amazon.Powershell.ElasticLoadBalancing
{
    using Amazon.ElasticLoadBalancing.Model;
    using Amazon.ElasticLoadBalancing;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.CREATE, ElasticLoadBalancingNouns.LBCOOKIESTICKINESSPOLICY)]
    public class CreateLBCookieStickinessPolicyCmdlet : ElasticLoadBalancingCmdLet
    {
        private string _LoadBalancerName;
        private string _PolicyName;
        private decimal _CookieExpirationPeriod;
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
        public string PolicyName
        {
            get
            {
                return this._PolicyName;
            }
            set
            {
                this._PolicyName = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public decimal CookieExpirationPeriod
        {
            get
            {
                return this._CookieExpirationPeriod;
            }
            set
            {
                this._CookieExpirationPeriod = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonElasticLoadBalancing client = base.GetClient();
            Amazon.ElasticLoadBalancing.Model.CreateLBCookieStickinessPolicyRequest request = new Amazon.ElasticLoadBalancing.Model.CreateLBCookieStickinessPolicyRequest();
            request.LoadBalancerName = this._LoadBalancerName;
            request.PolicyName = this._PolicyName;
            request.CookieExpirationPeriod = this._CookieExpirationPeriod;
            Amazon.ElasticLoadBalancing.Model.CreateLBCookieStickinessPolicyResponse response = client.CreateLBCookieStickinessPolicy(request);
        }
    }
}

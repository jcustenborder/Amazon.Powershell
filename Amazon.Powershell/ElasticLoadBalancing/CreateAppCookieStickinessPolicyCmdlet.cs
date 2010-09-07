namespace Amazon.Powershell.ElasticLoadBalancing
{
    using Amazon.ElasticLoadBalancing.Model;
    using Amazon.ElasticLoadBalancing;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.CREATE, ElasticLoadBalancingNouns.APPCOOKIESTICKINESSPOLICY)]
    public class CreateAppCookieStickinessPolicyCmdlet : ElasticLoadBalancingCmdLet
    {
        private string _LoadBalancerName;
        private string _PolicyName;
        private string _CookieName;
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
        public string CookieName
        {
            get
            {
                return this._CookieName;
            }
            set
            {
                this._CookieName = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonElasticLoadBalancing client = base.GetClient();
            Amazon.ElasticLoadBalancing.Model.CreateAppCookieStickinessPolicyRequest request = new Amazon.ElasticLoadBalancing.Model.CreateAppCookieStickinessPolicyRequest();
            request.LoadBalancerName = this._LoadBalancerName;
            request.PolicyName = this._PolicyName;
            request.CookieName = this._CookieName;
            Amazon.ElasticLoadBalancing.Model.CreateAppCookieStickinessPolicyResponse response = client.CreateAppCookieStickinessPolicy(request);
        }
    }
}

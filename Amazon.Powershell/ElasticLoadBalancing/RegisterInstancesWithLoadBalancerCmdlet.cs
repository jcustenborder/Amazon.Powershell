namespace Amazon.Powershell.ElasticLoadBalancing
{
    using Amazon.ElasticLoadBalancing.Model;
    using Amazon.ElasticLoadBalancing;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.REGISTER, ElasticLoadBalancingNouns.INSTANCESWITHLOADBALANCER)]
    public class RegisterInstancesWithLoadBalancerCmdlet : ElasticLoadBalancingCmdLet
    {
        private string _LoadBalancerName;
        [Parameter(Mandatory=true, ValueFromPipelineByPropertyName=true)]
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

        private string _InstanceId;
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true)]
        public string InstanceId
        {
            get
            {
                return this._InstanceId;
            }
            set
            {
                this._InstanceId = value;
            }
        }



        protected override void ProcessRecord()
        {
            AmazonElasticLoadBalancing client = base.GetClient();
            Amazon.ElasticLoadBalancing.Model.RegisterInstancesWithLoadBalancerRequest request = new Amazon.ElasticLoadBalancing.Model.RegisterInstancesWithLoadBalancerRequest();
            request.LoadBalancerName = this._LoadBalancerName;
            request.Instances.Add(new Instance(){InstanceId=this.InstanceId});
            Amazon.ElasticLoadBalancing.Model.RegisterInstancesWithLoadBalancerResponse response = client.RegisterInstancesWithLoadBalancer(request);
            base.WriteObject(response.RegisterInstancesWithLoadBalancerResult, true);
        }
    }
}

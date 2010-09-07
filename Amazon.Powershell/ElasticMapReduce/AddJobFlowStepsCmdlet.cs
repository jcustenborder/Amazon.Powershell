namespace Amazon.Powershell.ElasticMapReduce
{
    using Amazon.ElasticMapReduce.Model;
    using Amazon.ElasticMapReduce;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.ADD, ElasticMapReduceNouns.JOBFLOWSTEPS)]
    public class AddJobFlowStepsCmdlet : ElasticMapReduceCmdLet
    {
        private string _JobFlowId;
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string JobFlowId
        {
            get
            {
                return this._JobFlowId;
            }
            set
            {
                this._JobFlowId = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonElasticMapReduce client = base.GetClient();
            Amazon.ElasticMapReduce.Model.AddJobFlowStepsRequest request = new Amazon.ElasticMapReduce.Model.AddJobFlowStepsRequest();
            request.JobFlowId = this._JobFlowId;
            Amazon.ElasticMapReduce.Model.AddJobFlowStepsResponse response = client.AddJobFlowSteps(request);
        }
    }
}

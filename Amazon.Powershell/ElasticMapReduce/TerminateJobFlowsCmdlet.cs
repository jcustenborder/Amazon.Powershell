namespace Amazon.Powershell.ElasticMapReduce
{
    using Amazon.ElasticMapReduce.Model;
    using Amazon.ElasticMapReduce;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.TERMINATE, ElasticMapReduceNouns.JOBFLOWS)]
    public class TerminateJobFlowsCmdlet : ElasticMapReduceCmdLet
    {
        private string _JobFlowIds;
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string JobFlowIds
        {
            get
            {
                return this._JobFlowIds;
            }
            set
            {
                this._JobFlowIds = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonElasticMapReduce client = base.GetClient();
            Amazon.ElasticMapReduce.Model.TerminateJobFlowsRequest request = new Amazon.ElasticMapReduce.Model.TerminateJobFlowsRequest();
            if (string.IsNullOrEmpty(this._JobFlowIds))
            {
                request.JobFlowIds.Add(this._JobFlowIds);
            }
            Amazon.ElasticMapReduce.Model.TerminateJobFlowsResponse response = client.TerminateJobFlows(request);
        }
    }
}

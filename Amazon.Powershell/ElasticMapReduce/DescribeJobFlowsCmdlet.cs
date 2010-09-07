namespace Amazon.Powershell.ElasticMapReduce
{
    using Amazon.ElasticMapReduce.Model;
    using Amazon.ElasticMapReduce;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.DESCRIBE, ElasticMapReduceNouns.JOBFLOWS)]
    public class DescribeJobFlowsCmdlet : ElasticMapReduceCmdLet
    {
        private string _CreatedAfter;
        private string _CreatedBefore;
        private string _JobFlowIds;
        private string _JobFlowStates;
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string CreatedAfter
        {
            get
            {
                return this._CreatedAfter;
            }
            set
            {
                this._CreatedAfter = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string CreatedBefore
        {
            get
            {
                return this._CreatedBefore;
            }
            set
            {
                this._CreatedBefore = value;
            }
        }
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
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string JobFlowStates
        {
            get
            {
                return this._JobFlowStates;
            }
            set
            {
                this._JobFlowStates = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonElasticMapReduce client = base.GetClient();
            Amazon.ElasticMapReduce.Model.DescribeJobFlowsRequest request = new Amazon.ElasticMapReduce.Model.DescribeJobFlowsRequest();
            request.CreatedAfter = this._CreatedAfter;
            request.CreatedBefore = this._CreatedBefore;
            if (string.IsNullOrEmpty(this._JobFlowIds))
            {
                request.JobFlowIds.Add(this._JobFlowIds);
            }
            if (string.IsNullOrEmpty(this._JobFlowStates))
            {
                request.JobFlowStates.Add(this._JobFlowStates);
            }
            Amazon.ElasticMapReduce.Model.DescribeJobFlowsResponse response = client.DescribeJobFlows(request);
            base.WriteObject(response.DescribeJobFlowsResult, true);
        }
    }
}

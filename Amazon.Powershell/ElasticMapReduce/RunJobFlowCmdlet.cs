namespace Amazon.Powershell.ElasticMapReduce
{
    using Amazon.ElasticMapReduce.Model;
    using Amazon.ElasticMapReduce;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.RUN, ElasticMapReduceNouns.JOBFLOW)]
    public class RunJobFlowCmdlet : ElasticMapReduceCmdLet
    {
        private string _Name;
        private string _LogUri;
        private string _AdditionalInfo;
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this._Name = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string LogUri
        {
            get
            {
                return this._LogUri;
            }
            set
            {
                this._LogUri = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string AdditionalInfo
        {
            get
            {
                return this._AdditionalInfo;
            }
            set
            {
                this._AdditionalInfo = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonElasticMapReduce client = base.GetClient();
            Amazon.ElasticMapReduce.Model.RunJobFlowRequest request = new Amazon.ElasticMapReduce.Model.RunJobFlowRequest();
            request.Name = this._Name;
            request.LogUri = this._LogUri;
            request.AdditionalInfo = this._AdditionalInfo;
            Amazon.ElasticMapReduce.Model.RunJobFlowResponse response = client.RunJobFlow(request);
            base.WriteObject(response.RunJobFlowResult, true);
        }
    }
}

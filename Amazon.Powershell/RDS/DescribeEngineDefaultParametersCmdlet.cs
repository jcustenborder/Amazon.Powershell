namespace Amazon.Powershell.RDS
{
    using Amazon.RDS.Model;
    using Amazon.RDS;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.DESCRIBE, RDSNouns.ENGINEDEFAULTPARAMETERS)]
    public class DescribeEngineDefaultParametersCmdlet : RDSCmdLet
    {
        private string _Engine;
        private decimal _MaxRecords;
        private string _Marker;
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string Engine
        {
            get
            {
                return this._Engine;
            }
            set
            {
                this._Engine = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public decimal MaxRecords
        {
            get
            {
                return this._MaxRecords;
            }
            set
            {
                this._MaxRecords = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string Marker
        {
            get
            {
                return this._Marker;
            }
            set
            {
                this._Marker = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonRDS client = base.GetClient();
            Amazon.RDS.Model.DescribeEngineDefaultParametersRequest request = new Amazon.RDS.Model.DescribeEngineDefaultParametersRequest();
            request.Engine = this._Engine;
            request.MaxRecords = this._MaxRecords;
            request.Marker = this._Marker;
            Amazon.RDS.Model.DescribeEngineDefaultParametersResponse response = client.DescribeEngineDefaultParameters(request);
            base.WriteObject(response.DescribeEngineDefaultParametersResult, true);
        }
    }
}

namespace Amazon.Powershell.RDS
{
    using Amazon.RDS.Model;
    using Amazon.RDS;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.DESCRIBE, RDSNouns.DBPARAMETERS)]
    public class DescribeDBParametersCmdlet : RDSCmdLet
    {
        private string _DBParameterGroupName;
        private string _Source;
        private decimal _MaxRecords;
        private string _Marker;
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string DBParameterGroupName
        {
            get
            {
                return this._DBParameterGroupName;
            }
            set
            {
                this._DBParameterGroupName = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string Source
        {
            get
            {
                return this._Source;
            }
            set
            {
                this._Source = value;
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
            Amazon.RDS.Model.DescribeDBParametersRequest request = new Amazon.RDS.Model.DescribeDBParametersRequest();
            request.DBParameterGroupName = this._DBParameterGroupName;
            request.Source = this._Source;
            request.MaxRecords = this._MaxRecords;
            request.Marker = this._Marker;
            Amazon.RDS.Model.DescribeDBParametersResponse response = client.DescribeDBParameters(request);
            base.WriteObject(response.DescribeDBParametersResult, true);
        }
    }
}

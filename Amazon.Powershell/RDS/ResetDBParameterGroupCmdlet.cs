namespace Amazon.Powershell.RDS
{
    using Amazon.RDS.Model;
    using Amazon.RDS;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.RESET, RDSNouns.DBPARAMETERGROUP)]
    public class ResetDBParameterGroupCmdlet : RDSCmdLet
    {
        private string _DBParameterGroupName;
        private bool _ResetAllParameters;
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
        public bool ResetAllParameters
        {
            get
            {
                return this._ResetAllParameters;
            }
            set
            {
                this._ResetAllParameters = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonRDS client = base.GetClient();
            Amazon.RDS.Model.ResetDBParameterGroupRequest request = new Amazon.RDS.Model.ResetDBParameterGroupRequest();
            request.DBParameterGroupName = this._DBParameterGroupName;
            request.ResetAllParameters = this._ResetAllParameters;
            Amazon.RDS.Model.ResetDBParameterGroupResponse response = client.ResetDBParameterGroup(request);
            base.WriteObject(response.ResetDBParameterGroupResult, true);
        }
    }
}

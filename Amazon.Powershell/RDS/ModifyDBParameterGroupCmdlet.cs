namespace Amazon.Powershell.RDS
{
    using Amazon.RDS.Model;
    using Amazon.RDS;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.MODIFY, RDSNouns.DBPARAMETERGROUP)]
    public class ModifyDBParameterGroupCmdlet : RDSCmdLet
    {
        private string _DBParameterGroupName;
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
        protected override void ProcessRecord()
        {
            AmazonRDS client = base.GetClient();
            Amazon.RDS.Model.ModifyDBParameterGroupRequest request = new Amazon.RDS.Model.ModifyDBParameterGroupRequest();
            request.DBParameterGroupName = this._DBParameterGroupName;
            Amazon.RDS.Model.ModifyDBParameterGroupResponse response = client.ModifyDBParameterGroup(request);
            base.WriteObject(response.ModifyDBParameterGroupResult, true);
        }
    }
}

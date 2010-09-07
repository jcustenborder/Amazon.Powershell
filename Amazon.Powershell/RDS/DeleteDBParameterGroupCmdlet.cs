namespace Amazon.Powershell.RDS
{
    using Amazon.RDS.Model;
    using Amazon.RDS;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.DELETE, RDSNouns.DBPARAMETERGROUP)]
    public class DeleteDBParameterGroupCmdlet : RDSCmdLet
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
            Amazon.RDS.Model.DeleteDBParameterGroupRequest request = new Amazon.RDS.Model.DeleteDBParameterGroupRequest();
            request.DBParameterGroupName = this._DBParameterGroupName;
            Amazon.RDS.Model.DeleteDBParameterGroupResponse response = client.DeleteDBParameterGroup(request);
        }
    }
}

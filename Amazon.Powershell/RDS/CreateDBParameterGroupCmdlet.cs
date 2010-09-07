namespace Amazon.Powershell.RDS
{
    using Amazon.RDS.Model;
    using Amazon.RDS;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.CREATE, RDSNouns.DBPARAMETERGROUP)]
    public class CreateDBParameterGroupCmdlet : RDSCmdLet
    {
        private string _DBParameterGroupName;
        private string _Engine;
        private string _Description;
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
        public string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                this._Description = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonRDS client = base.GetClient();
            Amazon.RDS.Model.CreateDBParameterGroupRequest request = new Amazon.RDS.Model.CreateDBParameterGroupRequest();
            request.DBParameterGroupName = this._DBParameterGroupName;
            request.Engine = this._Engine;
            request.Description = this._Description;
            Amazon.RDS.Model.CreateDBParameterGroupResponse response = client.CreateDBParameterGroup(request);
            base.WriteObject(response.CreateDBParameterGroupResult, true);
        }
    }
}

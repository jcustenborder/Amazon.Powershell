namespace Amazon.Powershell.RDS
{
    using Amazon.RDS.Model;
    using Amazon.RDS;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.CREATE, RDSNouns.DBSECURITYGROUP)]
    public class CreateDBSecurityGroupCmdlet : RDSCmdLet
    {
        private string _DBSecurityGroupName;
        private string _DBSecurityGroupDescription;
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string DBSecurityGroupName
        {
            get
            {
                return this._DBSecurityGroupName;
            }
            set
            {
                this._DBSecurityGroupName = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string DBSecurityGroupDescription
        {
            get
            {
                return this._DBSecurityGroupDescription;
            }
            set
            {
                this._DBSecurityGroupDescription = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonRDS client = base.GetClient();
            Amazon.RDS.Model.CreateDBSecurityGroupRequest request = new Amazon.RDS.Model.CreateDBSecurityGroupRequest();
            request.DBSecurityGroupName = this._DBSecurityGroupName;
            request.DBSecurityGroupDescription = this._DBSecurityGroupDescription;
            Amazon.RDS.Model.CreateDBSecurityGroupResponse response = client.CreateDBSecurityGroup(request);
            base.WriteObject(response.CreateDBSecurityGroupResult, true);
        }
    }
}

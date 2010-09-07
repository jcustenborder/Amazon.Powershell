namespace Amazon.Powershell.RDS
{
    using Amazon.RDS.Model;
    using Amazon.RDS;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.DELETE, RDSNouns.DBSECURITYGROUP)]
    public class DeleteDBSecurityGroupCmdlet : RDSCmdLet
    {
        private string _DBSecurityGroupName;
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
        protected override void ProcessRecord()
        {
            AmazonRDS client = base.GetClient();
            Amazon.RDS.Model.DeleteDBSecurityGroupRequest request = new Amazon.RDS.Model.DeleteDBSecurityGroupRequest();
            request.DBSecurityGroupName = this._DBSecurityGroupName;
            Amazon.RDS.Model.DeleteDBSecurityGroupResponse response = client.DeleteDBSecurityGroup(request);
        }
    }
}

namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.DELETE, EC2Nouns.SECURITYGROUP)]
    public class DeleteSecurityGroupCmdlet : EC2CmdLet
    {
        private string _GroupName;
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string GroupName
        {
            get
            {
                return this._GroupName;
            }
            set
            {
                this._GroupName = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonEC2 client = base.GetClient();
            Amazon.EC2.Model.DeleteSecurityGroupRequest request = new Amazon.EC2.Model.DeleteSecurityGroupRequest();
            request.GroupName = this._GroupName;
            Amazon.EC2.Model.DeleteSecurityGroupResponse response = client.DeleteSecurityGroup(request);
        }
    }
}

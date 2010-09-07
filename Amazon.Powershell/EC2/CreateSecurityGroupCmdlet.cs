namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.CREATE, EC2Nouns.SECURITYGROUP)]
    public class CreateSecurityGroupCmdlet : EC2CmdLet
    {
        private string _GroupName;
        private string _GroupDescription;
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
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string GroupDescription
        {
            get
            {
                return this._GroupDescription;
            }
            set
            {
                this._GroupDescription = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonEC2 client = base.GetClient();
            Amazon.EC2.Model.CreateSecurityGroupRequest request = new Amazon.EC2.Model.CreateSecurityGroupRequest();
            request.GroupName = this._GroupName;
            request.GroupDescription = this._GroupDescription;
            Amazon.EC2.Model.CreateSecurityGroupResponse response = client.CreateSecurityGroup(request);
        }
    }
}

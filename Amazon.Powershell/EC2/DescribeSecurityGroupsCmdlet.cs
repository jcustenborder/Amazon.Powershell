namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.DESCRIBE, EC2Nouns.SECURITYGROUPS)]
    public class DescribeSecurityGroupsCmdlet : EC2CmdLet
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
            Amazon.EC2.Model.DescribeSecurityGroupsRequest request = new Amazon.EC2.Model.DescribeSecurityGroupsRequest();
            if (string.IsNullOrEmpty(this._GroupName))
            {
                request.GroupName.Add(this._GroupName);
            }
            Amazon.EC2.Model.DescribeSecurityGroupsResponse response = client.DescribeSecurityGroups(request);
            base.WriteObject(response.DescribeSecurityGroupsResult, true);
        }
    }
}

namespace Amazon.Powershell.RDS
{
    using Amazon.RDS.Model;
    using Amazon.RDS;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.AUTHORIZE, RDSNouns.DBSECURITYGROUPINGRESS)]
    public class AuthorizeDBSecurityGroupIngressCmdlet : RDSCmdLet
    {
        private string _DBSecurityGroupName;
        private string _CIDRIP;
        private string _EC2SecurityGroupName;
        private string _EC2SecurityGroupOwnerId;
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
        public string CIDRIP
        {
            get
            {
                return this._CIDRIP;
            }
            set
            {
                this._CIDRIP = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string EC2SecurityGroupName
        {
            get
            {
                return this._EC2SecurityGroupName;
            }
            set
            {
                this._EC2SecurityGroupName = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string EC2SecurityGroupOwnerId
        {
            get
            {
                return this._EC2SecurityGroupOwnerId;
            }
            set
            {
                this._EC2SecurityGroupOwnerId = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonRDS client = base.GetClient();
            Amazon.RDS.Model.AuthorizeDBSecurityGroupIngressRequest request = new Amazon.RDS.Model.AuthorizeDBSecurityGroupIngressRequest();
            request.DBSecurityGroupName = this._DBSecurityGroupName;
            request.CIDRIP = this._CIDRIP;
            request.EC2SecurityGroupName = this._EC2SecurityGroupName;
            request.EC2SecurityGroupOwnerId = this._EC2SecurityGroupOwnerId;
            Amazon.RDS.Model.AuthorizeDBSecurityGroupIngressResponse response = client.AuthorizeDBSecurityGroupIngress(request);
            base.WriteObject(response.AuthorizeDBSecurityGroupIngressResult, true);
        }
    }
}

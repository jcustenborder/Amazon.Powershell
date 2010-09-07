namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.REVOKE, EC2Nouns.SECURITYGROUPINGRESS)]
    public class RevokeSecurityGroupIngressCmdlet : EC2CmdLet
    {
        private string _UserId;
        private string _GroupName;
        private string _SourceSecurityGroupName;
        private string _SourceSecurityGroupOwnerId;
        private string _IpProtocol;
        private decimal _FromPort;
        private decimal _ToPort;
        private string _CidrIp;
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string UserId
        {
            get
            {
                return this._UserId;
            }
            set
            {
                this._UserId = value;
            }
        }
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
        public string SourceSecurityGroupName
        {
            get
            {
                return this._SourceSecurityGroupName;
            }
            set
            {
                this._SourceSecurityGroupName = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string SourceSecurityGroupOwnerId
        {
            get
            {
                return this._SourceSecurityGroupOwnerId;
            }
            set
            {
                this._SourceSecurityGroupOwnerId = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string IpProtocol
        {
            get
            {
                return this._IpProtocol;
            }
            set
            {
                this._IpProtocol = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public decimal FromPort
        {
            get
            {
                return this._FromPort;
            }
            set
            {
                this._FromPort = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public decimal ToPort
        {
            get
            {
                return this._ToPort;
            }
            set
            {
                this._ToPort = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string CidrIp
        {
            get
            {
                return this._CidrIp;
            }
            set
            {
                this._CidrIp = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonEC2 client = base.GetClient();
            Amazon.EC2.Model.RevokeSecurityGroupIngressRequest request = new Amazon.EC2.Model.RevokeSecurityGroupIngressRequest();
            request.UserId = this._UserId;
            request.GroupName = this._GroupName;
            request.SourceSecurityGroupName = this._SourceSecurityGroupName;
            request.SourceSecurityGroupOwnerId = this._SourceSecurityGroupOwnerId;
            request.IpProtocol = this._IpProtocol;
            request.FromPort = this._FromPort;
            request.ToPort = this._ToPort;
            request.CidrIp = this._CidrIp;
            Amazon.EC2.Model.RevokeSecurityGroupIngressResponse response = client.RevokeSecurityGroupIngress(request);
        }
    }
}

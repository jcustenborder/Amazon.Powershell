namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.CREATE, EC2Nouns.VPNCONNECTION)]
    public class CreateVpnConnectionCmdlet : EC2CmdLet
    {
        private string _Type;
        private string _CustomerGatewayId;
        private string _VpnGatewayId;
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string Type
        {
            get
            {
                return this._Type;
            }
            set
            {
                this._Type = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string CustomerGatewayId
        {
            get
            {
                return this._CustomerGatewayId;
            }
            set
            {
                this._CustomerGatewayId = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string VpnGatewayId
        {
            get
            {
                return this._VpnGatewayId;
            }
            set
            {
                this._VpnGatewayId = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonEC2 client = base.GetClient();
            Amazon.EC2.Model.CreateVpnConnectionRequest request = new Amazon.EC2.Model.CreateVpnConnectionRequest();
            request.Type = this._Type;
            request.CustomerGatewayId = this._CustomerGatewayId;
            request.VpnGatewayId = this._VpnGatewayId;
            Amazon.EC2.Model.CreateVpnConnectionResponse response = client.CreateVpnConnection(request);
            base.WriteObject(response.CreateVpnConnectionResult, true);
        }
    }
}

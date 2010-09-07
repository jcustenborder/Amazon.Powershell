namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.DELETE, EC2Nouns.VPNGATEWAY)]
    public class DeleteVpnGatewayCmdlet : EC2CmdLet
    {
        private string _VpnGatewayId;
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
            Amazon.EC2.Model.DeleteVpnGatewayRequest request = new Amazon.EC2.Model.DeleteVpnGatewayRequest();
            request.VpnGatewayId = this._VpnGatewayId;
            Amazon.EC2.Model.DeleteVpnGatewayResponse response = client.DeleteVpnGateway(request);
        }
    }
}

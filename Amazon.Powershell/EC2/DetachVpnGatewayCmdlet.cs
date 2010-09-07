namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.DETACH, EC2Nouns.VPNGATEWAY)]
    public class DetachVpnGatewayCmdlet : EC2CmdLet
    {
        private string _VpnGatewayId;
        private string _VpcId;
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
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string VpcId
        {
            get
            {
                return this._VpcId;
            }
            set
            {
                this._VpcId = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonEC2 client = base.GetClient();
            Amazon.EC2.Model.DetachVpnGatewayRequest request = new Amazon.EC2.Model.DetachVpnGatewayRequest();
            request.VpnGatewayId = this._VpnGatewayId;
            request.VpcId = this._VpcId;
            Amazon.EC2.Model.DetachVpnGatewayResponse response = client.DetachVpnGateway(request);
        }
    }
}

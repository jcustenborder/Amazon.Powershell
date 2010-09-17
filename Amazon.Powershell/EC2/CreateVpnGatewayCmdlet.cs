namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.CREATE, EC2Nouns.VPNGATEWAY)]
    public class CreateVpnGatewayCmdlet : EC2CmdLet
    {
        private string _Type;
        private string _AvailabilityZone;
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
        public string AvailabilityZone
        {
            get
            {
                return this._AvailabilityZone;
            }
            set
            {
                this._AvailabilityZone = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonEC2 client = base.GetClient();
            Amazon.EC2.Model.CreateVpnGatewayRequest request = new Amazon.EC2.Model.CreateVpnGatewayRequest();
            request.Type = this._Type;
            request.AvailabilityZone = this._AvailabilityZone;
            Amazon.EC2.Model.CreateVpnGatewayResponse response = client.CreateVpnGateway(request);
            base.WriteObject(response.CreateVpnGatewayResult.VpnGateway, true);
        }
    }
}

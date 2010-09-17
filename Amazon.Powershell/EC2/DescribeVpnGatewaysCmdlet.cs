namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.DESCRIBE, EC2Nouns.VPNGATEWAYS)]
    public class DescribeVpnGatewaysCmdlet : EC2CmdLet
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
            Amazon.EC2.Model.DescribeVpnGatewaysRequest request = new Amazon.EC2.Model.DescribeVpnGatewaysRequest();
            if (string.IsNullOrEmpty(this._VpnGatewayId))
            {
                request.VpnGatewayId.Add(this._VpnGatewayId);
            }
            Amazon.EC2.Model.DescribeVpnGatewaysResponse response = client.DescribeVpnGateways(request);
            base.WriteObject(response.DescribeVpnGatewaysResult.VpnGateway, true);
        }
    }
}

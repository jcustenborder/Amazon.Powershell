namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.CREATE, EC2Nouns.CUSTOMERGATEWAY)]
    public class CreateCustomerGatewayCmdlet : EC2CmdLet
    {
        private string _Type;
        private string _IpAddress;
        private decimal _BgpAsn;
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
        public string IpAddress
        {
            get
            {
                return this._IpAddress;
            }
            set
            {
                this._IpAddress = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public decimal BgpAsn
        {
            get
            {
                return this._BgpAsn;
            }
            set
            {
                this._BgpAsn = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonEC2 client = base.GetClient();
            Amazon.EC2.Model.CreateCustomerGatewayRequest request = new Amazon.EC2.Model.CreateCustomerGatewayRequest();
            request.Type = this._Type;
            request.IpAddress = this._IpAddress;
            request.BgpAsn = this._BgpAsn;
            Amazon.EC2.Model.CreateCustomerGatewayResponse response = client.CreateCustomerGateway(request);
            base.WriteObject(response.CreateCustomerGatewayResult.CustomerGateway, true);
        }
    }
}

namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.DELETE, EC2Nouns.CUSTOMERGATEWAY)]
    public class DeleteCustomerGatewayCmdlet : EC2CmdLet
    {
        private string _CustomerGatewayId;
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
        protected override void ProcessRecord()
        {
            AmazonEC2 client = base.GetClient();
            Amazon.EC2.Model.DeleteCustomerGatewayRequest request = new Amazon.EC2.Model.DeleteCustomerGatewayRequest();
            request.CustomerGatewayId = this._CustomerGatewayId;
            Amazon.EC2.Model.DeleteCustomerGatewayResponse response = client.DeleteCustomerGateway(request);
        }
    }
}

namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.DESCRIBE, EC2Nouns.CUSTOMERGATEWAYS)]
    public class DescribeCustomerGatewaysCmdlet : EC2CmdLet
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
            Amazon.EC2.Model.DescribeCustomerGatewaysRequest request = new Amazon.EC2.Model.DescribeCustomerGatewaysRequest();
            if (string.IsNullOrEmpty(this._CustomerGatewayId))
            {
                request.CustomerGatewayId.Add(this._CustomerGatewayId);
            }
            Amazon.EC2.Model.DescribeCustomerGatewaysResponse response = client.DescribeCustomerGateways(request);
            base.WriteObject(response.DescribeCustomerGatewaysResult, true);
        }
    }
}

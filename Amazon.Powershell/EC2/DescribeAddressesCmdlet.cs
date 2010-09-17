namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.DESCRIBE, EC2Nouns.ADDRESSES)]
    public class DescribeAddressesCmdlet : EC2CmdLet
    {
        private string _PublicIp;
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string PublicIp
        {
            get
            {
                return this._PublicIp;
            }
            set
            {
                this._PublicIp = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonEC2 client = base.GetClient();
            Amazon.EC2.Model.DescribeAddressesRequest request = new Amazon.EC2.Model.DescribeAddressesRequest();
            if (string.IsNullOrEmpty(this._PublicIp))
            {
                request.PublicIp.Add(this._PublicIp);
            }
            Amazon.EC2.Model.DescribeAddressesResponse response = client.DescribeAddresses(request);
            base.WriteObject(response.DescribeAddressesResult.Address, true);
        }
    }
}

namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.DESCRIBE, EC2Nouns.DHCPOPTIONS)]
    public class DescribeDhcpOptionsCmdlet : EC2CmdLet
    {
        private string _DhcpOptionsId;
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string DhcpOptionsId
        {
            get
            {
                return this._DhcpOptionsId;
            }
            set
            {
                this._DhcpOptionsId = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonEC2 client = base.GetClient();
            Amazon.EC2.Model.DescribeDhcpOptionsRequest request = new Amazon.EC2.Model.DescribeDhcpOptionsRequest();
            if (string.IsNullOrEmpty(this._DhcpOptionsId))
            {
                request.DhcpOptionsId.Add(this._DhcpOptionsId);
            }
            Amazon.EC2.Model.DescribeDhcpOptionsResponse response = client.DescribeDhcpOptions(request);
            base.WriteObject(response.DescribeDhcpOptionsResult, true);
        }
    }
}

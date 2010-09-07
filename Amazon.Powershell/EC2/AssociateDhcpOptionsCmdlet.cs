namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.ASSOCIATE, EC2Nouns.DHCPOPTIONS)]
    public class AssociateDhcpOptionsCmdlet : EC2CmdLet
    {
        private string _DhcpOptionsId;
        private string _VpcId;
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
            Amazon.EC2.Model.AssociateDhcpOptionsRequest request = new Amazon.EC2.Model.AssociateDhcpOptionsRequest();
            request.DhcpOptionsId = this._DhcpOptionsId;
            request.VpcId = this._VpcId;
            Amazon.EC2.Model.AssociateDhcpOptionsResponse response = client.AssociateDhcpOptions(request);
        }
    }
}

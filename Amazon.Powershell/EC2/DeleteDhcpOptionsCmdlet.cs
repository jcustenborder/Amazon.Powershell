namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.DELETE, EC2Nouns.DHCPOPTIONS)]
    public class DeleteDhcpOptionsCmdlet : EC2CmdLet
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
            Amazon.EC2.Model.DeleteDhcpOptionsRequest request = new Amazon.EC2.Model.DeleteDhcpOptionsRequest();
            request.DhcpOptionsId = this._DhcpOptionsId;
            Amazon.EC2.Model.DeleteDhcpOptionsResponse response = client.DeleteDhcpOptions(request);
        }
    }
}

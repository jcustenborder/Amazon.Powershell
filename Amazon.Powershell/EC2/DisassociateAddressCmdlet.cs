namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.DISASSOCIATE, EC2Nouns.ADDRESS)]
    public class DisassociateAddressCmdlet : EC2CmdLet
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
            Amazon.EC2.Model.DisassociateAddressRequest request = new Amazon.EC2.Model.DisassociateAddressRequest();
            request.PublicIp = this._PublicIp;
            Amazon.EC2.Model.DisassociateAddressResponse response = client.DisassociateAddress(request);
        }
    }
}

namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.RELEASE, EC2Nouns.ADDRESS)]
    public class ReleaseAddressCmdlet : EC2CmdLet
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
            Amazon.EC2.Model.ReleaseAddressRequest request = new Amazon.EC2.Model.ReleaseAddressRequest();
            request.PublicIp = this._PublicIp;
            Amazon.EC2.Model.ReleaseAddressResponse response = client.ReleaseAddress(request);
        }
    }
}

namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.ASSOCIATE, EC2Nouns.ADDRESS)]
    public class AssociateAddressCmdlet : EC2CmdLet
    {
        private string _InstanceId;
        private string _PublicIp;
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string InstanceId
        {
            get
            {
                return this._InstanceId;
            }
            set
            {
                this._InstanceId = value;
            }
        }
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
            Amazon.EC2.Model.AssociateAddressRequest request = new Amazon.EC2.Model.AssociateAddressRequest();
            request.InstanceId = this._InstanceId;
            request.PublicIp = this._PublicIp;
            Amazon.EC2.Model.AssociateAddressResponse response = client.AssociateAddress(request);
        }
    }
}

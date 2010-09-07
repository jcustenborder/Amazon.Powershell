namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.DELETE, EC2Nouns.KEYPAIR)]
    public class DeleteKeyPairCmdlet : EC2CmdLet
    {
        private string _KeyName;
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string KeyName
        {
            get
            {
                return this._KeyName;
            }
            set
            {
                this._KeyName = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonEC2 client = base.GetClient();
            Amazon.EC2.Model.DeleteKeyPairRequest request = new Amazon.EC2.Model.DeleteKeyPairRequest();
            request.KeyName = this._KeyName;
            Amazon.EC2.Model.DeleteKeyPairResponse response = client.DeleteKeyPair(request);
        }
    }
}

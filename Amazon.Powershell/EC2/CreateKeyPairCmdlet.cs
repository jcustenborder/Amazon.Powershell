namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.CREATE, EC2Nouns.KEYPAIR)]
    public class CreateKeyPairCmdlet : EC2CmdLet
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
            Amazon.EC2.Model.CreateKeyPairRequest request = new Amazon.EC2.Model.CreateKeyPairRequest();
            request.KeyName = this._KeyName;
            Amazon.EC2.Model.CreateKeyPairResponse response = client.CreateKeyPair(request);
            base.WriteObject(response.CreateKeyPairResult, true);
        }
    }
}

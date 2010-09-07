namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.DESCRIBE, EC2Nouns.KEYPAIRS)]
    public class DescribeKeyPairsCmdlet : EC2CmdLet
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
            Amazon.EC2.Model.DescribeKeyPairsRequest request = new Amazon.EC2.Model.DescribeKeyPairsRequest();
            if (string.IsNullOrEmpty(this._KeyName))
            {
                request.KeyName.Add(this._KeyName);
            }
            Amazon.EC2.Model.DescribeKeyPairsResponse response = client.DescribeKeyPairs(request);
            base.WriteObject(response.DescribeKeyPairsResult, true);
        }
    }
}

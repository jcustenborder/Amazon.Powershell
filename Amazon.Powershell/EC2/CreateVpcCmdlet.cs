namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.CREATE, EC2Nouns.VPC)]
    public class CreateVpcCmdlet : EC2CmdLet
    {
        private string _CidrBlock;
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string CidrBlock
        {
            get
            {
                return this._CidrBlock;
            }
            set
            {
                this._CidrBlock = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonEC2 client = base.GetClient();
            Amazon.EC2.Model.CreateVpcRequest request = new Amazon.EC2.Model.CreateVpcRequest();
            request.CidrBlock = this._CidrBlock;
            Amazon.EC2.Model.CreateVpcResponse response = client.CreateVpc(request);
            base.WriteObject(response.CreateVpcResult.Vpc, true);
        }
    }
}

namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.DELETE, EC2Nouns.VPC)]
    public class DeleteVpcCmdlet : EC2CmdLet
    {
        private string _VpcId;
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
            Amazon.EC2.Model.DeleteVpcRequest request = new Amazon.EC2.Model.DeleteVpcRequest();
            request.VpcId = this._VpcId;
            Amazon.EC2.Model.DeleteVpcResponse response = client.DeleteVpc(request);
        }
    }
}

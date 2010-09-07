namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.DELETE, EC2Nouns.SUBNET)]
    public class DeleteSubnetCmdlet : EC2CmdLet
    {
        private string _SubnetId;
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string SubnetId
        {
            get
            {
                return this._SubnetId;
            }
            set
            {
                this._SubnetId = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonEC2 client = base.GetClient();
            Amazon.EC2.Model.DeleteSubnetRequest request = new Amazon.EC2.Model.DeleteSubnetRequest();
            request.SubnetId = this._SubnetId;
            Amazon.EC2.Model.DeleteSubnetResponse response = client.DeleteSubnet(request);
        }
    }
}

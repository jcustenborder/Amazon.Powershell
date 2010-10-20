namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.CONFIRM, EC2Nouns.PRODUCTINSTANCE)]
    public class ConfirmProductInstanceCmdlet : EC2CmdLet
    {
        private string _ProductCode;
        private string _InstanceId;
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false, HelpMessage="This is a property help message")]
        public string ProductCode
        {
            get
            {
                return this._ProductCode;
            }
            set
            {
                this._ProductCode = value;
            }
        }
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
        
        protected override void ProcessRecord()
        {
            AmazonEC2 client = base.GetClient();
            Amazon.EC2.Model.ConfirmProductInstanceRequest request = new Amazon.EC2.Model.ConfirmProductInstanceRequest();
            request.ProductCode = this._ProductCode;
            request.InstanceId = this._InstanceId;
            Amazon.EC2.Model.ConfirmProductInstanceResponse response = client.ConfirmProductInstance(request);
            base.WriteObject(response.ConfirmProductInstanceResult.OwnerId, true);
        }
    }
}

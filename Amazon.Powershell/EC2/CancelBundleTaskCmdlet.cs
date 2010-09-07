namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.CANCEL, EC2Nouns.BUNDLETASK)]
    public class CancelBundleTaskCmdlet : EC2CmdLet
    {
        private string _BundleId;
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string BundleId
        {
            get
            {
                return this._BundleId;
            }
            set
            {
                this._BundleId = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonEC2 client = base.GetClient();
            Amazon.EC2.Model.CancelBundleTaskRequest request = new Amazon.EC2.Model.CancelBundleTaskRequest();
            request.BundleId = this._BundleId;
            Amazon.EC2.Model.CancelBundleTaskResponse response = client.CancelBundleTask(request);
            base.WriteObject(response.CancelBundleTaskResult, true);
        }
    }
}

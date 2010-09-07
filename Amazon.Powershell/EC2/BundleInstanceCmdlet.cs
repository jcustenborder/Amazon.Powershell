namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.BUNDLE, EC2Nouns.INSTANCE)]
    public class BundleInstanceCmdlet : EC2CmdLet
    {
        private string _InstanceId;
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
            Amazon.EC2.Model.BundleInstanceRequest request = new Amazon.EC2.Model.BundleInstanceRequest();
            request.InstanceId = this._InstanceId;
            Amazon.EC2.Model.BundleInstanceResponse response = client.BundleInstance(request);
            base.WriteObject(response.BundleInstanceResult, true);
        }
    }
}

namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.DESCRIBE, EC2Nouns.BUNDLETASKS)]
    public class DescribeBundleTasksCmdlet : EC2CmdLet
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
            Amazon.EC2.Model.DescribeBundleTasksRequest request = new Amazon.EC2.Model.DescribeBundleTasksRequest();
            if (string.IsNullOrEmpty(this._BundleId))
            {
                request.BundleId.Add(this._BundleId);
            }
            Amazon.EC2.Model.DescribeBundleTasksResponse response = client.DescribeBundleTasks(request);
            base.WriteObject(response.DescribeBundleTasksResult.BundleTask, true);
        }
    }
}

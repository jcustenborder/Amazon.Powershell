namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.UNMONITOR, EC2Nouns.INSTANCES)]
    public class UnmonitorInstancesCmdlet : EC2CmdLet
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
            Amazon.EC2.Model.UnmonitorInstancesRequest request = new Amazon.EC2.Model.UnmonitorInstancesRequest();
            if (string.IsNullOrEmpty(this._InstanceId))
            {
                request.InstanceId.Add(this._InstanceId);
            }
            Amazon.EC2.Model.UnmonitorInstancesResponse response = client.UnmonitorInstances(request);
            base.WriteObject(response.UnmonitorInstancesResult.InstanceMonitoring, true);
        }
    }
}

namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.MONITOR, EC2Nouns.INSTANCES)]
    public class MonitorInstancesCmdlet : EC2CmdLet
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
            Amazon.EC2.Model.MonitorInstancesRequest request = new Amazon.EC2.Model.MonitorInstancesRequest();
            if (string.IsNullOrEmpty(this._InstanceId))
            {
                request.InstanceId.Add(this._InstanceId);
            }
            Amazon.EC2.Model.MonitorInstancesResponse response = client.MonitorInstances(request);
            base.WriteObject(response.MonitorInstancesResult, true);
        }
    }
}

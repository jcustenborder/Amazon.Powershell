namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.START, EC2Nouns.INSTANCES)]
    public class StartInstancesCmdlet : EC2CmdLet
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
            Amazon.EC2.Model.StartInstancesRequest request = new Amazon.EC2.Model.StartInstancesRequest();
            if (string.IsNullOrEmpty(this._InstanceId))
            {
                request.InstanceId.Add(this._InstanceId);
            }
            Amazon.EC2.Model.StartInstancesResponse response = client.StartInstances(request);
            base.WriteObject(response.StartInstancesResult.StartingInstances, true);
        }
    }
}

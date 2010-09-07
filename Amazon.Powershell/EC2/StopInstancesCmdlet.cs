namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.STOP, EC2Nouns.INSTANCES)]
    public class StopInstancesCmdlet : EC2CmdLet
    {
        private string _InstanceId;
        private bool _Force;
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
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public bool Force
        {
            get
            {
                return this._Force;
            }
            set
            {
                this._Force = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonEC2 client = base.GetClient();
            Amazon.EC2.Model.StopInstancesRequest request = new Amazon.EC2.Model.StopInstancesRequest();
            if (string.IsNullOrEmpty(this._InstanceId))
            {
                request.InstanceId.Add(this._InstanceId);
            }
            request.Force = this._Force;
            Amazon.EC2.Model.StopInstancesResponse response = client.StopInstances(request);
            base.WriteObject(response.StopInstancesResult, true);
        }
    }
}

namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.REBOOT, EC2Nouns.INSTANCES)]
    public class RebootInstancesCmdlet : EC2CmdLet
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
            Amazon.EC2.Model.RebootInstancesRequest request = new Amazon.EC2.Model.RebootInstancesRequest();
            if (string.IsNullOrEmpty(this._InstanceId))
            {
                request.InstanceId.Add(this._InstanceId);
            }
            Amazon.EC2.Model.RebootInstancesResponse response = client.RebootInstances(request);
        }
    }
}

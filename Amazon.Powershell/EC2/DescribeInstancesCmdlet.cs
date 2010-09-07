namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.DESCRIBE, EC2Nouns.INSTANCES)]
    public class DescribeInstancesCmdlet : EC2CmdLet
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
            Amazon.EC2.Model.DescribeInstancesRequest request = new Amazon.EC2.Model.DescribeInstancesRequest();
            if (string.IsNullOrEmpty(this._InstanceId))
            {
                request.InstanceId.Add(this._InstanceId);
            }
            Amazon.EC2.Model.DescribeInstancesResponse response = client.DescribeInstances(request);
            base.WriteObject(response.DescribeInstancesResult, true);
        }
    }
}

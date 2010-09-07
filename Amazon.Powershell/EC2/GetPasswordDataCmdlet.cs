namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.GET, EC2Nouns.PASSWORDDATA)]
    public class GetPasswordDataCmdlet : EC2CmdLet
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
            Amazon.EC2.Model.GetPasswordDataRequest request = new Amazon.EC2.Model.GetPasswordDataRequest();
            request.InstanceId = this._InstanceId;
            Amazon.EC2.Model.GetPasswordDataResponse response = client.GetPasswordData(request);
            base.WriteObject(response.GetPasswordDataResult, true);
        }
    }
}

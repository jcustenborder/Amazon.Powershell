namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.GET, EC2Nouns.CONSOLEOUTPUT)]
    public class GetConsoleOutputCmdlet : EC2CmdLet
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
            Amazon.EC2.Model.GetConsoleOutputRequest request = new Amazon.EC2.Model.GetConsoleOutputRequest();
            request.InstanceId = this._InstanceId;
            Amazon.EC2.Model.GetConsoleOutputResponse response = client.GetConsoleOutput(request);
            base.WriteObject(response.GetConsoleOutputResult, true);
        }
    }
}

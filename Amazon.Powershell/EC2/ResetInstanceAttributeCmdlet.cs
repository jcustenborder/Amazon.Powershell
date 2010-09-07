namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.RESET, EC2Nouns.INSTANCEATTRIBUTE)]
    public class ResetInstanceAttributeCmdlet : EC2CmdLet
    {
        private string _InstanceId;
        private string _Attribute;
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
        public string Attribute
        {
            get
            {
                return this._Attribute;
            }
            set
            {
                this._Attribute = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonEC2 client = base.GetClient();
            Amazon.EC2.Model.ResetInstanceAttributeRequest request = new Amazon.EC2.Model.ResetInstanceAttributeRequest();
            request.InstanceId = this._InstanceId;
            request.Attribute = this._Attribute;
            Amazon.EC2.Model.ResetInstanceAttributeResponse response = client.ResetInstanceAttribute(request);
        }
    }
}

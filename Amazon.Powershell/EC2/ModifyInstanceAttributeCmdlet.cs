namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.MODIFY, EC2Nouns.INSTANCEATTRIBUTE)]
    public class ModifyInstanceAttributeCmdlet : EC2CmdLet
    {
        private string _InstanceId;
        private string _Attribute;
        private string _Value;
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
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string Value
        {
            get
            {
                return this._Value;
            }
            set
            {
                this._Value = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonEC2 client = base.GetClient();
            Amazon.EC2.Model.ModifyInstanceAttributeRequest request = new Amazon.EC2.Model.ModifyInstanceAttributeRequest();
            request.InstanceId = this._InstanceId;
            request.Attribute = this._Attribute;
            request.Value = this._Value;
            Amazon.EC2.Model.ModifyInstanceAttributeResponse response = client.ModifyInstanceAttribute(request);
        }
    }
}

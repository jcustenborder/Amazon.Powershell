namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.RESET, EC2Nouns.IMAGEATTRIBUTE)]
    public class ResetImageAttributeCmdlet : EC2CmdLet
    {
        private string _ImageId;
        private string _Attribute;
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string ImageId
        {
            get
            {
                return this._ImageId;
            }
            set
            {
                this._ImageId = value;
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
            Amazon.EC2.Model.ResetImageAttributeRequest request = new Amazon.EC2.Model.ResetImageAttributeRequest();
            request.ImageId = this._ImageId;
            request.Attribute = this._Attribute;
            Amazon.EC2.Model.ResetImageAttributeResponse response = client.ResetImageAttribute(request);
        }
    }
}

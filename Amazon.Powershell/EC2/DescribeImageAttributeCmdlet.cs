namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.DESCRIBE, EC2Nouns.IMAGEATTRIBUTE)]
    public class DescribeImageAttributeCmdlet : EC2CmdLet
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
            Amazon.EC2.Model.DescribeImageAttributeRequest request = new Amazon.EC2.Model.DescribeImageAttributeRequest();
            request.ImageId = this._ImageId;
            request.Attribute = this._Attribute;
            Amazon.EC2.Model.DescribeImageAttributeResponse response = client.DescribeImageAttribute(request);
            base.WriteObject(response.DescribeImageAttributeResult, true);
        }
    }
}

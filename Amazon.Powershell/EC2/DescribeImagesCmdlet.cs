namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.DESCRIBE, EC2Nouns.IMAGES)]
    public class DescribeImagesCmdlet : EC2CmdLet
    {
        private string _ImageId;
        private string _Owner;
        private string _ExecutableBy;
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
        public string Owner
        {
            get
            {
                return this._Owner;
            }
            set
            {
                this._Owner = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string ExecutableBy
        {
            get
            {
                return this._ExecutableBy;
            }
            set
            {
                this._ExecutableBy = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonEC2 client = base.GetClient();
            Amazon.EC2.Model.DescribeImagesRequest request = new Amazon.EC2.Model.DescribeImagesRequest();
            if (string.IsNullOrEmpty(this._ImageId))
            {
                request.ImageId.Add(this._ImageId);
            }
            if (string.IsNullOrEmpty(this._Owner))
            {
                request.Owner.Add(this._Owner);
            }
            if (string.IsNullOrEmpty(this._ExecutableBy))
            {
                request.ExecutableBy.Add(this._ExecutableBy);
            }
            Amazon.EC2.Model.DescribeImagesResponse response = client.DescribeImages(request);
            base.WriteObject(response.DescribeImagesResult, true);
        }
    }
}

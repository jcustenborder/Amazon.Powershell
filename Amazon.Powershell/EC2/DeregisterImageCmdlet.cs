namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.DEREGISTER, EC2Nouns.IMAGE)]
    public class DeregisterImageCmdlet : EC2CmdLet
    {
        private string _ImageId;
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
        protected override void ProcessRecord()
        {
            AmazonEC2 client = base.GetClient();
            Amazon.EC2.Model.DeregisterImageRequest request = new Amazon.EC2.Model.DeregisterImageRequest();
            request.ImageId = this._ImageId;
            Amazon.EC2.Model.DeregisterImageResponse response = client.DeregisterImage(request);
        }
    }
}

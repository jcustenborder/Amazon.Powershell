namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.CREATE, EC2Nouns.IMAGE)]
    public class CreateImageCmdlet : EC2CmdLet
    {
        private string _InstanceId;
        private string _Name;
        private string _Description;
        private bool _NoReboot;
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
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this._Name = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                this._Description = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public bool NoReboot
        {
            get
            {
                return this._NoReboot;
            }
            set
            {
                this._NoReboot = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonEC2 client = base.GetClient();
            Amazon.EC2.Model.CreateImageRequest request = new Amazon.EC2.Model.CreateImageRequest();
            request.InstanceId = this._InstanceId;
            request.Name = this._Name;
            request.Description = this._Description;
            request.NoReboot = this._NoReboot;
            Amazon.EC2.Model.CreateImageResponse response = client.CreateImage(request);
            base.WriteObject(response.CreateImageResult.ImageId, true);
        }
    }
}

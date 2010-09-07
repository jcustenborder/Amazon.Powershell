namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.REGISTER, EC2Nouns.IMAGE)]
    public class RegisterImageCmdlet : EC2CmdLet
    {
        private string _ImageLocation;
        private string _Name;
        private string _Description;
        private string _Architecture;
        private string _KernelId;
        private string _RamdiskId;
        private string _RootDeviceName;
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string ImageLocation
        {
            get
            {
                return this._ImageLocation;
            }
            set
            {
                this._ImageLocation = value;
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
        public string Architecture
        {
            get
            {
                return this._Architecture;
            }
            set
            {
                this._Architecture = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string KernelId
        {
            get
            {
                return this._KernelId;
            }
            set
            {
                this._KernelId = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string RamdiskId
        {
            get
            {
                return this._RamdiskId;
            }
            set
            {
                this._RamdiskId = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string RootDeviceName
        {
            get
            {
                return this._RootDeviceName;
            }
            set
            {
                this._RootDeviceName = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonEC2 client = base.GetClient();
            Amazon.EC2.Model.RegisterImageRequest request = new Amazon.EC2.Model.RegisterImageRequest();
            request.ImageLocation = this._ImageLocation;
            request.Name = this._Name;
            request.Description = this._Description;
            request.Architecture = this._Architecture;
            request.KernelId = this._KernelId;
            request.RamdiskId = this._RamdiskId;
            request.RootDeviceName = this._RootDeviceName;
            Amazon.EC2.Model.RegisterImageResponse response = client.RegisterImage(request);
            base.WriteObject(response.RegisterImageResult, true);
        }
    }
}

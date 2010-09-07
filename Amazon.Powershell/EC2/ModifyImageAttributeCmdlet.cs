namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.MODIFY, EC2Nouns.IMAGEATTRIBUTE)]
    public class ModifyImageAttributeCmdlet : EC2CmdLet
    {
        private string _ImageId;
        private string _Attribute;
        private string _OperationType;
        private string _UserId;
        private string _UserGroup;
        private string _ProductCode;
        private string _Description;
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
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string OperationType
        {
            get
            {
                return this._OperationType;
            }
            set
            {
                this._OperationType = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string UserId
        {
            get
            {
                return this._UserId;
            }
            set
            {
                this._UserId = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string UserGroup
        {
            get
            {
                return this._UserGroup;
            }
            set
            {
                this._UserGroup = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string ProductCode
        {
            get
            {
                return this._ProductCode;
            }
            set
            {
                this._ProductCode = value;
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
        protected override void ProcessRecord()
        {
            AmazonEC2 client = base.GetClient();
            Amazon.EC2.Model.ModifyImageAttributeRequest request = new Amazon.EC2.Model.ModifyImageAttributeRequest();
            request.ImageId = this._ImageId;
            request.Attribute = this._Attribute;
            request.OperationType = this._OperationType;
            if (string.IsNullOrEmpty(this._UserId))
            {
                request.UserId.Add(this._UserId);
            }
            if (string.IsNullOrEmpty(this._UserGroup))
            {
                request.UserGroup.Add(this._UserGroup);
            }
            if (string.IsNullOrEmpty(this._ProductCode))
            {
                request.ProductCode.Add(this._ProductCode);
            }
            request.Description = this._Description;
            Amazon.EC2.Model.ModifyImageAttributeResponse response = client.ModifyImageAttribute(request);
        }
    }
}

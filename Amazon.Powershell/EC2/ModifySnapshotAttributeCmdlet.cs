namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.MODIFY, EC2Nouns.SNAPSHOTATTRIBUTE)]
    public class ModifySnapshotAttributeCmdlet : EC2CmdLet
    {
        private string _SnapshotId;
        private string _Attribute;
        private string _OperationType;
        private string _UserId;
        private string _UserGroup;
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string SnapshotId
        {
            get
            {
                return this._SnapshotId;
            }
            set
            {
                this._SnapshotId = value;
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
        protected override void ProcessRecord()
        {
            AmazonEC2 client = base.GetClient();
            Amazon.EC2.Model.ModifySnapshotAttributeRequest request = new Amazon.EC2.Model.ModifySnapshotAttributeRequest();
            request.SnapshotId = this._SnapshotId;
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
            Amazon.EC2.Model.ModifySnapshotAttributeResponse response = client.ModifySnapshotAttribute(request);
        }
    }
}

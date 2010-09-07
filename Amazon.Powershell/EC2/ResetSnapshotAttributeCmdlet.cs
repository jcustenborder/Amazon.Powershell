namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.RESET, EC2Nouns.SNAPSHOTATTRIBUTE)]
    public class ResetSnapshotAttributeCmdlet : EC2CmdLet
    {
        private string _SnapshotId;
        private string _Attribute;
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
        protected override void ProcessRecord()
        {
            AmazonEC2 client = base.GetClient();
            Amazon.EC2.Model.ResetSnapshotAttributeRequest request = new Amazon.EC2.Model.ResetSnapshotAttributeRequest();
            request.SnapshotId = this._SnapshotId;
            request.Attribute = this._Attribute;
            Amazon.EC2.Model.ResetSnapshotAttributeResponse response = client.ResetSnapshotAttribute(request);
        }
    }
}

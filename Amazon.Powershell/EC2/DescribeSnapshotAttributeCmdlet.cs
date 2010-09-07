namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.DESCRIBE, EC2Nouns.SNAPSHOTATTRIBUTE)]
    public class DescribeSnapshotAttributeCmdlet : EC2CmdLet
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
            Amazon.EC2.Model.DescribeSnapshotAttributeRequest request = new Amazon.EC2.Model.DescribeSnapshotAttributeRequest();
            request.SnapshotId = this._SnapshotId;
            request.Attribute = this._Attribute;
            Amazon.EC2.Model.DescribeSnapshotAttributeResponse response = client.DescribeSnapshotAttribute(request);
            base.WriteObject(response.DescribeSnapshotAttributeResult, true);
        }
    }
}

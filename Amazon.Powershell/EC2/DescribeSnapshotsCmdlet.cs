namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.DESCRIBE, EC2Nouns.SNAPSHOTS)]
    public class DescribeSnapshotsCmdlet : EC2CmdLet
    {
        private string _SnapshotId;
        private string _Owner;
        private string _RestorableBy;
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
        public string RestorableBy
        {
            get
            {
                return this._RestorableBy;
            }
            set
            {
                this._RestorableBy = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonEC2 client = base.GetClient();
            Amazon.EC2.Model.DescribeSnapshotsRequest request = new Amazon.EC2.Model.DescribeSnapshotsRequest();
            if (string.IsNullOrEmpty(this._SnapshotId))
            {
                request.SnapshotId.Add(this._SnapshotId);
            }
            request.Owner = this._Owner;
            request.RestorableBy = this._RestorableBy;
            Amazon.EC2.Model.DescribeSnapshotsResponse response = client.DescribeSnapshots(request);
            base.WriteObject(response.DescribeSnapshotsResult.Snapshot, true);
        }
    }
}

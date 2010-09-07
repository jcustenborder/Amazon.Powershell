namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.DELETE, EC2Nouns.SNAPSHOT)]
    public class DeleteSnapshotCmdlet : EC2CmdLet
    {
        private string _SnapshotId;
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
        protected override void ProcessRecord()
        {
            AmazonEC2 client = base.GetClient();
            Amazon.EC2.Model.DeleteSnapshotRequest request = new Amazon.EC2.Model.DeleteSnapshotRequest();
            request.SnapshotId = this._SnapshotId;
            Amazon.EC2.Model.DeleteSnapshotResponse response = client.DeleteSnapshot(request);
        }
    }
}

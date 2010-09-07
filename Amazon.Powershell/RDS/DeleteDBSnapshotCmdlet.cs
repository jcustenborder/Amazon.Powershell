namespace Amazon.Powershell.RDS
{
    using Amazon.RDS.Model;
    using Amazon.RDS;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.DELETE, RDSNouns.DBSNAPSHOT)]
    public class DeleteDBSnapshotCmdlet : RDSCmdLet
    {
        private string _DBSnapshotIdentifier;
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string DBSnapshotIdentifier
        {
            get
            {
                return this._DBSnapshotIdentifier;
            }
            set
            {
                this._DBSnapshotIdentifier = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonRDS client = base.GetClient();
            Amazon.RDS.Model.DeleteDBSnapshotRequest request = new Amazon.RDS.Model.DeleteDBSnapshotRequest();
            request.DBSnapshotIdentifier = this._DBSnapshotIdentifier;
            Amazon.RDS.Model.DeleteDBSnapshotResponse response = client.DeleteDBSnapshot(request);
            base.WriteObject(response.DeleteDBSnapshotResult, true);
        }
    }
}

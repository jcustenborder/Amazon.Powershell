namespace Amazon.Powershell.RDS
{
    using Amazon.RDS.Model;
    using Amazon.RDS;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.CREATE, RDSNouns.DBSNAPSHOT)]
    public class CreateDBSnapshotCmdlet : RDSCmdLet
    {
        private string _DBSnapshotIdentifier;
        private string _DBInstanceIdentifier;
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
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string DBInstanceIdentifier
        {
            get
            {
                return this._DBInstanceIdentifier;
            }
            set
            {
                this._DBInstanceIdentifier = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonRDS client = base.GetClient();
            Amazon.RDS.Model.CreateDBSnapshotRequest request = new Amazon.RDS.Model.CreateDBSnapshotRequest();
            request.DBSnapshotIdentifier = this._DBSnapshotIdentifier;
            request.DBInstanceIdentifier = this._DBInstanceIdentifier;
            Amazon.RDS.Model.CreateDBSnapshotResponse response = client.CreateDBSnapshot(request);
            base.WriteObject(response.CreateDBSnapshotResult, true);
        }
    }
}

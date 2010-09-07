namespace Amazon.Powershell.RDS
{
    using Amazon.RDS.Model;
    using Amazon.RDS;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.RESTORE, RDSNouns.DBINSTANCEFROMDBSNAPSHOT)]
    public class RestoreDBInstanceFromDBSnapshotCmdlet : RDSCmdLet
    {
        private string _DBInstanceIdentifier;
        private string _DBSnapshotIdentifier;
        private string _DBInstanceClass;
        private decimal _Port;
        private string _AvailabilityZone;
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
        public string DBInstanceClass
        {
            get
            {
                return this._DBInstanceClass;
            }
            set
            {
                this._DBInstanceClass = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public decimal Port
        {
            get
            {
                return this._Port;
            }
            set
            {
                this._Port = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string AvailabilityZone
        {
            get
            {
                return this._AvailabilityZone;
            }
            set
            {
                this._AvailabilityZone = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonRDS client = base.GetClient();
            Amazon.RDS.Model.RestoreDBInstanceFromDBSnapshotRequest request = new Amazon.RDS.Model.RestoreDBInstanceFromDBSnapshotRequest();
            request.DBInstanceIdentifier = this._DBInstanceIdentifier;
            request.DBSnapshotIdentifier = this._DBSnapshotIdentifier;
            request.DBInstanceClass = this._DBInstanceClass;
            request.Port = this._Port;
            request.AvailabilityZone = this._AvailabilityZone;
            Amazon.RDS.Model.RestoreDBInstanceFromDBSnapshotResponse response = client.RestoreDBInstanceFromDBSnapshot(request);
            base.WriteObject(response.RestoreDBInstanceFromDBSnapshotResult, true);
        }
    }
}

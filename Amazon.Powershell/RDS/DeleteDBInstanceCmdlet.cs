namespace Amazon.Powershell.RDS
{
    using Amazon.RDS.Model;
    using Amazon.RDS;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.DELETE, RDSNouns.DBINSTANCE)]
    public class DeleteDBInstanceCmdlet : RDSCmdLet
    {
        private string _DBInstanceIdentifier;
        private bool _SkipFinalSnapshot;
        private string _FinalDBSnapshotIdentifier;
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
        public bool SkipFinalSnapshot
        {
            get
            {
                return this._SkipFinalSnapshot;
            }
            set
            {
                this._SkipFinalSnapshot = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string FinalDBSnapshotIdentifier
        {
            get
            {
                return this._FinalDBSnapshotIdentifier;
            }
            set
            {
                this._FinalDBSnapshotIdentifier = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonRDS client = base.GetClient();
            Amazon.RDS.Model.DeleteDBInstanceRequest request = new Amazon.RDS.Model.DeleteDBInstanceRequest();
            request.DBInstanceIdentifier = this._DBInstanceIdentifier;
            request.SkipFinalSnapshot = this._SkipFinalSnapshot;
            request.FinalDBSnapshotIdentifier = this._FinalDBSnapshotIdentifier;
            Amazon.RDS.Model.DeleteDBInstanceResponse response = client.DeleteDBInstance(request);
            base.WriteObject(response.DeleteDBInstanceResult, true);
        }
    }
}

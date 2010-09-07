namespace Amazon.Powershell.RDS
{
    using Amazon.RDS.Model;
    using Amazon.RDS;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.DESCRIBE, RDSNouns.DBSNAPSHOTS)]
    public class DescribeDBSnapshotsCmdlet : RDSCmdLet
    {
        private string _DBInstanceIdentifier;
        private string _DBSnapshotIdentifier;
        private decimal _MaxRecords;
        private string _Marker;
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
        public decimal MaxRecords
        {
            get
            {
                return this._MaxRecords;
            }
            set
            {
                this._MaxRecords = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string Marker
        {
            get
            {
                return this._Marker;
            }
            set
            {
                this._Marker = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonRDS client = base.GetClient();
            Amazon.RDS.Model.DescribeDBSnapshotsRequest request = new Amazon.RDS.Model.DescribeDBSnapshotsRequest();
            request.DBInstanceIdentifier = this._DBInstanceIdentifier;
            request.DBSnapshotIdentifier = this._DBSnapshotIdentifier;
            request.MaxRecords = this._MaxRecords;
            request.Marker = this._Marker;
            Amazon.RDS.Model.DescribeDBSnapshotsResponse response = client.DescribeDBSnapshots(request);
            base.WriteObject(response.DescribeDBSnapshotsResult, true);
        }
    }
}

namespace Amazon.Powershell.RDS
{
    using Amazon.RDS.Model;
    using Amazon.RDS;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.RESTORE, RDSNouns.DBINSTANCETOPOINTINTIME)]
    public class RestoreDBInstanceToPointInTimeCmdlet : RDSCmdLet
    {
        private string _SourceDBInstanceIdentifier;
        private string _TargetDBInstanceIdentifier;
        private System.DateTime _RestoreTime;
        private bool _UseLatestRestorableTime;
        private string _DBInstanceClass;
        private decimal _Port;
        private string _AvailabilityZone;
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string SourceDBInstanceIdentifier
        {
            get
            {
                return this._SourceDBInstanceIdentifier;
            }
            set
            {
                this._SourceDBInstanceIdentifier = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string TargetDBInstanceIdentifier
        {
            get
            {
                return this._TargetDBInstanceIdentifier;
            }
            set
            {
                this._TargetDBInstanceIdentifier = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public System.DateTime RestoreTime
        {
            get
            {
                return this._RestoreTime;
            }
            set
            {
                this._RestoreTime = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public bool UseLatestRestorableTime
        {
            get
            {
                return this._UseLatestRestorableTime;
            }
            set
            {
                this._UseLatestRestorableTime = value;
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
            Amazon.RDS.Model.RestoreDBInstanceToPointInTimeRequest request = new Amazon.RDS.Model.RestoreDBInstanceToPointInTimeRequest();
            request.SourceDBInstanceIdentifier = this._SourceDBInstanceIdentifier;
            request.TargetDBInstanceIdentifier = this._TargetDBInstanceIdentifier;
            request.RestoreTime = this._RestoreTime;
            request.UseLatestRestorableTime = this._UseLatestRestorableTime;
            request.DBInstanceClass = this._DBInstanceClass;
            request.Port = this._Port;
            request.AvailabilityZone = this._AvailabilityZone;
            Amazon.RDS.Model.RestoreDBInstanceToPointInTimeResponse response = client.RestoreDBInstanceToPointInTime(request);
            base.WriteObject(response.RestoreDBInstanceToPointInTimeResult, true);
        }
    }
}

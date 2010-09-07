namespace Amazon.Powershell.RDS
{
    using Amazon.RDS.Model;
    using Amazon.RDS;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.CREATE, RDSNouns.DBINSTANCE)]
    public class CreateDBInstanceCmdlet : RDSCmdLet
    {
        private string _DBName;
        private string _DBInstanceIdentifier;
        private decimal _AllocatedStorage;
        private string _DBInstanceClass;
        private string _Engine;
        private string _MasterUsername;
        private string _MasterUserPassword;
        private string _DBSecurityGroups;
        private string _AvailabilityZone;
        private string _PreferredMaintenanceWindow;
        private string _DBParameterGroupName;
        private decimal _BackupRetentionPeriod;
        private string _PreferredBackupWindow;
        private decimal _Port;
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string DBName
        {
            get
            {
                return this._DBName;
            }
            set
            {
                this._DBName = value;
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
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public decimal AllocatedStorage
        {
            get
            {
                return this._AllocatedStorage;
            }
            set
            {
                this._AllocatedStorage = value;
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
        public string Engine
        {
            get
            {
                return this._Engine;
            }
            set
            {
                this._Engine = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string MasterUsername
        {
            get
            {
                return this._MasterUsername;
            }
            set
            {
                this._MasterUsername = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string MasterUserPassword
        {
            get
            {
                return this._MasterUserPassword;
            }
            set
            {
                this._MasterUserPassword = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string DBSecurityGroups
        {
            get
            {
                return this._DBSecurityGroups;
            }
            set
            {
                this._DBSecurityGroups = value;
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
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string PreferredMaintenanceWindow
        {
            get
            {
                return this._PreferredMaintenanceWindow;
            }
            set
            {
                this._PreferredMaintenanceWindow = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string DBParameterGroupName
        {
            get
            {
                return this._DBParameterGroupName;
            }
            set
            {
                this._DBParameterGroupName = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public decimal BackupRetentionPeriod
        {
            get
            {
                return this._BackupRetentionPeriod;
            }
            set
            {
                this._BackupRetentionPeriod = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string PreferredBackupWindow
        {
            get
            {
                return this._PreferredBackupWindow;
            }
            set
            {
                this._PreferredBackupWindow = value;
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
        protected override void ProcessRecord()
        {
            AmazonRDS client = base.GetClient();
            Amazon.RDS.Model.CreateDBInstanceRequest request = new Amazon.RDS.Model.CreateDBInstanceRequest();
            request.DBName = this._DBName;
            request.DBInstanceIdentifier = this._DBInstanceIdentifier;
            request.AllocatedStorage = this._AllocatedStorage;
            request.DBInstanceClass = this._DBInstanceClass;
            request.Engine = this._Engine;
            request.MasterUsername = this._MasterUsername;
            request.MasterUserPassword = this._MasterUserPassword;
            if (string.IsNullOrEmpty(this._DBSecurityGroups))
            {
                request.DBSecurityGroups.Add(this._DBSecurityGroups);
            }
            request.AvailabilityZone = this._AvailabilityZone;
            request.PreferredMaintenanceWindow = this._PreferredMaintenanceWindow;
            request.DBParameterGroupName = this._DBParameterGroupName;
            request.BackupRetentionPeriod = this._BackupRetentionPeriod;
            request.PreferredBackupWindow = this._PreferredBackupWindow;
            request.Port = this._Port;
            Amazon.RDS.Model.CreateDBInstanceResponse response = client.CreateDBInstance(request);
            base.WriteObject(response.CreateDBInstanceResult, true);
        }
    }
}

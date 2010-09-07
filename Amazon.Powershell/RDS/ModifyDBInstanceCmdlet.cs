namespace Amazon.Powershell.RDS
{
    using Amazon.RDS.Model;
    using Amazon.RDS;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.MODIFY, RDSNouns.DBINSTANCE)]
    public class ModifyDBInstanceCmdlet : RDSCmdLet
    {
        private string _DBInstanceIdentifier;
        private decimal _AllocatedStorage;
        private string _DBInstanceClass;
        private string _DBSecurityGroups;
        private bool _ApplyImmediately;
        private string _MasterUserPassword;
        private string _DBParameterGroupName;
        private decimal _BackupRetentionPeriod;
        private string _PreferredBackupWindow;
        private string _PreferredMaintenanceWindow;
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
        public bool ApplyImmediately
        {
            get
            {
                return this._ApplyImmediately;
            }
            set
            {
                this._ApplyImmediately = value;
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
        protected override void ProcessRecord()
        {
            AmazonRDS client = base.GetClient();
            Amazon.RDS.Model.ModifyDBInstanceRequest request = new Amazon.RDS.Model.ModifyDBInstanceRequest();
            request.DBInstanceIdentifier = this._DBInstanceIdentifier;
            request.AllocatedStorage = this._AllocatedStorage;
            request.DBInstanceClass = this._DBInstanceClass;
            if (string.IsNullOrEmpty(this._DBSecurityGroups))
            {
                request.DBSecurityGroups.Add(this._DBSecurityGroups);
            }
            request.ApplyImmediately = this._ApplyImmediately;
            request.MasterUserPassword = this._MasterUserPassword;
            request.DBParameterGroupName = this._DBParameterGroupName;
            request.BackupRetentionPeriod = this._BackupRetentionPeriod;
            request.PreferredBackupWindow = this._PreferredBackupWindow;
            request.PreferredMaintenanceWindow = this._PreferredMaintenanceWindow;
            Amazon.RDS.Model.ModifyDBInstanceResponse response = client.ModifyDBInstance(request);
            base.WriteObject(response.ModifyDBInstanceResult, true);
        }
    }
}

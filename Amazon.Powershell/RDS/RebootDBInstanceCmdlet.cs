namespace Amazon.Powershell.RDS
{
    using Amazon.RDS.Model;
    using Amazon.RDS;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.REBOOT, RDSNouns.DBINSTANCE)]
    public class RebootDBInstanceCmdlet : RDSCmdLet
    {
        private string _DBInstanceIdentifier;
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
            Amazon.RDS.Model.RebootDBInstanceRequest request = new Amazon.RDS.Model.RebootDBInstanceRequest();
            request.DBInstanceIdentifier = this._DBInstanceIdentifier;
            Amazon.RDS.Model.RebootDBInstanceResponse response = client.RebootDBInstance(request);
            base.WriteObject(response.RebootDBInstanceResult, true);
        }
    }
}

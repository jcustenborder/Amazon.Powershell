namespace Amazon.Powershell.RDS
{
    using Amazon.RDS.Model;
    using Amazon.RDS;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.RESTORE, RDSNouns.DBINSTANCEFROMDBSNAPSHOT)]
    public class RestoreDBInstanceFromDBSnapshotCmdlet : RDSCmdLet
    {
        protected override void EndProcessing()
        {
            throw new System.NotImplementedException();
        }
    }
}

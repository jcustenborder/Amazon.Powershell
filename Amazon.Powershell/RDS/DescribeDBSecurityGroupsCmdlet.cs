namespace Amazon.Powershell.RDS
{
    using Amazon.RDS.Model;
    using Amazon.RDS;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.DESCRIBE, RDSNouns.DBSECURITYGROUPS)]
    public class DescribeDBSecurityGroupsCmdlet : RDSCmdLet
    {
        private string _DBSecurityGroupName;
        private decimal _MaxRecords;
        private string _Marker;
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string DBSecurityGroupName
        {
            get
            {
                return this._DBSecurityGroupName;
            }
            set
            {
                this._DBSecurityGroupName = value;
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
            Amazon.RDS.Model.DescribeDBSecurityGroupsRequest request = new Amazon.RDS.Model.DescribeDBSecurityGroupsRequest();
            request.DBSecurityGroupName = this._DBSecurityGroupName;
            request.MaxRecords = this._MaxRecords;
            request.Marker = this._Marker;
            Amazon.RDS.Model.DescribeDBSecurityGroupsResponse response = client.DescribeDBSecurityGroups(request);
            base.WriteObject(response.DescribeDBSecurityGroupsResult, true);
        }
    }
}

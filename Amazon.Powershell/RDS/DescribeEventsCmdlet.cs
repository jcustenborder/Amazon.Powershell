namespace Amazon.Powershell.RDS
{
    using Amazon.RDS.Model;
    using Amazon.RDS;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.DESCRIBE, RDSNouns.EVENTS)]
    public class DescribeEventsCmdlet : RDSCmdLet
    {
        private string _SourceIdentifier;
        private string _SourceType;
        private System.DateTime _StartTime;
        private System.DateTime _EndTime;
        private decimal _Duration;
        private decimal _MaxRecords;
        private string _Marker;
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string SourceIdentifier
        {
            get
            {
                return this._SourceIdentifier;
            }
            set
            {
                this._SourceIdentifier = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string SourceType
        {
            get
            {
                return this._SourceType;
            }
            set
            {
                this._SourceType = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public System.DateTime StartTime
        {
            get
            {
                return this._StartTime;
            }
            set
            {
                this._StartTime = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public System.DateTime EndTime
        {
            get
            {
                return this._EndTime;
            }
            set
            {
                this._EndTime = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public decimal Duration
        {
            get
            {
                return this._Duration;
            }
            set
            {
                this._Duration = value;
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
            Amazon.RDS.Model.DescribeEventsRequest request = new Amazon.RDS.Model.DescribeEventsRequest();
            request.SourceIdentifier = this._SourceIdentifier;
            request.SourceType = this._SourceType;
            request.StartTime = this._StartTime;
            request.EndTime = this._EndTime;
            request.Duration = this._Duration;
            request.MaxRecords = this._MaxRecords;
            request.Marker = this._Marker;
            Amazon.RDS.Model.DescribeEventsResponse response = client.DescribeEvents(request);
            base.WriteObject(response.DescribeEventsResult, true);
        }
    }
}

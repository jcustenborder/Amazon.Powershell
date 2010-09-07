namespace Amazon.Powershell.CloudWatch
{
    using Amazon.CloudWatch.Model;
    using Amazon.CloudWatch;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.GET, CloudWatchNouns.METRICSTATISTICS)]
    public class GetMetricStatisticsCmdlet : CloudWatchCmdLet
    {
        private string _Statistics;
        private decimal _Period;
        private string _MeasureName;
        private string _StartTime;
        private string _EndTime;
        private string _Unit;
        private string _CustomUnit;
        private string _Namespace;
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string Statistics
        {
            get
            {
                return this._Statistics;
            }
            set
            {
                this._Statistics = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public decimal Period
        {
            get
            {
                return this._Period;
            }
            set
            {
                this._Period = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string MeasureName
        {
            get
            {
                return this._MeasureName;
            }
            set
            {
                this._MeasureName = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string StartTime
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
        public string EndTime
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
        public string Unit
        {
            get
            {
                return this._Unit;
            }
            set
            {
                this._Unit = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string CustomUnit
        {
            get
            {
                return this._CustomUnit;
            }
            set
            {
                this._CustomUnit = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string Namespace
        {
            get
            {
                return this._Namespace;
            }
            set
            {
                this._Namespace = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonCloudWatch client = base.GetClient();
            Amazon.CloudWatch.Model.GetMetricStatisticsRequest request = new Amazon.CloudWatch.Model.GetMetricStatisticsRequest();
            if (string.IsNullOrEmpty(this._Statistics))
            {
                request.Statistics.Add(this._Statistics);
            }
            request.Period = this._Period;
            request.MeasureName = this._MeasureName;
            request.StartTime = this._StartTime;
            request.EndTime = this._EndTime;
            request.Unit = this._Unit;
            request.CustomUnit = this._CustomUnit;
            request.Namespace = this._Namespace;
            Amazon.CloudWatch.Model.GetMetricStatisticsResponse response = client.GetMetricStatistics(request);
            base.WriteObject(response.GetMetricStatisticsResult, true);
        }
    }
}

namespace Amazon.Powershell.CloudWatch
{
    using Amazon.CloudWatch.Model;
    using Amazon.CloudWatch;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.LIST, CloudWatchNouns.METRICS)]
    public class ListMetricsCmdlet : CloudWatchCmdLet
    {
        private string _NextToken;
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string NextToken
        {
            get
            {
                return this._NextToken;
            }
            set
            {
                this._NextToken = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonCloudWatch client = base.GetClient();
            Amazon.CloudWatch.Model.ListMetricsRequest request = new Amazon.CloudWatch.Model.ListMetricsRequest();
            request.NextToken = this._NextToken;
            Amazon.CloudWatch.Model.ListMetricsResponse response = client.ListMetrics(request);
            base.WriteObject(response.ListMetricsResult, true);
        }
    }
}

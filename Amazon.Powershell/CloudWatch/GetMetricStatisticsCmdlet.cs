namespace Amazon.Powershell.CloudWatch
{
    using Amazon.CloudWatch.Model;
    using Amazon.CloudWatch;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.GET, CloudWatchNouns.METRICSTATISTICS)]
    public class GetMetricStatisticsCmdlet : CloudWatchCmdLet
    {
        protected override void EndProcessing()
        {
            throw new System.NotImplementedException();
        }
    }
}

namespace Amazon.Powershell.CloudWatch
{
    using Amazon.CloudWatch.Model;
    using Amazon.CloudWatch;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    public abstract class CloudWatchCmdLet : AmazonCmdLet
    {
        protected virtual AmazonCloudWatch GetClient()
        {
            throw new System.NotSupportedException();
        }
    }
}

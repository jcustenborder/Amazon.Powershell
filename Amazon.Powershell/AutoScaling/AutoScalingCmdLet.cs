namespace Amazon.Powershell.AutoScaling
{
    using Amazon.AutoScaling.Model;
    using Amazon.AutoScaling;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    public abstract class AutoScalingCmdLet : AmazonCmdLet
    {
        protected virtual AmazonAutoScaling GetClient()
        {
            throw new System.NotSupportedException();
        }
    }
}

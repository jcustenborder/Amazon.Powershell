namespace Amazon.Powershell.AutoScaling
{
    using Amazon.AutoScaling.Model;
    using Amazon.AutoScaling;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.DESCRIBE, AutoScalingNouns.LAUNCHCONFIGURATIONS)]
    public class DescribeLaunchConfigurationsCmdlet : AutoScalingCmdLet
    {
        protected override void EndProcessing()
        {
            throw new System.NotImplementedException();
        }
    }
}
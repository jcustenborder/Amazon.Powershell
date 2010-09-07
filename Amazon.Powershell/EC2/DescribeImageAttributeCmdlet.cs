namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.DESCRIBE, EC2Nouns.IMAGEATTRIBUTE)]
    public class DescribeImageAttributeCmdlet : EC2CmdLet
    {
        protected override void EndProcessing()
        {
            throw new System.NotImplementedException();
        }
    }
}
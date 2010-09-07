namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.CREATE, EC2Nouns.VOLUME)]
    public class CreateVolumeCmdlet : EC2CmdLet
    {
        protected override void EndProcessing()
        {

        }
    }
}

namespace Amazon.Powershell.S3
{
    using Amazon.S3.Model;
    using Amazon.S3;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.GET, S3Nouns.PRESIGNEDURL)]
    public class GetPreSignedUrlCmdlet : S3CmdLet
    {
        protected override void EndProcessing()
        {
            throw new System.NotImplementedException();
        }
    }
}
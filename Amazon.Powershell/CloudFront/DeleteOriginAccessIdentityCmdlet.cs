namespace Amazon.Powershell.CloudFront
{
    using Amazon.CloudFront.Model;
    using Amazon.CloudFront;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.DELETE, CloudFrontNouns.ORIGINACCESSIDENTITY)]
    public class DeleteOriginAccessIdentityCmdlet : CloudFrontCmdLet
    {
        protected override void EndProcessing()
        {
            throw new System.NotImplementedException();
        }
    }
}
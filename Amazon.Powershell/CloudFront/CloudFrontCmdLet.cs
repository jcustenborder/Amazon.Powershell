namespace Amazon.Powershell.CloudFront
{
    using Amazon.CloudFront.Model;
    using Amazon.CloudFront;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    public abstract class CloudFrontCmdLet : AmazonCmdLet
    {
        protected virtual AmazonCloudFront GetClient()
        {
            throw new System.NotSupportedException();
        }
    }
}

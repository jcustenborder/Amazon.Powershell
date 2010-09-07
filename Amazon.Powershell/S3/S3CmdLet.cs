namespace Amazon.Powershell.S3
{
    using Amazon.S3.Model;
    using Amazon.S3;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    public abstract class S3CmdLet : AmazonCmdLet
    {
        protected virtual AmazonS3 GetClient()
        {
            throw new System.NotSupportedException();
        }
    }
}

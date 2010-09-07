namespace Amazon.Powershell.SimpleNotificationService
{
    using Amazon.SimpleNotificationService.Model;
    using Amazon.SimpleNotificationService;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    public abstract class SimpleNotificationServiceCmdLet : AmazonCmdLet
    {
        protected virtual AmazonSimpleNotificationService GetClient()
        {
            throw new System.NotSupportedException();
        }
    }
}

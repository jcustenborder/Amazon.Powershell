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
            AmazonCredentials.KeyPair credentials = base.GetCredentials();
            AmazonSimpleNotificationService client = new AmazonSimpleNotificationServiceClient(credentials.AwsAccessKeyId, credentials.AwsSecretAccessKey);
            return client;
        }
    }
}

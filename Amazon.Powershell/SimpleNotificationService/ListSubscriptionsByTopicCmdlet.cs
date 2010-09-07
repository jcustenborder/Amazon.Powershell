namespace Amazon.Powershell.SimpleNotificationService
{
    using Amazon.SimpleNotificationService.Model;
    using Amazon.SimpleNotificationService;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.LIST, SimpleNotificationServiceNouns.SUBSCRIPTIONSBYTOPIC)]
    public class ListSubscriptionsByTopicCmdlet : SimpleNotificationServiceCmdLet
    {
        protected override void EndProcessing()
        {
            throw new System.NotImplementedException();
        }
    }
}
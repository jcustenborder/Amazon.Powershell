namespace Amazon.Powershell.SimpleNotificationService
{
    using Amazon.SimpleNotificationService.Model;
    using Amazon.SimpleNotificationService;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.LIST, SimpleNotificationServiceNouns.SUBSCRIPTIONS)]
    public class ListSubscriptionsCmdlet : SimpleNotificationServiceCmdLet
    {
        private string _NextToken;
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string NextToken
        {
            get
            {
                return this._NextToken;
            }
            set
            {
                this._NextToken = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonSimpleNotificationService client = base.GetClient();
            Amazon.SimpleNotificationService.Model.ListSubscriptionsRequest request = new Amazon.SimpleNotificationService.Model.ListSubscriptionsRequest();
            request.NextToken = this._NextToken;
            Amazon.SimpleNotificationService.Model.ListSubscriptionsResponse response = client.ListSubscriptions(request);
            base.WriteObject(response.ListSubscriptionsResult, true);
        }
    }
}

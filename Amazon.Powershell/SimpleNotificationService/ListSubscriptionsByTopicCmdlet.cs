namespace Amazon.Powershell.SimpleNotificationService
{
    using Amazon.SimpleNotificationService.Model;
    using Amazon.SimpleNotificationService;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.LIST, SimpleNotificationServiceNouns.SUBSCRIPTIONSBYTOPIC)]
    public class ListSubscriptionsByTopicCmdlet : SimpleNotificationServiceCmdLet
    {
        private string _TopicArn;
        private string _NextToken;
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string TopicArn
        {
            get
            {
                return this._TopicArn;
            }
            set
            {
                this._TopicArn = value;
            }
        }
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
            Amazon.SimpleNotificationService.Model.ListSubscriptionsByTopicRequest request = new Amazon.SimpleNotificationService.Model.ListSubscriptionsByTopicRequest();
            request.TopicArn = this._TopicArn;
            request.NextToken = this._NextToken;
            Amazon.SimpleNotificationService.Model.ListSubscriptionsByTopicResponse response = client.ListSubscriptionsByTopic(request);
            base.WriteObject(response.ListSubscriptionsByTopicResult, true);
        }
    }
}

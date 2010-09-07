namespace Amazon.Powershell.SimpleNotificationService
{
    using Amazon.SimpleNotificationService.Model;
    using Amazon.SimpleNotificationService;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.CONFIRM, SimpleNotificationServiceNouns.SUBSCRIPTION)]
    public class ConfirmSubscriptionCmdlet : SimpleNotificationServiceCmdLet
    {
        private string _TopicArn;
        private string _Token;
        private string _AuthenticateOnUnsubscribe;
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
        public string Token
        {
            get
            {
                return this._Token;
            }
            set
            {
                this._Token = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string AuthenticateOnUnsubscribe
        {
            get
            {
                return this._AuthenticateOnUnsubscribe;
            }
            set
            {
                this._AuthenticateOnUnsubscribe = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonSimpleNotificationService client = base.GetClient();
            Amazon.SimpleNotificationService.Model.ConfirmSubscriptionRequest request = new Amazon.SimpleNotificationService.Model.ConfirmSubscriptionRequest();
            request.TopicArn = this._TopicArn;
            request.Token = this._Token;
            request.AuthenticateOnUnsubscribe = this._AuthenticateOnUnsubscribe;
            Amazon.SimpleNotificationService.Model.ConfirmSubscriptionResponse response = client.ConfirmSubscription(request);
            base.WriteObject(response.ConfirmSubscriptionResult, true);
        }
    }
}

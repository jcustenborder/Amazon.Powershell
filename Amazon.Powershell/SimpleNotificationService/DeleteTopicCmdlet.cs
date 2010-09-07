namespace Amazon.Powershell.SimpleNotificationService
{
    using Amazon.SimpleNotificationService.Model;
    using Amazon.SimpleNotificationService;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.DELETE, SimpleNotificationServiceNouns.TOPIC)]
    public class DeleteTopicCmdlet : SimpleNotificationServiceCmdLet
    {
        private string _TopicArn;
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
        protected override void ProcessRecord()
        {
            AmazonSimpleNotificationService client = base.GetClient();
            Amazon.SimpleNotificationService.Model.DeleteTopicRequest request = new Amazon.SimpleNotificationService.Model.DeleteTopicRequest();
            request.TopicArn = this._TopicArn;
            Amazon.SimpleNotificationService.Model.DeleteTopicResponse response = client.DeleteTopic(request);
        }
    }
}

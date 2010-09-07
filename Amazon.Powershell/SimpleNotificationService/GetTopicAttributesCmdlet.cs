namespace Amazon.Powershell.SimpleNotificationService
{
    using Amazon.SimpleNotificationService.Model;
    using Amazon.SimpleNotificationService;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.GET, SimpleNotificationServiceNouns.TOPICATTRIBUTES)]
    public class GetTopicAttributesCmdlet : SimpleNotificationServiceCmdLet
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
            Amazon.SimpleNotificationService.Model.GetTopicAttributesRequest request = new Amazon.SimpleNotificationService.Model.GetTopicAttributesRequest();
            request.TopicArn = this._TopicArn;
            Amazon.SimpleNotificationService.Model.GetTopicAttributesResponse response = client.GetTopicAttributes(request);
            base.WriteObject(response.GetTopicAttributesResult, true);
        }
    }
}

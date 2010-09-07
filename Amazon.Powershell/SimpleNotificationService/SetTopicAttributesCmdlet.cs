namespace Amazon.Powershell.SimpleNotificationService
{
    using Amazon.SimpleNotificationService.Model;
    using Amazon.SimpleNotificationService;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.SET, SimpleNotificationServiceNouns.TOPICATTRIBUTES)]
    public class SetTopicAttributesCmdlet : SimpleNotificationServiceCmdLet
    {
        private string _TopicArn;
        private string _AttributeName;
        private string _AttributeValue;
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
        public string AttributeName
        {
            get
            {
                return this._AttributeName;
            }
            set
            {
                this._AttributeName = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string AttributeValue
        {
            get
            {
                return this._AttributeValue;
            }
            set
            {
                this._AttributeValue = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonSimpleNotificationService client = base.GetClient();
            Amazon.SimpleNotificationService.Model.SetTopicAttributesRequest request = new Amazon.SimpleNotificationService.Model.SetTopicAttributesRequest();
            request.TopicArn = this._TopicArn;
            request.AttributeName = this._AttributeName;
            request.AttributeValue = this._AttributeValue;
            Amazon.SimpleNotificationService.Model.SetTopicAttributesResponse response = client.SetTopicAttributes(request);
        }
    }
}

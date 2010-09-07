namespace Amazon.Powershell.SimpleNotificationService
{
    using Amazon.SimpleNotificationService.Model;
    using Amazon.SimpleNotificationService;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.LIST, SimpleNotificationServiceNouns.TOPICS)]
    public class ListTopicsCmdlet : SimpleNotificationServiceCmdLet
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
            Amazon.SimpleNotificationService.Model.ListTopicsRequest request = new Amazon.SimpleNotificationService.Model.ListTopicsRequest();
            request.NextToken = this._NextToken;
            Amazon.SimpleNotificationService.Model.ListTopicsResponse response = client.ListTopics(request);
            base.WriteObject(response.ListTopicsResult, true);
        }
    }
}

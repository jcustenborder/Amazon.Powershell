namespace Amazon.Powershell.SimpleNotificationService
{
    using Amazon.SimpleNotificationService.Model;
    using Amazon.SimpleNotificationService;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.CREATE, SimpleNotificationServiceNouns.TOPIC)]
    public class CreateTopicCmdlet : SimpleNotificationServiceCmdLet
    {
        private string _Name;
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this._Name = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonSimpleNotificationService client = base.GetClient();
            Amazon.SimpleNotificationService.Model.CreateTopicRequest request = new Amazon.SimpleNotificationService.Model.CreateTopicRequest();
            request.Name = this._Name;
            Amazon.SimpleNotificationService.Model.CreateTopicResponse response = client.CreateTopic(request);
            base.WriteObject(response.CreateTopicResult, true);
        }
    }
}

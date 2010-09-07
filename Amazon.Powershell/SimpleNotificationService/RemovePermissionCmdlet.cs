namespace Amazon.Powershell.SimpleNotificationService
{
    using Amazon.SimpleNotificationService.Model;
    using Amazon.SimpleNotificationService;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.REMOVE, SimpleNotificationServiceNouns.PERMISSION)]
    public class RemovePermissionCmdlet : SimpleNotificationServiceCmdLet
    {
        private string _TopicArn;
        private string _Label;
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
        public string Label
        {
            get
            {
                return this._Label;
            }
            set
            {
                this._Label = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonSimpleNotificationService client = base.GetClient();
            Amazon.SimpleNotificationService.Model.RemovePermissionRequest request = new Amazon.SimpleNotificationService.Model.RemovePermissionRequest();
            request.TopicArn = this._TopicArn;
            request.Label = this._Label;
            Amazon.SimpleNotificationService.Model.RemovePermissionResponse response = client.RemovePermission(request);
        }
    }
}

namespace Amazon.Powershell.SimpleNotificationService
{
    using Amazon.SimpleNotificationService.Model;
    using Amazon.SimpleNotificationService;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.ADD, SimpleNotificationServiceNouns.PERMISSION)]
    public class AddPermissionCmdlet : SimpleNotificationServiceCmdLet
    {
        private string _TopicArn;
        private string _Label;
        private string _AWSAccountIds;
        private string _ActionNames;
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
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string AWSAccountIds
        {
            get
            {
                return this._AWSAccountIds;
            }
            set
            {
                this._AWSAccountIds = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string ActionNames
        {
            get
            {
                return this._ActionNames;
            }
            set
            {
                this._ActionNames = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonSimpleNotificationService client = base.GetClient();
            Amazon.SimpleNotificationService.Model.AddPermissionRequest request = new Amazon.SimpleNotificationService.Model.AddPermissionRequest();
            request.TopicArn = this._TopicArn;
            request.Label = this._Label;
            if (string.IsNullOrEmpty(this._AWSAccountIds))
            {
                request.AWSAccountIds.Add(this._AWSAccountIds);
            }
            if (string.IsNullOrEmpty(this._ActionNames))
            {
                request.ActionNames.Add(this._ActionNames);
            }
            Amazon.SimpleNotificationService.Model.AddPermissionResponse response = client.AddPermission(request);
        }
    }
}

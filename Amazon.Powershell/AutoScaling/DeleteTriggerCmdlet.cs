namespace Amazon.Powershell.AutoScaling
{
    using Amazon.AutoScaling.Model;
    using Amazon.AutoScaling;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.DELETE, AutoScalingNouns.TRIGGER)]
    public class DeleteTriggerCmdlet : AutoScalingCmdLet
    {
        private string _AutoScalingGroupName;
        private string _TriggerName;
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string AutoScalingGroupName
        {
            get
            {
                return this._AutoScalingGroupName;
            }
            set
            {
                this._AutoScalingGroupName = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string TriggerName
        {
            get
            {
                return this._TriggerName;
            }
            set
            {
                this._TriggerName = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonAutoScaling client = base.GetClient();
            Amazon.AutoScaling.Model.DeleteTriggerRequest request = new Amazon.AutoScaling.Model.DeleteTriggerRequest();
            request.AutoScalingGroupName = this._AutoScalingGroupName;
            request.TriggerName = this._TriggerName;
            Amazon.AutoScaling.Model.DeleteTriggerResponse response = client.DeleteTrigger(request);
        }
    }
}

namespace Amazon.Powershell.AutoScaling
{
    using Amazon.AutoScaling.Model;
    using Amazon.AutoScaling;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.DELETE, AutoScalingNouns.AUTOSCALINGGROUP)]
    public class DeleteAutoScalingGroupCmdlet : AutoScalingCmdLet
    {
        private string _AutoScalingGroupName;
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
        protected override void ProcessRecord()
        {
            AmazonAutoScaling client = base.GetClient();
            Amazon.AutoScaling.Model.DeleteAutoScalingGroupRequest request = new Amazon.AutoScaling.Model.DeleteAutoScalingGroupRequest();
            request.AutoScalingGroupName = this._AutoScalingGroupName;
            Amazon.AutoScaling.Model.DeleteAutoScalingGroupResponse response = client.DeleteAutoScalingGroup(request);
        }
    }
}

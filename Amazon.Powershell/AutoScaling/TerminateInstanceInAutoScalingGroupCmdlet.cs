namespace Amazon.Powershell.AutoScaling
{
    using Amazon.AutoScaling.Model;
    using Amazon.AutoScaling;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.TERMINATE, AutoScalingNouns.INSTANCEINAUTOSCALINGGROUP)]
    public class TerminateInstanceInAutoScalingGroupCmdlet : AutoScalingCmdLet
    {
        private string _InstanceId;
        private bool _ShouldDecrementDesiredCapacity;
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string InstanceId
        {
            get
            {
                return this._InstanceId;
            }
            set
            {
                this._InstanceId = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public bool ShouldDecrementDesiredCapacity
        {
            get
            {
                return this._ShouldDecrementDesiredCapacity;
            }
            set
            {
                this._ShouldDecrementDesiredCapacity = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonAutoScaling client = base.GetClient();
            Amazon.AutoScaling.Model.TerminateInstanceInAutoScalingGroupRequest request = new Amazon.AutoScaling.Model.TerminateInstanceInAutoScalingGroupRequest();
            request.InstanceId = this._InstanceId;
            request.ShouldDecrementDesiredCapacity = this._ShouldDecrementDesiredCapacity;
            Amazon.AutoScaling.Model.TerminateInstanceInAutoScalingGroupResponse response = client.TerminateInstanceInAutoScalingGroup(request);
            base.WriteObject(response.TerminateInstanceInAutoScalingGroupResult, true);
        }
    }
}

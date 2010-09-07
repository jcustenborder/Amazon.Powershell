namespace Amazon.Powershell.AutoScaling
{
    using Amazon.AutoScaling.Model;
    using Amazon.AutoScaling;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.DESCRIBE, AutoScalingNouns.TRIGGERS)]
    public class DescribeTriggersCmdlet : AutoScalingCmdLet
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
            Amazon.AutoScaling.Model.DescribeTriggersRequest request = new Amazon.AutoScaling.Model.DescribeTriggersRequest();
            request.AutoScalingGroupName = this._AutoScalingGroupName;
            Amazon.AutoScaling.Model.DescribeTriggersResponse response = client.DescribeTriggers(request);
            base.WriteObject(response.DescribeTriggersResult, true);
        }
    }
}

namespace Amazon.Powershell.AutoScaling
{
    using Amazon.AutoScaling.Model;
    using Amazon.AutoScaling;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.DESCRIBE, AutoScalingNouns.AUTOSCALINGGROUPS)]
    public class DescribeAutoScalingGroupsCmdlet : AutoScalingCmdLet
    {
        private string _AutoScalingGroupNames;
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string AutoScalingGroupNames
        {
            get
            {
                return this._AutoScalingGroupNames;
            }
            set
            {
                this._AutoScalingGroupNames = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonAutoScaling client = base.GetClient();
            Amazon.AutoScaling.Model.DescribeAutoScalingGroupsRequest request = new Amazon.AutoScaling.Model.DescribeAutoScalingGroupsRequest();
            if (string.IsNullOrEmpty(this._AutoScalingGroupNames))
            {
                request.AutoScalingGroupNames.Add(this._AutoScalingGroupNames);
            }
            Amazon.AutoScaling.Model.DescribeAutoScalingGroupsResponse response = client.DescribeAutoScalingGroups(request);
            base.WriteObject(response.DescribeAutoScalingGroupsResult, true);
        }
    }
}

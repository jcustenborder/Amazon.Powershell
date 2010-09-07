namespace Amazon.Powershell.AutoScaling
{
    using Amazon.AutoScaling.Model;
    using Amazon.AutoScaling;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.DESCRIBE, AutoScalingNouns.SCALINGACTIVITIES)]
    public class DescribeScalingActivitiesCmdlet : AutoScalingCmdLet
    {
        private string _ActivityIds;
        private string _AutoScalingGroupName;
        private decimal _MaxRecords;
        private string _NextToken;
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string ActivityIds
        {
            get
            {
                return this._ActivityIds;
            }
            set
            {
                this._ActivityIds = value;
            }
        }
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
        public decimal MaxRecords
        {
            get
            {
                return this._MaxRecords;
            }
            set
            {
                this._MaxRecords = value;
            }
        }
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
            AmazonAutoScaling client = base.GetClient();
            Amazon.AutoScaling.Model.DescribeScalingActivitiesRequest request = new Amazon.AutoScaling.Model.DescribeScalingActivitiesRequest();
            if (string.IsNullOrEmpty(this._ActivityIds))
            {
                request.ActivityIds.Add(this._ActivityIds);
            }
            request.AutoScalingGroupName = this._AutoScalingGroupName;
            request.MaxRecords = this._MaxRecords;
            request.NextToken = this._NextToken;
            Amazon.AutoScaling.Model.DescribeScalingActivitiesResponse response = client.DescribeScalingActivities(request);
            base.WriteObject(response.DescribeScalingActivitiesResult, true);
        }
    }
}

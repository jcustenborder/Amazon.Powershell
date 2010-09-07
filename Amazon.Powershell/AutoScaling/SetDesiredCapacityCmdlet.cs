namespace Amazon.Powershell.AutoScaling
{
    using Amazon.AutoScaling.Model;
    using Amazon.AutoScaling;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.SET, AutoScalingNouns.DESIREDCAPACITY)]
    public class SetDesiredCapacityCmdlet : AutoScalingCmdLet
    {
        private string _AutoScalingGroupName;
        private decimal _DesiredCapacity;
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
        public decimal DesiredCapacity
        {
            get
            {
                return this._DesiredCapacity;
            }
            set
            {
                this._DesiredCapacity = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonAutoScaling client = base.GetClient();
            Amazon.AutoScaling.Model.SetDesiredCapacityRequest request = new Amazon.AutoScaling.Model.SetDesiredCapacityRequest();
            request.AutoScalingGroupName = this._AutoScalingGroupName;
            request.DesiredCapacity = this._DesiredCapacity;
            Amazon.AutoScaling.Model.SetDesiredCapacityResponse response = client.SetDesiredCapacity(request);
        }
    }
}

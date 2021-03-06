namespace Amazon.Powershell.AutoScaling
{
    using Amazon.AutoScaling.Model;
    using Amazon.AutoScaling;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.UPDATE, AutoScalingNouns.AUTOSCALINGGROUP)]
    public class UpdateAutoScalingGroupCmdlet : AutoScalingCmdLet
    {
        private string _AutoScalingGroupName;
        private string _LaunchConfigurationName;
        private decimal _MinSize;
        private decimal _MaxSize;
        private decimal _Cooldown;
        private string _AvailabilityZones;
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
        public string LaunchConfigurationName
        {
            get
            {
                return this._LaunchConfigurationName;
            }
            set
            {
                this._LaunchConfigurationName = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public decimal MinSize
        {
            get
            {
                return this._MinSize;
            }
            set
            {
                this._MinSize = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public decimal MaxSize
        {
            get
            {
                return this._MaxSize;
            }
            set
            {
                this._MaxSize = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public decimal Cooldown
        {
            get
            {
                return this._Cooldown;
            }
            set
            {
                this._Cooldown = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string AvailabilityZones
        {
            get
            {
                return this._AvailabilityZones;
            }
            set
            {
                this._AvailabilityZones = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonAutoScaling client = base.GetClient();
            Amazon.AutoScaling.Model.UpdateAutoScalingGroupRequest request = new Amazon.AutoScaling.Model.UpdateAutoScalingGroupRequest();
            request.AutoScalingGroupName = this._AutoScalingGroupName;
            request.LaunchConfigurationName = this._LaunchConfigurationName;
            request.MinSize = this._MinSize;
            request.MaxSize = this._MaxSize;
            request.Cooldown = this._Cooldown;
            if (string.IsNullOrEmpty(this._AvailabilityZones))
            {
                request.AvailabilityZones.Add(this._AvailabilityZones);
            }
            Amazon.AutoScaling.Model.UpdateAutoScalingGroupResponse response = client.UpdateAutoScalingGroup(request);
        }
    }
}

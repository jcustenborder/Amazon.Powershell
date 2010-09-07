namespace Amazon.Powershell.AutoScaling
{
    using Amazon.AutoScaling.Model;
    using Amazon.AutoScaling;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.CREATE, AutoScalingNouns.ORUPDATESCALINGTRIGGER)]
    public class CreateOrUpdateScalingTriggerCmdlet : AutoScalingCmdLet
    {
        private string _TriggerName;
        private string _AutoScalingGroupName;
        private string _MeasureName;
        private string _Statistic;
        private decimal _Period;
        private string _Unit;
        private string _CustomUnit;
        private string _Namespace;
        private string _LowerBreachScaleIncrement;
        private string _UpperBreachScaleIncrement;
        private decimal _BreachDuration;
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
        public string MeasureName
        {
            get
            {
                return this._MeasureName;
            }
            set
            {
                this._MeasureName = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string Statistic
        {
            get
            {
                return this._Statistic;
            }
            set
            {
                this._Statistic = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public decimal Period
        {
            get
            {
                return this._Period;
            }
            set
            {
                this._Period = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string Unit
        {
            get
            {
                return this._Unit;
            }
            set
            {
                this._Unit = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string CustomUnit
        {
            get
            {
                return this._CustomUnit;
            }
            set
            {
                this._CustomUnit = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string Namespace
        {
            get
            {
                return this._Namespace;
            }
            set
            {
                this._Namespace = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string LowerBreachScaleIncrement
        {
            get
            {
                return this._LowerBreachScaleIncrement;
            }
            set
            {
                this._LowerBreachScaleIncrement = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string UpperBreachScaleIncrement
        {
            get
            {
                return this._UpperBreachScaleIncrement;
            }
            set
            {
                this._UpperBreachScaleIncrement = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public decimal BreachDuration
        {
            get
            {
                return this._BreachDuration;
            }
            set
            {
                this._BreachDuration = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonAutoScaling client = base.GetClient();
            Amazon.AutoScaling.Model.CreateOrUpdateScalingTriggerRequest request = new Amazon.AutoScaling.Model.CreateOrUpdateScalingTriggerRequest();
            request.TriggerName = this._TriggerName;
            request.AutoScalingGroupName = this._AutoScalingGroupName;
            request.MeasureName = this._MeasureName;
            request.Statistic = this._Statistic;
            request.Period = this._Period;
            request.Unit = this._Unit;
            request.CustomUnit = this._CustomUnit;
            request.Namespace = this._Namespace;
            request.LowerBreachScaleIncrement = this._LowerBreachScaleIncrement;
            request.UpperBreachScaleIncrement = this._UpperBreachScaleIncrement;
            request.BreachDuration = this._BreachDuration;
            Amazon.AutoScaling.Model.CreateOrUpdateScalingTriggerResponse response = client.CreateOrUpdateScalingTrigger(request);
        }
    }
}

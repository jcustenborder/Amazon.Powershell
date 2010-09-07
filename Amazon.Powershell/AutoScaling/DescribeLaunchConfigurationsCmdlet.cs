namespace Amazon.Powershell.AutoScaling
{
    using Amazon.AutoScaling.Model;
    using Amazon.AutoScaling;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.DESCRIBE, AutoScalingNouns.LAUNCHCONFIGURATIONS)]
    public class DescribeLaunchConfigurationsCmdlet : AutoScalingCmdLet
    {
        private string _LaunchConfigurationNames;
        private string _NextToken;
        private decimal _MaxRecords;
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string LaunchConfigurationNames
        {
            get
            {
                return this._LaunchConfigurationNames;
            }
            set
            {
                this._LaunchConfigurationNames = value;
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
        protected override void ProcessRecord()
        {
            AmazonAutoScaling client = base.GetClient();
            Amazon.AutoScaling.Model.DescribeLaunchConfigurationsRequest request = new Amazon.AutoScaling.Model.DescribeLaunchConfigurationsRequest();
            if (string.IsNullOrEmpty(this._LaunchConfigurationNames))
            {
                request.LaunchConfigurationNames.Add(this._LaunchConfigurationNames);
            }
            request.NextToken = this._NextToken;
            request.MaxRecords = this._MaxRecords;
            Amazon.AutoScaling.Model.DescribeLaunchConfigurationsResponse response = client.DescribeLaunchConfigurations(request);
            base.WriteObject(response.DescribeLaunchConfigurationsResult, true);
        }
    }
}

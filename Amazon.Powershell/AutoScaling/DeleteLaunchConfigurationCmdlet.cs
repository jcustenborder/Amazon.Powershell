namespace Amazon.Powershell.AutoScaling
{
    using Amazon.AutoScaling.Model;
    using Amazon.AutoScaling;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.DELETE, AutoScalingNouns.LAUNCHCONFIGURATION)]
    public class DeleteLaunchConfigurationCmdlet : AutoScalingCmdLet
    {
        private string _LaunchConfigurationName;
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
        protected override void ProcessRecord()
        {
            AmazonAutoScaling client = base.GetClient();
            Amazon.AutoScaling.Model.DeleteLaunchConfigurationRequest request = new Amazon.AutoScaling.Model.DeleteLaunchConfigurationRequest();
            request.LaunchConfigurationName = this._LaunchConfigurationName;
            Amazon.AutoScaling.Model.DeleteLaunchConfigurationResponse response = client.DeleteLaunchConfiguration(request);
        }
    }
}

namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.DESCRIBE, EC2Nouns.AVAILABILITYZONES)]
    public class DescribeAvailabilityZonesCmdlet : EC2CmdLet
    {
        private string _ZoneName;
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string ZoneName
        {
            get
            {
                return this._ZoneName;
            }
            set
            {
                this._ZoneName = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonEC2 client = base.GetClient();
            Amazon.EC2.Model.DescribeAvailabilityZonesRequest request = new Amazon.EC2.Model.DescribeAvailabilityZonesRequest();
            if (string.IsNullOrEmpty(this._ZoneName))
            {
                request.ZoneName.Add(this._ZoneName);
            }
            Amazon.EC2.Model.DescribeAvailabilityZonesResponse response = client.DescribeAvailabilityZones(request);
            base.WriteObject(response.DescribeAvailabilityZonesResult, true);
        }
    }
}

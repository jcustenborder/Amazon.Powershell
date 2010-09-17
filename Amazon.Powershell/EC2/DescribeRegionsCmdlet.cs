namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.DESCRIBE, EC2Nouns.REGIONS)]
    public class DescribeRegionsCmdlet : EC2CmdLet
    {
        private string _RegionName;
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string RegionName
        {
            get
            {
                return this._RegionName;
            }
            set
            {
                this._RegionName = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonEC2 client = base.GetClient();
            Amazon.EC2.Model.DescribeRegionsRequest request = new Amazon.EC2.Model.DescribeRegionsRequest();
            if (string.IsNullOrEmpty(this._RegionName))
            {
                request.RegionName.Add(this._RegionName);
            }
            Amazon.EC2.Model.DescribeRegionsResponse response = client.DescribeRegions(request);
            base.WriteObject(response.DescribeRegionsResult.Region, true);
        }
    }
}

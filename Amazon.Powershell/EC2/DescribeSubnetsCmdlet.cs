namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.DESCRIBE, EC2Nouns.SUBNETS)]
    public class DescribeSubnetsCmdlet : EC2CmdLet
    {
        private string _SubnetId;
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string SubnetId
        {
            get
            {
                return this._SubnetId;
            }
            set
            {
                this._SubnetId = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonEC2 client = base.GetClient();
            Amazon.EC2.Model.DescribeSubnetsRequest request = new Amazon.EC2.Model.DescribeSubnetsRequest();
            if (string.IsNullOrEmpty(this._SubnetId))
            {
                request.SubnetId.Add(this._SubnetId);
            }
            Amazon.EC2.Model.DescribeSubnetsResponse response = client.DescribeSubnets(request);
            base.WriteObject(response.DescribeSubnetsResult.Subnet, true);
        }
    }
}

namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.DESCRIBE, EC2Nouns.VPCS)]
    public class DescribeVpcsCmdlet : EC2CmdLet
    {
        private string _VpcId;
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string VpcId
        {
            get
            {
                return this._VpcId;
            }
            set
            {
                this._VpcId = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonEC2 client = base.GetClient();
            Amazon.EC2.Model.DescribeVpcsRequest request = new Amazon.EC2.Model.DescribeVpcsRequest();
            if (string.IsNullOrEmpty(this._VpcId))
            {
                request.VpcId.Add(this._VpcId);
            }
            Amazon.EC2.Model.DescribeVpcsResponse response = client.DescribeVpcs(request);
            base.WriteObject(response.DescribeVpcsResult.Vpc, true);
        }
    }
}

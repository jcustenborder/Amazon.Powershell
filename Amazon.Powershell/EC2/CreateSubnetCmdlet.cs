namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.CREATE, EC2Nouns.SUBNET)]
    public class CreateSubnetCmdlet : EC2CmdLet
    {
        private string _VpcId;
        private string _CidrBlock;
        private string _AvailabilityZone;
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
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string CidrBlock
        {
            get
            {
                return this._CidrBlock;
            }
            set
            {
                this._CidrBlock = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string AvailabilityZone
        {
            get
            {
                return this._AvailabilityZone;
            }
            set
            {
                this._AvailabilityZone = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonEC2 client = base.GetClient();
            Amazon.EC2.Model.CreateSubnetRequest request = new Amazon.EC2.Model.CreateSubnetRequest();
            request.VpcId = this._VpcId;
            request.CidrBlock = this._CidrBlock;
            request.AvailabilityZone = this._AvailabilityZone;
            Amazon.EC2.Model.CreateSubnetResponse response = client.CreateSubnet(request);
            base.WriteObject(response.CreateSubnetResult, true);
        }
    }
}

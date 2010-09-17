namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.DESCRIBE, EC2Nouns.RESERVEDINSTANCES)]
    public class DescribeReservedInstancesCmdlet : EC2CmdLet
    {
        private string _ReservedInstancesId;
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string ReservedInstancesId
        {
            get
            {
                return this._ReservedInstancesId;
            }
            set
            {
                this._ReservedInstancesId = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonEC2 client = base.GetClient();
            Amazon.EC2.Model.DescribeReservedInstancesRequest request = new Amazon.EC2.Model.DescribeReservedInstancesRequest();
            if (string.IsNullOrEmpty(this._ReservedInstancesId))
            {
                request.ReservedInstancesId.Add(this._ReservedInstancesId);
            }
            Amazon.EC2.Model.DescribeReservedInstancesResponse response = client.DescribeReservedInstances(request);
            base.WriteObject(response.DescribeReservedInstancesResult.ReservedInstances, true);
        }
    }
}

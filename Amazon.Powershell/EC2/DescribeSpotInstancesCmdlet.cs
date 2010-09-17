namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.DESCRIBE, EC2Nouns.SPOTINSTANCES)]
    public class DescribeSpotInstancesCmdlet : EC2CmdLet
    {
        private string _SpotInstanceRequestId;
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string SpotInstanceRequestId
        {
            get
            {
                return this._SpotInstanceRequestId;
            }
            set
            {
                this._SpotInstanceRequestId = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonEC2 client = base.GetClient();
            Amazon.EC2.Model.DescribeSpotInstanceRequestsRequest request = new Amazon.EC2.Model.DescribeSpotInstanceRequestsRequest();
            if (string.IsNullOrEmpty(this._SpotInstanceRequestId))
            {
                request.SpotInstanceRequestId.Add(this._SpotInstanceRequestId);
            }
            Amazon.EC2.Model.DescribeSpotInstanceRequestsResponse response = client.DescribeSpotInstanceRequests(request);
            base.WriteObject(response.DescribeSpotInstanceRequestsResult.SpotInstanceRequest, true);
        }
    }
}

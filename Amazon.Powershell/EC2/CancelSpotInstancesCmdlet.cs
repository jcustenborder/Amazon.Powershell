namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.CANCEL, EC2Nouns.SPOTINSTANCES)]
    public class CancelSpotInstancesCmdlet : EC2CmdLet
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
            Amazon.EC2.Model.CancelSpotInstanceRequestsRequest request = new Amazon.EC2.Model.CancelSpotInstanceRequestsRequest();
            if (string.IsNullOrEmpty(this._SpotInstanceRequestId))
            {
                request.SpotInstanceRequestId.Add(this._SpotInstanceRequestId);
            }
            Amazon.EC2.Model.CancelSpotInstanceRequestsResponse response = client.CancelSpotInstanceRequests(request);
            base.WriteObject(response.CancelSpotInstanceRequestsResult, true);
        }
    }
}

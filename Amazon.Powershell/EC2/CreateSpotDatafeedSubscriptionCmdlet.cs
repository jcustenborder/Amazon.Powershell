namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.CREATE, EC2Nouns.SPOTDATAFEEDSUBSCRIPTION)]
    public class CreateSpotDatafeedSubscriptionCmdlet : EC2CmdLet
    {
        private string _Bucket;
        private string _Prefix;
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string Bucket
        {
            get
            {
                return this._Bucket;
            }
            set
            {
                this._Bucket = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string Prefix
        {
            get
            {
                return this._Prefix;
            }
            set
            {
                this._Prefix = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonEC2 client = base.GetClient();
            Amazon.EC2.Model.CreateSpotDatafeedSubscriptionRequest request = new Amazon.EC2.Model.CreateSpotDatafeedSubscriptionRequest();
            request.Bucket = this._Bucket;
            request.Prefix = this._Prefix;
            Amazon.EC2.Model.CreateSpotDatafeedSubscriptionResponse response = client.CreateSpotDatafeedSubscription(request);
            base.WriteObject(response.CreateSpotDatafeedSubscriptionResult, true);
        }
    }
}

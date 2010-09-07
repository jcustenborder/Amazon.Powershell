namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.DELETE, EC2Nouns.SPOTDATAFEEDSUBSCRIPTION)]
    public class DeleteSpotDatafeedSubscriptionCmdlet : EC2CmdLet
    {
        protected override void ProcessRecord()
        {
            AmazonEC2 client = base.GetClient();
            Amazon.EC2.Model.DeleteSpotDatafeedSubscriptionRequest request = new Amazon.EC2.Model.DeleteSpotDatafeedSubscriptionRequest();
            Amazon.EC2.Model.DeleteSpotDatafeedSubscriptionResponse response = client.DeleteSpotDatafeedSubscription(request);
        }
    }
}

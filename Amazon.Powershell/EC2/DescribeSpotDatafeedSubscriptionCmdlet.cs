namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.DESCRIBE, EC2Nouns.SPOTDATAFEEDSUBSCRIPTION)]
    public class DescribeSpotDatafeedSubscriptionCmdlet : EC2CmdLet
    {
        protected override void ProcessRecord()
        {
            AmazonEC2 client = base.GetClient();
            Amazon.EC2.Model.DescribeSpotDatafeedSubscriptionRequest request = new Amazon.EC2.Model.DescribeSpotDatafeedSubscriptionRequest();
            Amazon.EC2.Model.DescribeSpotDatafeedSubscriptionResponse response = client.DescribeSpotDatafeedSubscription(request);
            base.WriteObject(response.DescribeSpotDatafeedSubscriptionResult, true);
        }
    }
}

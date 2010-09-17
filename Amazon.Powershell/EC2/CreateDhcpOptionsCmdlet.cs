namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.CREATE, EC2Nouns.DHCPOPTIONS)]
    public class CreateDhcpOptionsCmdlet : EC2CmdLet
    {
        protected override void ProcessRecord()
        {
            AmazonEC2 client = base.GetClient();
            Amazon.EC2.Model.CreateDhcpOptionsRequest request = new Amazon.EC2.Model.CreateDhcpOptionsRequest();
            Amazon.EC2.Model.CreateDhcpOptionsResponse response = client.CreateDhcpOptions(request);
            base.WriteObject(response.CreateDhcpOptionsResult.DhcpOptions, true);
        }
    }
}

namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.ALLOCATE, EC2Nouns.ADDRESS)]
    public class AllocateAddressCmdlet : EC2CmdLet
    {
        protected override void ProcessRecord()
        {
            AmazonEC2 client = base.GetClient();
            Amazon.EC2.Model.AllocateAddressRequest request = new Amazon.EC2.Model.AllocateAddressRequest();
            Amazon.EC2.Model.AllocateAddressResponse response = client.AllocateAddress(request);
            base.WriteObject(response.AllocateAddressResult, true);
        }
    }
}

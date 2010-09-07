namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.DELETE, EC2Nouns.VPNCONNECTION)]
    public class DeleteVpnConnectionCmdlet : EC2CmdLet
    {
        private string _VpnConnectionId;
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string VpnConnectionId
        {
            get
            {
                return this._VpnConnectionId;
            }
            set
            {
                this._VpnConnectionId = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonEC2 client = base.GetClient();
            Amazon.EC2.Model.DeleteVpnConnectionRequest request = new Amazon.EC2.Model.DeleteVpnConnectionRequest();
            request.VpnConnectionId = this._VpnConnectionId;
            Amazon.EC2.Model.DeleteVpnConnectionResponse response = client.DeleteVpnConnection(request);
        }
    }
}

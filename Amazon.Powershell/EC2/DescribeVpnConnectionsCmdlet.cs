namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.DESCRIBE, EC2Nouns.VPNCONNECTIONS)]
    public class DescribeVpnConnectionsCmdlet : EC2CmdLet
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
            Amazon.EC2.Model.DescribeVpnConnectionsRequest request = new Amazon.EC2.Model.DescribeVpnConnectionsRequest();
            if (string.IsNullOrEmpty(this._VpnConnectionId))
            {
                request.VpnConnectionId.Add(this._VpnConnectionId);
            }
            Amazon.EC2.Model.DescribeVpnConnectionsResponse response = client.DescribeVpnConnections(request);
            base.WriteObject(response.DescribeVpnConnectionsResult, true);
        }
    }
}

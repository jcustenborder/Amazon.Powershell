namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.CANCELLED, EC2Nouns.SPOTINSTANCE)]
    public class CancelledSpotInstanceCmdlet : EC2CmdLet
    {
        private string _SpotInstanceRequestId;
        private string _State;
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
        public string State
        {
            get
            {
                return this._State;
            }
            set
            {
                this._State = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonModel client = base.GetClient();
            Amazon.EC2.Model.CancelledSpotInstanceRequest request = new Amazon.EC2.Model.CancelledSpotInstanceRequest();
            request.SpotInstanceRequestId = this._SpotInstanceRequestId;
            request.State = this._State;
        }
    }
}

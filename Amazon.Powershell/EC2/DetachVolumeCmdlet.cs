namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.DETACH, EC2Nouns.VOLUME)]
    public class DetachVolumeCmdlet : EC2CmdLet
    {
        private string _VolumeId;
        private string _InstanceId;
        private string _Device;
        private bool _Force;
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string VolumeId
        {
            get
            {
                return this._VolumeId;
            }
            set
            {
                this._VolumeId = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string InstanceId
        {
            get
            {
                return this._InstanceId;
            }
            set
            {
                this._InstanceId = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string Device
        {
            get
            {
                return this._Device;
            }
            set
            {
                this._Device = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public bool Force
        {
            get
            {
                return this._Force;
            }
            set
            {
                this._Force = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonEC2 client = base.GetClient();
            Amazon.EC2.Model.DetachVolumeRequest request = new Amazon.EC2.Model.DetachVolumeRequest();
            request.VolumeId = this._VolumeId;
            request.InstanceId = this._InstanceId;
            request.Device = this._Device;
            request.Force = this._Force;
            Amazon.EC2.Model.DetachVolumeResponse response = client.DetachVolume(request);
            base.WriteObject(response.DetachVolumeResult.Attachment, true);
        }
    }
}

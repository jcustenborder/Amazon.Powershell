namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.ATTACH, EC2Nouns.VOLUME)]
    public class AttachVolumeCmdlet : EC2CmdLet
    {
        private string _VolumeId;
        private string _InstanceId;
        private string _Device;
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
        protected override void ProcessRecord()
        {
            AmazonEC2 client = base.GetClient();
            Amazon.EC2.Model.AttachVolumeRequest request = new Amazon.EC2.Model.AttachVolumeRequest();
            request.VolumeId = this._VolumeId;
            request.InstanceId = this._InstanceId;
            request.Device = this._Device;
            Amazon.EC2.Model.AttachVolumeResponse response = client.AttachVolume(request);
            base.WriteObject(response.AttachVolumeResult, true);
        }
    }
}

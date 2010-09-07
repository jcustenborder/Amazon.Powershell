namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.CREATE, EC2Nouns.VOLUME)]
    public class CreateVolumeCmdlet : EC2CmdLet
    {
        private string _Size;
        private string _SnapshotId;
        private string _AvailabilityZone;
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string Size
        {
            get
            {
                return this._Size;
            }
            set
            {
                this._Size = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string SnapshotId
        {
            get
            {
                return this._SnapshotId;
            }
            set
            {
                this._SnapshotId = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string AvailabilityZone
        {
            get
            {
                return this._AvailabilityZone;
            }
            set
            {
                this._AvailabilityZone = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonEC2 client = base.GetClient();
            Amazon.EC2.Model.CreateVolumeRequest request = new Amazon.EC2.Model.CreateVolumeRequest();
            request.Size = this._Size;
            request.SnapshotId = this._SnapshotId;
            request.AvailabilityZone = this._AvailabilityZone;
            Amazon.EC2.Model.CreateVolumeResponse response = client.CreateVolume(request);
            base.WriteObject(response.CreateVolumeResult, true);
        }
    }
}

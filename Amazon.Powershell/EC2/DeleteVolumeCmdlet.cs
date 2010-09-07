namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.DELETE, EC2Nouns.VOLUME)]
    public class DeleteVolumeCmdlet : EC2CmdLet
    {
        private string _VolumeId;
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
        protected override void ProcessRecord()
        {
            AmazonEC2 client = base.GetClient();
            Amazon.EC2.Model.DeleteVolumeRequest request = new Amazon.EC2.Model.DeleteVolumeRequest();
            request.VolumeId = this._VolumeId;
            Amazon.EC2.Model.DeleteVolumeResponse response = client.DeleteVolume(request);
        }
    }
}

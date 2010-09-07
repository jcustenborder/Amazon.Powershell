namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.CREATE, EC2Nouns.SNAPSHOT)]
    public class CreateSnapshotCmdlet : EC2CmdLet
    {
        private string _VolumeId;
        private string _Description;
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
        public string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                this._Description = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonEC2 client = base.GetClient();
            Amazon.EC2.Model.CreateSnapshotRequest request = new Amazon.EC2.Model.CreateSnapshotRequest();
            request.VolumeId = this._VolumeId;
            request.Description = this._Description;
            Amazon.EC2.Model.CreateSnapshotResponse response = client.CreateSnapshot(request);
            base.WriteObject(response.CreateSnapshotResult, true);
        }
    }
}

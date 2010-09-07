namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.CREATE, EC2Nouns.SNAPSHOT)]
    public class CreateSnapshotCmdlet : EC2CmdLet
    {
        [Parameter(Mandatory=false)]
        public string Description { get; set; }
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName=true)]
        [ValidateNotNullOrEmpty]
        public string VolumeId { get; set; }

        protected override void ProcessRecord()
        {
            AmazonEC2 client = GetClient();
            CreateSnapshotRequest request = new CreateSnapshotRequest();
            request.VolumeId = this.VolumeId;
            request.Description = this.Description;

            CreateSnapshotResponse response = client.CreateSnapshot(request);
            WriteObject(response.CreateSnapshotResult.Snapshot);
        }



        private bool IsNullOrEmpty(System.Array array)
        {
            if (null == array)
                return true;
            if (array.Length == 0)
                return true;

            return false;
        }
    }
}

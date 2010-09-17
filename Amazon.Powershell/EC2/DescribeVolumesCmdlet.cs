namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.DESCRIBE, EC2Nouns.VOLUMES)]
    public class DescribeVolumesCmdlet : EC2CmdLet
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
            Amazon.EC2.Model.DescribeVolumesRequest request = new Amazon.EC2.Model.DescribeVolumesRequest();
            if (string.IsNullOrEmpty(this._VolumeId))
            {
                request.VolumeId.Add(this._VolumeId);
            }
            Amazon.EC2.Model.DescribeVolumesResponse response = client.DescribeVolumes(request);
            base.WriteObject(response.DescribeVolumesResult.Volume, true);
        }
    }
}

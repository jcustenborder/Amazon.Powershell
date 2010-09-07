namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.DESCRIBE, EC2Nouns.VOLUMES)]
    public class DescribeVolumesCmdlet : EC2CmdLet
    {
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=true, ValueFromRemainingArguments=true)]
        public string[] VolumeId { get; set; }

        protected override void EndProcessing()
        {
            DescribeVolumesRequest request = new DescribeVolumesRequest();

            if (VolumeId != null && VolumeId.Length > 0)
            {
                request.VolumeId.AddRange(VolumeId);
            }

            AmazonEC2 client = base.GetClient();

            DescribeVolumesResponse response = client.DescribeVolumes(request);
            WriteObject(response.DescribeVolumesResult.Volume, true);
        }
    }
}

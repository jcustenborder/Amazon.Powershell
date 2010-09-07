namespace Amazon.Powershell.SimpleDB
{
    using Amazon.SimpleDB.Model;
    using Amazon.SimpleDB;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.DOMAIN, SimpleDBNouns.METADATA)]
    public class DomainMetadataCmdlet : SimpleDBCmdLet
    {
        private string _DomainName;
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string DomainName
        {
            get
            {
                return this._DomainName;
            }
            set
            {
                this._DomainName = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonSimpleDB client = base.GetClient();
            Amazon.SimpleDB.Model.DomainMetadataRequest request = new Amazon.SimpleDB.Model.DomainMetadataRequest();
            request.DomainName = this._DomainName;
            Amazon.SimpleDB.Model.DomainMetadataResponse response = client.DomainMetadata(request);
            base.WriteObject(response.DomainMetadataResult, true);
        }
    }
}

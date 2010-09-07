namespace Amazon.Powershell.SimpleDB
{
    using Amazon.SimpleDB.Model;
    using Amazon.SimpleDB;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.CREATE, SimpleDBNouns.DOMAIN)]
    public class CreateDomainCmdlet : SimpleDBCmdLet
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
            Amazon.SimpleDB.Model.CreateDomainRequest request = new Amazon.SimpleDB.Model.CreateDomainRequest();
            request.DomainName = this._DomainName;
            Amazon.SimpleDB.Model.CreateDomainResponse response = client.CreateDomain(request);
        }
    }
}

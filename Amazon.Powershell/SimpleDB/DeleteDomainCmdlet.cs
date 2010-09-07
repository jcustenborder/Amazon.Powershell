namespace Amazon.Powershell.SimpleDB
{
    using Amazon.SimpleDB.Model;
    using Amazon.SimpleDB;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.DELETE, SimpleDBNouns.DOMAIN)]
    public class DeleteDomainCmdlet : SimpleDBCmdLet
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
            Amazon.SimpleDB.Model.DeleteDomainRequest request = new Amazon.SimpleDB.Model.DeleteDomainRequest();
            request.DomainName = this._DomainName;
            Amazon.SimpleDB.Model.DeleteDomainResponse response = client.DeleteDomain(request);
        }
    }
}

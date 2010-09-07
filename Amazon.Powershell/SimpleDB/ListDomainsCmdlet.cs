namespace Amazon.Powershell.SimpleDB
{
    using Amazon.SimpleDB.Model;
    using Amazon.SimpleDB;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.LIST, SimpleDBNouns.DOMAINS)]
    public class ListDomainsCmdlet : SimpleDBCmdLet
    {
        private decimal _MaxNumberOfDomains;
        private string _NextToken;
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public decimal MaxNumberOfDomains
        {
            get
            {
                return this._MaxNumberOfDomains;
            }
            set
            {
                this._MaxNumberOfDomains = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string NextToken
        {
            get
            {
                return this._NextToken;
            }
            set
            {
                this._NextToken = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonSimpleDB client = base.GetClient();
            Amazon.SimpleDB.Model.ListDomainsRequest request = new Amazon.SimpleDB.Model.ListDomainsRequest();
            request.MaxNumberOfDomains = this._MaxNumberOfDomains;
            request.NextToken = this._NextToken;
            Amazon.SimpleDB.Model.ListDomainsResponse response = client.ListDomains(request);
            base.WriteObject(response.ListDomainsResult, true);
        }
    }
}

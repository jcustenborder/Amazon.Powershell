namespace Amazon.Powershell.SimpleDB
{
    using Amazon.SimpleDB.Model;
    using Amazon.SimpleDB;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.PUT, SimpleDBNouns.ATTRIBUTES)]
    public class PutAttributesCmdlet : SimpleDBCmdLet
    {
        private string _DomainName;
        private string _ItemName;
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
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string ItemName
        {
            get
            {
                return this._ItemName;
            }
            set
            {
                this._ItemName = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonSimpleDB client = base.GetClient();
            Amazon.SimpleDB.Model.PutAttributesRequest request = new Amazon.SimpleDB.Model.PutAttributesRequest();
            request.DomainName = this._DomainName;
            request.ItemName = this._ItemName;
            Amazon.SimpleDB.Model.PutAttributesResponse response = client.PutAttributes(request);
        }
    }
}

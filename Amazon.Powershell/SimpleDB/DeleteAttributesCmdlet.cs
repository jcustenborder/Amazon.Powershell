namespace Amazon.Powershell.SimpleDB
{
    using Amazon.SimpleDB.Model;
    using Amazon.SimpleDB;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.DELETE, SimpleDBNouns.ATTRIBUTES)]
    public class DeleteAttributesCmdlet : SimpleDBCmdLet
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
            Amazon.SimpleDB.Model.DeleteAttributesRequest request = new Amazon.SimpleDB.Model.DeleteAttributesRequest();
            request.DomainName = this._DomainName;
            request.ItemName = this._ItemName;
            Amazon.SimpleDB.Model.DeleteAttributesResponse response = client.DeleteAttributes(request);
        }
    }
}

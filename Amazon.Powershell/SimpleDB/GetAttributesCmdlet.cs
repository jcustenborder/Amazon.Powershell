namespace Amazon.Powershell.SimpleDB
{
    using Amazon.SimpleDB.Model;
    using Amazon.SimpleDB;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.GET, SimpleDBNouns.ATTRIBUTES)]
    public class GetAttributesCmdlet : SimpleDBCmdLet
    {
        private string _DomainName;
        private string _ItemName;
        private string _AttributeName;
        private bool _ConsistentRead;
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
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string AttributeName
        {
            get
            {
                return this._AttributeName;
            }
            set
            {
                this._AttributeName = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public bool ConsistentRead
        {
            get
            {
                return this._ConsistentRead;
            }
            set
            {
                this._ConsistentRead = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonSimpleDB client = base.GetClient();
            Amazon.SimpleDB.Model.GetAttributesRequest request = new Amazon.SimpleDB.Model.GetAttributesRequest();
            request.DomainName = this._DomainName;
            request.ItemName = this._ItemName;
            if (string.IsNullOrEmpty(this._AttributeName))
            {
                request.AttributeName.Add(this._AttributeName);
            }
            request.ConsistentRead = this._ConsistentRead;
            Amazon.SimpleDB.Model.GetAttributesResponse response = client.GetAttributes(request);
            base.WriteObject(response.GetAttributesResult, true);
        }
    }
}

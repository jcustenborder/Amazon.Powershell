namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.PURCHASE, EC2Nouns.RESERVEDINSTANCESOFFERING)]
    public class PurchaseReservedInstancesOfferingCmdlet : EC2CmdLet
    {
        private string _ReservedInstancesOfferingId;
        private string _InstanceCount;
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string ReservedInstancesOfferingId
        {
            get
            {
                return this._ReservedInstancesOfferingId;
            }
            set
            {
                this._ReservedInstancesOfferingId = value;
            }
        }
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string InstanceCount
        {
            get
            {
                return this._InstanceCount;
            }
            set
            {
                this._InstanceCount = value;
            }
        }
        protected override void ProcessRecord()
        {
            AmazonEC2 client = base.GetClient();
            Amazon.EC2.Model.PurchaseReservedInstancesOfferingRequest request = new Amazon.EC2.Model.PurchaseReservedInstancesOfferingRequest();
            request.ReservedInstancesOfferingId = this._ReservedInstancesOfferingId;
            request.InstanceCount = this._InstanceCount;
            Amazon.EC2.Model.PurchaseReservedInstancesOfferingResponse response = client.PurchaseReservedInstancesOffering(request);
            base.WriteObject(response.PurchaseReservedInstancesOfferingResult, true);
        }
    }
}

namespace Amazon.Powershell.RDS
{
    using Amazon.RDS.Model;
    using Amazon.RDS;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.MODIFY, RDSNouns.DBPARAMETERGROUP)]
    public class ModifyDBParameterGroupCmdlet : RDSCmdLet
    {
        private string _DBParameterGroupName;
        [Parameter(Mandatory=false, ValueFromPipelineByPropertyName=false)]
        public string DBParameterGroupName
        {
            get
            {
                return this._DBParameterGroupName;
            }
            set
            {
                this._DBParameterGroupName = value;
            }
        
        }

        private string _ParameterName;
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false)]
        public string ParameterName
        {
            get { return _ParameterName; }
            set { _ParameterName = value; }
        }
        private string _ParameterValue;
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false)]
        public string ParameterValue
        {
            get { return _ParameterValue; }
            set { _ParameterValue = value; }
        }
        private string _ApplyMethod;
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false)]
        public string ApplyMethod
        {
            get { return _ApplyMethod; }
            set { _ApplyMethod = value; }
        }

        protected override void ProcessRecord()
        {
            AmazonRDS client = base.GetClient();
            Amazon.RDS.Model.ModifyDBParameterGroupRequest request = new Amazon.RDS.Model.ModifyDBParameterGroupRequest();
            request.DBParameterGroupName = this._DBParameterGroupName;

            Parameter parm = new Parameter();
            parm.ParameterName = this.ParameterName;
            parm.ParameterValue = this.ParameterValue;
            parm.ApplyMethod = this.ApplyMethod;
            request.Parameters.Add(parm);


            Amazon.RDS.Model.ModifyDBParameterGroupResponse response = client.ModifyDBParameterGroup(request);
            base.WriteObject(response.ModifyDBParameterGroupResult, true);
        }
    }
}

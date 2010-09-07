namespace Amazon.Powershell.ElasticMapReduce
{
    using Amazon.ElasticMapReduce.Model;
    using Amazon.ElasticMapReduce;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    public abstract class ElasticMapReduceCmdLet : AmazonCmdLet
    {
        protected virtual AmazonElasticMapReduce GetClient()
        {
            throw new System.NotSupportedException();
        }
    }
}

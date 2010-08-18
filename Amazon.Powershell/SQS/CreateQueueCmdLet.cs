using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management.Automation;
using Amazon.SQS;
using Amazon.SQS.Model;
namespace Amazon.Powershell.SQS
{
    [Cmdlet(Verbs.CREATE, SQSNouns.QUEUE)]
    public class CreateQueueCmdLet:SQSCmdLet
    {
        public decimal? DefaultVisibilityTimeout { get; set; }
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory=true)]
        public string QueueName { get; set; }

        protected override void EndProcessing()
        {
            AmazonSQS client = base.GetClient();

            CreateQueueRequest request = new CreateQueueRequest();
            request.QueueName = this.QueueName;
            if (null != this.DefaultVisibilityTimeout)
                request.DefaultVisibilityTimeout = this.DefaultVisibilityTimeout.Value;

            CreateQueueResponse response = client.CreateQueue(request);
            WriteObject(response.CreateQueueResult);
        }
    }
}

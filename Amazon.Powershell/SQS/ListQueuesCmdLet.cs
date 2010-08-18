using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management.Automation;
using Amazon.SQS;
using Amazon.SQS.Model;

namespace Amazon.Powershell.SQS
{
    [Cmdlet(Verbs.LIST, SQSNouns.QUEUE)]
    public class ListQueuesCmdLet:SQSCmdLet
    {
        [Parameter]
        public string QueueNamePrefix { get; set; }

        protected override void EndProcessing()
        {
            AmazonSQS client = GetClient();
            ListQueuesRequest request = new ListQueuesRequest();
            request.QueueNamePrefix = this.QueueNamePrefix;

            ListQueuesResponse response = client.ListQueues(request);

            WriteObject(response.ListQueuesResult.QueueUrl, true);
        }
    }
}

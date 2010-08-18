using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Amazon.SQS;
using Amazon.SQS.Model;
using System.Management.Automation;

namespace Amazon.Powershell.SQS
{
    [Cmdlet(Verbs.DELETE, SQSNouns.QUEUE)]
    public class DeleteQueueCmdLet:SQSCmdLet
    {
        [Parameter(Mandatory=true, ValueFromPipeline=true, ValueFromPipelineByPropertyName=true)]
        public List<string> QueueUrl { get; set; }

        protected override void EndProcessing()
        {
            AmazonSQS client = base.GetClient();

            
            foreach (string queueUrl in this.QueueUrl)
            {
                try
                {
                    DeleteQueueRequest request = new DeleteQueueRequest();
                    request.QueueUrl = queueUrl;

                    DeleteQueueResponse response = client.DeleteQueue(request);
                }
                catch (Exception ex)
                {
                    ErrorRecord record = new ErrorRecord(ex, null, ErrorCategory.InvalidOperation, queueUrl);
                    WriteError(record);
                }
            }
        }

    }
}

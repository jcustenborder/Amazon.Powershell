using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Amazon.SQS;
using Amazon.SQS.Model;
using System.Management.Automation;

namespace Amazon.Powershell.SQS
{
    public class SendMessageCmdLet:SQSCmdLet
    {
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory=true, ValueFromPipeline=true)]
        public string QueueUrl { get; set; }
        [Parameter(ValueFromPipeline=true)]
        public List<string> Messages { get; set; }

        protected override void EndProcessing()
        {
            AmazonSQS client = base.GetClient();

            foreach (string message in this.Messages)
            {
                try
                {
                    SendMessageRequest request = new SendMessageRequest();
                    request.QueueUrl = this.QueueUrl;
                    request.MessageBody = message;

                    SendMessageResponse response = client.SendMessage(request);
                    WriteObject(response.SendMessageResult);
                }
                catch (Exception ex)
                {
                    ErrorRecord record = new ErrorRecord(ex, null, ErrorCategory.InvalidOperation, message);
                    WriteError(record);
                }
            }


            base.EndProcessing();
        }
    }
}

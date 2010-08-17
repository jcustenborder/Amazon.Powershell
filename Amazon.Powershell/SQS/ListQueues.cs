using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management.Automation;
using Amazon.SQS;
using Amazon.SQS.Model;

namespace Amazon.Powershell.SQS
{
    [Cmdlet(Verbs.LIST, "queues")]
    public class ListQueues:SQSCmdLet
    {
        public string QueueNamePrefix { get; set; }

        protected override void BeginProcessing()
        {





            base.BeginProcessing();
        }
    }
}

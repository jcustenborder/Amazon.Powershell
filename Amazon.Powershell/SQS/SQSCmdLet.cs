using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management.Automation;
using Amazon.SQS;
using Amazon.SQS.Model;

namespace Amazon.Powershell.SQS
{
    public abstract class SQSCmdLet:AmazonCmdLet
    {
        protected AmazonSQS GetClient()
        {
            AmazonSQSClient client = null;



            return client;
        }
    }
}

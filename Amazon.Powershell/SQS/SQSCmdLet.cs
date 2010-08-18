using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management.Automation;
using Amazon.SQS;
using Amazon.SQS.Model;
using Amazon.Powershell.Model;

namespace Amazon.Powershell.SQS
{
    public abstract class SQSCmdLet:AmazonCmdLet
    {
        protected AmazonSQS GetClient()
        {
            AmazonCredentials.KeyPair credentials = GetCredentials();
            AmazonSQSClient client = new AmazonSQSClient(credentials.AwsAccessKeyId, credentials.AwsSecretAccessKey);
            return client;
        }
    }
}

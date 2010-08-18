using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management.Automation;
using Amazon.Powershell.Model;

namespace Amazon.Powershell
{
    [Cmdlet(VerbsCommon.Set, "AwsCredentials")]
    public class SetAwsCredentials:Cmdlet
    {
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory=true)]
        public string Name { get; set; }
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true)]        
        public string AwsAccessKeyId { get; set; }
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true)]        
        public string AwsSecretAccessKey { get; set; }
        [Parameter]
        public SwitchParameter Default { get; set; }

        protected override void EndProcessing()
        {
            AmazonCredentials credentials = AmazonCredentials.Load();

            if (null == credentials)
            {
                credentials = new AmazonCredentials();
            }

            AmazonCredentials.KeyPair keyPair = credentials.KeyPairs.FirstOrDefault(p => string.Equals(this.Name, p.Name, StringComparison.OrdinalIgnoreCase));

            if (null == keyPair)
            {
                keyPair = new AmazonCredentials.KeyPair();
                keyPair.Name = this.Name;
                credentials.KeyPairs.Add(keyPair);
            }

            keyPair.AwsAccessKeyId = this.AwsAccessKeyId;
            keyPair.AwsSecretAccessKey = this.AwsSecretAccessKey;

            if (Default)
            {
                credentials.KeyPairs.ForEach(delegate(AmazonCredentials.KeyPair a) { a.Default = false; });
                keyPair.Default = true;
            }
            
            AmazonCredentials.Save(credentials);
        }
    }
}

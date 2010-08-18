using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management.Automation;
using Amazon.Powershell.Model;

namespace Amazon.Powershell
{
    public abstract class AmazonCmdLet:Cmdlet
    {
        [Parameter]
        public string KeyName { get; set; }



        protected AmazonCredentials.KeyPair GetCredentials()
        {
            AmazonCredentials credentials = AmazonCredentials.Load();

            if (null == credentials)
                throw new CredentialNotFoundException(KeyName);




            AmazonCredentials.KeyPair key = null;

            if (!string.IsNullOrEmpty(this.KeyName))
            {
                key = credentials.KeyPairs.FirstOrDefault(p => string.Equals(KeyName, p.Name, StringComparison.OrdinalIgnoreCase));

                if (null == key)
                    throw new CredentialNotFoundException(KeyName);
            }
            else
            {
                key = credentials.KeyPairs.FirstOrDefault(p => p.Default);

                if (null == key)
                    throw new CredentialNotFoundException("[default]");
            }

            return key;
        }

    }

    public class CredentialNotFoundException : Exception
    {
        public CredentialNotFoundException(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }

        public override string Message
        {
            get
            {
                return string.Format("The credentials \"{0}\" were not found.", this.Name);
            }
        }
    }
}

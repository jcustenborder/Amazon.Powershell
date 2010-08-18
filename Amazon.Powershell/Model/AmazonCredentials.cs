using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace Amazon.Powershell.Model
{
    [XmlRoot("AmazonCredentials", Namespace = "http://schemas.amazon.com/Aws/2010/8/AmazonCredentials")]
    public class AmazonCredentials
    {
        public AmazonCredentials()
        {
            this.KeyPairs = new List<KeyPair>();
        }

        [XmlElement("KeyPair")]
        public List<KeyPair> KeyPairs { get; set; }

        private static string CredentialsPath = Environment.ExpandEnvironmentVariables(@"%APPDATA%\Amazon\Powershell\AmazonCredentials.xml");

        public static void Save(AmazonCredentials credentials)
        {
            if (null == credentials) throw new ArgumentNullException("credentials", "credentials cannot be null.");

            string parentFolder = Path.GetDirectoryName(CredentialsPath);

            if (!Directory.Exists(parentFolder))
                Directory.CreateDirectory(parentFolder);

            using (FileStream iostr = new FileStream(CredentialsPath, FileMode.Create, FileAccess.Write))
            {
                Serializer.Serialize(iostr, credentials);
            }

            File.Encrypt(CredentialsPath);
        }

        static XmlSerializer Serializer = new XmlSerializer(typeof(AmazonCredentials));

        public static AmazonCredentials Load()
        {
            if (!File.Exists(CredentialsPath))
                return null;

            using (FileStream iostr = new FileStream(CredentialsPath, FileMode.Open, FileAccess.Read))
            {
                return Serializer.Deserialize(iostr) as AmazonCredentials;
            }
        }


        public class KeyPair
        {
            [XmlAttribute]
            public string Name { get; set; }
            public string AwsAccessKeyId { get; set; }
            public string AwsSecretAccessKey { get; set; }
            public bool Default { get; set; }

        }
    }
}

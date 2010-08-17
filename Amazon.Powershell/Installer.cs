using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Management.Automation;

namespace Amazon.Powershell
{
    [RunInstaller(true)]
    public class PowerShellInstallerClass : PSSnapIn
    {
        public override string Name
        {
            get
            {
                return "Amazon.PowerShell";
            }
        }

        public override string Vendor
        {
            get
            {
                return "Yo Mama";
            }
        }

        public override string Description
        {
            get
            {
                return "Powershell commandlets for Amazon AWS";
            }
        }
    }
}

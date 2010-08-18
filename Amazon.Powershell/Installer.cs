using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Management.Automation;
using System.Collections.ObjectModel;
using System.Management.Automation.Runspaces;

namespace Amazon.Powershell
{
    [RunInstaller(true)]
    public class PowerShellInstallerClass : PSSnapIn
    {
        public override string Name
        {
            get
            {
                return "Amazon.Powershell";
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

using PackageManager.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PackageManager.Core.Contracts;
using PackageManager.Models.Contracts;

namespace PackageManager.Tests.Commands.InstallCommandTests.Fakes
{
    class InstallCommandFake : InstallCommand
    {
        public InstallCommandFake(IInstaller<IPackage> installer, IPackage package) : base(installer, package)
        {
        }

        public IInstaller<IPackage> InstallerFake
        {
            get
            {
                return this.Installer;
            }
        }
        public IPackage PackageFake
        {
            get
            {
                return this.Package;
            }
        }
    }
}

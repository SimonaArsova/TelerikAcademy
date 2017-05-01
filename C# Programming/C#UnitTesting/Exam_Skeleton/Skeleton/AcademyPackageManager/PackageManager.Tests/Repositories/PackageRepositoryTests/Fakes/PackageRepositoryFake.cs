using PackageManager.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PackageManager.Info.Contracts;
using PackageManager.Models.Contracts;

namespace PackageManager.Tests.Repositories.PackageRepositoryTests.Fakes
{
    class PackageRepositoryFake : PackageRepository
    {
        public PackageRepositoryFake(ILogger logger, ICollection<IPackage> packages = null) : base(logger, packages)
        {
        }

        public ICollection<IPackage> PackagesFake
        {
            get
            {
                return this.Packages;
            }
        }

        public ILogger LoggerFake
        {
            get
            {
                return this.Logger;
            }
        }
    }
}

using PackageManager.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PackageManager.Core.Contracts;
using PackageManager.Models.Contracts;

namespace PackageManager.Tests.Core.PackageInstallerTests.Fakes
{
    class PackageInstallerFake : PackageInstaller
    {
        public PackageInstallerFake(IDownloader downloader, IProject project) : base(downloader, project)
        {
        }

        public IDownloader DownloaderFake
        {
            get
            {
                return this.Downloader;
            }
        }

        public IProject ProjectFake
        {
            get
            {
                return this.Project;
            }
        }
    }
}

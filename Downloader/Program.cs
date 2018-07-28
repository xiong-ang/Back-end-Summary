using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Downloader
{
    class Program
    {
        static void Main(string[] args)
        {
            DownloadHelper helper = new DownloadHelper();
            helper.Download("https://gss3.bdstatic.com/7Po3dSag_xI4khGkpoWK1HF6hhy/baike/c0%3Dbaike272%2C5%2C5%2C272%2C90/sign=81ea5e29067b020818c437b303b099b6/472309f7905298229de24f4fdbca7bcb0b46d46d.jpg", "C://testDownload");
        }
    }
}

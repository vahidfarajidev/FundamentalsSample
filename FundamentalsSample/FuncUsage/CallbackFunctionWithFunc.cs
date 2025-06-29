using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsSample.FuncUsage.CallbackFunctionWithFunc
{
    internal class FileDownloader
    {
        public void Download(string fileUrl, Func<int, string> onProgress)
        {

            for (int i=1; i<=10; i++)
            {
                Thread.Sleep(300);
                Console.WriteLine(onProgress(i * 10));
            }

            Console.WriteLine("Download complete!");
        }
    }
}

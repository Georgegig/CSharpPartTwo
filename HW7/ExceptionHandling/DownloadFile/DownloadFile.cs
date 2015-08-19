using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;


namespace DownloadFile
{
    class DownloadFile
    {
        static void Main(string[] args)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile("http://telerikacademy.com/Content/Images/news-img01.png", @"D:\telerik\CSharp 2\Telerik2402\news-img01.png");
        }
    }
}

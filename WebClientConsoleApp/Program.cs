using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WebClientConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Download File
            /*
            WebClient client = new WebClient();
            client.DownloadFile("http://www.dinicevaplar.com/wp-content/uploads/2014/01/cennette-cinsellik-ve-huri-meselesi.jpg", "tree.jpg");
            Console.WriteLine("Файл загружен");
            */

            // Download File in Stream
            /*
            WebClient client = new WebClient();

            using (Stream stream = client.OpenRead("https://www.olx.ua/obyavlenie/ryukzak-sportivnyy-gorodskoy-IDu2IV2.html"))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    string line = "";
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }

            Console.WriteLine("Файл загружен");
            Console.Read();
            */

            /*
            DownloadFileAsync().GetAwaiter();

            Console.WriteLine("Файл загружен");
            Console.ReadKey(true);
            */

            /*
            WebRequest request = WebRequest.Create("https://www.olx.ua/obyavlenie/ryukzak-sportivnyy-gorodskoy-IDu2IV2.html");
            WebResponse response = request.GetResponse();
            using (Stream stream = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    string line = "";
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            response.Close();
            Console.WriteLine("Запрос выполнен");
            Console.ReadKey(true);
            */

            Console.WriteLine(Guid.NewGuid().ToString());

            /*
            DownloadFileAsync2();
            Console.ReadKey(true);
            */
        }

        private static async Task DownloadFileAsync2()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://www.olx.ua/obyavlenie/ryukzak-sportivnyy-gorodskoy-IDu2IV2.html");
            HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync();
            WebHeaderCollection headers = response.Headers;
            for (int i = 0; i < headers.Count; i++)
            {
                Console.WriteLine("{0}: {1}", headers.GetKey(i), headers[i]);
            }
            response.Close();
        }

            private static async Task DownloadFileAsync()
        {
            WebClient client = new WebClient();
            await client.DownloadFileTaskAsync(new Uri("http://www.dinicevaplar.com/wp-content/uploads/2014/01/cennette-cinsellik-ve-huri-meselesi.jpg"), "tree2.jpg");
        }
    }
}

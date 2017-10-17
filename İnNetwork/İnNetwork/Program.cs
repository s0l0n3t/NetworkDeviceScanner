using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;

namespace İnNetwork
{
    class Program
    {
        public static void İpadress(string abc)
        {

            if (abc == "start")
            {
               
                int son_satır = 0;
                string Yerel_baslangıc = "192.168.";
                string Yerel_Devam = "1.";
                Ping _ping = new Ping();
                PingReply _ping_Do;
                
                    for (int delay = 0; delay < 100; delay++)
                    {
                        son_satır++;
                        _ping_Do = _ping.Send(Yerel_baslangıc + Yerel_Devam + son_satır);
                        Console.WriteLine(Yerel_baslangıc + Yerel_Devam + son_satır + ";" + _ping_Do.Status);
                        
                }


                }
            
            else
            {
                Console.WriteLine("Lütfen başlamak için 'start' komutunu kullanın.");
                return;


            }
            
            
        }
        public static void Main(string[] args)
        {
            Console.Clear();
            
            Console.WriteLine("     Note:    " +
                "\n\tağ içerisindeki hostları, ping göndererek tesbit etmeye yarayan araçtır.\n" +
                " \tinput'a start yazarak aracı başlatabilirsiniz.\n");
            Console.Write("> ");
            string IPAnalyst = Console.ReadLine();
            İpadress(IPAnalyst);
            Console.WriteLine("\n Tarama tamamlandı.");
            Console.Read();
        }

       
    }
}

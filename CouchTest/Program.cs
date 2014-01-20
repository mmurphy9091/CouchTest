using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpCouch;
using System.Timers;

namespace CouchTest
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Timer _timer;
            _timer = new Timer(3000);
            _timer.Elapsed += new ElapsedEventHandler(doVitals);
            _timer.Enabled = true;

            while (Console.Read() != 'q') ;
            */ 

            TEST();
        }

        static void doVitals(object sender, ElapsedEventArgs e)
        {
            string server = "http://127.0.0.1:5984";
            string database = "ud_test";
            SharpCouch.DB COUCH = new SharpCouch.DB();

            Random rnd = new Random();
            int hr = rnd.Next(40, 80);
            int bpd = rnd.Next(100, 200);
            int bps = rnd.Next(50, 100);
            int spo2 = rnd.Next(10, 80);
            int etco2 = rnd.Next(10, 80);
            int temp = rnd.Next(95, 105);
            int resp = rnd.Next(0, 30);

            string content = "{" + "HR:" + hr.ToString() +
                                ",BP:" + bpd.ToString() + "/" + bps.ToString() +
                                ",SPO2:" + spo2.ToString() +
                                ",ETCO2:" + etco2.ToString() +
                                ",TEMP:" + temp.ToString() +
                                ",RESP:" + resp.ToString() +
                                "}";

            Console.WriteLine("Creating Document with Conent:\n");
            Console.WriteLine(content);
            Console.WriteLine("\n");
            COUCH.CreateDocument(server, database, content);
            Console.ReadLine();
        }

        static void TEST()
        {
            string server = "http://127.0.0.1:5984";
            string database = "ud_test";
            SharpCouch.DB COUCH = new SharpCouch.DB();

            Random rnd = new Random();
            int hr = rnd.Next(40, 80);
            int bpd = rnd.Next(100, 200);
            int bps = rnd.Next(50, 100);
            int spo2 = rnd.Next(10, 80);
            int etco2 = rnd.Next(10, 80);
            int temp = rnd.Next(95, 105);
            int resp = rnd.Next(0, 30);

            string content = "{" + "\"HR\":\"" + hr.ToString() +
                                "\",\"BP\":\"" + bpd.ToString() + "/" + bps.ToString() +
                                "\",\"SPO2\":\"" + spo2.ToString() +
                                "\",\"ETCO2\":\"" + etco2.ToString() +
                                "\",\"TEMP\":\"" + temp.ToString() +
                                "\",\"RESP\":\"" + resp.ToString() +
                                "\"}";

            Console.WriteLine("Creating Document with Conent:\n");
            Console.WriteLine(content);
            Console.WriteLine("\n");
            COUCH.CreateDocument(server, database, content);
            Console.ReadLine();
        }
    }
}

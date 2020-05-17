using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace JSONParser
{
    class Program
    {
        static void Main(string[] args)
        {
            //do jsonów trzeba pobrac i zainstalować osobną biblioteke, 
            //klikamy PPM w references i Manage NuGet packages - tam 
            //można pobrać też inne biblioteki (np do pobierania danych 
            //z excela)
            WebClient webClient = new WebClient();
            String json = webClient.DownloadString("http://dummy.restapiexample.com/api/v1/employees");
            JObject jsonData = JObject.Parse(json);

            Console.WriteLine(jsonData["status"].ToString());

            foreach (JToken item in jsonData["data"])
            {   //pobieramy dane, ale trzeba je od razu konwertowac na
                //odpowiedni format
                int _id = Convert.ToInt32(item["id"]);
                string name = item["employee_name"].ToString();
                double salary = Convert.ToDouble(item["employee_salary"]);
                int age = Int32.Parse(item["employee_age"].ToString());
                String image = item["profile_image"].ToString();

                Console.WriteLine("{0,5}|{1,40}|{2,10}|{3,5}|{4,40}",
                    _id, name, salary, age, image);
            }



            Console.ReadKey();

        }
    }
}

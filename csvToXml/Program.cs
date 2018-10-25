using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using csvToXml.demo_csvToXml;

namespace csvToXml
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string csvString = @"GREAL,Great Lakes Food Market,Howard Snyder,Marketing Manager,(503) 555-7555,2732 Baker Blvd.,Eugene,OR,97403,USA  
HUNGC,Hungry Coyote Import Store,Yoshi Latimer,Sales Representative,(503) 555-6874,City Center Plaza 516 Main St.,Elgin,OR,97827,USA  
LAZYK,Lazy K Kountry Store,John Steel,Marketing Manager,(509) 555-7969,12 Orchestra Terrace,Walla Walla,WA,99362,USA  
LETSS,Let's Stop N Shop,Jaime Yorres,Owner,(415) 555-5938,87 Polk St. Suite 5,San Francisco,CA,94117,USA";
            File.WriteAllText("cust.csv", csvString);
            string[] source = File.ReadAllLines("cust.csv");
            XElement cust = new XElement("Root",
                from str in source
                let fields = str.Split(',')
                select new XElement("Customer",
                new XAttribute("CustomerID", fields[0]),
                new XElement("CompanyName", fields[1]),
                new XElement("ContactName", fields[2]),
                new XElement("ContactTitle", fields[3]),
                new XElement("Phone", fields[4]),
                new XElement("FullAdress",
                new XElement("Address", fields[5]),
                new XElement("City", fields[6]),
                new XElement("Region", fields[7]),
                new XElement("PostalCode", fields[8]),
                new XElement("Country", fields[9])
                )
                ));
                */

            theInternetDemo theInternetDemo = new theInternetDemo();
            //XElement cust = theInternetDemo.returnXelement();
            //Console.WriteLine(cust);
            string csv = theInternetDemo.csv();
            Console.WriteLine(csv);
            Console.ReadKey();
        }
    }
}

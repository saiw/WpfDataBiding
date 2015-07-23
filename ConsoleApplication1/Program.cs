/*TO DO  
 * 1. delegate timer to count every excute time 
 * 2. check connection re-connect or not (eq :excute three instance at same time, how about the connection count ) 
 * 3. compare the other way to populate data fo ViewModel 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("start to test the EF of code first");
            TestCustemerQuery();
            Console.WriteLine("test is done , press any key to exit");           
            Console.ReadKey();
        }
        static void TestCustemerQuery()
        {
            var db = new Model.NorthWind();
            var customersList = (from c in db.Customers
                                         orderby c.CustomerID ascending
                                         select c).Take(10);
            if (customersList.Count() == 0)
            {
                Console.WriteLine("can not query anything");
                return;
            }

            foreach(var cus in customersList )
            {
                Console.WriteLine("{0}:{1}  ,{2}:{3}" ,"[ID]" ,cus.CustomerID,
                                                                        "[ContactName]" ,cus.ContactName);


            }
        }
    }
}

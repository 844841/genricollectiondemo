using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genricollectiondemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // GenricListDemo();
            // GenrichasSetDemo();
            //SortedDictionaryDemo();
            //Queue<course> qcrs = new Queue<course>();


            Dictionary<int, course> dct = new Dictionary<int, course>();

            dct.Add(1, new course
            {
                Cname = "robo",
                Cid = 890,
                StartDate = Convert.ToDateTime("07-12-2020"),
                Fees = 1500
            });
            dct.Add(1, new course
            {
                Cname = "robo2",
                Cid = 890,
                StartDate = Convert.ToDateTime("17-12-2020"),
                Fees = 1500
            });

            foreach (KeyValuePair<int, course> dc in dct)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}",
                    dc.Key, dc.Value.Cid, dc.Value.Cname,
                    dc.Value.StartDate.ToShortDateString(), dc.Value.Fees);
            }











            Stack<course> stcr = new Stack<course>();

            stcr.Push(new course
            {
                Cname = "physics",
                Cid = 890,
                StartDate = Convert.ToDateTime("03-02-2020"),
                Fees = 3500
            });


            stcr.Push(new course
            {

                Cname = "chemistry",
                Cid = 850,
                StartDate = Convert.ToDateTime("03-02-2020"),
                Fees = 3500
            });

            stcr.Push(new course
            {

                Cname = "maths",
                Cid = 990,
                StartDate = Convert.ToDateTime("04-02-2020"),
                Fees = 3400
            });
            stcr.Pop();

            foreach (course cr in stcr)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", cr.Cid, cr.Cname, cr.StartDate.ToString("dd-mm-yyyy"), cr.Fees);
            }
        }

        private static void SortedDictionaryDemo()
        {
            SortedDictionary<int, string> sortDt = new SortedDictionary<int, string>();
            sortDt.Add(123, "chennai");
            sortDt.Add(231, "hyderabad");
            sortDt.Add(111, "bangalore");
            foreach (KeyValuePair<int, string> ct in sortDt)
            {
                Console.WriteLine("{0}\t{1}", ct.Key, ct.Value);
            }
        }

       
    }

    /*   private static void GenrichasSetDemo()
       {
           HashSet<course> hset = new HashSet<course>();

           hset.Add(new course
           {
               Cname = "python",
               Cid = 890,
               StartDate = Convert.ToDateTime("03-02-2020"),
               Fees = 3500
           });


           hset.Add(new course
           {

               Cname = "bootstrap",
               Cid = 850,
               StartDate = Convert.ToDateTime("03-02-2020"),
               Fees = 3500
           });

           hset.Add(new course
           {

               Cname = "javascript",
               Cid = 990,
               StartDate = Convert.ToDateTime("04-02-2020"),
               Fees = 3400
           });

           foreach (course cr in hset)
           {
               Console.WriteLine("{0}\t{1}\t{2}\t{3}", cr.Cid, cr.Cname, cr.StartDate.ToString("dd-mm-yyyy"), cr.Fees);
           }
       }
       */

    /*   private static void GenricListDemo()
       {
           List<course> courselist = new List<course>();
           courselist.Add(new course
           {
               Cid = 1,
               Cname = "c#",
               StartDate = DateTime.Today,
               Fees = 6000
           });
           courselist.Add(new course
           {
               Cid = 2,
               Cname = "web apps",
               StartDate = DateTime.Parse("05-02-2020"),
               Fees = 8000

           });

           courselist.Add(
           new course
           {
               Cid = 3,
               Cname = "python",
               StartDate = Convert.ToDateTime("08-05-2020"),
               Fees = 5000
           });

           foreach (course cr in courselist)
           {
               Console.WriteLine("{0}\t{1}\t{2}\t{3}", cr.Cid, cr.Cname, cr.StartDate, cr.Fees);
           } */
}
   

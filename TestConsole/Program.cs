using DbProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("test");

            TaskManDBEntities1 testconn = new TaskManDBEntities1();

            List<Project> projlist = new List<Project>(testconn.Projects);

            Project Currentproj = projlist.FirstOrDefault();

            Console.WriteLine(Currentproj.Name);


            Console.ReadKey();
        }
    }
}

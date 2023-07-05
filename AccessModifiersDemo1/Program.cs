using DemoLibrary;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiersDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            person.SavePerson();

            Console.ReadLine();
        }
    }
}

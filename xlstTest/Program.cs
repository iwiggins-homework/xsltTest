using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Xsl;

namespace xlstTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Loading Transform 0");
            XslCompiledTransform transform0 = new XslCompiledTransform();
            transform0.Load("variant0Transform.xslt");
            Console.WriteLine("Transforming 0");
            transform0.Transform("variant0.xml","out0.xml");
            Console.WriteLine("0 Done");

            Console.WriteLine("Loading Transform 1");
            XslCompiledTransform transform1 = new XslCompiledTransform();
            transform1.Load("variant1Transform.xslt");
            Console.WriteLine("Transforming 1");
            transform1.Transform("variant1.xml","out1.xml");
            Console.WriteLine("1 Done");

            Console.ReadKey();
        }
    }
}

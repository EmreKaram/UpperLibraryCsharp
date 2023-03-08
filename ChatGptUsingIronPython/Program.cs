using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronPython.Hosting;

namespace ChatGptUsingIronPython
{
    public class Program
    {
        static int Main()
        {
            var source = @"C:\Users\Emre\Desktop\Code\Python\ChatGpt.py";

            var engine = Python.CreateEngine();
            var scope =  engine.CreateScope();
            var operations = engine.Operations;

            engine.ExecuteFile(source, scope);

            var ChatGpt = scope.GetVariable("ChatGpt");
            dynamic ins = operations.CreateInstance(ChatGpt);

            Console.WriteLine(ins.Chat());

            Console.ReadLine();

            //Beceremedim key önemli saklamak lazım !

            return 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestSS
{
    public class TestLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }

    public interface ILogger
    {
        void Log(string message);
    }
}

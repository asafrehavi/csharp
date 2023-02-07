using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        private static log4net.ILog Log = log4net.LogManager.GetLogger(typeof(Program));
        static void Main(string[] args)
        {
            Log.Info("Main method execution started");
            try
            {
                Log.Info("Hello World!");
                Log.Info("try block executed");
            }
            catch (Exception ex)
            {
                Log.Error(ex);
            }
            finally
            {
                Log.Info("Finally block executed");
            }
            Log.Info("Test method execution completed");
            Log.Error("Test method execution completed");
            //https://www.kailashsblogs.com/2020/07/how-to-use-log4net-in-c-console.html
        }
    }
    
}

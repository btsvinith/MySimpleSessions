using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Concepts.General
{
    public class TryCatchFinallyEx
    {
        public void Exec()
        {
            ScenarioOne();
        }

        private void ScenarioOne()
        {
            Console.WriteLine($"Start of the Method ScenarioOne");
            WebClient wc = null;
            try
            {
                //string url = "http://google.com";
                //url = "";
                //wc = new WebClient(); //downloading a web page
                //var resultData = wc.DownloadString(url);
                FirstLogic();
                SecondLogic();
                ThirdLogic();
                FourthLogic();
            }
            //catch (ArgumentNullException ex)
            //{
            //    Console.WriteLine($"ArgumentNullException {ex.Message}");
            //    //code specifically for a ArgumentNullException
            //}
            //catch (WebException ex)
            //{
            //    Console.WriteLine($"WebException {ex.Message}");
            //    //code specifically for a WebException
            //}
            //General Exception
            catch (Exception ex)
            {
                Console.WriteLine($"Exception {ex.Message}");
                //code for any other type of exception
            }
            //finally
            //{
            //    //call this if exception occurs or not
            //    //in this example, dispose the WebClient
            //    wc?.Dispose();
            //}

            Console.WriteLine($"End of the Method ScenarioOne");
        }

        private void ThirdLogic()
        {
            Console.WriteLine($"Start of the Method ThirdLogic");
            try
            {
                int a = 4;
                int b = -1;
                var c = Divide(a, b);
                Console.WriteLine($"ThirdLogic result --> {c}");
            }
            // handled exception
            catch (ArgumentException ex)
            {
                Console.WriteLine($"ThirdLogic ArgumentException {ex.Message}");
            }
            // handled exception
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"ThirdLogic DivideByZeroException {ex.Message}");
            }
            //General Exception or un handled exception.
            catch (Exception ex)
            {
                Console.WriteLine($"ThirdLogic General Exception {ex.Message}");
                // Full trace is available in StackTrace
                //throw;
                // Only exception details, we will have in StackTrace. Not the full details of each and every method's flow path.
                throw ex;
            }
            finally
            {
                Console.WriteLine($"End of the Method ThirdLogic Finally");
            }
            Console.WriteLine($"End of the Method ThirdLogic");
        }
        private int Divide(int a, int b)
        {
            //throw the specific error {DivideByZeroException}
            if (b == 0)
            {
                throw new DivideByZeroException($"{b} shouldnot be 0");
            }
            if (a < 0 || b < 0)
            {
                throw new ArgumentException($"Either a: {a} nor b:{b} shouldnot be 0");
            }
            var c = a / b;
            return c;
        }

        private void FourthLogic()
        {
            Console.WriteLine($"Start of the Method FourthLogic");
            throw new NotImplementedException("ThirdLogic --> Still logic not confirmed..");
            Console.WriteLine($"End of the Method FourthLogic");
        }

        private void SecondLogic()
        {
            Console.WriteLine($"Start of the Method SecondLogic");
            try
            {
                int a = 4;
                int b = 2;
                var c = Divide(a, b);
                Console.WriteLine($"SecondLogic result --> {c}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"SecondLogic Exception {ex.Message}");
                //code for any other type of exception

            }
            Console.WriteLine($"End of the Method SecondLogic");
        }
        private void FirstLogic()
        {
            Console.WriteLine($"Start of the Method FirstLogic");
            int a = 5;
            int b = 10;
            var c = b / a;
            Console.WriteLine($"FirstLogic result --> {c}");
            Console.WriteLine($"End of the Method FirstLogic");
        }
    }
}

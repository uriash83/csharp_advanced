using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseAdv.Exceptions
{
    internal partial class ProgramExceprion
    {
        public static void ProgramExceprionVoid()
        {
            var calculator = new Calculator();
            
            try
            {
                //calculator.Divide(5, 0);

                //using(var streamReader = new StreamReader(@"c:\file.zip"))// using w domysle tworzy block finnaly a w nim stramreader.dispose()
                //{
                //    var content = streamReader.ReadToEnd();
                //}

                var yt = new YouTubeApi();
                var yts = yt.GetVideos("martin");
                
            }
            catch (DivideByZeroException ex )
            {
                Console.WriteLine("divided by xero");
            }
            catch (ArithmeticException ex)
            {

            }
            catch (System.Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                //streamReader.Dispose();// zamykanie sesji
            }
            
        }
    }
}

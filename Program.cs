using System;
using System.IO; 
using System.Drawing;
using System.Drawing.Printing;
using QRCoder; 
using thom371d;

     
// Read Console input stream: https://stackoverflow.com/questions/50279001/how-to-read-console-input-until-space-or-enter-in-c-sharp

namespace thom371d
{
    class Program
    {

        static void Main(string[] args)
        {
        
            simpleFunctions myFactory = new simpleFunctions(); 
            

            using (var sr = new StreamReader(Console.OpenStandardInput(), Console.InputEncoding)) // Opens streamreader, takes input in terminal 
            {
                var input = sr.ReadToEnd();

                var tokens = input.Replace(Environment.NewLine, " ").Split(" ");

                foreach (var t in tokens)
                {
                    Console.WriteLine($"Token: \"{t}\"");
                }

                // var terminalInput = Console.Read();
                var finalQR = myFactory.createDynamicQRCode(input);
                
                Bitmap qrCodeImage = finalQR.GetGraphic(20);
                
            }
        }
    }
}



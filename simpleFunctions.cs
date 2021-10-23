using System;
using System.Drawing;
using System.Drawing.Printing;



// https://www.youtube.com/watch?v=VvFghudrbAg


namespace thom371d 
{
    public class simpleFunctions
    {
        Image bmIm;

        internal QRCoder.QRCode createDynamicQRCode(string text) 
        {
            QRCoder.QRCodeGenerator qrFactory = new QRCoder.QRCodeGenerator();
            var inputText = qrFactory.CreateQrCode(text, QRCoder.QRCodeGenerator.ECCLevel.H);
            var outputQr =  new QRCoder.QRCode(inputText);


            return outputQr; 
        }    

        internal void PrintImage(Image img)
        {
            bmIm = img;
            PrintDocument pd = new PrintDocument();
            pd.OriginAtMargins = true;
            pd.DefaultPageSettings.Landscape = true;
            pd.Print();
        }
        
        internal void pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            double cmToUnits = 100 / 2.54;
            e.Graphics.DrawImage(bmIm, 0, 0,(float)(27 * cmToUnits),(float)(27 * cmToUnits));
        }
    }
}
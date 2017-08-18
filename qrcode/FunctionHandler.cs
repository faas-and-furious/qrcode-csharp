using System;
using System.IO;
using QRCoder;

namespace Function
{
    public class FunctionHandler
    {
        public void Handle(string input)
        {
            var qrGenerator = new QRCodeGenerator();
            var qrCodeData = qrGenerator.CreateQrCode(input, QRCodeGenerator.ECCLevel.Q);
            var qrCode = new BitmapByteQRCode(qrCodeData);
            var qrCodeAsBitmapByteArray = qrCode.GetGraphic(20);

            using (Stream outStream = Console.OpenStandardOutput())
            {
                outStream.Write(qrCodeAsBitmapByteArray, 0, qrCodeAsBitmapByteArray.Length);
            }
        }
    }
}

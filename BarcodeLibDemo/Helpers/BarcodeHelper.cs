using BarcodeLib;
using System.Drawing;

namespace gotoconfig.BarcodeLibDemo.Helpers
{
    public sealed class BarcodeHelper
    {
        public byte[] Generate(string barcodeString, int width, int height, bool includeLabel)
        {
            Barcode barcode = new Barcode();
            barcode.Alignment = AlignmentPositions.CENTER;
            barcode.IncludeLabel = includeLabel;
            barcode.RotateFlipType = RotateFlipType.Rotate180FlipXY;
            barcode.LabelPosition = LabelPositions.BOTTOMCENTER;

            TYPE type = TYPE.CODE128;
            ImageConverter imageConverter = new ImageConverter();
            byte[] imageData = (byte[])imageConverter.ConvertTo(barcode.Encode(type, barcodeString.Trim(), Color.Black, Color.White, width, height), typeof(byte[]));
            return imageData;
        }
    }
}
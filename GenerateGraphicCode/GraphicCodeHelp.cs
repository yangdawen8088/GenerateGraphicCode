using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThoughtWorks.QRCode.Codec;

namespace GenerateGraphicCode
{
    class GraphicCodeHelp
    {
        public static Bitmap CreateImgQRCode(
            string codeStr,
            string errorCorrect,
            int versionNum,
            string encodeMode,
            int scale,
            Color backgroundColor,
            Color foregroundColor)
        {
            try
            {
                // 二维码图像存储
                Bitmap bitmap;
                // 创建一个二维码编码器
                QRCodeEncoder qRCodeEncoder = new QRCodeEncoder();
                // 设置二维码纠错等级
                switch (errorCorrect)
                {
                    case "L":
                        qRCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.L;
                        break;
                    case "M":
                        qRCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M;
                        break;
                    case "Q":
                        qRCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.Q;
                        break;
                    case "H":
                        qRCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.H;
                        break;
                }
                // 设置二维码版本
                qRCodeEncoder.QRCodeVersion = versionNum;
                // 设置二维码编码模式
                switch (encodeMode)
                {
                    case "ALPHA_NUMERIC":
                        qRCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.ALPHA_NUMERIC;
                        break;
                    case "NUMERIC":
                        qRCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.NUMERIC;
                        break;
                    case "BYTE":
                        qRCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
                        break;
                }
                // 设置清晰度
                qRCodeEncoder.QRCodeScale = scale;
                // 设置二维码背景颜色
                qRCodeEncoder.QRCodeBackgroundColor = backgroundColor;
                // 设置二维码前景色
                qRCodeEncoder.QRCodeForegroundColor = foregroundColor;
                // 获取二维码图片
                bitmap = qRCodeEncoder.Encode(codeStr);
                return bitmap;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static string CreateImageFromBytes(string fileName, byte[] buffer)
        {
            string file = fileName;
            MemoryStream ms = new MemoryStream(buffer);
            Image image = System.Drawing.Image.FromStream(ms);
            ImageFormat format = image.RawFormat;
            if (format.Equals(ImageFormat.Jpeg))
            {
                file += ".jpeg";
            }
            else if (format.Equals(ImageFormat.Png))
            {
                file += ".png";
            }
            else if (format.Equals(ImageFormat.Bmp))
            {
                file += ".bmp";
            }
            else if (format.Equals(ImageFormat.Gif))
            {
                file += ".gif";
            }
            else if (format.Equals(ImageFormat.Icon))
            {
                file += ".icon";
            }
            System.IO.FileInfo info = new System.IO.FileInfo(file);
            System.IO.Directory.CreateDirectory(info.Directory.FullName);
            try
            {
                File.WriteAllBytes(file, buffer);
                return file;
            }
            catch (Exception)
            {
                return "false";
            }
        }
    }
}

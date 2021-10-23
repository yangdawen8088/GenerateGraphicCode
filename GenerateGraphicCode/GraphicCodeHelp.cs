using BarcodeLib;
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
        /// <summary>
        /// 生成二维码
        /// </summary>
        /// <param name="codeStr">生成二维码所需要的字符串</param>
        /// <param name="errorCorrect">纠错等级</param>
        /// <param name="versionNum">版本号</param>
        /// <param name="encodeMode">编码模式</param>
        /// <param name="scale">二维码清晰度</param>
        /// <param name="backgroundColor">背景色</param>
        /// <param name="foregroundColor">前景色</param>
        /// <returns></returns>
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
                qRCodeEncoder.QRCodeErrorCorrect = (QRCodeEncoder.ERROR_CORRECTION)Enum.Parse(
                    typeof(QRCodeEncoder.ERROR_CORRECTION), 
                    errorCorrect);
                // 设置二维码版本
                qRCodeEncoder.QRCodeVersion = versionNum;
                // 设置二维码编码模式
                qRCodeEncoder.QRCodeEncodeMode = (QRCodeEncoder.ENCODE_MODE)Enum.Parse(
                    typeof(QRCodeEncoder.ENCODE_MODE), 
                    encodeMode);
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
        public static Image CreateImgBarCode(
            string codeStr,
            Color backgroundColor,
            Color foregroundColor,
            string labelPosition,
            int width,
            int height,
            bool includeLabel)
        {
            Barcode barcode = new Barcode();
            // 前景色
            barcode.ForeColor = foregroundColor;
            // 背景色
            barcode.BackColor = backgroundColor;
            // 标签字体
            barcode.LabelFont = new Font("宋体", 20f);
            // 标签位置
            barcode.LabelPosition = (LabelPositions)Enum.Parse(
                   typeof(LabelPositions),
                   labelPosition);
            // 宽度、高度
            barcode.Width = width;
            barcode.Height = height;
            // 是否包含标签
            barcode.IncludeLabel = includeLabel;
            // 编码类型
            barcode.EncodedType = TYPE.CODE128;
            // 靠齐方式
            barcode.Alignment = AlignmentPositions.CENTER;
            //barcode.BarWidth = 760;
            try
            {
                return barcode.Encode(TYPE.CODE128, codeStr);//条形码的类型
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 给图片添加边框
        /// </summary>
        /// <param name="bmp">Bitmap 图片数据</param>
        /// <param name="Margin">外边框距离</param>
        /// <param name="color">边框颜色</param>
        /// <returns></returns>
        public static Bitmap ImageAddFrame(Bitmap bmp, int Margin, Color color)
        {
            //位图宽高
            int width = bmp.Width + Margin;
            int height = bmp.Height + Margin;
            Bitmap BitmapResult = new Bitmap(width, height);
            Graphics Grp = Graphics.FromImage(BitmapResult);
            SolidBrush b = new SolidBrush(color);//这里修改颜色
            Grp.FillRectangle(b, 0, 0, width, height);
            Rectangle Rec = new Rectangle(0, 0, bmp.Width, bmp.Height);
            //向矩形框内填充Img
            Grp.DrawImage(bmp, Margin / 2, Margin / 2, Rec, GraphicsUnit.Pixel);
            //返回位图文件
            Grp.Dispose();
            GC.Collect();
            return BitmapResult;
        }
    }
}

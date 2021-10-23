using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenerateGraphicCode
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
            Initialization();
        }

        private void Initialization()
        {
            comboBox_errorCorrect.SelectedIndex = 0;
            comboBox_encodeMode.SelectedIndex = 0;
            comboBox_encodeMode.SelectedIndex = 2;
            comboBox_errorCorrect.SelectedIndex = 0;
            comboBox_LocationLabel.SelectedIndex = 4;
            richTextBox_Centent.Text = "    生成二维码/条形码工具是一个开源的Windows桌面端程序，能够根据自定义的内容和样式生成二维码或条形码，通过手机或者扫码工具可扫描解码出其中的内容。" +
                "\n    软件开源，免费使用。这里特别声明，该软件仅用于学习和个人研究使用，不得用作任何商业及非法用途，造成一切后果自负，并将追究其法律责任。" +
                "\n    作者留言：感谢各位用户的支持和使用，技术交流，软件定制（Windows桌面软件、手机 APP、网站系统内、VR 全景、C / S、B / S等）可通过以下方式联系和咨询。" +
                "\n\t微信公众号：易学长（YMGYM_1024）" +
                "\n\t微信号：YMGYM_Yxz" +
                "\n\tQQ：1686581509" +
                "\n\t电子邮箱：1352559801@qq.com" +
                "\n    添加微信和QQ请记得告明来意哦！";
            GenerateQRCode();
            GenerateBRCode();
        }

        private void button_SelectColF_Click(object sender, EventArgs e)
        {
            SelectColor(panel_QRforegroundColor);
        }

        private void button_SelectColB_Click(object sender, EventArgs e)
        {
            SelectColor(panel_QRbackgroundColor);
        }

        private void panel_foregroundColor_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            SelectColor(panel_QRforegroundColor);
        }

        private void panel_backgroundColor_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            SelectColor(panel_QRbackgroundColor);
        }

        private void SelectColor(Panel panel)
        {
            DialogResult dialogResult = colorDialog_Color.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                panel.BackColor = colorDialog_Color.Color;
            }
        }

        private void button_generate_Click(object sender, EventArgs e)
        {
            GenerateQRCode();
        }

        private void GenerateQRCode()
        {
            string codeStr = textBox_QRValue.Text;
            if (string.IsNullOrWhiteSpace(codeStr))
            {
                MessageBox.Show("生成二维码的源文本不能为空白字符。", "系统提示");
                return;
            }
            try
            {
                Bitmap bitmap = GraphicCodeHelp.CreateImgQRCode(codeStr,
                    comboBox_errorCorrect.Text,
                    Convert.ToInt32(numericUpDown_Version.Value),
                    comboBox_encodeMode.Text,
                    Convert.ToInt32(numericUpDown_scale.Value),
                    panel_QRbackgroundColor.BackColor,
                    panel_QRforegroundColor.BackColor);
                if (radioButton_Yes.Checked)
                {
                    bitmap = GraphicCodeHelp.ImageAddFrame(bitmap, 20, panel_QRbackgroundColor.BackColor);
                }
                pictureBox_QRGraphicCode.BackgroundImage = bitmap;
            }
            catch (Exception ex)
            {
                Bitmap bitmap = GraphicCodeHelp.CreateImgQRCode(
                    "你以为生成二维码成功了吗？——其实没有！",
                    "L",
                    0,
                    "BYTE",
                    10,
                    panel_QRbackgroundColor.BackColor,
                    panel_QRforegroundColor.BackColor);
                if (radioButton_Yes.Checked)
                {
                    bitmap = GraphicCodeHelp.ImageAddFrame(bitmap, 20, panel_QRbackgroundColor.BackColor);
                }
                pictureBox_QRGraphicCode.BackgroundImage = bitmap;
                MessageBox.Show(ex.Message, "系统提示");
            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = saveFileDialog_Save.ShowDialog();
                string fileName = saveFileDialog_Save.FileName;
                if (dr == DialogResult.OK && !string.IsNullOrEmpty(fileName))
                {
                    string fileNameEx = fileName.Split('.')[fileName.Split('.').Length - 1];
                    System.Drawing.Imaging.ImageFormat imageFormat;
                    if (fileNameEx.Equals("png") || fileNameEx.Equals("Png"))
                    {
                        imageFormat = System.Drawing.Imaging.ImageFormat.Png;
                    }
                    else
                    {
                        imageFormat = System.Drawing.Imaging.ImageFormat.Jpeg;
                    }
                    pictureBox_QRGraphicCode.BackgroundImage.Save(fileName, imageFormat);
                    MessageBox.Show("图片保存成功！", "系统提示");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("图片保存失败：\n" + ex, "系统提示");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GenerateBRCode();
        }

        private void GenerateBRCode()
        {
            string codeStr = textBox_BRValue.Text;
            if (string.IsNullOrWhiteSpace(codeStr))
            {
                MessageBox.Show("生成条形码的源文本不能为空白字符。", "系统提示");
                return;
            }
            try
            {
                string labelPosition = "";
                switch (comboBox_LocationLabel.Text)
                {
                    case "左上方": labelPosition = "TOPLEFT"; break;
                    case "上方居中": labelPosition = "TOPCENTER"; break;
                    case "右上方": labelPosition = "TOPRIGHT"; break;
                    case "左下方": labelPosition = "BOTTOMLEFT"; break;
                    case "下方居中": labelPosition = "BOTTOMCENTER"; break;
                    case "右下方": labelPosition = "BOTTOMRIGHT"; break;
                }
                Image image = GraphicCodeHelp.CreateImgBarCode(
                    codeStr,
                    panel_BRbackgroundColor.BackColor,
                    panel_BRforegroundColor.BackColor,
                    labelPosition,
                    Convert.ToInt32(pictureBox_BRGraphicCode.Width),
                    Convert.ToInt32(pictureBox_BRGraphicCode.Height),
                    radioButton_ShowLabel.Checked);
                if (radioButton_ShowB.Checked)
                {
                    image = GraphicCodeHelp.ImageAddFrame(new Bitmap(image), 20, panel_BRbackgroundColor.BackColor);
                }
                pictureBox_BRGraphicCode.BackgroundImage = image;
            }
            catch (Exception ex)
            {
                MessageBox.Show("条形码生成失败：\n" + ex, "系统提示");
            }
        }

        private void button_BRSelectColF_Click(object sender, EventArgs e)
        {
            SelectColor(panel_BRforegroundColor);
        }

        private void button_BRSelectColB_Click(object sender, EventArgs e)
        {
            SelectColor(panel_BRbackgroundColor);
        }

        private void panel_BRforegroundColor_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            SelectColor(panel_BRforegroundColor);
        }

        private void panel_BRbackgroundColor_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            SelectColor(panel_BRbackgroundColor);
        }

        private void button_BRSave_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = saveFileDialog_Save.ShowDialog();
                string fileName = saveFileDialog_Save.FileName;
                if (dr == DialogResult.OK && !string.IsNullOrEmpty(fileName))
                {
                    string fileNameEx = fileName.Split('.')[fileName.Split('.').Length - 1];
                    System.Drawing.Imaging.ImageFormat imageFormat;
                    if (fileNameEx.Equals("png") || fileNameEx.Equals("Png"))
                    {
                        imageFormat = System.Drawing.Imaging.ImageFormat.Png;
                    }
                    else
                    {
                        imageFormat = System.Drawing.Imaging.ImageFormat.Jpeg;
                    }
                    pictureBox_BRGraphicCode.BackgroundImage.Save(fileName, imageFormat);
                    MessageBox.Show("图片保存成功！", "系统提示");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("图片保存失败：\n" + ex, "系统提示");
            }
        }
    }
}

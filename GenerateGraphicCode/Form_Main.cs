using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            GenerateQRCode();
        }

        private void button_SelectColF_Click(object sender, EventArgs e)
        {
            SelectColor(panel_foregroundColor);
        }

        private void button_SelectColB_Click(object sender, EventArgs e)
        {
            SelectColor(panel_backgroundColor);
        }

        private void panel_foregroundColor_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            SelectColor(panel_foregroundColor);
        }

        private void panel_backgroundColor_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            SelectColor(panel_backgroundColor);
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
            string codeStr = textBox_Value.Text;
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
                    panel_backgroundColor.BackColor,
                    panel_foregroundColor.BackColor);
                pictureBox_GraphicCode.BackgroundImage = bitmap;
            }
            catch (Exception ex)
            {
                Bitmap bitmap = GraphicCodeHelp.CreateImgQRCode(
                    "你以为生成二维码成功了吗？——其实没有！",
                    "M",
                    0,
                    "BYTE",
                    100,
                    panel_backgroundColor.BackColor,
                    panel_foregroundColor.BackColor);
                pictureBox_GraphicCode.BackgroundImage = bitmap;
                MessageBox.Show(ex.Message, "系统提示");
            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            Image image = pictureBox_GraphicCode.BackgroundImage;
        }
    }
}

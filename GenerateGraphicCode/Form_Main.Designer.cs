
namespace GenerateGraphicCode
{
    partial class Form_Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.radioButton_No = new System.Windows.Forms.RadioButton();
            this.radioButton_Yes = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_QRValue = new System.Windows.Forms.TextBox();
            this.numericUpDown_scale = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Version = new System.Windows.Forms.NumericUpDown();
            this.button_QRSelectColB = new System.Windows.Forms.Button();
            this.panel_QRbackgroundColor = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.button_QRSelectColF = new System.Windows.Forms.Button();
            this.panel_QRforegroundColor = new System.Windows.Forms.Panel();
            this.button_QRSave = new System.Windows.Forms.Button();
            this.comboBox_encodeMode = new System.Windows.Forms.ComboBox();
            this.button_QRgenerate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_errorCorrect = new System.Windows.Forms.ComboBox();
            this.pictureBox_QRGraphicCode = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton_ShowLabel = new System.Windows.Forms.RadioButton();
            this.label16 = new System.Windows.Forms.Label();
            this.button_BRSave = new System.Windows.Forms.Button();
            this.button_BRgenerate = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton_ShowB = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.button_BRSelectColB = new System.Windows.Forms.Button();
            this.panel_BRbackgroundColor = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.button_BRSelectColF = new System.Windows.Forms.Button();
            this.panel_BRforegroundColor = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBox_LocationLabel = new System.Windows.Forms.ComboBox();
            this.textBox_BRValue = new System.Windows.Forms.TextBox();
            this.pictureBox_BRGraphicCode = new System.Windows.Forms.PictureBox();
            this.colorDialog_Color = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog_Save = new System.Windows.Forms.SaveFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.richTextBox_Centent = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_scale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Version)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_QRGraphicCode)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_BRGraphicCode)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.ItemSize = new System.Drawing.Size(58, 28);
            this.tabControl1.Location = new System.Drawing.Point(2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(780, 415);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.radioButton_No);
            this.tabPage1.Controls.Add(this.radioButton_Yes);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.textBox_QRValue);
            this.tabPage1.Controls.Add(this.numericUpDown_scale);
            this.tabPage1.Controls.Add(this.numericUpDown_Version);
            this.tabPage1.Controls.Add(this.button_QRSelectColB);
            this.tabPage1.Controls.Add(this.panel_QRbackgroundColor);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.button_QRSelectColF);
            this.tabPage1.Controls.Add(this.panel_QRforegroundColor);
            this.tabPage1.Controls.Add(this.button_QRSave);
            this.tabPage1.Controls.Add(this.comboBox_encodeMode);
            this.tabPage1.Controls.Add(this.button_QRgenerate);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.comboBox_errorCorrect);
            this.tabPage1.Controls.Add(this.pictureBox_QRGraphicCode);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(772, 379);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "二维码 — QR Code";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // radioButton_No
            // 
            this.radioButton_No.AutoSize = true;
            this.radioButton_No.Location = new System.Drawing.Point(518, 310);
            this.radioButton_No.Name = "radioButton_No";
            this.radioButton_No.Size = new System.Drawing.Size(35, 16);
            this.radioButton_No.TabIndex = 25;
            this.radioButton_No.Text = "否";
            this.radioButton_No.UseVisualStyleBackColor = true;
            // 
            // radioButton_Yes
            // 
            this.radioButton_Yes.AutoSize = true;
            this.radioButton_Yes.Checked = true;
            this.radioButton_Yes.Location = new System.Drawing.Point(453, 310);
            this.radioButton_Yes.Name = "radioButton_Yes";
            this.radioButton_Yes.Size = new System.Drawing.Size(35, 16);
            this.radioButton_Yes.TabIndex = 24;
            this.radioButton_Yes.TabStop = true;
            this.radioButton_Yes.Text = "是";
            this.radioButton_Yes.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(382, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 23;
            this.label7.Text = "是否留边：";
            // 
            // textBox_QRValue
            // 
            this.textBox_QRValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_QRValue.Location = new System.Drawing.Point(382, 6);
            this.textBox_QRValue.Multiline = true;
            this.textBox_QRValue.Name = "textBox_QRValue";
            this.textBox_QRValue.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_QRValue.Size = new System.Drawing.Size(384, 185);
            this.textBox_QRValue.TabIndex = 22;
            this.textBox_QRValue.Text = "欢迎使用二维码生成工具，使用之前请看“使用之前必看”。";
            // 
            // numericUpDown_scale
            // 
            this.numericUpDown_scale.Location = new System.Drawing.Point(666, 239);
            this.numericUpDown_scale.Name = "numericUpDown_scale";
            this.numericUpDown_scale.Size = new System.Drawing.Size(100, 21);
            this.numericUpDown_scale.TabIndex = 21;
            this.numericUpDown_scale.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDown_Version
            // 
            this.numericUpDown_Version.Location = new System.Drawing.Point(453, 239);
            this.numericUpDown_Version.Name = "numericUpDown_Version";
            this.numericUpDown_Version.Size = new System.Drawing.Size(100, 21);
            this.numericUpDown_Version.TabIndex = 20;
            // 
            // button_QRSelectColB
            // 
            this.button_QRSelectColB.Font = new System.Drawing.Font("黑体", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_QRSelectColB.Location = new System.Drawing.Point(741, 272);
            this.button_QRSelectColB.Name = "button_QRSelectColB";
            this.button_QRSelectColB.Size = new System.Drawing.Size(25, 23);
            this.button_QRSelectColB.TabIndex = 19;
            this.button_QRSelectColB.Text = ">";
            this.button_QRSelectColB.UseVisualStyleBackColor = true;
            this.button_QRSelectColB.Click += new System.EventHandler(this.button_SelectColB_Click);
            // 
            // panel_QRbackgroundColor
            // 
            this.panel_QRbackgroundColor.BackColor = System.Drawing.Color.White;
            this.panel_QRbackgroundColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_QRbackgroundColor.Location = new System.Drawing.Point(666, 273);
            this.panel_QRbackgroundColor.Name = "panel_QRbackgroundColor";
            this.panel_QRbackgroundColor.Size = new System.Drawing.Size(69, 22);
            this.panel_QRbackgroundColor.TabIndex = 18;
            this.panel_QRbackgroundColor.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_backgroundColor_MouseUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(607, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 17;
            this.label6.Text = "背景色：";
            // 
            // button_QRSelectColF
            // 
            this.button_QRSelectColF.Font = new System.Drawing.Font("黑体", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_QRSelectColF.Location = new System.Drawing.Point(528, 272);
            this.button_QRSelectColF.Name = "button_QRSelectColF";
            this.button_QRSelectColF.Size = new System.Drawing.Size(25, 23);
            this.button_QRSelectColF.TabIndex = 16;
            this.button_QRSelectColF.Text = ">";
            this.button_QRSelectColF.UseVisualStyleBackColor = true;
            this.button_QRSelectColF.Click += new System.EventHandler(this.button_SelectColF_Click);
            // 
            // panel_QRforegroundColor
            // 
            this.panel_QRforegroundColor.BackColor = System.Drawing.Color.Black;
            this.panel_QRforegroundColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_QRforegroundColor.Location = new System.Drawing.Point(453, 273);
            this.panel_QRforegroundColor.Name = "panel_QRforegroundColor";
            this.panel_QRforegroundColor.Size = new System.Drawing.Size(69, 22);
            this.panel_QRforegroundColor.TabIndex = 15;
            this.panel_QRforegroundColor.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_foregroundColor_MouseUp);
            // 
            // button_QRSave
            // 
            this.button_QRSave.Location = new System.Drawing.Point(686, 346);
            this.button_QRSave.Name = "button_QRSave";
            this.button_QRSave.Size = new System.Drawing.Size(80, 23);
            this.button_QRSave.TabIndex = 14;
            this.button_QRSave.Text = "保  存";
            this.button_QRSave.UseVisualStyleBackColor = true;
            this.button_QRSave.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // comboBox_encodeMode
            // 
            this.comboBox_encodeMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_encodeMode.DropDownWidth = 120;
            this.comboBox_encodeMode.FormattingEnabled = true;
            this.comboBox_encodeMode.Items.AddRange(new object[] {
            "ALPHA_NUMERIC",
            "NUMERIC",
            "BYTE"});
            this.comboBox_encodeMode.Location = new System.Drawing.Point(666, 205);
            this.comboBox_encodeMode.Name = "comboBox_encodeMode";
            this.comboBox_encodeMode.Size = new System.Drawing.Size(100, 20);
            this.comboBox_encodeMode.TabIndex = 10;
            // 
            // button_QRgenerate
            // 
            this.button_QRgenerate.Location = new System.Drawing.Point(600, 346);
            this.button_QRgenerate.Name = "button_QRgenerate";
            this.button_QRgenerate.Size = new System.Drawing.Size(80, 23);
            this.button_QRgenerate.TabIndex = 9;
            this.button_QRgenerate.Text = "生  成";
            this.button_QRgenerate.UseVisualStyleBackColor = true;
            this.button_QRgenerate.Click += new System.EventHandler(this.button_generate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(394, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "前景色：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(607, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "清晰度：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(595, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "编码模式：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(382, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "编码版本：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(382, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "纠错等级：";
            // 
            // comboBox_errorCorrect
            // 
            this.comboBox_errorCorrect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_errorCorrect.FormattingEnabled = true;
            this.comboBox_errorCorrect.Items.AddRange(new object[] {
            "L",
            "M",
            "Q",
            "H"});
            this.comboBox_errorCorrect.Location = new System.Drawing.Point(453, 205);
            this.comboBox_errorCorrect.Name = "comboBox_errorCorrect";
            this.comboBox_errorCorrect.Size = new System.Drawing.Size(100, 20);
            this.comboBox_errorCorrect.TabIndex = 2;
            // 
            // pictureBox_QRGraphicCode
            // 
            this.pictureBox_QRGraphicCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_QRGraphicCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_QRGraphicCode.Location = new System.Drawing.Point(6, 4);
            this.pictureBox_QRGraphicCode.Name = "pictureBox_QRGraphicCode";
            this.pictureBox_QRGraphicCode.Size = new System.Drawing.Size(370, 370);
            this.pictureBox_QRGraphicCode.TabIndex = 0;
            this.pictureBox_QRGraphicCode.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.radioButton3);
            this.tabPage2.Controls.Add(this.radioButton_ShowLabel);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.button_BRSave);
            this.tabPage2.Controls.Add(this.button_BRgenerate);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.button_BRSelectColB);
            this.tabPage2.Controls.Add(this.panel_BRbackgroundColor);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.button_BRSelectColF);
            this.tabPage2.Controls.Add(this.panel_BRforegroundColor);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.comboBox_LocationLabel);
            this.tabPage2.Controls.Add(this.textBox_BRValue);
            this.tabPage2.Controls.Add(this.pictureBox_BRGraphicCode);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(772, 379);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "条形码 — BR Code";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(441, 223);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(35, 16);
            this.radioButton3.TabIndex = 50;
            this.radioButton3.Text = "否";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton_ShowLabel
            // 
            this.radioButton_ShowLabel.AutoSize = true;
            this.radioButton_ShowLabel.Checked = true;
            this.radioButton_ShowLabel.Location = new System.Drawing.Point(376, 223);
            this.radioButton_ShowLabel.Name = "radioButton_ShowLabel";
            this.radioButton_ShowLabel.Size = new System.Drawing.Size(35, 16);
            this.radioButton_ShowLabel.TabIndex = 49;
            this.radioButton_ShowLabel.TabStop = true;
            this.radioButton_ShowLabel.Text = "是";
            this.radioButton_ShowLabel.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(305, 225);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 12);
            this.label16.TabIndex = 48;
            this.label16.Text = "显示标签：";
            // 
            // button_BRSave
            // 
            this.button_BRSave.Location = new System.Drawing.Point(661, 316);
            this.button_BRSave.Name = "button_BRSave";
            this.button_BRSave.Size = new System.Drawing.Size(80, 23);
            this.button_BRSave.TabIndex = 44;
            this.button_BRSave.Text = "保  存";
            this.button_BRSave.UseVisualStyleBackColor = true;
            this.button_BRSave.Click += new System.EventHandler(this.button_BRSave_Click);
            // 
            // button_BRgenerate
            // 
            this.button_BRgenerate.Location = new System.Drawing.Point(575, 316);
            this.button_BRgenerate.Name = "button_BRgenerate";
            this.button_BRgenerate.Size = new System.Drawing.Size(80, 23);
            this.button_BRgenerate.TabIndex = 43;
            this.button_BRgenerate.Text = "生  成";
            this.button_BRgenerate.UseVisualStyleBackColor = true;
            this.button_BRgenerate.Click += new System.EventHandler(this.button4_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(72, 12);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(35, 16);
            this.radioButton1.TabIndex = 42;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "否";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton_ShowB
            // 
            this.radioButton_ShowB.AutoSize = true;
            this.radioButton_ShowB.Location = new System.Drawing.Point(7, 13);
            this.radioButton_ShowB.Name = "radioButton_ShowB";
            this.radioButton_ShowB.Size = new System.Drawing.Size(35, 16);
            this.radioButton_ShowB.TabIndex = 41;
            this.radioButton_ShowB.Text = "是";
            this.radioButton_ShowB.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(305, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 40;
            this.label8.Text = "是否留边：";
            // 
            // button_BRSelectColB
            // 
            this.button_BRSelectColB.Font = new System.Drawing.Font("黑体", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_BRSelectColB.Location = new System.Drawing.Point(716, 176);
            this.button_BRSelectColB.Name = "button_BRSelectColB";
            this.button_BRSelectColB.Size = new System.Drawing.Size(25, 23);
            this.button_BRSelectColB.TabIndex = 37;
            this.button_BRSelectColB.Text = ">";
            this.button_BRSelectColB.UseVisualStyleBackColor = true;
            this.button_BRSelectColB.Click += new System.EventHandler(this.button_BRSelectColB_Click);
            // 
            // panel_BRbackgroundColor
            // 
            this.panel_BRbackgroundColor.BackColor = System.Drawing.Color.White;
            this.panel_BRbackgroundColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_BRbackgroundColor.Location = new System.Drawing.Point(641, 176);
            this.panel_BRbackgroundColor.Name = "panel_BRbackgroundColor";
            this.panel_BRbackgroundColor.Size = new System.Drawing.Size(69, 22);
            this.panel_BRbackgroundColor.TabIndex = 36;
            this.panel_BRbackgroundColor.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_BRbackgroundColor_MouseUp);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(582, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 35;
            this.label9.Text = "背景色：";
            // 
            // button_BRSelectColF
            // 
            this.button_BRSelectColF.Font = new System.Drawing.Font("黑体", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_BRSelectColF.Location = new System.Drawing.Point(451, 176);
            this.button_BRSelectColF.Name = "button_BRSelectColF";
            this.button_BRSelectColF.Size = new System.Drawing.Size(25, 23);
            this.button_BRSelectColF.TabIndex = 34;
            this.button_BRSelectColF.Text = ">";
            this.button_BRSelectColF.UseVisualStyleBackColor = true;
            this.button_BRSelectColF.Click += new System.EventHandler(this.button_BRSelectColF_Click);
            // 
            // panel_BRforegroundColor
            // 
            this.panel_BRforegroundColor.BackColor = System.Drawing.Color.Black;
            this.panel_BRforegroundColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_BRforegroundColor.Location = new System.Drawing.Point(376, 176);
            this.panel_BRforegroundColor.Name = "panel_BRforegroundColor";
            this.panel_BRforegroundColor.Size = new System.Drawing.Size(69, 22);
            this.panel_BRforegroundColor.TabIndex = 33;
            this.panel_BRforegroundColor.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_BRforegroundColor_MouseUp);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(317, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 31;
            this.label10.Text = "前景色：";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(570, 225);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 12);
            this.label14.TabIndex = 27;
            this.label14.Text = "标签位置：";
            // 
            // comboBox_LocationLabel
            // 
            this.comboBox_LocationLabel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_LocationLabel.FormattingEnabled = true;
            this.comboBox_LocationLabel.Items.AddRange(new object[] {
            "左上方",
            "上方居中",
            "右上方",
            "左下方",
            "下方居中",
            "右下方"});
            this.comboBox_LocationLabel.Location = new System.Drawing.Point(641, 221);
            this.comboBox_LocationLabel.Name = "comboBox_LocationLabel";
            this.comboBox_LocationLabel.Size = new System.Drawing.Size(100, 20);
            this.comboBox_LocationLabel.TabIndex = 26;
            // 
            // textBox_BRValue
            // 
            this.textBox_BRValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_BRValue.Location = new System.Drawing.Point(6, 162);
            this.textBox_BRValue.Multiline = true;
            this.textBox_BRValue.Name = "textBox_BRValue";
            this.textBox_BRValue.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_BRValue.Size = new System.Drawing.Size(276, 211);
            this.textBox_BRValue.TabIndex = 23;
            this.textBox_BRValue.Text = "1352559801@qq.com";
            // 
            // pictureBox_BRGraphicCode
            // 
            this.pictureBox_BRGraphicCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_BRGraphicCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_BRGraphicCode.Location = new System.Drawing.Point(6, 6);
            this.pictureBox_BRGraphicCode.Name = "pictureBox_BRGraphicCode";
            this.pictureBox_BRGraphicCode.Size = new System.Drawing.Size(760, 150);
            this.pictureBox_BRGraphicCode.TabIndex = 1;
            this.pictureBox_BRGraphicCode.TabStop = false;
            // 
            // saveFileDialog_Save
            // 
            this.saveFileDialog_Save.CheckPathExists = false;
            this.saveFileDialog_Save.Filter = "PNG | *.PNG | JPEG | *.JPG;*.JPEG;*.JPE";
            this.saveFileDialog_Save.InitialDirectory = "*\\\\Desktop";
            this.saveFileDialog_Save.Title = "保存图片";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.radioButton_ShowB);
            this.panel1.Location = new System.Drawing.Point(369, 251);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(142, 44);
            this.panel1.TabIndex = 51;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.richTextBox_Centent);
            this.tabPage3.Location = new System.Drawing.Point(4, 32);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(772, 379);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "使用之前必看";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // richTextBox_Centent
            // 
            this.richTextBox_Centent.BackColor = System.Drawing.Color.White;
            this.richTextBox_Centent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_Centent.Location = new System.Drawing.Point(3, 3);
            this.richTextBox_Centent.Name = "richTextBox_Centent";
            this.richTextBox_Centent.ReadOnly = true;
            this.richTextBox_Centent.Size = new System.Drawing.Size(766, 373);
            this.richTextBox_Centent.TabIndex = 0;
            this.richTextBox_Centent.Text = "";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 421);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 460);
            this.MinimumSize = new System.Drawing.Size(800, 460);
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "生成二维码/条形码";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_scale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Version)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_QRGraphicCode)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_BRGraphicCode)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox_QRGraphicCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_errorCorrect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_QRgenerate;
        private System.Windows.Forms.ComboBox comboBox_encodeMode;
        private System.Windows.Forms.ColorDialog colorDialog_Color;
        private System.Windows.Forms.Button button_QRSave;
        private System.Windows.Forms.Button button_QRSelectColB;
        private System.Windows.Forms.Panel panel_QRbackgroundColor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_QRSelectColF;
        private System.Windows.Forms.Panel panel_QRforegroundColor;
        private System.Windows.Forms.NumericUpDown numericUpDown_scale;
        private System.Windows.Forms.NumericUpDown numericUpDown_Version;
        private System.Windows.Forms.TextBox textBox_QRValue;
        private System.Windows.Forms.RadioButton radioButton_No;
        private System.Windows.Forms.RadioButton radioButton_Yes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_Save;
        private System.Windows.Forms.TextBox textBox_BRValue;
        private System.Windows.Forms.PictureBox pictureBox_BRGraphicCode;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton_ShowB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_BRSelectColB;
        private System.Windows.Forms.Panel panel_BRbackgroundColor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_BRSelectColF;
        private System.Windows.Forms.Panel panel_BRforegroundColor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBox_LocationLabel;
        private System.Windows.Forms.Button button_BRSave;
        private System.Windows.Forms.Button button_BRgenerate;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton_ShowLabel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox richTextBox_Centent;
    }
}


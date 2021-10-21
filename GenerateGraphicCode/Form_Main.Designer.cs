
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox_GraphicCode = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.comboBox_errorCorrect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_generate = new System.Windows.Forms.Button();
            this.comboBox_encodeMode = new System.Windows.Forms.ComboBox();
            this.colorDialog_Color = new System.Windows.Forms.ColorDialog();
            this.button_Save = new System.Windows.Forms.Button();
            this.panel_foregroundColor = new System.Windows.Forms.Panel();
            this.button_SelectColF = new System.Windows.Forms.Button();
            this.button_SelectColB = new System.Windows.Forms.Button();
            this.panel_backgroundColor = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown_Version = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_scale = new System.Windows.Forms.NumericUpDown();
            this.textBox_Value = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButton_Yes = new System.Windows.Forms.RadioButton();
            this.radioButton_No = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_GraphicCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Version)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_scale)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.ItemSize = new System.Drawing.Size(58, 28);
            this.tabControl1.Location = new System.Drawing.Point(2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(780, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.radioButton_No);
            this.tabPage1.Controls.Add(this.radioButton_Yes);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.textBox_Value);
            this.tabPage1.Controls.Add(this.numericUpDown_scale);
            this.tabPage1.Controls.Add(this.numericUpDown_Version);
            this.tabPage1.Controls.Add(this.button_SelectColB);
            this.tabPage1.Controls.Add(this.panel_backgroundColor);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.button_SelectColF);
            this.tabPage1.Controls.Add(this.panel_foregroundColor);
            this.tabPage1.Controls.Add(this.button_Save);
            this.tabPage1.Controls.Add(this.comboBox_encodeMode);
            this.tabPage1.Controls.Add(this.button_generate);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.comboBox_errorCorrect);
            this.tabPage1.Controls.Add(this.pictureBox_GraphicCode);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(772, 414);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "二维码 — QR Code";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(772, 414);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "条形码 — BR Code";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox_GraphicCode
            // 
            this.pictureBox_GraphicCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_GraphicCode.Location = new System.Drawing.Point(6, 6);
            this.pictureBox_GraphicCode.Name = "pictureBox_GraphicCode";
            this.pictureBox_GraphicCode.Size = new System.Drawing.Size(402, 402);
            this.pictureBox_GraphicCode.TabIndex = 0;
            this.pictureBox_GraphicCode.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(6, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(760, 150);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
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
            this.comboBox_errorCorrect.Location = new System.Drawing.Point(487, 222);
            this.comboBox_errorCorrect.Name = "comboBox_errorCorrect";
            this.comboBox_errorCorrect.Size = new System.Drawing.Size(90, 21);
            this.comboBox_errorCorrect.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(414, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "纠错等级：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(414, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "编码版本：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(603, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "编码模式：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(615, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "清晰度：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(426, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "前景色：";
            // 
            // button_generate
            // 
            this.button_generate.Location = new System.Drawing.Point(600, 375);
            this.button_generate.Name = "button_generate";
            this.button_generate.Size = new System.Drawing.Size(80, 25);
            this.button_generate.TabIndex = 9;
            this.button_generate.Text = "生  成";
            this.button_generate.UseVisualStyleBackColor = true;
            this.button_generate.Click += new System.EventHandler(this.button_generate_Click);
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
            this.comboBox_encodeMode.Location = new System.Drawing.Point(676, 222);
            this.comboBox_encodeMode.Name = "comboBox_encodeMode";
            this.comboBox_encodeMode.Size = new System.Drawing.Size(90, 21);
            this.comboBox_encodeMode.TabIndex = 10;
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(686, 375);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(80, 25);
            this.button_Save.TabIndex = 14;
            this.button_Save.Text = "保  存";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // panel_foregroundColor
            // 
            this.panel_foregroundColor.BackColor = System.Drawing.Color.Black;
            this.panel_foregroundColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_foregroundColor.Location = new System.Drawing.Point(487, 296);
            this.panel_foregroundColor.Name = "panel_foregroundColor";
            this.panel_foregroundColor.Size = new System.Drawing.Size(59, 23);
            this.panel_foregroundColor.TabIndex = 15;
            this.panel_foregroundColor.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_foregroundColor_MouseUp);
            // 
            // button_SelectColF
            // 
            this.button_SelectColF.Font = new System.Drawing.Font("黑体", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SelectColF.Location = new System.Drawing.Point(552, 295);
            this.button_SelectColF.Name = "button_SelectColF";
            this.button_SelectColF.Size = new System.Drawing.Size(25, 25);
            this.button_SelectColF.TabIndex = 16;
            this.button_SelectColF.Text = ">";
            this.button_SelectColF.UseVisualStyleBackColor = true;
            this.button_SelectColF.Click += new System.EventHandler(this.button_SelectColF_Click);
            // 
            // button_SelectColB
            // 
            this.button_SelectColB.Font = new System.Drawing.Font("黑体", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SelectColB.Location = new System.Drawing.Point(741, 295);
            this.button_SelectColB.Name = "button_SelectColB";
            this.button_SelectColB.Size = new System.Drawing.Size(25, 25);
            this.button_SelectColB.TabIndex = 19;
            this.button_SelectColB.Text = ">";
            this.button_SelectColB.UseVisualStyleBackColor = true;
            this.button_SelectColB.Click += new System.EventHandler(this.button_SelectColB_Click);
            // 
            // panel_backgroundColor
            // 
            this.panel_backgroundColor.BackColor = System.Drawing.Color.White;
            this.panel_backgroundColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_backgroundColor.Location = new System.Drawing.Point(676, 296);
            this.panel_backgroundColor.Name = "panel_backgroundColor";
            this.panel_backgroundColor.Size = new System.Drawing.Size(59, 23);
            this.panel_backgroundColor.TabIndex = 18;
            this.panel_backgroundColor.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_backgroundColor_MouseUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(615, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "背景色：";
            // 
            // numericUpDown_Version
            // 
            this.numericUpDown_Version.Location = new System.Drawing.Point(487, 259);
            this.numericUpDown_Version.Name = "numericUpDown_Version";
            this.numericUpDown_Version.Size = new System.Drawing.Size(90, 20);
            this.numericUpDown_Version.TabIndex = 20;
            // 
            // numericUpDown_scale
            // 
            this.numericUpDown_scale.Location = new System.Drawing.Point(676, 259);
            this.numericUpDown_scale.Name = "numericUpDown_scale";
            this.numericUpDown_scale.Size = new System.Drawing.Size(90, 20);
            this.numericUpDown_scale.TabIndex = 21;
            this.numericUpDown_scale.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // textBox_Value
            // 
            this.textBox_Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Value.Location = new System.Drawing.Point(414, 6);
            this.textBox_Value.Multiline = true;
            this.textBox_Value.Name = "textBox_Value";
            this.textBox_Value.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Value.Size = new System.Drawing.Size(352, 200);
            this.textBox_Value.TabIndex = 22;
            this.textBox_Value.Text = "欢迎使用二维码生成工具，使用之前请看声明，需要帮助请看文档。";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(414, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "是否留边：";
            // 
            // radioButton_Yes
            // 
            this.radioButton_Yes.AutoSize = true;
            this.radioButton_Yes.Checked = true;
            this.radioButton_Yes.Location = new System.Drawing.Point(487, 336);
            this.radioButton_Yes.Name = "radioButton_Yes";
            this.radioButton_Yes.Size = new System.Drawing.Size(37, 17);
            this.radioButton_Yes.TabIndex = 24;
            this.radioButton_Yes.TabStop = true;
            this.radioButton_Yes.Text = "是";
            this.radioButton_Yes.UseVisualStyleBackColor = true;
            // 
            // radioButton_No
            // 
            this.radioButton_No.AutoSize = true;
            this.radioButton_No.Location = new System.Drawing.Point(540, 336);
            this.radioButton_No.Name = "radioButton_No";
            this.radioButton_No.Size = new System.Drawing.Size(37, 17);
            this.radioButton_No.TabIndex = 25;
            this.radioButton_No.Text = "否";
            this.radioButton_No.UseVisualStyleBackColor = true;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 456);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 495);
            this.MinimumSize = new System.Drawing.Size(800, 495);
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "生成二维码/条形码";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_GraphicCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Version)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_scale)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox_GraphicCode;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_errorCorrect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_generate;
        private System.Windows.Forms.ComboBox comboBox_encodeMode;
        private System.Windows.Forms.ColorDialog colorDialog_Color;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_SelectColB;
        private System.Windows.Forms.Panel panel_backgroundColor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_SelectColF;
        private System.Windows.Forms.Panel panel_foregroundColor;
        private System.Windows.Forms.NumericUpDown numericUpDown_scale;
        private System.Windows.Forms.NumericUpDown numericUpDown_Version;
        private System.Windows.Forms.TextBox textBox_Value;
        private System.Windows.Forms.RadioButton radioButton_No;
        private System.Windows.Forms.RadioButton radioButton_Yes;
        private System.Windows.Forms.Label label7;
    }
}


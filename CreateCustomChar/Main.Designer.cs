namespace CreateCustomChar
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.TB_Log = new System.Windows.Forms.TextBox();
            this.FlowLayout_Digit_LCD = new System.Windows.Forms.FlowLayoutPanel();
            this.CB_ChangeColor_Blue = new System.Windows.Forms.CheckBox();
            this.CB_ChangeColor_Green = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CB_DataType_Binary = new System.Windows.Forms.CheckBox();
            this.CB_DataType_Hex = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_MlType = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BTN_Clear = new System.Windows.Forms.Button();
            this.CB_TypeInterfac_Parallel = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CB_TypeInterfac_I2C = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_VarialbleName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_GenarateCode = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.BTN_Clipboard = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TB_Log
            // 
            this.TB_Log.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.TB_Log.Location = new System.Drawing.Point(533, 241);
            this.TB_Log.Multiline = true;
            this.TB_Log.Name = "TB_Log";
            this.TB_Log.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TB_Log.Size = new System.Drawing.Size(523, 199);
            this.TB_Log.TabIndex = 0;
            this.TB_Log.TabStop = false;
            this.TB_Log.WordWrap = false;
            // 
            // FlowLayout_Digit_LCD
            // 
            this.FlowLayout_Digit_LCD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FlowLayout_Digit_LCD.Location = new System.Drawing.Point(12, 14);
            this.FlowLayout_Digit_LCD.Name = "FlowLayout_Digit_LCD";
            this.FlowLayout_Digit_LCD.Size = new System.Drawing.Size(1044, 193);
            this.FlowLayout_Digit_LCD.TabIndex = 2;
            // 
            // CB_ChangeColor_Blue
            // 
            this.CB_ChangeColor_Blue.AutoSize = true;
            this.CB_ChangeColor_Blue.Location = new System.Drawing.Point(1006, 218);
            this.CB_ChangeColor_Blue.Name = "CB_ChangeColor_Blue";
            this.CB_ChangeColor_Blue.Size = new System.Drawing.Size(47, 17);
            this.CB_ChangeColor_Blue.TabIndex = 3;
            this.CB_ChangeColor_Blue.Text = "Blue";
            this.CB_ChangeColor_Blue.UseVisualStyleBackColor = true;
            this.CB_ChangeColor_Blue.CheckedChanged += new System.EventHandler(this.CB_ChangeColor_Blue_CheckedChanged);
            // 
            // CB_ChangeColor_Green
            // 
            this.CB_ChangeColor_Green.AutoSize = true;
            this.CB_ChangeColor_Green.Location = new System.Drawing.Point(944, 218);
            this.CB_ChangeColor_Green.Name = "CB_ChangeColor_Green";
            this.CB_ChangeColor_Green.Size = new System.Drawing.Size(55, 17);
            this.CB_ChangeColor_Green.TabIndex = 4;
            this.CB_ChangeColor_Green.Text = "Green";
            this.CB_ChangeColor_Green.UseVisualStyleBackColor = true;
            this.CB_ChangeColor_Green.CheckedChanged += new System.EventHandler(this.CB_ChangeColor_Green_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CB_DataType_Binary);
            this.groupBox1.Controls.Add(this.CB_DataType_Hex);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cb_MlType);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.BTN_Clear);
            this.groupBox1.Controls.Add(this.CB_TypeInterfac_Parallel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CB_TypeInterfac_I2C);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TB_VarialbleName);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 230);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 210);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Config";
            // 
            // CB_DataType_Binary
            // 
            this.CB_DataType_Binary.AutoSize = true;
            this.CB_DataType_Binary.Location = new System.Drawing.Point(105, 165);
            this.CB_DataType_Binary.Name = "CB_DataType_Binary";
            this.CB_DataType_Binary.Size = new System.Drawing.Size(69, 24);
            this.CB_DataType_Binary.TabIndex = 16;
            this.CB_DataType_Binary.Text = "Binary";
            this.CB_DataType_Binary.UseVisualStyleBackColor = true;
            this.CB_DataType_Binary.CheckedChanged += new System.EventHandler(this.CB_DataType_Binary_CheckedChanged);
            // 
            // CB_DataType_Hex
            // 
            this.CB_DataType_Hex.AutoSize = true;
            this.CB_DataType_Hex.Location = new System.Drawing.Point(180, 165);
            this.CB_DataType_Hex.Name = "CB_DataType_Hex";
            this.CB_DataType_Hex.Size = new System.Drawing.Size(54, 24);
            this.CB_DataType_Hex.TabIndex = 15;
            this.CB_DataType_Hex.Text = "Hex";
            this.CB_DataType_Hex.UseVisualStyleBackColor = true;
            this.CB_DataType_Hex.CheckedChanged += new System.EventHandler(this.CB_DataType_Hex_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Data Type :";
            // 
            // cb_MlType
            // 
            this.cb_MlType.AutoSize = true;
            this.cb_MlType.Checked = true;
            this.cb_MlType.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_MlType.Location = new System.Drawing.Point(142, 126);
            this.cb_MlType.Name = "cb_MlType";
            this.cb_MlType.Size = new System.Drawing.Size(81, 24);
            this.cb_MlType.TabIndex = 13;
            this.cb_MlType.Text = "Arduino";
            this.cb_MlType.UseVisualStyleBackColor = true;
            this.cb_MlType.CheckedChanged += new System.EventHandler(this.cb_MlType_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Microcontroller :";
            // 
            // BTN_Clear
            // 
            this.BTN_Clear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Clear.Location = new System.Drawing.Point(408, 44);
            this.BTN_Clear.Name = "BTN_Clear";
            this.BTN_Clear.Size = new System.Drawing.Size(65, 25);
            this.BTN_Clear.TabIndex = 8;
            this.BTN_Clear.Text = "Clear";
            this.BTN_Clear.UseVisualStyleBackColor = true;
            this.BTN_Clear.Click += new System.EventHandler(this.BTN_Clear_Click);
            // 
            // CB_TypeInterfac_Parallel
            // 
            this.CB_TypeInterfac_Parallel.AutoSize = true;
            this.CB_TypeInterfac_Parallel.Location = new System.Drawing.Point(145, 86);
            this.CB_TypeInterfac_Parallel.Name = "CB_TypeInterfac_Parallel";
            this.CB_TypeInterfac_Parallel.Size = new System.Drawing.Size(76, 24);
            this.CB_TypeInterfac_Parallel.TabIndex = 9;
            this.CB_TypeInterfac_Parallel.Text = "Parallel";
            this.CB_TypeInterfac_Parallel.UseVisualStyleBackColor = true;
            this.CB_TypeInterfac_Parallel.CheckedChanged += new System.EventHandler(this.CB_TypeInterfac_Parallel_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Interfacing type :";
            // 
            // CB_TypeInterfac_I2C
            // 
            this.CB_TypeInterfac_I2C.AutoSize = true;
            this.CB_TypeInterfac_I2C.Location = new System.Drawing.Point(226, 86);
            this.CB_TypeInterfac_I2C.Name = "CB_TypeInterfac_I2C";
            this.CB_TypeInterfac_I2C.Size = new System.Drawing.Size(49, 24);
            this.CB_TypeInterfac_I2C.TabIndex = 8;
            this.CB_TypeInterfac_I2C.Text = "I2C";
            this.CB_TypeInterfac_I2C.UseVisualStyleBackColor = true;
            this.CB_TypeInterfac_I2C.CheckedChanged += new System.EventHandler(this.CB_TypeInterfac_I2C_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Variable name :";
            // 
            // TB_VarialbleName
            // 
            this.TB_VarialbleName.Location = new System.Drawing.Point(142, 44);
            this.TB_VarialbleName.Multiline = true;
            this.TB_VarialbleName.Name = "TB_VarialbleName";
            this.TB_VarialbleName.Size = new System.Drawing.Size(257, 25);
            this.TB_VarialbleName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(888, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Color :";
            // 
            // BTN_GenarateCode
            // 
            this.BTN_GenarateCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_GenarateCode.Location = new System.Drawing.Point(340, 450);
            this.BTN_GenarateCode.Name = "BTN_GenarateCode";
            this.BTN_GenarateCode.Size = new System.Drawing.Size(176, 30);
            this.BTN_GenarateCode.TabIndex = 7;
            this.BTN_GenarateCode.Text = "Genarate Custom Charater";
            this.BTN_GenarateCode.UseVisualStyleBackColor = true;
            this.BTN_GenarateCode.Click += new System.EventHandler(this.BTN_GenarateCode_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(12, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(498, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "* Up to 8 characters can be displayed, depending on the Ram Microcontroller used." +
    "";
            // 
            // BTN_Clipboard
            // 
            this.BTN_Clipboard.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Clipboard.Location = new System.Drawing.Point(964, 450);
            this.BTN_Clipboard.Name = "BTN_Clipboard";
            this.BTN_Clipboard.Size = new System.Drawing.Size(93, 30);
            this.BTN_Clipboard.TabIndex = 9;
            this.BTN_Clipboard.Text = "Clipboard";
            this.BTN_Clipboard.UseVisualStyleBackColor = true;
            this.BTN_Clipboard.Click += new System.EventHandler(this.BTN_Clipboard_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1069, 492);
            this.Controls.Add(this.BTN_Clipboard);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BTN_GenarateCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_Log);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CB_ChangeColor_Green);
            this.Controls.Add(this.CB_ChangeColor_Blue);
            this.Controls.Add(this.FlowLayout_Digit_LCD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "LCD Custom Character Generator By Gapz@ThaiLand";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Log;
        private System.Windows.Forms.FlowLayoutPanel FlowLayout_Digit_LCD;
        private System.Windows.Forms.CheckBox CB_ChangeColor_Blue;
        private System.Windows.Forms.CheckBox CB_ChangeColor_Green;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_Clear;
        private System.Windows.Forms.CheckBox CB_TypeInterfac_Parallel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox CB_TypeInterfac_I2C;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_VarialbleName;
        private System.Windows.Forms.Button BTN_GenarateCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox CB_DataType_Binary;
        private System.Windows.Forms.CheckBox CB_DataType_Hex;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cb_MlType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BTN_Clipboard;
    }
}


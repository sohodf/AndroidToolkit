namespace APK_Manager
{
    partial class Start
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.label1 = new System.Windows.Forms.Label();
            this.devicesComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.deviceStatusTextBox = new System.Windows.Forms.TextBox();
            this.openApkBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.install = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button11 = new System.Windows.Forms.Button();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button12 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button15 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select ADB device:";
            // 
            // devicesComboBox
            // 
            this.devicesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.devicesComboBox.FormattingEnabled = true;
            this.devicesComboBox.Location = new System.Drawing.Point(145, 22);
            this.devicesComboBox.Name = "devicesComboBox";
            this.devicesComboBox.Size = new System.Drawing.Size(236, 21);
            this.devicesComboBox.TabIndex = 1;
            this.devicesComboBox.SelectedValueChanged += new System.EventHandler(this.Devices_SelectedValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(530, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Refresh devices";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(12, 441);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Log:";
            // 
            // deviceStatusTextBox
            // 
            this.deviceStatusTextBox.Location = new System.Drawing.Point(390, 22);
            this.deviceStatusTextBox.Multiline = true;
            this.deviceStatusTextBox.Name = "deviceStatusTextBox";
            this.deviceStatusTextBox.ReadOnly = true;
            this.deviceStatusTextBox.Size = new System.Drawing.Size(134, 23);
            this.deviceStatusTextBox.TabIndex = 6;
            this.deviceStatusTextBox.Text = "Device Status";
            this.deviceStatusTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deviceStatusTextBox.TextChanged += new System.EventHandler(this.deviceStatusTextBox_TextChanged);
            // 
            // openApkBtn
            // 
            this.openApkBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.openApkBtn.Location = new System.Drawing.Point(6, 19);
            this.openApkBtn.Name = "openApkBtn";
            this.openApkBtn.Size = new System.Drawing.Size(92, 40);
            this.openApkBtn.TabIndex = 7;
            this.openApkBtn.Text = "Select apk file";
            this.openApkBtn.UseVisualStyleBackColor = true;
            this.openApkBtn.Click += new System.EventHandler(this.openApkBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.install);
            this.groupBox1.Controls.Add(this.openApkBtn);
            this.groupBox1.Location = new System.Drawing.Point(16, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 111);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "APK Management";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Arial", 7F);
            this.button5.Location = new System.Drawing.Point(6, 63);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(92, 39);
            this.button5.TabIndex = 15;
            this.button5.Text = "Install as none sysapp";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button4.Location = new System.Drawing.Point(104, 63);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 39);
            this.button4.TabIndex = 14;
            this.button4.Text = "Uninstall";
            this.ToolTip.SetToolTip(this.button4, "Uninstalls the wireless controller apk from the machine");
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // install
            // 
            this.install.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.install.Location = new System.Drawing.Point(104, 19);
            this.install.Name = "install";
            this.install.Size = new System.Drawing.Size(116, 40);
            this.install.TabIndex = 8;
            this.install.Text = "Install as sysapp";
            this.install.UseVisualStyleBackColor = true;
            this.install.Click += new System.EventHandler(this.install_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(112, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "None";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(18, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Device Type:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(530, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Connect through TCP";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(530, 98);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Disconect selected device";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(11, 472);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(659, 134);
            this.listBox1.TabIndex = 14;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(536, 437);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(134, 23);
            this.button6.TabIndex = 15;
            this.button6.Text = "Restart ADB";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(396, 437);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(134, 23);
            this.button7.TabIndex = 16;
            this.button7.Text = "Clear Log";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button8.Location = new System.Drawing.Point(32, 33);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(119, 55);
            this.button8.TabIndex = 18;
            this.button8.Text = "Install ADB";
            this.ToolTip.SetToolTip(this.button8, "Install ADB on the current machine");
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Location = new System.Drawing.Point(256, 309);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(189, 115);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "System";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button11);
            this.groupBox3.Controls.Add(this.button9);
            this.groupBox3.Controls.Add(this.button10);
            this.groupBox3.Location = new System.Drawing.Point(16, 244);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(233, 180);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Platform";
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button9.Location = new System.Drawing.Point(6, 26);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(102, 40);
            this.button9.TabIndex = 19;
            this.button9.Text = "Install Iperf";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button10.Location = new System.Drawing.Point(6, 72);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(102, 36);
            this.button10.TabIndex = 19;
            this.button10.Text = "Wake Screen";
            this.ToolTip.SetToolTip(this.button10, "Send keyevent 26 to the device");
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::APK_Manager.Properties.Resources.cellphone;
            this.pictureBox1.Location = new System.Drawing.Point(516, 190);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Arial", 8F);
            this.button11.Location = new System.Drawing.Point(6, 114);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(102, 39);
            this.button11.TabIndex = 20;
            this.button11.Text = "Single Core Mode";
            this.ToolTip.SetToolTip(this.button11, "Change XMM6321 to single core mode for improved stability.\r\nLasts until next rebo" +
                    "ot.");
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.WorkerReportsProgress = true;
            this.backgroundWorker2.WorkerSupportsCancellation = true;
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button15);
            this.groupBox4.Controls.Add(this.button14);
            this.groupBox4.Controls.Add(this.button13);
            this.groupBox4.Controls.Add(this.comboBox1);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.button12);
            this.groupBox4.Location = new System.Drawing.Point(256, 127);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(189, 176);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Push file";
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button12.Location = new System.Drawing.Point(103, 19);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(80, 40);
            this.button12.TabIndex = 8;
            this.button12.Text = "Select file";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Select push destination:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "/system/bin",
            "/sysem/data",
            "/system/lib"});
            this.comboBox1.Location = new System.Drawing.Point(10, 80);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(173, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button13.Location = new System.Drawing.Point(10, 19);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(76, 40);
            this.button13.TabIndex = 11;
            this.button13.Text = "Mount r/w";
            this.ToolTip.SetToolTip(this.button13, "File system must be mounted as read/write before files can be pushed");
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Enabled = false;
            this.button14.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button14.Location = new System.Drawing.Point(10, 117);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(76, 40);
            this.button14.TabIndex = 12;
            this.button14.Text = "Push file";
            this.ToolTip.SetToolTip(this.button14, "File system must be mounted as read/write before files can be pushed");
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // button15
            // 
            this.button15.Enabled = false;
            this.button15.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button15.Location = new System.Drawing.Point(103, 117);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(76, 40);
            this.button15.TabIndex = 13;
            this.button15.Text = "Cancel";
            this.ToolTip.SetToolTip(this.button15, "File system must be mounted as read/write before files can be pushed");
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 618);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.deviceStatusTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.devicesComboBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Android Toolkit by WISE JER 1.31";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox deviceStatusTextBox;
        private System.Windows.Forms.Button openApkBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button install;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.ToolTip ToolTip;
        public System.Windows.Forms.ComboBox devicesComboBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button14;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button15;

    }
}


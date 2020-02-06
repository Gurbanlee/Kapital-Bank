namespace BirCard_Credit_Calculator
{
    partial class BirCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BirCard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudCash = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dpCashDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtPayDate = new System.Windows.Forms.DateTimePicker();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCash = new System.Windows.Forms.Label();
            this.lblPay = new System.Windows.Forms.Label();
            this.lblDateDiff = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCash)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImage = global::BirCard_Credit_Calculator.Properties.Resources.background;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 110);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudCash);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 66);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nağdlaşdırılan məbləğ:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // nudCash
            // 
            this.nudCash.Location = new System.Drawing.Point(6, 25);
            this.nudCash.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudCash.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudCash.Name = "nudCash";
            this.nudCash.Size = new System.Drawing.Size(292, 26);
            this.nudCash.TabIndex = 0;
            this.nudCash.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudCash.ValueChanged += new System.EventHandler(this.nudCash_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dpCashDate);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(12, 188);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(162, 66);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nağdlaşdırılan tarix:";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dpCashDate
            // 
            this.dpCashDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dpCashDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpCashDate.Location = new System.Drawing.Point(6, 25);
            this.dpCashDate.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dpCashDate.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dpCashDate.Name = "dpCashDate";
            this.dpCashDate.Size = new System.Drawing.Size(121, 26);
            this.dpCashDate.TabIndex = 0;
            this.dpCashDate.Value = new System.DateTime(2020, 2, 6, 11, 37, 13, 0);
            this.dpCashDate.ValueChanged += new System.EventHandler(this.dpCashDate_ValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtPayDate);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(181, 188);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(162, 66);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ödənilən tarix tarix:";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // dtPayDate
            // 
            this.dtPayDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtPayDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPayDate.Location = new System.Drawing.Point(6, 25);
            this.dtPayDate.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dtPayDate.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dtPayDate.Name = "dtPayDate";
            this.dtPayDate.Size = new System.Drawing.Size(121, 26);
            this.dtPayDate.TabIndex = 0;
            this.dtPayDate.Value = new System.DateTime(2020, 2, 6, 11, 37, 13, 0);
            this.dtPayDate.ValueChanged += new System.EventHandler(this.dtPayDate_ValueChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculate.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCalculate.Location = new System.Drawing.Point(12, 260);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(331, 25);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Hesabla";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClear.Location = new System.Drawing.Point(12, 291);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(331, 25);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Təmizlə";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.lblDateDiff);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.lblPay);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.lblCash);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(12, 322);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(331, 89);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kredit hesablanması";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(199, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "AZN";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(199, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "AZN";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(6, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ödənilməli məbləğ:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(199, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "gün sonra";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ödəmə vaxtı:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nağdlaşdırılan məbləğ:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCash
            // 
            this.lblCash.AutoSize = true;
            this.lblCash.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCash.Location = new System.Drawing.Point(172, 22);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(0, 18);
            this.lblCash.TabIndex = 1;
            this.lblCash.Click += new System.EventHandler(this.lblCash_Click);
            // 
            // lblPay
            // 
            this.lblPay.AutoSize = true;
            this.lblPay.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPay.Location = new System.Drawing.Point(172, 58);
            this.lblPay.Name = "lblPay";
            this.lblPay.Size = new System.Drawing.Size(0, 18);
            this.lblPay.TabIndex = 4;
            this.lblPay.Click += new System.EventHandler(this.lblPay_Click);
            // 
            // lblDateDiff
            // 
            this.lblDateDiff.AutoSize = true;
            this.lblDateDiff.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDateDiff.Location = new System.Drawing.Point(172, 40);
            this.lblDateDiff.Name = "lblDateDiff";
            this.lblDateDiff.Size = new System.Drawing.Size(0, 18);
            this.lblDateDiff.TabIndex = 6;
            this.lblDateDiff.Click += new System.EventHandler(this.lblDateDiff_Click);
            // 
            // BirCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 423);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BirCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BirKart - Kredit hesablayıcı";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudCash)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudCash;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dpCashDate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtPayDate;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDateDiff;
        private System.Windows.Forms.Label lblPay;
        private System.Windows.Forms.Label lblCash;
    }
}


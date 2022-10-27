namespace Assignment_3
{
    partial class Form1
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
            this.flushesGrpBx = new System.Windows.Forms.GroupBox();
            this.transmissionChkBx = new System.Windows.Forms.CheckBox();
            this.radiatorChkBx = new System.Windows.Forms.CheckBox();
            this.miscGrpBx = new System.Windows.Forms.GroupBox();
            this.tireLstBx = new System.Windows.Forms.ListBox();
            this.clearMiscBtn = new System.Windows.Forms.Button();
            this.miscLstBx = new System.Windows.Forms.ListBox();
            this.oilGrpBx = new System.Windows.Forms.GroupBox();
            this.lubeChkBx = new System.Windows.Forms.CheckBox();
            this.oilChkBx = new System.Windows.Forms.CheckBox();
            this.partsGrpBx = new System.Windows.Forms.GroupBox();
            this.errorLbl = new System.Windows.Forms.Label();
            this.laborLbl = new System.Windows.Forms.Label();
            this.partsLbl = new System.Windows.Forms.Label();
            this.laborTxtBx = new System.Windows.Forms.TextBox();
            this.partsTxtBx = new System.Windows.Forms.TextBox();
            this.summaryGrpBx = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.laborSummaryTxtBx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.totalTxtBx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pstTxtBx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gstTxtBx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.partsSummaryTxtBx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.serviceTxtBx = new System.Windows.Forms.TextBox();
            this.serviceLbl = new System.Windows.Forms.Label();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.clearAllBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.flushesGrpBx.SuspendLayout();
            this.miscGrpBx.SuspendLayout();
            this.oilGrpBx.SuspendLayout();
            this.partsGrpBx.SuspendLayout();
            this.summaryGrpBx.SuspendLayout();
            this.SuspendLayout();
            // 
            // flushesGrpBx
            // 
            this.flushesGrpBx.Controls.Add(this.transmissionChkBx);
            this.flushesGrpBx.Controls.Add(this.radiatorChkBx);
            this.flushesGrpBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flushesGrpBx.Location = new System.Drawing.Point(12, 12);
            this.flushesGrpBx.Name = "flushesGrpBx";
            this.flushesGrpBx.Size = new System.Drawing.Size(200, 75);
            this.flushesGrpBx.TabIndex = 0;
            this.flushesGrpBx.TabStop = false;
            this.flushesGrpBx.Text = "Flushes";
            // 
            // transmissionChkBx
            // 
            this.transmissionChkBx.AutoSize = true;
            this.transmissionChkBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.transmissionChkBx.Location = new System.Drawing.Point(7, 44);
            this.transmissionChkBx.Name = "transmissionChkBx";
            this.transmissionChkBx.Size = new System.Drawing.Size(157, 17);
            this.transmissionChkBx.TabIndex = 1;
            this.transmissionChkBx.Text = "Transmission Flush ($80.00)";
            this.transmissionChkBx.UseVisualStyleBackColor = true;
            // 
            // radiatorChkBx
            // 
            this.radiatorChkBx.AutoSize = true;
            this.radiatorChkBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.radiatorChkBx.Location = new System.Drawing.Point(7, 20);
            this.radiatorChkBx.Name = "radiatorChkBx";
            this.radiatorChkBx.Size = new System.Drawing.Size(136, 17);
            this.radiatorChkBx.TabIndex = 0;
            this.radiatorChkBx.Text = "Radiator Flush ($30.00)";
            this.radiatorChkBx.UseVisualStyleBackColor = true;
            // 
            // miscGrpBx
            // 
            this.miscGrpBx.Controls.Add(this.tireLstBx);
            this.miscGrpBx.Controls.Add(this.clearMiscBtn);
            this.miscGrpBx.Controls.Add(this.miscLstBx);
            this.miscGrpBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miscGrpBx.Location = new System.Drawing.Point(12, 93);
            this.miscGrpBx.Name = "miscGrpBx";
            this.miscGrpBx.Size = new System.Drawing.Size(200, 147);
            this.miscGrpBx.TabIndex = 1;
            this.miscGrpBx.TabStop = false;
            this.miscGrpBx.Text = "Misc";
            // 
            // tireLstBx
            // 
            this.tireLstBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tireLstBx.FormattingEnabled = true;
            this.tireLstBx.Location = new System.Drawing.Point(7, 83);
            this.tireLstBx.Name = "tireLstBx";
            this.tireLstBx.Size = new System.Drawing.Size(94, 56);
            this.tireLstBx.TabIndex = 2;
            this.tireLstBx.Visible = false;
            // 
            // clearMiscBtn
            // 
            this.clearMiscBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.clearMiscBtn.Location = new System.Drawing.Point(107, 83);
            this.clearMiscBtn.Name = "clearMiscBtn";
            this.clearMiscBtn.Size = new System.Drawing.Size(75, 23);
            this.clearMiscBtn.TabIndex = 1;
            this.clearMiscBtn.Text = "Clear Misc";
            this.clearMiscBtn.UseVisualStyleBackColor = true;
            this.clearMiscBtn.Click += new System.EventHandler(this.clearMiscBtn_Click);
            // 
            // miscLstBx
            // 
            this.miscLstBx.BackColor = System.Drawing.Color.Yellow;
            this.miscLstBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miscLstBx.FormattingEnabled = true;
            this.miscLstBx.Items.AddRange(new object[] {
            "Inspection ($15.00)",
            "Replace Muffler ($90.50)",
            "Tire Rotation ($28.90)",
            "Purchase New Tires ($87.75 each)"});
            this.miscLstBx.Location = new System.Drawing.Point(7, 20);
            this.miscLstBx.Name = "miscLstBx";
            this.miscLstBx.Size = new System.Drawing.Size(176, 56);
            this.miscLstBx.TabIndex = 0;
            this.miscLstBx.SelectedIndexChanged += new System.EventHandler(this.miscLstBx_SelectedIndexChanged);
            // 
            // oilGrpBx
            // 
            this.oilGrpBx.Controls.Add(this.lubeChkBx);
            this.oilGrpBx.Controls.Add(this.oilChkBx);
            this.oilGrpBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.oilGrpBx.Location = new System.Drawing.Point(333, 12);
            this.oilGrpBx.Name = "oilGrpBx";
            this.oilGrpBx.Size = new System.Drawing.Size(200, 75);
            this.oilGrpBx.TabIndex = 2;
            this.oilGrpBx.TabStop = false;
            this.oilGrpBx.Text = "Oil and Lube";
            // 
            // lubeChkBx
            // 
            this.lubeChkBx.AutoSize = true;
            this.lubeChkBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lubeChkBx.Location = new System.Drawing.Point(6, 44);
            this.lubeChkBx.Name = "lubeChkBx";
            this.lubeChkBx.Size = new System.Drawing.Size(112, 17);
            this.lubeChkBx.TabIndex = 9;
            this.lubeChkBx.Text = "Lube Job ($19.50)";
            this.lubeChkBx.UseVisualStyleBackColor = true;
            // 
            // oilChkBx
            // 
            this.oilChkBx.AutoSize = true;
            this.oilChkBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.oilChkBx.Location = new System.Drawing.Point(6, 20);
            this.oilChkBx.Name = "oilChkBx";
            this.oilChkBx.Size = new System.Drawing.Size(120, 17);
            this.oilChkBx.TabIndex = 8;
            this.oilChkBx.Text = "Oil Change ($28.50)";
            this.oilChkBx.UseVisualStyleBackColor = true;
            // 
            // partsGrpBx
            // 
            this.partsGrpBx.Controls.Add(this.errorLbl);
            this.partsGrpBx.Controls.Add(this.laborLbl);
            this.partsGrpBx.Controls.Add(this.partsLbl);
            this.partsGrpBx.Controls.Add(this.laborTxtBx);
            this.partsGrpBx.Controls.Add(this.partsTxtBx);
            this.partsGrpBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.partsGrpBx.Location = new System.Drawing.Point(333, 99);
            this.partsGrpBx.Name = "partsGrpBx";
            this.partsGrpBx.Size = new System.Drawing.Size(200, 141);
            this.partsGrpBx.TabIndex = 3;
            this.partsGrpBx.TabStop = false;
            this.partsGrpBx.Text = "Parts and Labor ($21.80)";
            // 
            // errorLbl
            // 
            this.errorLbl.AutoSize = true;
            this.errorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLbl.ForeColor = System.Drawing.Color.Red;
            this.errorLbl.Location = new System.Drawing.Point(18, 77);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(0, 13);
            this.errorLbl.TabIndex = 9;
            // 
            // laborLbl
            // 
            this.laborLbl.AutoSize = true;
            this.laborLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.laborLbl.Location = new System.Drawing.Point(35, 48);
            this.laborLbl.Name = "laborLbl";
            this.laborLbl.Size = new System.Drawing.Size(95, 13);
            this.laborLbl.TabIndex = 8;
            this.laborLbl.Text = "Labor (hrs worked)";
            // 
            // partsLbl
            // 
            this.partsLbl.AutoSize = true;
            this.partsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.partsLbl.Location = new System.Drawing.Point(84, 22);
            this.partsLbl.Name = "partsLbl";
            this.partsLbl.Size = new System.Drawing.Size(46, 13);
            this.partsLbl.TabIndex = 2;
            this.partsLbl.Text = "Parts ($)";
            // 
            // laborTxtBx
            // 
            this.laborTxtBx.BackColor = System.Drawing.Color.Yellow;
            this.laborTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.laborTxtBx.Location = new System.Drawing.Point(136, 45);
            this.laborTxtBx.Name = "laborTxtBx";
            this.laborTxtBx.Size = new System.Drawing.Size(58, 20);
            this.laborTxtBx.TabIndex = 1;
            // 
            // partsTxtBx
            // 
            this.partsTxtBx.BackColor = System.Drawing.Color.Yellow;
            this.partsTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.partsTxtBx.Location = new System.Drawing.Point(136, 19);
            this.partsTxtBx.Name = "partsTxtBx";
            this.partsTxtBx.Size = new System.Drawing.Size(58, 20);
            this.partsTxtBx.TabIndex = 0;
            // 
            // summaryGrpBx
            // 
            this.summaryGrpBx.Controls.Add(this.label6);
            this.summaryGrpBx.Controls.Add(this.laborSummaryTxtBx);
            this.summaryGrpBx.Controls.Add(this.label5);
            this.summaryGrpBx.Controls.Add(this.totalTxtBx);
            this.summaryGrpBx.Controls.Add(this.label4);
            this.summaryGrpBx.Controls.Add(this.pstTxtBx);
            this.summaryGrpBx.Controls.Add(this.label3);
            this.summaryGrpBx.Controls.Add(this.gstTxtBx);
            this.summaryGrpBx.Controls.Add(this.label2);
            this.summaryGrpBx.Controls.Add(this.partsSummaryTxtBx);
            this.summaryGrpBx.Controls.Add(this.label1);
            this.summaryGrpBx.Controls.Add(this.serviceTxtBx);
            this.summaryGrpBx.Controls.Add(this.serviceLbl);
            this.summaryGrpBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summaryGrpBx.Location = new System.Drawing.Point(12, 246);
            this.summaryGrpBx.Name = "summaryGrpBx";
            this.summaryGrpBx.Size = new System.Drawing.Size(376, 153);
            this.summaryGrpBx.TabIndex = 4;
            this.summaryGrpBx.TabStop = false;
            this.summaryGrpBx.Text = "Summary";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(213, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "PST";
            // 
            // laborSummaryTxtBx
            // 
            this.laborSummaryTxtBx.BackColor = System.Drawing.SystemColors.Control;
            this.laborSummaryTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.laborSummaryTxtBx.Enabled = false;
            this.laborSummaryTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.laborSummaryTxtBx.Location = new System.Drawing.Point(264, 14);
            this.laborSummaryTxtBx.Name = "laborSummaryTxtBx";
            this.laborSummaryTxtBx.Size = new System.Drawing.Size(100, 20);
            this.laborSummaryTxtBx.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(224, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Labor";
            // 
            // totalTxtBx
            // 
            this.totalTxtBx.BackColor = System.Drawing.SystemColors.Control;
            this.totalTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalTxtBx.Enabled = false;
            this.totalTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTxtBx.Location = new System.Drawing.Point(107, 118);
            this.totalTxtBx.Name = "totalTxtBx";
            this.totalTxtBx.Size = new System.Drawing.Size(100, 20);
            this.totalTxtBx.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(44, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Total Fees";
            // 
            // pstTxtBx
            // 
            this.pstTxtBx.BackColor = System.Drawing.SystemColors.Control;
            this.pstTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pstTxtBx.Enabled = false;
            this.pstTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.pstTxtBx.Location = new System.Drawing.Point(107, 92);
            this.pstTxtBx.Name = "pstTxtBx";
            this.pstTxtBx.Size = new System.Drawing.Size(100, 20);
            this.pstTxtBx.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(213, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "GST";
            // 
            // gstTxtBx
            // 
            this.gstTxtBx.BackColor = System.Drawing.SystemColors.Control;
            this.gstTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gstTxtBx.Enabled = false;
            this.gstTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.gstTxtBx.Location = new System.Drawing.Point(107, 66);
            this.gstTxtBx.Name = "gstTxtBx";
            this.gstTxtBx.Size = new System.Drawing.Size(100, 20);
            this.gstTxtBx.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(0, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tax(on Parts ONLY)";
            // 
            // partsSummaryTxtBx
            // 
            this.partsSummaryTxtBx.BackColor = System.Drawing.SystemColors.Control;
            this.partsSummaryTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.partsSummaryTxtBx.Enabled = false;
            this.partsSummaryTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.partsSummaryTxtBx.Location = new System.Drawing.Point(107, 40);
            this.partsSummaryTxtBx.Name = "partsSummaryTxtBx";
            this.partsSummaryTxtBx.Size = new System.Drawing.Size(100, 20);
            this.partsSummaryTxtBx.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(70, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Parts";
            // 
            // serviceTxtBx
            // 
            this.serviceTxtBx.BackColor = System.Drawing.SystemColors.Control;
            this.serviceTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.serviceTxtBx.Enabled = false;
            this.serviceTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.serviceTxtBx.Location = new System.Drawing.Point(107, 14);
            this.serviceTxtBx.Name = "serviceTxtBx";
            this.serviceTxtBx.Size = new System.Drawing.Size(100, 20);
            this.serviceTxtBx.TabIndex = 3;
            // 
            // serviceLbl
            // 
            this.serviceLbl.AutoSize = true;
            this.serviceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.serviceLbl.Location = new System.Drawing.Point(7, 16);
            this.serviceLbl.Name = "serviceLbl";
            this.serviceLbl.Size = new System.Drawing.Size(94, 13);
            this.serviceLbl.TabIndex = 2;
            this.serviceLbl.Text = "Service and Labor";
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(22, 405);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(75, 23);
            this.calculateBtn.TabIndex = 5;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // clearAllBtn
            // 
            this.clearAllBtn.Location = new System.Drawing.Point(103, 405);
            this.clearAllBtn.Name = "clearAllBtn";
            this.clearAllBtn.Size = new System.Drawing.Size(75, 23);
            this.clearAllBtn.TabIndex = 6;
            this.clearAllBtn.Text = "Clear";
            this.clearAllBtn.UseVisualStyleBackColor = true;
            this.clearAllBtn.Click += new System.EventHandler(this.clearAllBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(184, 405);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 7;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 440);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.clearAllBtn);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.summaryGrpBx);
            this.Controls.Add(this.partsGrpBx);
            this.Controls.Add(this.oilGrpBx);
            this.Controls.Add(this.miscGrpBx);
            this.Controls.Add(this.flushesGrpBx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flushesGrpBx.ResumeLayout(false);
            this.flushesGrpBx.PerformLayout();
            this.miscGrpBx.ResumeLayout(false);
            this.oilGrpBx.ResumeLayout(false);
            this.oilGrpBx.PerformLayout();
            this.partsGrpBx.ResumeLayout(false);
            this.partsGrpBx.PerformLayout();
            this.summaryGrpBx.ResumeLayout(false);
            this.summaryGrpBx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox flushesGrpBx;
        private System.Windows.Forms.CheckBox transmissionChkBx;
        private System.Windows.Forms.CheckBox radiatorChkBx;
        private System.Windows.Forms.GroupBox miscGrpBx;
        private System.Windows.Forms.ListBox tireLstBx;
        private System.Windows.Forms.Button clearMiscBtn;
        private System.Windows.Forms.ListBox miscLstBx;
        private System.Windows.Forms.GroupBox oilGrpBx;
        private System.Windows.Forms.CheckBox lubeChkBx;
        private System.Windows.Forms.CheckBox oilChkBx;
        private System.Windows.Forms.GroupBox partsGrpBx;
        private System.Windows.Forms.Label laborLbl;
        private System.Windows.Forms.Label partsLbl;
        private System.Windows.Forms.TextBox laborTxtBx;
        private System.Windows.Forms.TextBox partsTxtBx;
        private System.Windows.Forms.GroupBox summaryGrpBx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox laborSummaryTxtBx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox totalTxtBx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pstTxtBx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox gstTxtBx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox partsSummaryTxtBx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox serviceTxtBx;
        private System.Windows.Forms.Label serviceLbl;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Button clearAllBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label errorLbl;
    }
}


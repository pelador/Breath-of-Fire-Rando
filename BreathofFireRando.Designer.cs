namespace _BreathofFireRandomiser
{
    partial class BreathofFireRando
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
            this.BtnBrowse = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCompare = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSHAChecksum = new System.Windows.Forms.Label();
            this.btnCompare = new System.Windows.Forms.Button();
            this.lblSeed = new System.Windows.Forms.Label();
            this.lblRequired = new System.Windows.Forms.Label();
            this.lblReqChecksum = new System.Windows.Forms.Label();
            this.txtSeed = new System.Windows.Forms.TextBox();
            this.btnNewSeed = new System.Windows.Forms.Button();
            this.cmdRandomize = new System.Windows.Forms.Button();
            this.lblFlags = new System.Windows.Forms.Label();
            this.txtFlags = new System.Windows.Forms.TextBox();
            this.chkTreasures = new System.Windows.Forms.CheckBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnBrowse
            // 
            this.BtnBrowse.Location = new System.Drawing.Point(640, 14);
            this.BtnBrowse.Name = "BtnBrowse";
            this.BtnBrowse.Size = new System.Drawing.Size(75, 40);
            this.BtnBrowse.TabIndex = 43;
            this.BtnBrowse.Text = "Browse";
            this.BtnBrowse.UseVisualStyleBackColor = true;
            this.BtnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(157, 21);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(477, 26);
            this.txtFileName.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "ROM Image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 44;
            this.label2.Text = "Comparison Image";
            // 
            // txtCompare
            // 
            this.txtCompare.Location = new System.Drawing.Point(157, 76);
            this.txtCompare.Name = "txtCompare";
            this.txtCompare.Size = new System.Drawing.Size(477, 26);
            this.txtCompare.TabIndex = 45;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(640, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 46;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 47;
            this.label3.Text = "SHA1 Checksum";
            // 
            // lblSHAChecksum
            // 
            this.lblSHAChecksum.AutoSize = true;
            this.lblSHAChecksum.Location = new System.Drawing.Point(163, 136);
            this.lblSHAChecksum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSHAChecksum.Name = "lblSHAChecksum";
            this.lblSHAChecksum.Size = new System.Drawing.Size(369, 20);
            this.lblSHAChecksum.TabIndex = 53;
            this.lblSHAChecksum.Text = "????????????????????????????????????????";
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(630, 121);
            this.btnCompare.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(112, 35);
            this.btnCompare.TabIndex = 54;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            // 
            // lblSeed
            // 
            this.lblSeed.AutoSize = true;
            this.lblSeed.Location = new System.Drawing.Point(12, 229);
            this.lblSeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeed.Name = "lblSeed";
            this.lblSeed.Size = new System.Drawing.Size(47, 20);
            this.lblSeed.TabIndex = 57;
            this.lblSeed.Text = "Seed";
            // 
            // lblRequired
            // 
            this.lblRequired.AutoSize = true;
            this.lblRequired.Location = new System.Drawing.Point(8, 180);
            this.lblRequired.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRequired.Name = "lblRequired";
            this.lblRequired.Size = new System.Drawing.Size(74, 20);
            this.lblRequired.TabIndex = 58;
            this.lblRequired.Text = "Required";
            // 
            // lblReqChecksum
            // 
            this.lblReqChecksum.AutoSize = true;
            this.lblReqChecksum.Location = new System.Drawing.Point(163, 180);
            this.lblReqChecksum.Name = "lblReqChecksum";
            this.lblReqChecksum.Size = new System.Drawing.Size(353, 20);
            this.lblReqChecksum.TabIndex = 54;
            this.lblReqChecksum.Text = "b8a9e3023b92e0f4139428f6d7a9e0f9db70f60e";
            // 
            // txtSeed
            // 
            this.txtSeed.Location = new System.Drawing.Point(157, 223);
            this.txtSeed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSeed.Name = "txtSeed";
            this.txtSeed.Size = new System.Drawing.Size(148, 26);
            this.txtSeed.TabIndex = 60;
            // 
            // btnNewSeed
            // 
            this.btnNewSeed.Location = new System.Drawing.Point(320, 219);
            this.btnNewSeed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNewSeed.Name = "btnNewSeed";
            this.btnNewSeed.Size = new System.Drawing.Size(129, 35);
            this.btnNewSeed.TabIndex = 61;
            this.btnNewSeed.Text = "New Seed";
            this.btnNewSeed.UseVisualStyleBackColor = true;
            this.btnNewSeed.Click += new System.EventHandler(this.BtnNewSeed_Click);
            // 
            // cmdRandomize
            // 
            this.cmdRandomize.Location = new System.Drawing.Point(584, 214);
            this.cmdRandomize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdRandomize.Name = "cmdRandomize";
            this.cmdRandomize.Size = new System.Drawing.Size(144, 35);
            this.cmdRandomize.TabIndex = 85;
            this.cmdRandomize.Text = "Randomise";
            this.cmdRandomize.UseVisualStyleBackColor = true;
            this.cmdRandomize.Click += new System.EventHandler(this.CmdRandomise_Click);
            // 
            // lblFlags
            // 
            this.lblFlags.AutoSize = true;
            this.lblFlags.Location = new System.Drawing.Point(365, 279);
            this.lblFlags.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFlags.Name = "lblFlags";
            this.lblFlags.Size = new System.Drawing.Size(48, 20);
            this.lblFlags.TabIndex = 86;
            this.lblFlags.Text = "Flags";
            // 
            // txtFlags
            // 
            this.txtFlags.Location = new System.Drawing.Point(444, 279);
            this.txtFlags.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFlags.Name = "txtFlags";
            this.txtFlags.Size = new System.Drawing.Size(298, 26);
            this.txtFlags.TabIndex = 57;
            this.txtFlags.Leave += new System.EventHandler(this.DetermineChecks);
            // 
            // chkTreasures
            // 
            this.chkTreasures.AutoSize = true;
            this.chkTreasures.Location = new System.Drawing.Point(28, 281);
            this.chkTreasures.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkTreasures.Name = "chkTreasures";
            this.chkTreasures.Size = new System.Drawing.Size(191, 24);
            this.chkTreasures.TabIndex = 88;
            this.chkTreasures.Text = "Randomize Treasures";
            this.chkTreasures.UseVisualStyleBackColor = true;
            this.chkTreasures.CheckedChanged += new System.EventHandler(this.DetermineFlags);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(10, 384);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(51, 20);
            this.lblStatus.TabIndex = 80;
            this.lblStatus.Text = "label5";
            // 
            // BreathofFireRando
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 364);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.chkTreasures);
            this.Controls.Add(this.txtFlags);
            this.Controls.Add(this.lblFlags);
            this.Controls.Add(this.cmdRandomize);
            this.Controls.Add(this.btnNewSeed);
            this.Controls.Add(this.txtSeed);
            this.Controls.Add(this.lblReqChecksum);
            this.Controls.Add(this.lblRequired);
            this.Controls.Add(this.lblSeed);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.lblSHAChecksum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCompare);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.BtnBrowse);
            this.Name = "BreathofFireRando";
            this.Text = "Breath of Fire Randomiser";
            this.Load += new System.EventHandler(this.BreathofFireRando_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnBrowse;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSHAChecksum;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Label lblSeed;
        private System.Windows.Forms.Label lblRequired;
        private System.Windows.Forms.Label lblReqChecksum;
        private System.Windows.Forms.TextBox txtSeed;
        private System.Windows.Forms.Button btnNewSeed;
        private System.Windows.Forms.Button cmdRandomize;
        private System.Windows.Forms.Label lblFlags;
        private System.Windows.Forms.TextBox txtFlags;
        private System.Windows.Forms.CheckBox chkTreasures;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtCompare;
    }
}


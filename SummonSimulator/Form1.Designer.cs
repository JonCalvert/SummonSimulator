namespace WindowsFormsApplication1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.NumberSummons = new System.Windows.Forms.TextBox();
            this.Summon = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.Label();
            this.Stats = new System.Windows.Forms.Label();
            this.FiveStars = new System.Windows.Forms.Label();
            this.NumSums = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.WantedMon = new System.Windows.Forms.TextBox();
            this.panelMassSummon = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelSummonType = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSingleSummon = new System.Windows.Forms.Button();
            this.btnMassSummon = new System.Windows.Forms.Button();
            this.panelSingleSummon = new System.Windows.Forms.Panel();
            this.lblSingleSummonRes = new System.Windows.Forms.Label();
            this.btnSingle = new System.Windows.Forms.Button();
            this.btnExit2 = new System.Windows.Forms.Button();
            this.picSummonedMon = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cntThrees = new System.Windows.Forms.Label();
            this.cntFours = new System.Windows.Forms.Label();
            this.cntFives = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblnumSums = new System.Windows.Forms.Label();
            this.panelPrevSums = new System.Windows.Forms.Panel();
            this.pbSumm = new System.Windows.Forms.Panel();
            this.panelMassSummon.SuspendLayout();
            this.panelSummonType.SuspendLayout();
            this.panelSingleSummon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSummonedMon)).BeginInit();
            this.SuspendLayout();
            // 
            // NumberSummons
            // 
            this.NumberSummons.Location = new System.Drawing.Point(150, 99);
            this.NumberSummons.Name = "NumberSummons";
            this.NumberSummons.Size = new System.Drawing.Size(100, 20);
            this.NumberSummons.TabIndex = 0;
            // 
            // Summon
            // 
            this.Summon.Location = new System.Drawing.Point(150, 176);
            this.Summon.Name = "Summon";
            this.Summon.Size = new System.Drawing.Size(75, 23);
            this.Summon.TabIndex = 1;
            this.Summon.Text = "Summon!";
            this.Summon.UseVisualStyleBackColor = true;
            this.Summon.Click += new System.EventHandler(this.Summon_Click);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(15, 211);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(0, 13);
            this.Result.TabIndex = 2;
            // 
            // Stats
            // 
            this.Stats.AutoSize = true;
            this.Stats.Location = new System.Drawing.Point(285, 106);
            this.Stats.Name = "Stats";
            this.Stats.Size = new System.Drawing.Size(0, 13);
            this.Stats.TabIndex = 3;
            // 
            // FiveStars
            // 
            this.FiveStars.AutoSize = true;
            this.FiveStars.Location = new System.Drawing.Point(285, 176);
            this.FiveStars.MaximumSize = new System.Drawing.Size(350, 0);
            this.FiveStars.Name = "FiveStars";
            this.FiveStars.Size = new System.Drawing.Size(0, 13);
            this.FiveStars.TabIndex = 4;
            this.FiveStars.Visible = false;
            // 
            // NumSums
            // 
            this.NumSums.AutoSize = true;
            this.NumSums.Location = new System.Drawing.Point(38, 102);
            this.NumSums.Name = "NumSums";
            this.NumSums.Size = new System.Drawing.Size(106, 13);
            this.NumSums.TabIndex = 5;
            this.NumSums.Text = "Number of summons:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Desired Monster";
            // 
            // WantedMon
            // 
            this.WantedMon.Location = new System.Drawing.Point(150, 134);
            this.WantedMon.Name = "WantedMon";
            this.WantedMon.Size = new System.Drawing.Size(100, 20);
            this.WantedMon.TabIndex = 7;
            // 
            // panelMassSummon
            // 
            this.panelMassSummon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMassSummon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMassSummon.Controls.Add(this.panelPrevSums);
            this.panelMassSummon.Controls.Add(this.btnExit);
            this.panelMassSummon.Controls.Add(this.NumSums);
            this.panelMassSummon.Controls.Add(this.Result);
            this.panelMassSummon.Controls.Add(this.FiveStars);
            this.panelMassSummon.Controls.Add(this.WantedMon);
            this.panelMassSummon.Controls.Add(this.Stats);
            this.panelMassSummon.Controls.Add(this.NumberSummons);
            this.panelMassSummon.Controls.Add(this.label1);
            this.panelMassSummon.Controls.Add(this.Summon);
            this.panelMassSummon.Location = new System.Drawing.Point(37, 50);
            this.panelMassSummon.Name = "panelMassSummon";
            this.panelMassSummon.Size = new System.Drawing.Size(664, 365);
            this.panelMassSummon.TabIndex = 8;
            this.panelMassSummon.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(557, 323);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelSummonType
            // 
            this.panelSummonType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSummonType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSummonType.Controls.Add(this.label2);
            this.panelSummonType.Controls.Add(this.btnSingleSummon);
            this.panelSummonType.Controls.Add(this.btnMassSummon);
            this.panelSummonType.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelSummonType.Location = new System.Drawing.Point(39, 50);
            this.panelSummonType.Name = "panelSummonType";
            this.panelSummonType.Size = new System.Drawing.Size(662, 365);
            this.panelSummonType.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Calligraphy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(99, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(462, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "How would you like to summon?";
            // 
            // btnSingleSummon
            // 
            this.btnSingleSummon.Location = new System.Drawing.Point(251, 239);
            this.btnSingleSummon.Name = "btnSingleSummon";
            this.btnSingleSummon.Size = new System.Drawing.Size(156, 65);
            this.btnSingleSummon.TabIndex = 1;
            this.btnSingleSummon.Text = "Normal Summon";
            this.btnSingleSummon.UseVisualStyleBackColor = true;
            this.btnSingleSummon.Click += new System.EventHandler(this.btnSingleSummon_Click);
            // 
            // btnMassSummon
            // 
            this.btnMassSummon.Location = new System.Drawing.Point(251, 143);
            this.btnMassSummon.Name = "btnMassSummon";
            this.btnMassSummon.Size = new System.Drawing.Size(156, 65);
            this.btnMassSummon.TabIndex = 0;
            this.btnMassSummon.Text = "Mass Summon";
            this.btnMassSummon.UseVisualStyleBackColor = true;
            this.btnMassSummon.Click += new System.EventHandler(this.btnMassSummon_Click);
            // 
            // panelSingleSummon
            // 
            this.panelSingleSummon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSingleSummon.AutoSize = true;
            this.panelSingleSummon.Controls.Add(this.picSummonedMon);
            this.panelSingleSummon.Controls.Add(this.pbSumm);
            this.panelSingleSummon.Controls.Add(this.lblnumSums);
            this.panelSingleSummon.Controls.Add(this.label9);
            this.panelSingleSummon.Controls.Add(this.cntFives);
            this.panelSingleSummon.Controls.Add(this.cntFours);
            this.panelSingleSummon.Controls.Add(this.cntThrees);
            this.panelSingleSummon.Controls.Add(this.label5);
            this.panelSingleSummon.Controls.Add(this.label4);
            this.panelSingleSummon.Controls.Add(this.label3);
            this.panelSingleSummon.Controls.Add(this.btnExit2);
            this.panelSingleSummon.Controls.Add(this.lblSingleSummonRes);
            this.panelSingleSummon.Controls.Add(this.btnSingle);
            this.panelSingleSummon.Location = new System.Drawing.Point(37, 50);
            this.panelSingleSummon.Name = "panelSingleSummon";
            this.panelSingleSummon.Size = new System.Drawing.Size(664, 366);
            this.panelSingleSummon.TabIndex = 10;
            this.panelSingleSummon.Visible = false;
            // 
            // lblSingleSummonRes
            // 
            this.lblSingleSummonRes.AutoSize = true;
            this.lblSingleSummonRes.Location = new System.Drawing.Point(285, 23);
            this.lblSingleSummonRes.Name = "lblSingleSummonRes";
            this.lblSingleSummonRes.Size = new System.Drawing.Size(0, 13);
            this.lblSingleSummonRes.TabIndex = 1;
            // 
            // btnSingle
            // 
            this.btnSingle.Location = new System.Drawing.Point(220, 298);
            this.btnSingle.Name = "btnSingle";
            this.btnSingle.Size = new System.Drawing.Size(89, 36);
            this.btnSingle.TabIndex = 0;
            this.btnSingle.Text = "Summon!";
            this.btnSingle.UseVisualStyleBackColor = true;
            this.btnSingle.Click += new System.EventHandler(this.btnSingle_Click);
            // 
            // btnExit2
            // 
            this.btnExit2.Location = new System.Drawing.Point(342, 298);
            this.btnExit2.Name = "btnExit2";
            this.btnExit2.Size = new System.Drawing.Size(91, 36);
            this.btnExit2.TabIndex = 2;
            this.btnExit2.Text = "Exit";
            this.btnExit2.UseVisualStyleBackColor = true;
            this.btnExit2.Click += new System.EventHandler(this.btnExit2_Click);
            // 
            // picSummonedMon
            // 
            this.picSummonedMon.Location = new System.Drawing.Point(220, 43);
            this.picSummonedMon.MaximumSize = new System.Drawing.Size(213, 240);
            this.picSummonedMon.Name = "picSummonedMon";
            this.picSummonedMon.Size = new System.Drawing.Size(213, 240);
            this.picSummonedMon.TabIndex = 3;
            this.picSummonedMon.TabStop = false;
            this.picSummonedMon.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(480, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "***";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(480, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "****";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(480, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "*****";
            // 
            // cntThrees
            // 
            this.cntThrees.AutoSize = true;
            this.cntThrees.Location = new System.Drawing.Point(529, 39);
            this.cntThrees.Name = "cntThrees";
            this.cntThrees.Size = new System.Drawing.Size(0, 13);
            this.cntThrees.TabIndex = 7;
            // 
            // cntFours
            // 
            this.cntFours.AutoSize = true;
            this.cntFours.Location = new System.Drawing.Point(529, 73);
            this.cntFours.Name = "cntFours";
            this.cntFours.Size = new System.Drawing.Size(0, 13);
            this.cntFours.TabIndex = 8;
            // 
            // cntFives
            // 
            this.cntFives.AutoSize = true;
            this.cntFives.Location = new System.Drawing.Point(529, 107);
            this.cntFives.Name = "cntFives";
            this.cntFives.Size = new System.Drawing.Size(0, 13);
            this.cntFives.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Number of summons:";
            // 
            // lblnumSums
            // 
            this.lblnumSums.AutoSize = true;
            this.lblnumSums.Location = new System.Drawing.Point(144, 39);
            this.lblnumSums.Name = "lblnumSums";
            this.lblnumSums.Size = new System.Drawing.Size(0, 13);
            this.lblnumSums.TabIndex = 11;
            // 
            // panelPrevSums
            // 
            this.panelPrevSums.AutoScroll = true;
            this.panelPrevSums.AutoSize = true;
            this.panelPrevSums.Location = new System.Drawing.Point(41, 215);
            this.panelPrevSums.MaximumSize = new System.Drawing.Size(583, 0);
            this.panelPrevSums.MinimumSize = new System.Drawing.Size(583, 90);
            this.panelPrevSums.Name = "panelPrevSums";
            this.panelPrevSums.Size = new System.Drawing.Size(583, 90);
            this.panelPrevSums.TabIndex = 9;
            // 
            // pbSumm
            // 
            this.pbSumm.Location = new System.Drawing.Point(220, 43);
            this.pbSumm.Name = "pbSumm";
            this.pbSumm.Size = new System.Drawing.Size(213, 240);
            this.pbSumm.TabIndex = 12;
            this.pbSumm.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(761, 473);
            this.Controls.Add(this.panelSingleSummon);
            this.Controls.Add(this.panelMassSummon);
            this.Controls.Add(this.panelSummonType);
            this.Name = "Form1";
            this.Text = "Summoning Simulator";
            this.panelMassSummon.ResumeLayout(false);
            this.panelMassSummon.PerformLayout();
            this.panelSummonType.ResumeLayout(false);
            this.panelSummonType.PerformLayout();
            this.panelSingleSummon.ResumeLayout(false);
            this.panelSingleSummon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSummonedMon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NumberSummons;
        private System.Windows.Forms.Button Summon;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Label Stats;
        private System.Windows.Forms.Label FiveStars;
        private System.Windows.Forms.Label NumSums;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox WantedMon;
        private System.Windows.Forms.Panel panelMassSummon;
        private System.Windows.Forms.Panel panelSummonType;
        private System.Windows.Forms.Button btnSingleSummon;
        private System.Windows.Forms.Button btnMassSummon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelSingleSummon;
        private System.Windows.Forms.Label lblSingleSummonRes;
        private System.Windows.Forms.Button btnSingle;
        private System.Windows.Forms.Button btnExit2;
        private System.Windows.Forms.PictureBox picSummonedMon;
        private System.Windows.Forms.Label lblnumSums;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label cntFives;
        private System.Windows.Forms.Label cntFours;
        private System.Windows.Forms.Label cntThrees;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelPrevSums;
        private System.Windows.Forms.Panel pbSumm;
    }
}


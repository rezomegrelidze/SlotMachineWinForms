namespace SlotMachineWinForms
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
            this.slot1Pbox = new System.Windows.Forms.PictureBox();
            this.slot2Pbox = new System.Windows.Forms.PictureBox();
            this.slot3Pbox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.playerCreditLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bettingAmountTxt = new System.Windows.Forms.TextBox();
            this.SpinBtn = new System.Windows.Forms.Button();
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            ((System.ComponentModel.ISupportInitialize)(this.slot1Pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot2Pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot3Pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            this.SuspendLayout();
            // 
            // slot1Pbox
            // 
            this.slot1Pbox.Location = new System.Drawing.Point(43, 58);
            this.slot1Pbox.Name = "slot1Pbox";
            this.slot1Pbox.Size = new System.Drawing.Size(100, 100);
            this.slot1Pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.slot1Pbox.TabIndex = 0;
            this.slot1Pbox.TabStop = false;
            // 
            // slot2Pbox
            // 
            this.slot2Pbox.Location = new System.Drawing.Point(152, 58);
            this.slot2Pbox.Name = "slot2Pbox";
            this.slot2Pbox.Size = new System.Drawing.Size(100, 100);
            this.slot2Pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.slot2Pbox.TabIndex = 1;
            this.slot2Pbox.TabStop = false;
            // 
            // slot3Pbox
            // 
            this.slot3Pbox.Location = new System.Drawing.Point(258, 58);
            this.slot3Pbox.Name = "slot3Pbox";
            this.slot3Pbox.Size = new System.Drawing.Size(100, 100);
            this.slot3Pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.slot3Pbox.TabIndex = 2;
            this.slot3Pbox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(433, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Player Credit:";
            // 
            // playerCreditLbl
            // 
            this.playerCreditLbl.AutoSize = true;
            this.playerCreditLbl.Location = new System.Drawing.Point(502, 73);
            this.playerCreditLbl.Name = "playerCreditLbl";
            this.playerCreditLbl.Size = new System.Drawing.Size(0, 13);
            this.playerCreditLbl.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(432, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Betting amount:";
            // 
            // bettingAmountTxt
            // 
            this.bettingAmountTxt.Location = new System.Drawing.Point(519, 110);
            this.bettingAmountTxt.Name = "bettingAmountTxt";
            this.bettingAmountTxt.Size = new System.Drawing.Size(61, 20);
            this.bettingAmountTxt.TabIndex = 6;
            // 
            // SpinBtn
            // 
            this.SpinBtn.Location = new System.Drawing.Point(435, 152);
            this.SpinBtn.Name = "SpinBtn";
            this.SpinBtn.Size = new System.Drawing.Size(75, 23);
            this.SpinBtn.TabIndex = 7;
            this.SpinBtn.Text = "Spin";
            this.SpinBtn.UseVisualStyleBackColor = true;
            this.SpinBtn.Click += new System.EventHandler(this.SpinBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 242);
            this.Controls.Add(this.SpinBtn);
            this.Controls.Add(this.bettingAmountTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.playerCreditLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.slot3Pbox);
            this.Controls.Add(this.slot2Pbox);
            this.Controls.Add(this.slot1Pbox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.slot1Pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot2Pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot3Pbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox slot1Pbox;
        private System.Windows.Forms.PictureBox slot2Pbox;
        private System.Windows.Forms.PictureBox slot3Pbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label playerCreditLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bettingAmountTxt;
        private System.Windows.Forms.Button SpinBtn;
        private System.Diagnostics.PerformanceCounter performanceCounter1;
    }
}


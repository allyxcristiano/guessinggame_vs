namespace GuessingGame
{
    partial class WhatTheAnimalTrait
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
            this.lQuestion = new System.Windows.Forms.Label();
            this.tbAnimalTrait = new System.Windows.Forms.TextBox();
            this.bOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lQuestion
            // 
            this.lQuestion.AutoSize = true;
            this.lQuestion.Location = new System.Drawing.Point(11, 11);
            this.lQuestion.Name = "lQuestion";
            this.lQuestion.Size = new System.Drawing.Size(400, 13);
            this.lQuestion.TabIndex = 5;
            this.lQuestion.Text = "A {0} __________ but a {1} does not (Fill it with an animal trait, like \"lives in" +
    " water\").";
            // 
            // tbAnimalTrait
            // 
            this.tbAnimalTrait.Location = new System.Drawing.Point(11, 27);
            this.tbAnimalTrait.Name = "tbAnimalTrait";
            this.tbAnimalTrait.Size = new System.Drawing.Size(544, 20);
            this.tbAnimalTrait.TabIndex = 4;
            this.tbAnimalTrait.Enter += new System.EventHandler(this.tbAnimalTrait_Enter);
            // 
            // bOK
            // 
            this.bOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bOK.Location = new System.Drawing.Point(480, 53);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(75, 23);
            this.bOK.TabIndex = 3;
            this.bOK.Text = "OK";
            this.bOK.UseVisualStyleBackColor = true;
            this.bOK.Click += new System.EventHandler(this.bOK_Click);
            // 
            // WhatTheAnimalTrait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 86);
            this.Controls.Add(this.lQuestion);
            this.Controls.Add(this.tbAnimalTrait);
            this.Controls.Add(this.bOK);
            this.Name = "WhatTheAnimalTrait";
            this.Text = "Guessing Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lQuestion;
        private System.Windows.Forms.TextBox tbAnimalTrait;
        private System.Windows.Forms.Button bOK;
    }
}
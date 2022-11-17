
namespace Bid501Client
{
    partial class Bid501Form
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
            this.uxProductNameLabel = new System.Windows.Forms.Label();
            this.uxTimeRemainingLabel = new System.Windows.Forms.Label();
            this.uxProductStatusLabel = new System.Windows.Forms.Label();
            this.uxStatusColorLabel = new System.Windows.Forms.Label();
            this.uxBidTextBox = new System.Windows.Forms.TextBox();
            this.uxTotalBidsLabel = new System.Windows.Forms.Label();
            this.uxMinimumBidLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxProductNameLabel
            // 
            this.uxProductNameLabel.AutoSize = true;
            this.uxProductNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uxProductNameLabel.Location = new System.Drawing.Point(26, 31);
            this.uxProductNameLabel.MinimumSize = new System.Drawing.Size(300, 20);
            this.uxProductNameLabel.Name = "uxProductNameLabel";
            this.uxProductNameLabel.Size = new System.Drawing.Size(300, 20);
            this.uxProductNameLabel.TabIndex = 0;
            // 
            // uxTimeRemainingLabel
            // 
            this.uxTimeRemainingLabel.AutoSize = true;
            this.uxTimeRemainingLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uxTimeRemainingLabel.Location = new System.Drawing.Point(26, 73);
            this.uxTimeRemainingLabel.MinimumSize = new System.Drawing.Size(300, 20);
            this.uxTimeRemainingLabel.Name = "uxTimeRemainingLabel";
            this.uxTimeRemainingLabel.Size = new System.Drawing.Size(300, 20);
            this.uxTimeRemainingLabel.TabIndex = 1;
            this.uxTimeRemainingLabel.Click += new System.EventHandler(this.uxTimeRemaining_Click);
            // 
            // uxProductStatusLabel
            // 
            this.uxProductStatusLabel.AutoSize = true;
            this.uxProductStatusLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uxProductStatusLabel.Location = new System.Drawing.Point(26, 114);
            this.uxProductStatusLabel.MinimumSize = new System.Drawing.Size(200, 20);
            this.uxProductStatusLabel.Name = "uxProductStatusLabel";
            this.uxProductStatusLabel.Size = new System.Drawing.Size(200, 20);
            this.uxProductStatusLabel.TabIndex = 2;
            // 
            // uxStatusColorLabel
            // 
            this.uxStatusColorLabel.AutoSize = true;
            this.uxStatusColorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uxStatusColorLabel.Location = new System.Drawing.Point(276, 114);
            this.uxStatusColorLabel.MinimumSize = new System.Drawing.Size(50, 20);
            this.uxStatusColorLabel.Name = "uxStatusColorLabel";
            this.uxStatusColorLabel.Size = new System.Drawing.Size(50, 20);
            this.uxStatusColorLabel.TabIndex = 3;
            // 
            // uxBidTextBox
            // 
            this.uxBidTextBox.Location = new System.Drawing.Point(26, 154);
            this.uxBidTextBox.Name = "uxBidTextBox";
            this.uxBidTextBox.Size = new System.Drawing.Size(200, 22);
            this.uxBidTextBox.TabIndex = 4;
            // 
            // uxTotalBidsLabel
            // 
            this.uxTotalBidsLabel.AutoSize = true;
            this.uxTotalBidsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uxTotalBidsLabel.Location = new System.Drawing.Point(251, 157);
            this.uxTotalBidsLabel.MinimumSize = new System.Drawing.Size(75, 20);
            this.uxTotalBidsLabel.Name = "uxTotalBidsLabel";
            this.uxTotalBidsLabel.Size = new System.Drawing.Size(75, 20);
            this.uxTotalBidsLabel.TabIndex = 5;
            // 
            // uxMinimumBidLabel
            // 
            this.uxMinimumBidLabel.AutoSize = true;
            this.uxMinimumBidLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uxMinimumBidLabel.Location = new System.Drawing.Point(26, 196);
            this.uxMinimumBidLabel.MinimumSize = new System.Drawing.Size(300, 20);
            this.uxMinimumBidLabel.Name = "uxMinimumBidLabel";
            this.uxMinimumBidLabel.Size = new System.Drawing.Size(300, 20);
            this.uxMinimumBidLabel.TabIndex = 6;
            this.uxMinimumBidLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Bid501Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uxMinimumBidLabel);
            this.Controls.Add(this.uxTotalBidsLabel);
            this.Controls.Add(this.uxBidTextBox);
            this.Controls.Add(this.uxStatusColorLabel);
            this.Controls.Add(this.uxProductStatusLabel);
            this.Controls.Add(this.uxTimeRemainingLabel);
            this.Controls.Add(this.uxProductNameLabel);
            this.Name = "Bid501Form";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxProductNameLabel;
        private System.Windows.Forms.Label uxTimeRemainingLabel;
        private System.Windows.Forms.Label uxProductStatusLabel;
        private System.Windows.Forms.Label uxStatusColorLabel;
        private System.Windows.Forms.TextBox uxBidTextBox;
        private System.Windows.Forms.Label uxTotalBidsLabel;
        private System.Windows.Forms.Label uxMinimumBidLabel;
    }
}


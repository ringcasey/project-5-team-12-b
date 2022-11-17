
namespace Bid501Server
{
    partial class ServerForm
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
            this.uxProductsListView = new System.Windows.Forms.ListView();
            this.uxClientsListView = new System.Windows.Forms.ListView();
            this.uxAddProductButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxProductsListView
            // 
            this.uxProductsListView.HideSelection = false;
            this.uxProductsListView.Location = new System.Drawing.Point(12, 12);
            this.uxProductsListView.Name = "uxProductsListView";
            this.uxProductsListView.Size = new System.Drawing.Size(200, 300);
            this.uxProductsListView.TabIndex = 0;
            this.uxProductsListView.UseCompatibleStateImageBehavior = false;
            // 
            // uxClientsListView
            // 
            this.uxClientsListView.HideSelection = false;
            this.uxClientsListView.Location = new System.Drawing.Point(228, 12);
            this.uxClientsListView.Name = "uxClientsListView";
            this.uxClientsListView.Size = new System.Drawing.Size(200, 300);
            this.uxClientsListView.TabIndex = 1;
            this.uxClientsListView.UseCompatibleStateImageBehavior = false;
            // 
            // uxAddProductButton
            // 
            this.uxAddProductButton.Location = new System.Drawing.Point(12, 330);
            this.uxAddProductButton.Name = "uxAddProductButton";
            this.uxAddProductButton.Size = new System.Drawing.Size(416, 61);
            this.uxAddProductButton.TabIndex = 2;
            this.uxAddProductButton.Text = "Add";
            this.uxAddProductButton.UseVisualStyleBackColor = true;
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 407);
            this.Controls.Add(this.uxAddProductButton);
            this.Controls.Add(this.uxClientsListView);
            this.Controls.Add(this.uxProductsListView);
            this.Name = "ServerForm";
            this.Text = "ServerForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView uxProductsListView;
        private System.Windows.Forms.ListView uxClientsListView;
        private System.Windows.Forms.Button uxAddProductButton;
    }
}


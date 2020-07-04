namespace Eks
{
    partial class FormChoice
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
            this.buttonManager = new System.Windows.Forms.Button();
            this.buttonBuyer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonManager
            // 
            this.buttonManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.buttonManager.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonManager.Location = new System.Drawing.Point(27, 130);
            this.buttonManager.Name = "buttonManager";
            this.buttonManager.Size = new System.Drawing.Size(151, 73);
            this.buttonManager.TabIndex = 0;
            this.buttonManager.Text = "Менеджер";
            this.buttonManager.UseVisualStyleBackColor = false;
            this.buttonManager.Click += new System.EventHandler(this.buttonManager_Click);
            // 
            // buttonBuyer
            // 
            this.buttonBuyer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.buttonBuyer.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBuyer.Location = new System.Drawing.Point(264, 130);
            this.buttonBuyer.Name = "buttonBuyer";
            this.buttonBuyer.Size = new System.Drawing.Size(151, 73);
            this.buttonBuyer.TabIndex = 1;
            this.buttonBuyer.Text = "Покупатель";
            this.buttonBuyer.UseVisualStyleBackColor = false;
            this.buttonBuyer.Click += new System.EventHandler(this.buttonBuyer_Click);
            // 
            // FormChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.ClientSize = new System.Drawing.Size(459, 353);
            this.Controls.Add(this.buttonBuyer);
            this.Controls.Add(this.buttonManager);
            this.Name = "FormChoice";
            this.Text = "FormChoice";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonManager;
        private System.Windows.Forms.Button buttonBuyer;
    }
}
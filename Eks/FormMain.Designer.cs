namespace Eks
{
    partial class FormMain
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
            this.buttonBuyer = new System.Windows.Forms.Button();
            this.buttonManagers = new System.Windows.Forms.Button();
            this.buttonAuto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBuyer
            // 
            this.buttonBuyer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.buttonBuyer.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBuyer.Location = new System.Drawing.Point(79, 62);
            this.buttonBuyer.Name = "buttonBuyer";
            this.buttonBuyer.Size = new System.Drawing.Size(121, 54);
            this.buttonBuyer.TabIndex = 0;
            this.buttonBuyer.Text = "Покупатели";
            this.buttonBuyer.UseVisualStyleBackColor = false;
            this.buttonBuyer.Click += new System.EventHandler(this.buttonBuyer_Click);
            // 
            // buttonManagers
            // 
            this.buttonManagers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.buttonManagers.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonManagers.Location = new System.Drawing.Point(275, 62);
            this.buttonManagers.Name = "buttonManagers";
            this.buttonManagers.Size = new System.Drawing.Size(121, 54);
            this.buttonManagers.TabIndex = 1;
            this.buttonManagers.Text = "Менеджеры";
            this.buttonManagers.UseVisualStyleBackColor = false;
            this.buttonManagers.Click += new System.EventHandler(this.buttonManagers_Click);
            // 
            // buttonAuto
            // 
            this.buttonAuto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.buttonAuto.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAuto.Location = new System.Drawing.Point(178, 164);
            this.buttonAuto.Name = "buttonAuto";
            this.buttonAuto.Size = new System.Drawing.Size(121, 54);
            this.buttonAuto.TabIndex = 2;
            this.buttonAuto.Text = "Автомобили";
            this.buttonAuto.UseVisualStyleBackColor = false;
            this.buttonAuto.Click += new System.EventHandler(this.buttonAuto_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.ClientSize = new System.Drawing.Size(516, 287);
            this.Controls.Add(this.buttonAuto);
            this.Controls.Add(this.buttonManagers);
            this.Controls.Add(this.buttonBuyer);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBuyer;
        private System.Windows.Forms.Button buttonManagers;
        private System.Windows.Forms.Button buttonAuto;
    }
}
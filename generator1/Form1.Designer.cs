namespace generator1
{
    partial class Generator
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnGenerateEmail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(100, 50);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(150, 23);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate Fingerprint";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnGenerateEmail
            // 
            this.btnGenerateEmail.Location = new System.Drawing.Point(100, 100);
            this.btnGenerateEmail.Name = "btnGenerateEmail";
            this.btnGenerateEmail.Size = new System.Drawing.Size(150, 23);
            this.btnGenerateEmail.TabIndex = 1;
            this.btnGenerateEmail.Text = "Generate Random Email";
            this.btnGenerateEmail.UseVisualStyleBackColor = true;
            this.btnGenerateEmail.Click += new System.EventHandler(this.btnGenerateEmail_Click);
            // 
            // Generator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnGenerateEmail);
            this.Controls.Add(this.btnGenerate);
            this.Name = "Generator";
            this.Text = "Fingerprint Generator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnGenerateEmail;
    }
}

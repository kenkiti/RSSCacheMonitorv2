namespace RSSCacheMonitor
{
    partial class Form2
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
            this.richRaw = new System.Windows.Forms.RichTextBox();
            this.lblRaw = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richRaw
            // 
            this.richRaw.BackColor = System.Drawing.Color.Black;
            this.richRaw.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richRaw.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.richRaw.Location = new System.Drawing.Point(0, 202);
            this.richRaw.Name = "richRaw";
            this.richRaw.Size = new System.Drawing.Size(525, 451);
            this.richRaw.TabIndex = 22;
            this.richRaw.Text = "";
            // 
            // lblRaw
            // 
            this.lblRaw.AutoSize = true;
            this.lblRaw.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblRaw.Location = new System.Drawing.Point(12, 187);
            this.lblRaw.Name = "lblRaw";
            this.lblRaw.Size = new System.Drawing.Size(311, 12);
            this.lblRaw.TabIndex = 23;
            this.lblRaw.Text = "No.     TIme     millisec tick     value       item";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 653);
            this.Controls.Add(this.lblRaw);
            this.Controls.Add(this.richRaw);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richRaw;
        private System.Windows.Forms.Label lblRaw;
    }
}
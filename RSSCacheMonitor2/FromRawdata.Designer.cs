namespace RSSCacheMonitor
{
    partial class FormRawdata
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
            this.components = new System.ComponentModel.Container();
            this.richRaw = new System.Windows.Forms.RichTextBox();
            this.lblRaw = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // richRaw
            // 
            this.richRaw.BackColor = System.Drawing.Color.Black;
            this.richRaw.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richRaw.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.richRaw.Location = new System.Drawing.Point(0, 61);
            this.richRaw.Name = "richRaw";
            this.richRaw.Size = new System.Drawing.Size(389, 582);
            this.richRaw.TabIndex = 23;
            this.richRaw.Text = "";
            // 
            // lblRaw
            // 
            this.lblRaw.AutoSize = true;
            this.lblRaw.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblRaw.Location = new System.Drawing.Point(-1, 42);
            this.lblRaw.Name = "lblRaw";
            this.lblRaw.Size = new System.Drawing.Size(311, 12);
            this.lblRaw.TabIndex = 22;
            this.lblRaw.Text = "No.     TIme     millisec tick     value       item";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(311, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "開始";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormRawdata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 643);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richRaw);
            this.Controls.Add(this.lblRaw);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FormRawdata";
            this.ShowIcon = false;
            this.Text = "生データビューア";
            this.Load += new System.EventHandler(this.FormRawdata_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richRaw;
        private System.Windows.Forms.Label lblRaw;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}
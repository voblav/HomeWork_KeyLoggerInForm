namespace KeyLoggerInForm
{
    partial class MainForm2
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
            this.TimerKL = new System.Windows.Forms.Timer(this.components);
            this.LinkOnTxt = new System.Windows.Forms.LinkLabel();
            this.LabelTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TimerKL
            // 
            this.TimerKL.Enabled = true;
            this.TimerKL.Tick += new System.EventHandler(this.TimerKL_Tick);
            // 
            // LinkOnTxt
            // 
            this.LinkOnTxt.AutoSize = true;
            this.LinkOnTxt.Location = new System.Drawing.Point(29, 104);
            this.LinkOnTxt.Name = "LinkOnTxt";
            this.LinkOnTxt.Size = new System.Drawing.Size(23, 13);
            this.LinkOnTxt.TabIndex = 0;
            this.LinkOnTxt.TabStop = true;
            this.LinkOnTxt.Text = "link";
            // 
            // LabelTxt
            // 
            this.LabelTxt.AutoSize = true;
            this.LabelTxt.Location = new System.Drawing.Point(29, 80);
            this.LabelTxt.Name = "LabelTxt";
            this.LabelTxt.Size = new System.Drawing.Size(49, 13);
            this.LabelTxt.TabIndex = 1;
            this.LabelTxt.Text = "blablabla";
            // 
            // MainForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.LabelTxt);
            this.Controls.Add(this.LinkOnTxt);
            this.Name = "MainForm2";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer TimerKL;
        private System.Windows.Forms.LinkLabel LinkOnTxt;
        private System.Windows.Forms.Label LabelTxt;
    }
}
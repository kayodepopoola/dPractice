namespace dPractice
{
    partial class frmMain
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
            this.mnu = new System.Windows.Forms.MenuStrip();
            this.tbr = new System.Windows.Forms.ToolStrip();
            this.sbr = new System.Windows.Forms.StatusStrip();
            this.SuspendLayout();
            // 
            // mnu
            // 
            this.mnu.Location = new System.Drawing.Point(0, 0);
            this.mnu.Name = "mnu";
            this.mnu.Size = new System.Drawing.Size(848, 24);
            this.mnu.TabIndex = 0;
            this.mnu.Text = "menuStrip1";
            // 
            // tbr
            // 
            this.tbr.Location = new System.Drawing.Point(0, 24);
            this.tbr.Name = "tbr";
            this.tbr.Size = new System.Drawing.Size(848, 25);
            this.tbr.TabIndex = 1;
            this.tbr.Text = "toolStrip1";
            // 
            // sbr
            // 
            this.sbr.Location = new System.Drawing.Point(0, 443);
            this.sbr.Name = "sbr";
            this.sbr.Size = new System.Drawing.Size(848, 22);
            this.sbr.TabIndex = 2;
            this.sbr.Text = "statusStrip1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 465);
            this.Controls.Add(this.sbr);
            this.Controls.Add(this.tbr);
            this.Controls.Add(this.mnu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.mnu;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Practice App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnu;
        private System.Windows.Forms.ToolStrip tbr;
        private System.Windows.Forms.StatusStrip sbr;
    }
}


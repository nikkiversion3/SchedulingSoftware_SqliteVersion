﻿namespace SchedulingSoftware
{
    partial class weekbar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.apptpanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(166, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "00";
            // 
            // apptpanel
            // 
            this.apptpanel.AutoScroll = true;
            this.apptpanel.Location = new System.Drawing.Point(3, 79);
            this.apptpanel.Name = "apptpanel";
            this.apptpanel.Size = new System.Drawing.Size(228, 941);
            this.apptpanel.TabIndex = 1;
            // 
            // weekbar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.apptpanel);
            this.Controls.Add(this.label1);
            this.Name = "weekbar";
            this.Size = new System.Drawing.Size(234, 1038);
            this.Load += new System.EventHandler(this.weekbar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel apptpanel;
    }
}

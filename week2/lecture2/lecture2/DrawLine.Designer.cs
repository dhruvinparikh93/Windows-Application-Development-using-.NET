﻿namespace lecture2
{
    partial class DrawLine
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
            this.SuspendLayout();
            // 
            // DrawLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "DrawLine";
            this.Text = "DrawLine";
            this.Load += new System.EventHandler(this.DrawLine_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.drawLine_Mouse_Click);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawLine_Mouse_Down);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawLine_Mouse_Up);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
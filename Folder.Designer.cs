﻿namespace SEnPA
{
    partial class Folder
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
            this.lblText = new System.Windows.Forms.Label();
            this.folderPic = new System.Windows.Forms.PictureBox();
            this.lblId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.folderPic)).BeginInit();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(0, 56);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(110, 38);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "...";
            this.lblText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // folderPic
            // 
            this.folderPic.Image = global::SEnPA.Properties.Resources.folders;
            this.folderPic.Location = new System.Drawing.Point(36, 3);
            this.folderPic.Name = "folderPic";
            this.folderPic.Size = new System.Drawing.Size(50, 50);
            this.folderPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.folderPic.TabIndex = 0;
            this.folderPic.TabStop = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(92, 3);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(13, 13);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "1";
            this.lblId.Visible = false;
            // 
            // Folder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.folderPic);
            this.Name = "Folder";
            this.Size = new System.Drawing.Size(110, 94);
            ((System.ComponentModel.ISupportInitialize)(this.folderPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox folderPic;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblId;
    }
}
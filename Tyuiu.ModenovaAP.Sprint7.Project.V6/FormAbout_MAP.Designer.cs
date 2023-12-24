namespace Tyuiu.ModenovaAP.Sprint7.Project.V6
{
    partial class FormAbout_MAP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout_MAP));
            this.buttonOK_MAP = new System.Windows.Forms.Button();
            this.pictureBoxAvatar_MAP = new System.Windows.Forms.PictureBox();
            this.labelInfo_MAP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_MAP)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOK_MAP
            // 
            this.buttonOK_MAP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.buttonOK_MAP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.buttonOK_MAP.Location = new System.Drawing.Point(331, 157);
            this.buttonOK_MAP.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOK_MAP.Name = "buttonOK_MAP";
            this.buttonOK_MAP.Size = new System.Drawing.Size(112, 32);
            this.buttonOK_MAP.TabIndex = 11;
            this.buttonOK_MAP.Text = "Ок";
            this.buttonOK_MAP.UseVisualStyleBackColor = false;
            // 
            // pictureBoxAvatar_MAP
            // 
            this.pictureBoxAvatar_MAP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxAvatar_MAP.InitialImage = null;
            this.pictureBoxAvatar_MAP.Location = new System.Drawing.Point(13, 13);
            this.pictureBoxAvatar_MAP.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxAvatar_MAP.Name = "pictureBoxAvatar_MAP";
            this.pictureBoxAvatar_MAP.Size = new System.Drawing.Size(118, 176);
            this.pictureBoxAvatar_MAP.TabIndex = 10;
            this.pictureBoxAvatar_MAP.TabStop = false;
            // 
            // labelInfo_MAP
            // 
            this.labelInfo_MAP.AutoSize = true;
            this.labelInfo_MAP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.labelInfo_MAP.Location = new System.Drawing.Point(159, 13);
            this.labelInfo_MAP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInfo_MAP.Name = "labelInfo_MAP";
            this.labelInfo_MAP.Size = new System.Drawing.Size(284, 130);
            this.labelInfo_MAP.TabIndex = 9;
            this.labelInfo_MAP.Text = resources.GetString("labelInfo_MAP.Text");
            // 
            // FormAbout_MAP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(471, 204);
            this.Controls.Add(this.buttonOK_MAP);
            this.Controls.Add(this.pictureBoxAvatar_MAP);
            this.Controls.Add(this.labelInfo_MAP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout_MAP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_MAP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK_MAP;
        private System.Windows.Forms.PictureBox pictureBoxAvatar_MAP;
        private System.Windows.Forms.Label labelInfo_MAP;
    }
}
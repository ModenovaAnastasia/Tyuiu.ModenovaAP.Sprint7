namespace Tyuiu.ModenovaAP.Sprint7.Project.V6
{
    partial class FormGuide_MAP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGuide_MAP));
            this.pictureBoxManual_MAP = new System.Windows.Forms.PictureBox();
            this.buttonPrev_MAP = new System.Windows.Forms.Button();
            this.buttonNext_MAP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxManual_MAP)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxManual_MAP
            // 
            this.pictureBoxManual_MAP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxManual_MAP.BackgroundImage")));
            this.pictureBoxManual_MAP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxManual_MAP.Location = new System.Drawing.Point(93, -2);
            this.pictureBoxManual_MAP.Name = "pictureBoxManual_MAP";
            this.pictureBoxManual_MAP.Size = new System.Drawing.Size(900, 571);
            this.pictureBoxManual_MAP.TabIndex = 0;
            this.pictureBoxManual_MAP.TabStop = false;
            // 
            // buttonPrev_MAP
            // 
            this.buttonPrev_MAP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.buttonPrev_MAP.Enabled = false;
            this.buttonPrev_MAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPrev_MAP.Location = new System.Drawing.Point(12, 261);
            this.buttonPrev_MAP.Name = "buttonPrev_MAP";
            this.buttonPrev_MAP.Size = new System.Drawing.Size(75, 65);
            this.buttonPrev_MAP.TabIndex = 1;
            this.buttonPrev_MAP.Text = "<";
            this.buttonPrev_MAP.UseVisualStyleBackColor = false;
            this.buttonPrev_MAP.Click += new System.EventHandler(this.buttonPrev_MAP_Click);
            // 
            // buttonNext_MAP
            // 
            this.buttonNext_MAP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.buttonNext_MAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNext_MAP.Location = new System.Drawing.Point(999, 261);
            this.buttonNext_MAP.Name = "buttonNext_MAP";
            this.buttonNext_MAP.Size = new System.Drawing.Size(75, 65);
            this.buttonNext_MAP.TabIndex = 2;
            this.buttonNext_MAP.Text = ">";
            this.buttonNext_MAP.UseVisualStyleBackColor = false;
            this.buttonNext_MAP.Click += new System.EventHandler(this.buttonNext_MAP_Click);
            // 
            // FormGuide_MAP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1086, 573);
            this.Controls.Add(this.buttonNext_MAP);
            this.Controls.Add(this.buttonPrev_MAP);
            this.Controls.Add(this.pictureBoxManual_MAP);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGuide_MAP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Руководство пользователя";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxManual_MAP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxManual_MAP;
        private System.Windows.Forms.Button buttonPrev_MAP;
        private System.Windows.Forms.Button buttonNext_MAP;
    }
}
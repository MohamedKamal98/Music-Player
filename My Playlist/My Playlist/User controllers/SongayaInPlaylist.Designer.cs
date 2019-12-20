namespace My_Playlist.User_controllers
{
    partial class SongayaInPlaylist
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SongayaInPlaylist));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RemoveBT = new CustomImageButton.ImageButtonCustom();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RemoveBT)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(36, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Song name";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RemoveBT);
            this.panel1.Location = new System.Drawing.Point(451, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 28);
            this.panel1.TabIndex = 14;
            // 
            // RemoveBT
            // 
            this.RemoveBT.Image = ((System.Drawing.Image)(resources.GetObject("RemoveBT.Image")));
            this.RemoveBT.ImageHover = ((System.Drawing.Image)(resources.GetObject("RemoveBT.ImageHover")));
            this.RemoveBT.ImageNormal = ((System.Drawing.Image)(resources.GetObject("RemoveBT.ImageNormal")));
            this.RemoveBT.Location = new System.Drawing.Point(75, 2);
            this.RemoveBT.Name = "RemoveBT";
            this.RemoveBT.Size = new System.Drawing.Size(25, 25);
            this.RemoveBT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RemoveBT.TabIndex = 15;
            this.RemoveBT.TabStop = false;
            this.RemoveBT.Click += new System.EventHandler(this.RemoveBT_Click);
            this.RemoveBT.MouseHover += new System.EventHandler(this.RemoveBT_MouseHover);
            // 
            // SongayaInPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "SongayaInPlaylist";
            this.Load += new System.EventHandler(this.SongayaInPlaylist_Load);
            this.Controls.SetChildIndex(this.songnamelbl, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RemoveBT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private CustomImageButton.ImageButtonCustom RemoveBT;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

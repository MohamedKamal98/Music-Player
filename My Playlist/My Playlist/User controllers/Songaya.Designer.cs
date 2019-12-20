namespace My_Playlist.User_controllers
{
    partial class Songaya
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Songaya));
            this.songnamelbl = new System.Windows.Forms.Label();
            this.PlayBT = new CustomImageButton.ImageButtonCustom();
            this.AddToPlaylistBT = new CustomImageButton.ImageButtonCustom();
            this.RenameBT = new CustomImageButton.ImageButtonCustom();
            this.DeleteBT = new CustomImageButton.ImageButtonCustom();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PlayBT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddToPlaylistBT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RenameBT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteBT)).BeginInit();
            this.SuspendLayout();
            // 
            // songnamelbl
            // 
            this.songnamelbl.AutoSize = true;
            this.songnamelbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songnamelbl.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.songnamelbl.Location = new System.Drawing.Point(37, 10);
            this.songnamelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.songnamelbl.Name = "songnamelbl";
            this.songnamelbl.Size = new System.Drawing.Size(82, 17);
            this.songnamelbl.TabIndex = 1;
            this.songnamelbl.Text = "Song name";
            this.songnamelbl.Click += new System.EventHandler(this.Songnamelbl_Click);
            // 
            // PlayBT
            // 
            this.PlayBT.Image = ((System.Drawing.Image)(resources.GetObject("PlayBT.Image")));
            this.PlayBT.ImageHover = ((System.Drawing.Image)(resources.GetObject("PlayBT.ImageHover")));
            this.PlayBT.ImageNormal = ((System.Drawing.Image)(resources.GetObject("PlayBT.ImageNormal")));
            this.PlayBT.Location = new System.Drawing.Point(6, 5);
            this.PlayBT.Name = "PlayBT";
            this.PlayBT.Size = new System.Drawing.Size(25, 25);
            this.PlayBT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayBT.TabIndex = 9;
            this.PlayBT.TabStop = false;
            this.PlayBT.Click += new System.EventHandler(this.PlayBT_Click);
            // 
            // AddToPlaylistBT
            // 
            this.AddToPlaylistBT.Image = ((System.Drawing.Image)(resources.GetObject("AddToPlaylistBT.Image")));
            this.AddToPlaylistBT.ImageHover = ((System.Drawing.Image)(resources.GetObject("AddToPlaylistBT.ImageHover")));
            this.AddToPlaylistBT.ImageNormal = ((System.Drawing.Image)(resources.GetObject("AddToPlaylistBT.ImageNormal")));
            this.AddToPlaylistBT.Location = new System.Drawing.Point(457, 5);
            this.AddToPlaylistBT.Name = "AddToPlaylistBT";
            this.AddToPlaylistBT.Size = new System.Drawing.Size(30, 30);
            this.AddToPlaylistBT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AddToPlaylistBT.TabIndex = 10;
            this.AddToPlaylistBT.TabStop = false;
            this.AddToPlaylistBT.Click += new System.EventHandler(this.AddToPlaylistBT_Click);
            this.AddToPlaylistBT.MouseHover += new System.EventHandler(this.AddToPlaylistBT_MouseHover);
            // 
            // RenameBT
            // 
            this.RenameBT.Image = ((System.Drawing.Image)(resources.GetObject("RenameBT.Image")));
            this.RenameBT.ImageHover = ((System.Drawing.Image)(resources.GetObject("RenameBT.ImageHover")));
            this.RenameBT.ImageNormal = ((System.Drawing.Image)(resources.GetObject("RenameBT.ImageNormal")));
            this.RenameBT.Location = new System.Drawing.Point(492, 7);
            this.RenameBT.Name = "RenameBT";
            this.RenameBT.Size = new System.Drawing.Size(25, 25);
            this.RenameBT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RenameBT.TabIndex = 11;
            this.RenameBT.TabStop = false;
            this.RenameBT.Click += new System.EventHandler(this.RenameBT_Click);
            this.RenameBT.MouseHover += new System.EventHandler(this.RenameBT_MouseHover);
            // 
            // DeleteBT
            // 
            this.DeleteBT.Image = ((System.Drawing.Image)(resources.GetObject("DeleteBT.Image")));
            this.DeleteBT.ImageHover = ((System.Drawing.Image)(resources.GetObject("DeleteBT.ImageHover")));
            this.DeleteBT.ImageNormal = ((System.Drawing.Image)(resources.GetObject("DeleteBT.ImageNormal")));
            this.DeleteBT.Location = new System.Drawing.Point(526, 7);
            this.DeleteBT.Name = "DeleteBT";
            this.DeleteBT.Size = new System.Drawing.Size(25, 25);
            this.DeleteBT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DeleteBT.TabIndex = 12;
            this.DeleteBT.TabStop = false;
            this.DeleteBT.Click += new System.EventHandler(this.DeleteBT_Click);
            this.DeleteBT.MouseHover += new System.EventHandler(this.DeleteBT_MouseHover);
            // 
            // Songaya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Controls.Add(this.DeleteBT);
            this.Controls.Add(this.RenameBT);
            this.Controls.Add(this.AddToPlaylistBT);
            this.Controls.Add(this.PlayBT);
            this.Controls.Add(this.songnamelbl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Songaya";
            this.Size = new System.Drawing.Size(558, 36);
            this.Load += new System.EventHandler(this.Song_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PlayBT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddToPlaylistBT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RenameBT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteBT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomImageButton.ImageButtonCustom PlayBT;
        private CustomImageButton.ImageButtonCustom AddToPlaylistBT;
        private CustomImageButton.ImageButtonCustom RenameBT;
        private CustomImageButton.ImageButtonCustom DeleteBT;
        public System.Windows.Forms.Label songnamelbl;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

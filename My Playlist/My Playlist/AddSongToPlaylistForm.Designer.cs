namespace My_Playlist
{
    partial class AddSongToPlaylistForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSongToPlaylistForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.playcombo = new Bunifu.UI.WinForms.BunifuDropdown();
            this.addplaybtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.SuspendLayout();
            // 
            // playcombo
            // 
            this.playcombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.playcombo.BorderRadius = 1;
            this.playcombo.Color = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.playcombo.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.playcombo.DisabledColor = System.Drawing.Color.Gray;
            this.playcombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.playcombo.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.playcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.playcombo.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.playcombo.FillDropDown = false;
            this.playcombo.FillIndicator = false;
            this.playcombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playcombo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playcombo.ForeColor = System.Drawing.Color.DarkGray;
            this.playcombo.FormattingEnabled = true;
            this.playcombo.Icon = null;
            this.playcombo.IndicatorColor = System.Drawing.Color.DarkGray;
            this.playcombo.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.playcombo.ItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.playcombo.ItemBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.playcombo.ItemForeColor = System.Drawing.Color.DarkGray;
            this.playcombo.ItemHeight = 15;
            this.playcombo.ItemHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.playcombo.Location = new System.Drawing.Point(25, 27);
            this.playcombo.Name = "playcombo";
            this.playcombo.Size = new System.Drawing.Size(217, 21);
            this.playcombo.TabIndex = 23;
            this.playcombo.Text = "Choose Playlist";
            // 
            // addplaybtn
            // 
            this.addplaybtn.BackColor = System.Drawing.Color.Transparent;
            this.addplaybtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addplaybtn.BackgroundImage")));
            this.addplaybtn.ButtonText = "Add";
            this.addplaybtn.ButtonTextMarginLeft = 0;
            this.addplaybtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.addplaybtn.DisabledFillColor = System.Drawing.Color.Gray;
            this.addplaybtn.DisabledForecolor = System.Drawing.Color.White;
            this.addplaybtn.ForeColor = System.Drawing.Color.White;
            this.addplaybtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.addplaybtn.IconPadding = 10;
            this.addplaybtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.addplaybtn.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.addplaybtn.IdleBorderRadius = 1;
            this.addplaybtn.IdleBorderThickness = 0;
            this.addplaybtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.addplaybtn.IdleIconLeftImage = null;
            this.addplaybtn.IdleIconRightImage = null;
            this.addplaybtn.Location = new System.Drawing.Point(186, 66);
            this.addplaybtn.Name = "addplaybtn";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.addplaybtn.onHoverState = stateProperties1;
            this.addplaybtn.Size = new System.Drawing.Size(91, 30);
            this.addplaybtn.TabIndex = 24;
            this.addplaybtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addplaybtn.Click += new System.EventHandler(this.Addplaybtn_Click);
            // 
            // AddSongToPlaylistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(289, 108);
            this.Controls.Add(this.addplaybtn);
            this.Controls.Add(this.playcombo);
            this.Name = "AddSongToPlaylistForm";
            this.Text = "Add song to playlist";
            this.Load += new System.EventHandler(this.AddSongToPlaylistForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Bunifu.UI.WinForms.BunifuDropdown playcombo;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton addplaybtn;
    }
}
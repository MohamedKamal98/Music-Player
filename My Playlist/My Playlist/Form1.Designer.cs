namespace My_Playlist
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.PlayerPanel = new System.Windows.Forms.Panel();
            SongName_lbl = new System.Windows.Forms.Label();
            this.Speaker_bt = new CustomImageButton.ImageButtonCustom();
            this.Mute_bt = new CustomImageButton.ImageButtonCustom();
            this.Volume_Slider = new Bunifu.UI.WinForms.BunifuHSlider();
            this.Resume_bt = new CustomImageButton.ImageButtonCustom();
            this.Pause_bt = new CustomImageButton.ImageButtonCustom();
            Player_Slider = new Bunifu.UI.WinForms.BunifuHSlider();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            timer1 = new System.Windows.Forms.Timer(this.components);
            this.SongsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.gradientPanel1 = new GradientPanelDemo.GradientPanel();
            playcombo = new Bunifu.UI.WinForms.BunifuDropdown();
            pictureBox5 = new System.Windows.Forms.PictureBox();
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.AddPlaylist_bt = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.AddSongs_bt = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label2 = new System.Windows.Forms.Label();
            this.AllSongs_bt = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Min_bt = new CustomImageButton.ImageButtonCustom();
            this.Max_bt = new CustomImageButton.ImageButtonCustom();
            this.Exit_bt = new CustomImageButton.ImageButtonCustom();
            this.Search_Panel = new System.Windows.Forms.Panel();
            this.search_txt = new System.Windows.Forms.TextBox();
            this.search_bt = new CustomImageButton.ImageButtonCustom();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dragControl1 = new DragControlDemo.DragControl();
            this.HeaderBottomPanel = new System.Windows.Forms.Panel();
            this.BackToAllSongs_bt = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.DeletePlaylist_bt = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.SongsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.PlayerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Speaker_bt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mute_bt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Resume_bt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pause_bt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Min_bt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Max_bt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_bt)).BeginInit();
            this.Search_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search_bt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.HeaderBottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(638, 171);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // PlayerPanel
            // 
            this.PlayerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayerPanel.BackColor = System.Drawing.Color.Black;
            this.PlayerPanel.Controls.Add(SongName_lbl);
            this.PlayerPanel.Controls.Add(this.Speaker_bt);
            this.PlayerPanel.Controls.Add(this.Mute_bt);
            this.PlayerPanel.Controls.Add(this.Volume_Slider);
            this.PlayerPanel.Controls.Add(this.Resume_bt);
            this.PlayerPanel.Controls.Add(this.Pause_bt);
            this.PlayerPanel.Controls.Add(Player_Slider);
            this.PlayerPanel.Controls.Add(this.pictureBox6);
            this.PlayerPanel.Location = new System.Drawing.Point(218, 467);
            this.PlayerPanel.Name = "PlayerPanel";
            this.PlayerPanel.Size = new System.Drawing.Size(638, 74);
            this.PlayerPanel.TabIndex = 13;
            // 
            // SongName_lbl
            // 
            SongName_lbl.AutoSize = true;
            SongName_lbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            SongName_lbl.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            SongName_lbl.Location = new System.Drawing.Point(92, 40);
            SongName_lbl.Name = "SongName_lbl";
            SongName_lbl.Size = new System.Drawing.Size(90, 16);
            SongName_lbl.TabIndex = 22;
            SongName_lbl.Text = "SONG NAME";
            // 
            // Speaker_bt
            // 
            this.Speaker_bt.Image = ((System.Drawing.Image)(resources.GetObject("Speaker_bt.Image")));
            this.Speaker_bt.ImageHover = ((System.Drawing.Image)(resources.GetObject("Speaker_bt.ImageHover")));
            this.Speaker_bt.ImageNormal = ((System.Drawing.Image)(resources.GetObject("Speaker_bt.ImageNormal")));
            this.Speaker_bt.Location = new System.Drawing.Point(509, 36);
            this.Speaker_bt.Name = "Speaker_bt";
            this.Speaker_bt.Size = new System.Drawing.Size(27, 27);
            this.Speaker_bt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Speaker_bt.TabIndex = 21;
            this.Speaker_bt.TabStop = false;
            this.Speaker_bt.Click += new System.EventHandler(this.Speaker_bt_Click);
            // 
            // Mute_bt
            // 
            this.Mute_bt.Image = ((System.Drawing.Image)(resources.GetObject("Mute_bt.Image")));
            this.Mute_bt.ImageHover = ((System.Drawing.Image)(resources.GetObject("Mute_bt.ImageHover")));
            this.Mute_bt.ImageNormal = ((System.Drawing.Image)(resources.GetObject("Mute_bt.ImageNormal")));
            this.Mute_bt.Location = new System.Drawing.Point(509, 36);
            this.Mute_bt.Name = "Mute_bt";
            this.Mute_bt.Size = new System.Drawing.Size(27, 27);
            this.Mute_bt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Mute_bt.TabIndex = 20;
            this.Mute_bt.TabStop = false;
            this.Mute_bt.Click += new System.EventHandler(this.Mute_bt_Click);
            // 
            // Volume_Slider
            // 
            this.Volume_Slider.AllowCursorChanges = true;
            this.Volume_Slider.AllowHomeEndKeysDetection = false;
            this.Volume_Slider.AllowIncrementalClickMoves = true;
            this.Volume_Slider.AllowMouseDownEffects = false;
            this.Volume_Slider.AllowMouseHoverEffects = false;
            this.Volume_Slider.AllowScrollingAnimations = true;
            this.Volume_Slider.AllowScrollKeysDetection = true;
            this.Volume_Slider.AllowScrollOptionsMenu = true;
            this.Volume_Slider.AllowShrinkingOnFocusLost = false;
            this.Volume_Slider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Volume_Slider.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Volume_Slider.BackgroundImage")));
            this.Volume_Slider.BindingContainer = null;
            this.Volume_Slider.BorderRadius = 2;
            this.Volume_Slider.BorderThickness = 1;
            this.Volume_Slider.DurationBeforeShrink = 2000;
            this.Volume_Slider.ElapsedColor = System.Drawing.Color.MidnightBlue;
            this.Volume_Slider.LargeChange = 10;
            this.Volume_Slider.Location = new System.Drawing.Point(541, 34);
            this.Volume_Slider.Maximum = 100;
            this.Volume_Slider.Minimum = 0;
            this.Volume_Slider.MinimumSize = new System.Drawing.Size(0, 31);
            this.Volume_Slider.MinimumThumbLength = 18;
            this.Volume_Slider.Name = "Volume_Slider";
            this.Volume_Slider.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.Volume_Slider.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.Volume_Slider.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.Volume_Slider.OnDisableSlider.ElapsedColor = System.Drawing.Color.Silver;
            this.Volume_Slider.OnDisableSlider.SliderColor = System.Drawing.Color.Gainsboro;
            this.Volume_Slider.OnDisableSlider.ThumbColor = System.Drawing.Color.Silver;
            this.Volume_Slider.ScrollBarBorderColor = System.Drawing.Color.Thistle;
            this.Volume_Slider.ScrollBarColor = System.Drawing.Color.Thistle;
            this.Volume_Slider.ShrinkSizeLimit = 3;
            this.Volume_Slider.Size = new System.Drawing.Size(88, 31);
            this.Volume_Slider.SliderColor = System.Drawing.Color.Thistle;
            this.Volume_Slider.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.Volume_Slider.SmallChange = 1;
            this.Volume_Slider.TabIndex = 19;
            this.Volume_Slider.ThumbColor = System.Drawing.Color.MidnightBlue;
            this.Volume_Slider.ThumbLength = 18;
            this.Volume_Slider.ThumbMargin = 1;
            this.Volume_Slider.ThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.ThumbStyles.Inset;
            this.Volume_Slider.Value = 100;
            this.Volume_Slider.Scroll += new System.EventHandler<Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs>(this.Volume_Slider_Scroll);
            // 
            // Resume_bt
            // 
            this.Resume_bt.Image = ((System.Drawing.Image)(resources.GetObject("Resume_bt.Image")));
            this.Resume_bt.ImageHover = ((System.Drawing.Image)(resources.GetObject("Resume_bt.ImageHover")));
            this.Resume_bt.ImageNormal = ((System.Drawing.Image)(resources.GetObject("Resume_bt.ImageNormal")));
            this.Resume_bt.Location = new System.Drawing.Point(221, 36);
            this.Resume_bt.Name = "Resume_bt";
            this.Resume_bt.Size = new System.Drawing.Size(27, 27);
            this.Resume_bt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Resume_bt.TabIndex = 18;
            this.Resume_bt.TabStop = false;
            this.Resume_bt.Click += new System.EventHandler(this.Resume_bt_Click);
            // 
            // Pause_bt
            // 
            this.Pause_bt.Image = ((System.Drawing.Image)(resources.GetObject("Pause_bt.Image")));
            this.Pause_bt.ImageHover = ((System.Drawing.Image)(resources.GetObject("Pause_bt.ImageHover")));
            this.Pause_bt.ImageNormal = ((System.Drawing.Image)(resources.GetObject("Pause_bt.ImageNormal")));
            this.Pause_bt.Location = new System.Drawing.Point(188, 36);
            this.Pause_bt.Name = "Pause_bt";
            this.Pause_bt.Size = new System.Drawing.Size(27, 27);
            this.Pause_bt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pause_bt.TabIndex = 17;
            this.Pause_bt.TabStop = false;
            this.Pause_bt.Click += new System.EventHandler(this.Pause_bt_Click);
            // 
            // Player_Slider
            // 
            Player_Slider.AllowCursorChanges = true;
            Player_Slider.AllowHomeEndKeysDetection = false;
            Player_Slider.AllowIncrementalClickMoves = true;
            Player_Slider.AllowMouseDownEffects = false;
            Player_Slider.AllowMouseHoverEffects = false;
            Player_Slider.AllowScrollingAnimations = true;
            Player_Slider.AllowScrollKeysDetection = true;
            Player_Slider.AllowScrollOptionsMenu = true;
            Player_Slider.AllowShrinkingOnFocusLost = false;
            Player_Slider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            Player_Slider.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Player_Slider.BackgroundImage")));
            Player_Slider.BindingContainer = null;
            Player_Slider.BorderRadius = 2;
            Player_Slider.BorderThickness = 1;
            Player_Slider.DurationBeforeShrink = 2000;
            Player_Slider.ElapsedColor = System.Drawing.Color.MidnightBlue;
            Player_Slider.LargeChange = 10;
            Player_Slider.Location = new System.Drawing.Point(82, 7);
            Player_Slider.Maximum = 100;
            Player_Slider.Minimum = 0;
            Player_Slider.MinimumSize = new System.Drawing.Size(0, 31);
            Player_Slider.MinimumThumbLength = 18;
            Player_Slider.Name = "Player_Slider";
            Player_Slider.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            Player_Slider.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            Player_Slider.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            Player_Slider.OnDisableSlider.ElapsedColor = System.Drawing.Color.Silver;
            Player_Slider.OnDisableSlider.SliderColor = System.Drawing.Color.Gainsboro;
            Player_Slider.OnDisableSlider.ThumbColor = System.Drawing.Color.Silver;
            Player_Slider.ScrollBarBorderColor = System.Drawing.Color.Thistle;
            Player_Slider.ScrollBarColor = System.Drawing.Color.Thistle;
            Player_Slider.ShrinkSizeLimit = 3;
            Player_Slider.Size = new System.Drawing.Size(547, 31);
            Player_Slider.SliderColor = System.Drawing.Color.Thistle;
            Player_Slider.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            Player_Slider.SmallChange = 1;
            Player_Slider.TabIndex = 14;
            Player_Slider.ThumbColor = System.Drawing.Color.MidnightBlue;
            Player_Slider.ThumbLength = 54;
            Player_Slider.ThumbMargin = 1;
            Player_Slider.ThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.ThumbStyles.Inset;
            Player_Slider.Value = 0;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(4, 4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(72, 65);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 14;
            this.pictureBox6.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Location = new System.Drawing.Point(218, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 170);
            this.panel1.TabIndex = 14;
            // 
            // timer1
            // 
            timer1.Interval = 5000;
            timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // SongsPanel
            // 
            this.SongsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SongsPanel.AutoScroll = true;
            this.SongsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.SongsPanel.Location = new System.Drawing.Point(218, 202);
            this.SongsPanel.Name = "SongsPanel";
            this.SongsPanel.Size = new System.Drawing.Size(567, 266);
            this.SongsPanel.TabIndex = 15;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(786, 172);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(69, 296);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 16;
            this.pictureBox7.TabStop = false;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gradientPanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.gradientPanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.gradientPanel1.Controls.Add(playcombo);
            this.gradientPanel1.Controls.Add(pictureBox5);
            this.gradientPanel1.Controls.Add(axWindowsMediaPlayer1);
            this.gradientPanel1.Controls.Add(this.AddPlaylist_bt);
            this.gradientPanel1.Controls.Add(this.AddSongs_bt);
            this.gradientPanel1.Controls.Add(this.label2);
            this.gradientPanel1.Controls.Add(this.AllSongs_bt);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Controls.Add(this.pictureBox3);
            this.gradientPanel1.Controls.Add(this.pictureBox2);
            this.gradientPanel1.Controls.Add(this.Min_bt);
            this.gradientPanel1.Controls.Add(this.Max_bt);
            this.gradientPanel1.Controls.Add(this.Exit_bt);
            this.gradientPanel1.Controls.Add(this.Search_Panel);
            this.gradientPanel1.Location = new System.Drawing.Point(-2, 1);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(220, 540);
            this.gradientPanel1.TabIndex = 11;
            // 
            // playcombo
            // 
            playcombo.BackColor = System.Drawing.Color.Transparent;
            playcombo.BorderRadius = 1;
            playcombo.Color = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            playcombo.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            playcombo.DisabledColor = System.Drawing.Color.Gray;
            playcombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            playcombo.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            playcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            playcombo.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            playcombo.FillDropDown = false;
            playcombo.FillIndicator = false;
            playcombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            playcombo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            playcombo.ForeColor = System.Drawing.Color.DarkGray;
            playcombo.FormattingEnabled = true;
            playcombo.Icon = null;
            playcombo.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            playcombo.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            playcombo.ItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            playcombo.ItemBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            playcombo.ItemForeColor = System.Drawing.Color.DarkGray;
            playcombo.ItemHeight = 15;
            playcombo.ItemHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            playcombo.Location = new System.Drawing.Point(3, 402);
            playcombo.Name = "playcombo";
            playcombo.Size = new System.Drawing.Size(217, 21);
            playcombo.TabIndex = 22;
            playcombo.Text = "Playlists";
            playcombo.SelectedIndexChanged += new System.EventHandler(this.Playcombo_SelectedIndexChanged);
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = System.Drawing.Color.Transparent;
            pictureBox5.Enabled = false;
            pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            pictureBox5.Location = new System.Drawing.Point(0, 50);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new System.Drawing.Size(220, 66);
            pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 13;
            pictureBox5.TabStop = false;
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new System.Drawing.Point(139, 508);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            axWindowsMediaPlayer1.Size = new System.Drawing.Size(75, 23);
            axWindowsMediaPlayer1.TabIndex = 0;
            axWindowsMediaPlayer1.Visible = false;
            // 
            // AddPlaylist_bt
            // 
            this.AddPlaylist_bt.BackColor = System.Drawing.Color.Transparent;
            this.AddPlaylist_bt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddPlaylist_bt.BackgroundImage")));
            this.AddPlaylist_bt.ButtonText = "Add Playlist";
            this.AddPlaylist_bt.ButtonTextMarginLeft = 0;
            this.AddPlaylist_bt.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.AddPlaylist_bt.DisabledFillColor = System.Drawing.Color.Gray;
            this.AddPlaylist_bt.DisabledForecolor = System.Drawing.Color.White;
            this.AddPlaylist_bt.ForeColor = System.Drawing.Color.DarkGray;
            this.AddPlaylist_bt.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.AddPlaylist_bt.IconPadding = 10;
            this.AddPlaylist_bt.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.AddPlaylist_bt.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.AddPlaylist_bt.IdleBorderRadius = 1;
            this.AddPlaylist_bt.IdleBorderThickness = 0;
            this.AddPlaylist_bt.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.AddPlaylist_bt.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("AddPlaylist_bt.IdleIconLeftImage")));
            this.AddPlaylist_bt.IdleIconRightImage = null;
            this.AddPlaylist_bt.Location = new System.Drawing.Point(0, 263);
            this.AddPlaylist_bt.Name = "AddPlaylist_bt";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("stateProperties1.IconLeftImage")));
            stateProperties1.IconRightImage = null;
            this.AddPlaylist_bt.onHoverState = stateProperties1;
            this.AddPlaylist_bt.Size = new System.Drawing.Size(217, 45);
            this.AddPlaylist_bt.TabIndex = 21;
            this.AddPlaylist_bt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddPlaylist_bt.Click += new System.EventHandler(this.BunifuButton1_Click);
            // 
            // AddSongs_bt
            // 
            this.AddSongs_bt.BackColor = System.Drawing.Color.Transparent;
            this.AddSongs_bt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddSongs_bt.BackgroundImage")));
            this.AddSongs_bt.ButtonText = "Add Song";
            this.AddSongs_bt.ButtonTextMarginLeft = 0;
            this.AddSongs_bt.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.AddSongs_bt.DisabledFillColor = System.Drawing.Color.Gray;
            this.AddSongs_bt.DisabledForecolor = System.Drawing.Color.White;
            this.AddSongs_bt.ForeColor = System.Drawing.Color.DarkGray;
            this.AddSongs_bt.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.AddSongs_bt.IconPadding = 10;
            this.AddSongs_bt.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.AddSongs_bt.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.AddSongs_bt.IdleBorderRadius = 1;
            this.AddSongs_bt.IdleBorderThickness = 0;
            this.AddSongs_bt.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.AddSongs_bt.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("AddSongs_bt.IdleIconLeftImage")));
            this.AddSongs_bt.IdleIconRightImage = null;
            this.AddSongs_bt.Location = new System.Drawing.Point(0, 213);
            this.AddSongs_bt.Name = "AddSongs_bt";
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 1;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("stateProperties2.IconLeftImage")));
            stateProperties2.IconRightImage = null;
            this.AddSongs_bt.onHoverState = stateProperties2;
            this.AddSongs_bt.Size = new System.Drawing.Size(217, 45);
            this.AddSongs_bt.TabIndex = 20;
            this.AddSongs_bt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddSongs_bt.Click += new System.EventHandler(this.AddSongs_bt_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(14, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "MAIN";
            // 
            // AllSongs_bt
            // 
            this.AllSongs_bt.BackColor = System.Drawing.Color.Transparent;
            this.AllSongs_bt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AllSongs_bt.BackgroundImage")));
            this.AllSongs_bt.ButtonText = "All Songs";
            this.AllSongs_bt.ButtonTextMarginLeft = 0;
            this.AllSongs_bt.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.AllSongs_bt.DisabledFillColor = System.Drawing.Color.Gray;
            this.AllSongs_bt.DisabledForecolor = System.Drawing.Color.White;
            this.AllSongs_bt.ForeColor = System.Drawing.Color.DarkGray;
            this.AllSongs_bt.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.AllSongs_bt.IconPadding = 10;
            this.AllSongs_bt.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.AllSongs_bt.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.AllSongs_bt.IdleBorderRadius = 1;
            this.AllSongs_bt.IdleBorderThickness = 0;
            this.AllSongs_bt.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.AllSongs_bt.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("AllSongs_bt.IdleIconLeftImage")));
            this.AllSongs_bt.IdleIconRightImage = null;
            this.AllSongs_bt.Location = new System.Drawing.Point(0, 354);
            this.AllSongs_bt.Name = "AllSongs_bt";
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties3.BorderRadius = 1;
            stateProperties3.BorderThickness = 1;
            stateProperties3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties3.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("stateProperties3.IconLeftImage")));
            stateProperties3.IconRightImage = null;
            this.AllSongs_bt.onHoverState = stateProperties3;
            this.AllSongs_bt.Size = new System.Drawing.Size(217, 45);
            this.AllSongs_bt.TabIndex = 17;
            this.AllSongs_bt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AllSongs_bt.Click += new System.EventHandler(this.AllSongs_bt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(14, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "YOUR MUSIC";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(-97, -11);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(127, 53);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(93, -11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(127, 53);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // Min_bt
            // 
            this.Min_bt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Min_bt.Image = ((System.Drawing.Image)(resources.GetObject("Min_bt.Image")));
            this.Min_bt.ImageHover = ((System.Drawing.Image)(resources.GetObject("Min_bt.ImageHover")));
            this.Min_bt.ImageNormal = ((System.Drawing.Image)(resources.GetObject("Min_bt.ImageNormal")));
            this.Min_bt.Location = new System.Drawing.Point(75, 8);
            this.Min_bt.Name = "Min_bt";
            this.Min_bt.Size = new System.Drawing.Size(15, 15);
            this.Min_bt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Min_bt.TabIndex = 13;
            this.Min_bt.TabStop = false;
            this.Min_bt.Click += new System.EventHandler(this.Min_bt_Click);
            // 
            // Max_bt
            // 
            this.Max_bt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Max_bt.Image = ((System.Drawing.Image)(resources.GetObject("Max_bt.Image")));
            this.Max_bt.ImageHover = ((System.Drawing.Image)(resources.GetObject("Max_bt.ImageHover")));
            this.Max_bt.ImageNormal = ((System.Drawing.Image)(resources.GetObject("Max_bt.ImageNormal")));
            this.Max_bt.Location = new System.Drawing.Point(54, 8);
            this.Max_bt.Name = "Max_bt";
            this.Max_bt.Size = new System.Drawing.Size(15, 15);
            this.Max_bt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Max_bt.TabIndex = 12;
            this.Max_bt.TabStop = false;
            this.Max_bt.Click += new System.EventHandler(this.Max_bt_Click);
            // 
            // Exit_bt
            // 
            this.Exit_bt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Exit_bt.Image = ((System.Drawing.Image)(resources.GetObject("Exit_bt.Image")));
            this.Exit_bt.ImageHover = ((System.Drawing.Image)(resources.GetObject("Exit_bt.ImageHover")));
            this.Exit_bt.ImageNormal = ((System.Drawing.Image)(resources.GetObject("Exit_bt.ImageNormal")));
            this.Exit_bt.Location = new System.Drawing.Point(33, 8);
            this.Exit_bt.Name = "Exit_bt";
            this.Exit_bt.Size = new System.Drawing.Size(15, 15);
            this.Exit_bt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Exit_bt.TabIndex = 11;
            this.Exit_bt.TabStop = false;
            this.Exit_bt.Click += new System.EventHandler(this.Exit_bt_Click);
            // 
            // Search_Panel
            // 
            this.Search_Panel.Controls.Add(this.search_txt);
            this.Search_Panel.Controls.Add(this.search_bt);
            this.Search_Panel.Controls.Add(this.pictureBox1);
            this.Search_Panel.Location = new System.Drawing.Point(26, 122);
            this.Search_Panel.Name = "Search_Panel";
            this.Search_Panel.Size = new System.Drawing.Size(167, 38);
            this.Search_Panel.TabIndex = 0;
            // 
            // search_txt
            // 
            this.search_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.search_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.search_txt.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(159)))), ((int)(((byte)(161)))));
            this.search_txt.Location = new System.Drawing.Point(34, 11);
            this.search_txt.Margin = new System.Windows.Forms.Padding(2);
            this.search_txt.Name = "search_txt";
            this.search_txt.Size = new System.Drawing.Size(105, 15);
            this.search_txt.TabIndex = 9;
            this.search_txt.Text = "Search";
            this.search_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.search_txt.Click += new System.EventHandler(this.Search_txt_Click);
            this.search_txt.TextChanged += new System.EventHandler(this.search_txt_TextChanged);
            // 
            // search_bt
            // 
            this.search_bt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.search_bt.Image = ((System.Drawing.Image)(resources.GetObject("search_bt.Image")));
            this.search_bt.ImageHover = ((System.Drawing.Image)(resources.GetObject("search_bt.ImageHover")));
            this.search_bt.ImageNormal = ((System.Drawing.Image)(resources.GetObject("search_bt.ImageNormal")));
            this.search_bt.Location = new System.Drawing.Point(142, 13);
            this.search_bt.Name = "search_bt";
            this.search_bt.Size = new System.Drawing.Size(14, 18);
            this.search_bt.TabIndex = 1;
            this.search_bt.TabStop = false;
            this.search_bt.Click += new System.EventHandler(this.imageButtonCustom1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 27);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.pictureBox4;
            // 
            // HeaderBottomPanel
            // 
            this.HeaderBottomPanel.Controls.Add(this.BackToAllSongs_bt);
            this.HeaderBottomPanel.Controls.Add(this.DeletePlaylist_bt);
            this.HeaderBottomPanel.Controls.Add(this.SongsLabel);
            this.HeaderBottomPanel.Location = new System.Drawing.Point(218, 172);
            this.HeaderBottomPanel.Name = "HeaderBottomPanel";
            this.HeaderBottomPanel.Size = new System.Drawing.Size(567, 32);
            this.HeaderBottomPanel.TabIndex = 17;
            // 
            // BackToAllSongs_bt
            // 
            this.BackToAllSongs_bt.BackColor = System.Drawing.Color.Transparent;
            this.BackToAllSongs_bt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackToAllSongs_bt.BackgroundImage")));
            this.BackToAllSongs_bt.ButtonText = "Back to all songs";
            this.BackToAllSongs_bt.ButtonTextMarginLeft = 0;
            this.BackToAllSongs_bt.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.BackToAllSongs_bt.DisabledFillColor = System.Drawing.Color.Gray;
            this.BackToAllSongs_bt.DisabledForecolor = System.Drawing.Color.White;
            this.BackToAllSongs_bt.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToAllSongs_bt.ForeColor = System.Drawing.Color.White;
            this.BackToAllSongs_bt.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.BackToAllSongs_bt.IconPadding = 10;
            this.BackToAllSongs_bt.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.BackToAllSongs_bt.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.BackToAllSongs_bt.IdleBorderRadius = 1;
            this.BackToAllSongs_bt.IdleBorderThickness = 0;
            this.BackToAllSongs_bt.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.BackToAllSongs_bt.IdleIconLeftImage = null;
            this.BackToAllSongs_bt.IdleIconRightImage = null;
            this.BackToAllSongs_bt.Location = new System.Drawing.Point(364, 7);
            this.BackToAllSongs_bt.Name = "BackToAllSongs_bt";
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.BorderRadius = 1;
            stateProperties4.BorderThickness = 1;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.IconLeftImage = null;
            stateProperties4.IconRightImage = null;
            this.BackToAllSongs_bt.onHoverState = stateProperties4;
            this.BackToAllSongs_bt.Size = new System.Drawing.Size(105, 17);
            this.BackToAllSongs_bt.TabIndex = 25;
            this.BackToAllSongs_bt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BackToAllSongs_bt.Click += new System.EventHandler(this.BackToAllSongs_bt_Click);
            // 
            // DeletePlaylist_bt
            // 
            this.DeletePlaylist_bt.BackColor = System.Drawing.Color.Transparent;
            this.DeletePlaylist_bt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeletePlaylist_bt.BackgroundImage")));
            this.DeletePlaylist_bt.ButtonText = "Delete Playlist";
            this.DeletePlaylist_bt.ButtonTextMarginLeft = 0;
            this.DeletePlaylist_bt.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.DeletePlaylist_bt.DisabledFillColor = System.Drawing.Color.Gray;
            this.DeletePlaylist_bt.DisabledForecolor = System.Drawing.Color.White;
            this.DeletePlaylist_bt.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeletePlaylist_bt.ForeColor = System.Drawing.Color.White;
            this.DeletePlaylist_bt.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.DeletePlaylist_bt.IconPadding = 10;
            this.DeletePlaylist_bt.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.DeletePlaylist_bt.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.DeletePlaylist_bt.IdleBorderRadius = 1;
            this.DeletePlaylist_bt.IdleBorderThickness = 0;
            this.DeletePlaylist_bt.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.DeletePlaylist_bt.IdleIconLeftImage = null;
            this.DeletePlaylist_bt.IdleIconRightImage = null;
            this.DeletePlaylist_bt.Location = new System.Drawing.Point(475, 7);
            this.DeletePlaylist_bt.Name = "DeletePlaylist_bt";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties5.BorderRadius = 1;
            stateProperties5.BorderThickness = 1;
            stateProperties5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties5.IconLeftImage = null;
            stateProperties5.IconRightImage = null;
            this.DeletePlaylist_bt.onHoverState = stateProperties5;
            this.DeletePlaylist_bt.Size = new System.Drawing.Size(87, 17);
            this.DeletePlaylist_bt.TabIndex = 24;
            this.DeletePlaylist_bt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DeletePlaylist_bt.Click += new System.EventHandler(this.DeletePlaylist_bt_Click);
            // 
            // SongsLabel
            // 
            this.SongsLabel.AutoSize = true;
            this.SongsLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SongsLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.SongsLabel.Location = new System.Drawing.Point(8, 7);
            this.SongsLabel.Name = "SongsLabel";
            this.SongsLabel.Size = new System.Drawing.Size(80, 16);
            this.SongsLabel.TabIndex = 23;
            this.SongsLabel.Text = "ALL SONGS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(855, 542);
            this.Controls.Add(this.HeaderBottomPanel);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.SongsPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PlayerPanel);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "My Playlist";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.PlayerPanel.ResumeLayout(false);
            this.PlayerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Speaker_bt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mute_bt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Resume_bt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pause_bt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Min_bt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Max_bt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_bt)).EndInit();
            this.Search_Panel.ResumeLayout(false);
            this.Search_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search_bt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.HeaderBottomPanel.ResumeLayout(false);
            this.HeaderBottomPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox search_txt;
        private GradientPanelDemo.GradientPanel gradientPanel1;
        private System.Windows.Forms.Panel Search_Panel;
        private CustomImageButton.ImageButtonCustom search_bt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CustomImageButton.ImageButtonCustom Exit_bt;
        private DragControlDemo.DragControl dragControl1;
        private CustomImageButton.ImageButtonCustom Min_bt;
        private CustomImageButton.ImageButtonCustom Max_bt;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton AllSongs_bt;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton AddPlaylist_bt;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton AddSongs_bt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel PlayerPanel;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Panel panel1;
        private CustomImageButton.ImageButtonCustom Pause_bt;
        private CustomImageButton.ImageButtonCustom Resume_bt;
        private CustomImageButton.ImageButtonCustom Speaker_bt;
        private CustomImageButton.ImageButtonCustom Mute_bt;
        private Bunifu.UI.WinForms.BunifuHSlider Volume_Slider;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Panel HeaderBottomPanel;
        private System.Windows.Forms.Label SongsLabel;
        public System.Windows.Forms.FlowLayoutPanel SongsPanel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton DeletePlaylist_bt;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton BackToAllSongs_bt;
        public static System.Windows.Forms.Label SongName_lbl;
        public static System.Windows.Forms.PictureBox pictureBox5;
        public static Bunifu.UI.WinForms.BunifuHSlider Player_Slider;
        public static System.Windows.Forms.Timer timer1;
        public static AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        public static Bunifu.UI.WinForms.BunifuDropdown playcombo;
    }
}


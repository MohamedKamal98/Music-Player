namespace My_Playlist
{
    partial class b
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(b));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.label1 = new System.Windows.Forms.Label();
            this.playnametxt = new System.Windows.Forms.TextBox();
            this.addplaybtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Playlist Name";
            // 
            // playnametxt
            // 
            this.playnametxt.Location = new System.Drawing.Point(104, 23);
            this.playnametxt.Name = "playnametxt";
            this.playnametxt.Size = new System.Drawing.Size(145, 20);
            this.playnametxt.TabIndex = 1;
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
            this.addplaybtn.TabIndex = 2;
            this.addplaybtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addplaybtn.Click += new System.EventHandler(this.Addplaybtn_Click);
            // 
            // b
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(289, 108);
            this.Controls.Add(this.addplaybtn);
            this.Controls.Add(this.playnametxt);
            this.Controls.Add(this.label1);
            this.Name = "b";
            this.Text = "Add new playlist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox playnametxt;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton addplaybtn;
    }
}
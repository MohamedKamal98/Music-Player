using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomImageButton
{
    public partial class ImageButtonCustom: PictureBox
    {
        public ImageButtonCustom()
        {
            InitializeComponent();
        }

        private Image NormalImage;
        private Image HoverImage;

        public Image ImageNormal
        {
            get { return NormalImage; }
            set { NormalImage = value; }
        }

        public Image ImageHover
        {
            get { return HoverImage; }
            set { HoverImage = value; }
        }

        private void ImageButtonCustom_MouseHover(object sender, EventArgs e)
        {
            this.Image = HoverImage;

        }

        private void ImageButtonCustom_MouseLeave(object sender, EventArgs e)
        {
            this.Image = NormalImage;
        }
    }
}

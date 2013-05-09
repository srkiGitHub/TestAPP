using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.DirectX.AudioVideoPlayback;

namespace TestAPP
{
    public partial class Test : Form
    {
        private string _pathVideo = "";
        public string _pathPic="";
        public string _textScroll = "";

        Video myVideo;

        public Test(string sPathVideo, string sPathPic, string sTextScroll)
        {
            this._pathPic = sPathPic;
            this._pathVideo = sPathVideo;
            this._textScroll = sTextScroll;
            InitializeComponent();
        }

        private void Test_Load(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(_pathPic);
            pictureBox1.Image = (Image)image;

            myVideo = new Video(_pathVideo);
            myVideo.Owner = panel2;
            myVideo.Play();

            scrollingText1.ScrollText = _textScroll;
            scrollingText1.TextScrollEnabled=true;
        }
    }
}

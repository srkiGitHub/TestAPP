using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.DirectX.AudioVideoPlayback;

namespace TestAPP
{
    public partial class Test : Form
    {
        private readonly string _pathVideo = "";
        public readonly string PathPic = "";
        public readonly string TextScroll = "";

        Video _myVideo;

        public Test(string sPathVideo, string sPathPic, string sTextScroll)
        {
            PathPic = sPathPic;
            _pathVideo = sPathVideo;
            TextScroll = sTextScroll;
            InitializeComponent();
        }

        private void Test_Load(object sender, EventArgs e)
        {
            var image = new Bitmap(PathPic);
            pictureBox1.Image = image;

            _myVideo = new Video(_pathVideo) {Owner = panel2};
            _myVideo.Play();

            scrollingText1.ScrollText = TextScroll;
            scrollingText1.TextScrollEnabled=true;
        }
    }
}

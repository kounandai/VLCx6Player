using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VlcTest2
{
    public partial class Form1 : Form
    {
        bool bPlayMode;
        bool bPlayPause;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bPlayMode = false;
            bPlayPause = false;

        }

        private void vlcControl1_Click(object sender, EventArgs e)
        {

        }


        private void vlcControl1_VlcLibDirectoryNeeded(object sender, Vlc.DotNet.Forms.VlcLibDirectoryNeededEventArgs e)
        {
           e.VlcLibDirectory = new System.IO.DirectoryInfo(@"C:\cygwin64\home\ryos\Project\Gstreamer\VlcTest2\packages\VideoLAN.LibVLC.Windows.3.0.10\build\x64");

        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (vlcControl1.State == Vlc.DotNet.Core.Interops.Signatures.MediaStates.Ended)
            {
//                vlcControl1.Play(new Uri("rtsp://wowzaec2demo.streamlock.net/vod/mp4:BigBuckBunny_115k.mov"));

            }
        }

        private void stop_Click(object sender, EventArgs e)
        {
            if (bPlayMode == true)
            {
                vlcControl1.Stop();
                stop.Text = "PLAY";
                bPlayMode = false;
            }
            else
            {
                vlcControl1.Play(new Uri("udp://@239.192.64.115:5000"));
                //vlcControl1.Play(new Uri("rtsp://whale.local:8554/test"));
                //vlcControl1.Play(new Uri("rtsp://wowzaec2demo.streamlock.net/vod/mp4:BigBuckBunny_115k.mov"));


                stop.Text = "STOP";
                bPlayMode = true;
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {

            if (bPlayPause == true)
            {
                vlcControl1.Play();

            }
            else
            {
                vlcControl1.Pause();

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            vlcControl1.Dispose();
            this.Close();
        }

        private void btnRate2_Click(object sender, EventArgs e)
        {
            vlcControl1.Rate *= 2; 

        }

        private void btnRate1_Click(object sender, EventArgs e)
        {
            vlcControl1.Rate = 1;

        }

        private void btnRate05_Click(object sender, EventArgs e)
        {

            vlcControl1.Rate /= 2;
        }
    }
}

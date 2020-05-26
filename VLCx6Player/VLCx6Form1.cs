using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vlc.DotNet.Core.Interops;
using Vlc.DotNet.Core.Interops.Signatures;
using Vlc.DotNet.Forms;
using VLCMediaStats;

namespace VLCx6Player
{
    public partial class VLCx6Form1 : Form
    {
        private System.IO.DirectoryInfo libDirectory;
        public VLCx6Form1()
        {
            InitializeComponent();
        }

        private void VLCx6Form1_Load(object sender, EventArgs e)
        {
            vlcControl1.Play(new Uri("udp://@238.0.0.1:1234"));
            vlcControl1.VlcMediaPlayer.Audio.ToggleMute();


            vlcControl2.Play(new Uri("https://www.freedesktop.org/software/gstreamer-sdk/data/media/sintel_trailer-480p.webm"));

            vlcControl3.Play(new Uri("udp://@239.192.64.113:5000"));
            vlcControl3.VlcMediaPlayer.Audio.ToggleMute();

            vlcControl4.Play(new Uri("udp://@239.192.64.114:5000"));
            vlcControl4.VlcMediaPlayer.Audio.ToggleMute();

            vlcControl5.Play(new Uri("udp://@239.192.64.115:5000"));
            vlcControl5.VlcMediaPlayer.Audio.ToggleMute();

            vlcControl6.Play(new Uri("udp://@239.192.64.116:5000"));
            vlcControl6.VlcMediaPlayer.Audio.ToggleMute();

            timer1.Start();
        }

        private void vlcControl1_VlcLibDirectoryNeeded(object sender, Vlc.DotNet.Forms.VlcLibDirectoryNeededEventArgs e)
        {
            if (libDirectory == null)
            {
                var currentAssembly = Assembly.GetEntryAssembly();
                var currentDirectory = new FileInfo(currentAssembly.Location).DirectoryName;
                libDirectory = new DirectoryInfo(System.IO.Path.Combine(currentDirectory, "libvlc", IntPtr.Size == 4 ? "win-x86" : "win-x64"));
            }
            e.VlcLibDirectory = libDirectory;
        }

        private void update_stats(VLCMediaStats.VLCMediaStats vlcMediaStats, MediaStatsStructure stats)
        {
            vlcMediaStats.update_stats(stats.InputBitrate, stats.LostPictures);
        }

        private void set_mediaInfo(VLCMediaStats.VLCMediaStats vlcMediaStats, VlcControl vlcControl)
        {
            var mediaInfos = vlcControl.GetCurrentMedia().Tracks;
            foreach (var media in mediaInfos)
            {
                if (media.Type == MediaTrackTypes.Video)
                {
                    var vtrack = media.TrackInfo as VideoTrack;
                    vlcMediaStats.setSize(vtrack.Width, vtrack.Height);
                }
                else if (media.Type == MediaTrackTypes.Text)
                {
                    var titletrack = media.TrackInfo as Vlc.DotNet.Core.Interops.SubtitleTrack;
                    vlcMediaStats.setText(titletrack.ToString());
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.set_mediaInfo(this.vlcMediaStats3, vlcControl3);
            this.set_mediaInfo(this.vlcMediaStats4, vlcControl4);
            this.set_mediaInfo(this.vlcMediaStats5, vlcControl5);
            this.set_mediaInfo(this.vlcMediaStats6, vlcControl6);

            this.update_stats(this.vlcMediaStats3, vlcControl3.GetCurrentMedia().Statistics);
            this.update_stats(this.vlcMediaStats4, vlcControl4.GetCurrentMedia().Statistics);
            this.update_stats(this.vlcMediaStats5, vlcControl5.GetCurrentMedia().Statistics);
            this.update_stats(this.vlcMediaStats6, vlcControl6.GetCurrentMedia().Statistics);
        }
    }
}

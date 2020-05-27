using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VLCMediaStats
{
    public partial class VLCMediaStats: UserControl
    {
        public VLCMediaStats()
        {
            InitializeComponent();
        }

        public void setSize(uint x, uint y)
        {
            this.label_size.Text = x.ToString() + "x" + y.ToString();
        }

        public void update_stats(float bitrate, int lost_pictures)
        {
            this.label_value_bitrate.Text = Math.Round(bitrate * 10, 3).ToString();
            this.label_value_lost.Text = lost_pictures.ToString();
        }

        public void setText(string text)
        {

        }
    }
}

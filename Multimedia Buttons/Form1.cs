using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Timers;
using System.IO;
using System.Threading;

namespace Multimedia_Buttons
{


    public partial class Form1 : Form
    {

        // https://docs.microsoft.com/en-us/windows/win32/inputdev/virtual-key-codes

        public
        const int KEYEVENTF_EXTENTEDKEY = 1;
        public
        const int KEYEVENTF_KEYUP = 0;
        public
        const int VK_MEDIA_NEXT_TRACK = 0xB0;
        public
        const int VK_MEDIA_PLAY_PAUSE = 0xB3;
        public
        const int VK_MEDIA_PREV_TRACK = 0xB1;
        public
        const int VK_VOLUME_MUTE = 0xAD;
        public
        const int VK_MEDIA_STOP = 0xB2;
        public
        const int VK_VOLUME_UP = 0xAF;
        public
        const int VK_VOLUME_DOWN = 0xAE;
        [DllImport("user32.dll")]
        public static extern void keybd_event(byte virtualKey, byte scanCode, uint flags, IntPtr extraInfo);

        void Title()
        {
            var proc = Process.GetProcessesByName("Spotify").LastOrDefault(p => !string.IsNullOrWhiteSpace(p.MainWindowTitle));
            if (proc == null)
            {
                this.Text = "Spotify is not running";
            }
            if (proc != null)
            {
                this.Text = proc.MainWindowTitle;
            }
        }

        public Form1()
        {
            InitializeComponent();
            TopMost = true;
            Title();
        }

        private void stop_Click(object sender, EventArgs e)
        {
            keybd_event(VK_MEDIA_STOP, 0, KEYEVENTF_EXTENTEDKEY, IntPtr.Zero);
        }


        private void mute_Click(object sender, EventArgs e)
        {
            keybd_event(VK_VOLUME_MUTE, 0, KEYEVENTF_EXTENTEDKEY, IntPtr.Zero);
        }

        private void spotify_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Spotify.exe");
        }

        private void volume_down_Click(object sender, EventArgs e)
        {
            keybd_event(VK_VOLUME_DOWN, 0, KEYEVENTF_EXTENTEDKEY, IntPtr.Zero);
        }

        private void volume_up_Click(object sender, EventArgs e)
        {
            keybd_event(VK_VOLUME_UP, 0, KEYEVENTF_EXTENTEDKEY, IntPtr.Zero);
        }

        private void prev_track_Click(object sender, EventArgs e)
        { 
            keybd_event(VK_MEDIA_PREV_TRACK, 0, KEYEVENTF_EXTENTEDKEY, IntPtr.Zero);
        }

        private void play_pause_Click(object sender, EventArgs e)
        {
            keybd_event(VK_MEDIA_PLAY_PAUSE, 0, KEYEVENTF_EXTENTEDKEY, IntPtr.Zero);
        }

        private void next_track_Click(object sender, EventArgs e)
        {
            keybd_event(VK_MEDIA_NEXT_TRACK, 0, KEYEVENTF_EXTENTEDKEY, IntPtr.Zero);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Title();
        }
    }
   }
    

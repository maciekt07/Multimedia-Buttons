using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

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
                this.Text = "Multimedia Buttons By github.com/maciekkoks";
            }
            if (proc != null)
            {
                if (proc.MainWindowTitle == "Advertisement" || proc.MainWindowTitle == "Spotify")
                {
                    skip_ad.Visible = true;
                }
                else
                {
                    skip_ad.Visible = false;
                }
                if (proc.MainWindowTitle == "Spotify Free" || proc.MainWindowTitle == "Spotify Free")
                {
                    this.Text = "Multimedia Buttons By github.com/maciekkoks";
                }
                else
                {
                    this.Text = proc.MainWindowTitle;
                }

            }
        }

        void ad()
        {
            var procad = Process.GetProcessesByName("Spotify").LastOrDefault(p => !string.IsNullOrWhiteSpace(p.MainWindowTitle));
            if (procad.MainWindowTitle == "Advertisement")
            {
                foreach (var process in Process.GetProcessesByName("Spotify"))
                {
                    process.Kill();
                }
                System.Diagnostics.Process.Start("Spotify.exe");
                Thread.Sleep(2000);
                keybd_event(VK_MEDIA_PLAY_PAUSE, 0, KEYEVENTF_EXTENTEDKEY, IntPtr.Zero);
            }

        }
        public Form1()
        {
            InitializeComponent();
            TopMost = true;
            Title();
            skip_ad.Visible = false;
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
        private void prev_track_MouseHover(object sender, EventArgs e) { Title(); }
        private void next_track_MouseHover(object sender, EventArgs e) { Title(); }
        private void Form1_MouseHover(object sender, EventArgs e) { Title(); }
        private void Form1_MouseMove(object sender, MouseEventArgs e) { Title(); }
        private void Form1_Activated(object sender, EventArgs e) { Title(); }
        private void Form1_Deactivate(object sender, EventArgs e) { Title(); }
        private void skip_ad_Click(object sender, EventArgs e) { ad(); }
    }
}
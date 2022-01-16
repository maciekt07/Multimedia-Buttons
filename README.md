# Multimedia Buttons
# [About Website](https://maciekkoks.github.io/Multimedia-Buttons/)
![preview](https://raw.githubusercontent.com/maciekkoks/Multimedia-Buttons/Website/Img/previewmain.png)
![preview2](https://raw.githubusercontent.com/maciekkoks/Multimedia-Buttons/Website/Img/skipad.png)
![preview3](https://raw.githubusercontent.com/maciekkoks/Multimedia-Buttons/Website/Img/mainimg.png)
# Main Code

```cs
using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Timer = System.Timers.Timer;

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
        void TitleTimer()
        {
            Timer x = new Timer(100);
            x.AutoReset = true;
            x.Elapsed += new System.Timers.ElapsedEventHandler(Title);
            x.Start();
        }

        void isAd()
        {
            var procad = Process.GetProcessesByName("Spotify").LastOrDefault(p => !string.IsNullOrWhiteSpace(p.MainWindowTitle));
            if (procad == null)
            {
                Text = "Multimedia Buttons By github.com/maciekkoks";
            }
            if (procad != null)
            {
                if (procad.MainWindowTitle == "Advertisement" || procad.MainWindowTitle == "Spotify")
                {
                    Skip_ad.Visible = true;
                }
                else
                {
                    Skip_ad.Visible = false;
                }
            }
        }
        void Title(object sender, System.Timers.ElapsedEventArgs e)
        {
            var proc = Process.GetProcessesByName("Spotify").LastOrDefault(p => !string.IsNullOrWhiteSpace(p.MainWindowTitle));
            if (proc == null)
            {
                Text = "Multimedia Buttons By github.com/maciekkoks";
            }
            if (proc != null)
            {
                if (proc.MainWindowTitle == "Spotify Free" || proc.MainWindowTitle == "Spotify Premium")
                {
                    Text = "Multimedia Buttons By github.com/maciekkoks";
                }
                else
                {
                    Text = proc.MainWindowTitle;
                }
            }
        }


        void Ad()
        {
            foreach (var process in Process.GetProcessesByName("Spotify"))
            {
                process.Kill();
            }
            System.Diagnostics.Process.Start("Spotify");
            Thread.Sleep(2000);
            keybd_event(VK_MEDIA_PLAY_PAUSE, 0, KEYEVENTF_EXTENTEDKEY, IntPtr.Zero);
        }
        public Form1()
        {
            InitializeComponent();
            TopMost = true;
            TitleTimer();
            isAd();
            Skip_ad.Visible = false;
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            keybd_event(VK_MEDIA_STOP, 0, KEYEVENTF_EXTENTEDKEY, IntPtr.Zero);
        }

        private void Mute_Click(object sender, EventArgs e)
        {
            keybd_event(VK_VOLUME_MUTE, 0, KEYEVENTF_EXTENTEDKEY, IntPtr.Zero);
        }

        private void Spotify_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Spotify.exe");
        }

        private void Volume_down_Click(object sender, EventArgs e)
        {
            keybd_event(VK_VOLUME_DOWN, 0, KEYEVENTF_EXTENTEDKEY, IntPtr.Zero);
        }

        private void Volume_up_Click(object sender, EventArgs e)
        {
            keybd_event(VK_VOLUME_UP, 0, KEYEVENTF_EXTENTEDKEY, IntPtr.Zero);
        }

        private void Prev_track_Click(object sender, EventArgs e)
        {
            keybd_event(VK_MEDIA_PREV_TRACK, 0, KEYEVENTF_EXTENTEDKEY, IntPtr.Zero);
        }

        private void Play_pause_Click(object sender, EventArgs e)
        {
            keybd_event(VK_MEDIA_PLAY_PAUSE, 0, KEYEVENTF_EXTENTEDKEY, IntPtr.Zero);
        }

        private void Next_track_Click(object sender, EventArgs e)
        {
            keybd_event(VK_MEDIA_NEXT_TRACK, 0, KEYEVENTF_EXTENTEDKEY, IntPtr.Zero);
        }

        private void Skip_ad_Click(object sender, EventArgs e)
        {
            Ad();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            isAd();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            isAd();
        }
    }
}
```


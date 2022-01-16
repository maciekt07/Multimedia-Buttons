namespace Multimedia_Buttons
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Spotify = new System.Windows.Forms.Button();
            this.Volume_up = new System.Windows.Forms.Button();
            this.Volume_down = new System.Windows.Forms.Button();
            this.Mute = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.Next_track = new System.Windows.Forms.Button();
            this.Prev_track = new System.Windows.Forms.Button();
            this.Play_pause = new System.Windows.Forms.Button();
            this.Skip_ad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Spotify
            // 
            this.Spotify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Spotify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Spotify.Image = global::Multimedia_Buttons.Properties.Resources.spotify_logo;
            this.Spotify.Location = new System.Drawing.Point(168, 12);
            this.Spotify.Name = "Spotify";
            this.Spotify.Size = new System.Drawing.Size(102, 70);
            this.Spotify.TabIndex = 7;
            this.Spotify.UseVisualStyleBackColor = true;
            this.Spotify.Click += new System.EventHandler(this.Spotify_Click);
            // 
            // Volume_up
            // 
            this.Volume_up.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Volume_up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Volume_up.Image = global::Multimedia_Buttons.Properties.Resources.volume_up;
            this.Volume_up.Location = new System.Drawing.Point(352, 12);
            this.Volume_up.Name = "Volume_up";
            this.Volume_up.Size = new System.Drawing.Size(70, 70);
            this.Volume_up.TabIndex = 6;
            this.Volume_up.UseVisualStyleBackColor = true;
            this.Volume_up.Click += new System.EventHandler(this.Volume_up_Click);
            // 
            // Volume_down
            // 
            this.Volume_down.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Volume_down.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Volume_down.Image = global::Multimedia_Buttons.Properties.Resources.volume_down;
            this.Volume_down.Location = new System.Drawing.Point(276, 12);
            this.Volume_down.Name = "Volume_down";
            this.Volume_down.Size = new System.Drawing.Size(70, 70);
            this.Volume_down.TabIndex = 5;
            this.Volume_down.UseVisualStyleBackColor = true;
            this.Volume_down.Click += new System.EventHandler(this.Volume_down_Click);
            // 
            // Mute
            // 
            this.Mute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Mute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mute.Image = global::Multimedia_Buttons.Properties.Resources.mute;
            this.Mute.Location = new System.Drawing.Point(92, 12);
            this.Mute.Name = "Mute";
            this.Mute.Size = new System.Drawing.Size(70, 70);
            this.Mute.TabIndex = 4;
            this.Mute.UseVisualStyleBackColor = true;
            this.Mute.Click += new System.EventHandler(this.Mute_Click);
            // 
            // Stop
            // 
            this.Stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Stop.Image = global::Multimedia_Buttons.Properties.Resources.stop;
            this.Stop.Location = new System.Drawing.Point(12, 12);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(70, 70);
            this.Stop.TabIndex = 3;
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Next_track
            // 
            this.Next_track.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Next_track.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Next_track.Image = global::Multimedia_Buttons.Properties.Resources.next_track;
            this.Next_track.Location = new System.Drawing.Point(302, 104);
            this.Next_track.Name = "Next_track";
            this.Next_track.Size = new System.Drawing.Size(120, 120);
            this.Next_track.TabIndex = 2;
            this.Next_track.UseVisualStyleBackColor = true;
            this.Next_track.Click += new System.EventHandler(this.Next_track_Click);
            // 
            // Prev_track
            // 
            this.Prev_track.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Prev_track.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Prev_track.Image = global::Multimedia_Buttons.Properties.Resources.prev_track;
            this.Prev_track.Location = new System.Drawing.Point(12, 104);
            this.Prev_track.Name = "Prev_track";
            this.Prev_track.Size = new System.Drawing.Size(120, 120);
            this.Prev_track.TabIndex = 1;
            this.Prev_track.UseVisualStyleBackColor = true;
            this.Prev_track.Click += new System.EventHandler(this.Prev_track_Click);
            // 
            // Play_pause
            // 
            this.Play_pause.BackColor = System.Drawing.Color.Gray;
            this.Play_pause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Play_pause.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Play_pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Play_pause.Image = global::Multimedia_Buttons.Properties.Resources.play_pause;
            this.Play_pause.Location = new System.Drawing.Point(157, 104);
            this.Play_pause.Name = "Play_pause";
            this.Play_pause.Size = new System.Drawing.Size(120, 120);
            this.Play_pause.TabIndex = 0;
            this.Play_pause.UseVisualStyleBackColor = false;
            this.Play_pause.Click += new System.EventHandler(this.Play_pause_Click);
            // 
            // Skip_ad
            // 
            this.Skip_ad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Skip_ad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Skip_ad.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Skip_ad.Location = new System.Drawing.Point(328, 176);
            this.Skip_ad.Name = "Skip_ad";
            this.Skip_ad.Size = new System.Drawing.Size(94, 48);
            this.Skip_ad.TabIndex = 8;
            this.Skip_ad.Text = "Skip Ad";
            this.Skip_ad.UseVisualStyleBackColor = true;
            this.Skip_ad.Click += new System.EventHandler(this.Skip_ad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(434, 236);
            this.Controls.Add(this.Skip_ad);
            this.Controls.Add(this.Spotify);
            this.Controls.Add(this.Volume_up);
            this.Controls.Add(this.Volume_down);
            this.Controls.Add(this.Mute);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Next_track);
            this.Controls.Add(this.Prev_track);
            this.Controls.Add(this.Play_pause);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Tag = "";
            this.Text = "Multimedia Buttons By github.com/maciekkoks";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Play_pause;
        private System.Windows.Forms.Button Prev_track;
        private System.Windows.Forms.Button Next_track;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Mute;
        private System.Windows.Forms.Button Volume_down;
        private System.Windows.Forms.Button Volume_up;
        private System.Windows.Forms.Button Spotify;
        private System.Windows.Forms.Button Skip_ad;
    }
}


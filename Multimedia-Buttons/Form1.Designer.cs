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
            this.spotify = new System.Windows.Forms.Button();
            this.volume_up = new System.Windows.Forms.Button();
            this.volume_down = new System.Windows.Forms.Button();
            this.mute = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.next_track = new System.Windows.Forms.Button();
            this.prev_track = new System.Windows.Forms.Button();
            this.play_pause = new System.Windows.Forms.Button();
            this.skip_ad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // spotify
            // 
            this.spotify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.spotify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.spotify.Image = global::Multimedia_Buttons.Properties.Resources.spotify_logo;
            this.spotify.Location = new System.Drawing.Point(168, 12);
            this.spotify.Name = "spotify";
            this.spotify.Size = new System.Drawing.Size(102, 70);
            this.spotify.TabIndex = 7;
            this.spotify.UseVisualStyleBackColor = true;
            this.spotify.Click += new System.EventHandler(this.spotify_Click);
            // 
            // volume_up
            // 
            this.volume_up.Cursor = System.Windows.Forms.Cursors.Hand;
            this.volume_up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.volume_up.Image = global::Multimedia_Buttons.Properties.Resources.volume_up;
            this.volume_up.Location = new System.Drawing.Point(352, 12);
            this.volume_up.Name = "volume_up";
            this.volume_up.Size = new System.Drawing.Size(70, 70);
            this.volume_up.TabIndex = 6;
            this.volume_up.UseVisualStyleBackColor = true;
            this.volume_up.Click += new System.EventHandler(this.volume_up_Click);
            // 
            // volume_down
            // 
            this.volume_down.Cursor = System.Windows.Forms.Cursors.Hand;
            this.volume_down.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.volume_down.Image = global::Multimedia_Buttons.Properties.Resources.volume_down;
            this.volume_down.Location = new System.Drawing.Point(276, 12);
            this.volume_down.Name = "volume_down";
            this.volume_down.Size = new System.Drawing.Size(70, 70);
            this.volume_down.TabIndex = 5;
            this.volume_down.UseVisualStyleBackColor = true;
            this.volume_down.Click += new System.EventHandler(this.volume_down_Click);
            // 
            // mute
            // 
            this.mute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mute.Image = global::Multimedia_Buttons.Properties.Resources.mute;
            this.mute.Location = new System.Drawing.Point(92, 12);
            this.mute.Name = "mute";
            this.mute.Size = new System.Drawing.Size(70, 70);
            this.mute.TabIndex = 4;
            this.mute.UseVisualStyleBackColor = true;
            this.mute.Click += new System.EventHandler(this.mute_Click);
            // 
            // stop
            // 
            this.stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stop.Image = global::Multimedia_Buttons.Properties.Resources.stop;
            this.stop.Location = new System.Drawing.Point(12, 12);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(70, 70);
            this.stop.TabIndex = 3;
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // next_track
            // 
            this.next_track.Cursor = System.Windows.Forms.Cursors.Hand;
            this.next_track.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next_track.Image = global::Multimedia_Buttons.Properties.Resources.next_track;
            this.next_track.Location = new System.Drawing.Point(302, 104);
            this.next_track.Name = "next_track";
            this.next_track.Size = new System.Drawing.Size(120, 120);
            this.next_track.TabIndex = 2;
            this.next_track.UseVisualStyleBackColor = true;
            this.next_track.Click += new System.EventHandler(this.next_track_Click);
            this.next_track.MouseHover += new System.EventHandler(this.next_track_MouseHover);
            // 
            // prev_track
            // 
            this.prev_track.Cursor = System.Windows.Forms.Cursors.Hand;
            this.prev_track.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prev_track.Image = global::Multimedia_Buttons.Properties.Resources.prev_track;
            this.prev_track.Location = new System.Drawing.Point(12, 104);
            this.prev_track.Name = "prev_track";
            this.prev_track.Size = new System.Drawing.Size(120, 120);
            this.prev_track.TabIndex = 1;
            this.prev_track.UseVisualStyleBackColor = true;
            this.prev_track.Click += new System.EventHandler(this.prev_track_Click);
            this.prev_track.MouseHover += new System.EventHandler(this.prev_track_MouseHover);
            // 
            // play_pause
            // 
            this.play_pause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.play_pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play_pause.Image = global::Multimedia_Buttons.Properties.Resources.play_pause;
            this.play_pause.Location = new System.Drawing.Point(157, 104);
            this.play_pause.Name = "play_pause";
            this.play_pause.Size = new System.Drawing.Size(120, 120);
            this.play_pause.TabIndex = 0;
            this.play_pause.UseVisualStyleBackColor = true;
            this.play_pause.Click += new System.EventHandler(this.play_pause_Click);
            // 
            // skip_ad
            // 
            this.skip_ad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skip_ad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skip_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.skip_ad.Location = new System.Drawing.Point(328, 176);
            this.skip_ad.Name = "skip_ad";
            this.skip_ad.Size = new System.Drawing.Size(94, 48);
            this.skip_ad.TabIndex = 8;
            this.skip_ad.Text = "Skip Ad";
            this.skip_ad.UseVisualStyleBackColor = true;
            this.skip_ad.Click += new System.EventHandler(this.skip_ad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(434, 236);
            this.Controls.Add(this.skip_ad);
            this.Controls.Add(this.spotify);
            this.Controls.Add(this.volume_up);
            this.Controls.Add(this.volume_down);
            this.Controls.Add(this.mute);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.next_track);
            this.Controls.Add(this.prev_track);
            this.Controls.Add(this.play_pause);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Tag = "";
            this.Text = "Multimedia Buttons By github.com/maciekkoks";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button play_pause;
        private System.Windows.Forms.Button prev_track;
        private System.Windows.Forms.Button next_track;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button mute;
        private System.Windows.Forms.Button volume_down;
        private System.Windows.Forms.Button volume_up;
        private System.Windows.Forms.Button spotify;
        private System.Windows.Forms.Button skip_ad;
    }
}


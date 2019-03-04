namespace CMPE2300_ICa07_Toon
{
    partial class BlockGen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UI_Pop_butt = new System.Windows.Forms.Button();
            this.UI_Col_Butt = new System.Windows.Forms.Button();
            this.UI_Wid_Butt = new System.Windows.Forms.Button();
            this.UI_Wde_Butt = new System.Windows.Forms.Button();
            this.UI_Lon_Butt = new System.Windows.Forms.Button();
            this.UI_Bri_Butt = new System.Windows.Forms.Button();
            this.UI_Wco_Butt = new System.Windows.Forms.Button();
            this.UI_Track = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.UI_Track)).BeginInit();
            this.SuspendLayout();
            // 
            // UI_Pop_butt
            // 
            this.UI_Pop_butt.Location = new System.Drawing.Point(13, 13);
            this.UI_Pop_butt.Name = "UI_Pop_butt";
            this.UI_Pop_butt.Size = new System.Drawing.Size(265, 23);
            this.UI_Pop_butt.TabIndex = 0;
            this.UI_Pop_butt.Text = "Populate";
            this.UI_Pop_butt.UseVisualStyleBackColor = true;
            this.UI_Pop_butt.Click += new System.EventHandler(this.UI_Pop_butt_Click);
            // 
            // UI_Col_Butt
            // 
            this.UI_Col_Butt.Location = new System.Drawing.Point(13, 42);
            this.UI_Col_Butt.Name = "UI_Col_Butt";
            this.UI_Col_Butt.Size = new System.Drawing.Size(265, 23);
            this.UI_Col_Butt.TabIndex = 1;
            this.UI_Col_Butt.Text = "Color";
            this.UI_Col_Butt.UseVisualStyleBackColor = true;
            this.UI_Col_Butt.Click += new System.EventHandler(this.UI_Col_Butt_Click);
            // 
            // UI_Wid_Butt
            // 
            this.UI_Wid_Butt.Location = new System.Drawing.Point(12, 71);
            this.UI_Wid_Butt.Name = "UI_Wid_Butt";
            this.UI_Wid_Butt.Size = new System.Drawing.Size(265, 23);
            this.UI_Wid_Butt.TabIndex = 2;
            this.UI_Wid_Butt.Text = "Width";
            this.UI_Wid_Butt.UseVisualStyleBackColor = true;
            this.UI_Wid_Butt.Click += new System.EventHandler(this.UI_Wid_Butt_Click);
            // 
            // UI_Wde_Butt
            // 
            this.UI_Wde_Butt.Location = new System.Drawing.Point(12, 100);
            this.UI_Wde_Butt.Name = "UI_Wde_Butt";
            this.UI_Wde_Butt.Size = new System.Drawing.Size(265, 23);
            this.UI_Wde_Butt.TabIndex = 3;
            this.UI_Wde_Butt.Text = "Width desc";
            this.UI_Wde_Butt.UseVisualStyleBackColor = true;
            this.UI_Wde_Butt.Click += new System.EventHandler(this.UI_Wde_Butt_Click);
            // 
            // UI_Lon_Butt
            // 
            this.UI_Lon_Butt.Location = new System.Drawing.Point(12, 187);
            this.UI_Lon_Butt.Name = "UI_Lon_Butt";
            this.UI_Lon_Butt.Size = new System.Drawing.Size(265, 23);
            this.UI_Lon_Butt.TabIndex = 6;
            this.UI_Lon_Butt.Text = "Longer than 100";
            this.UI_Lon_Butt.UseVisualStyleBackColor = true;
            this.UI_Lon_Butt.Click += new System.EventHandler(this.UI_Lon_Butt_Click);
            // 
            // UI_Bri_Butt
            // 
            this.UI_Bri_Butt.Location = new System.Drawing.Point(12, 158);
            this.UI_Bri_Butt.Name = "UI_Bri_Butt";
            this.UI_Bri_Butt.Size = new System.Drawing.Size(265, 23);
            this.UI_Bri_Butt.TabIndex = 5;
            this.UI_Bri_Butt.Text = "Bright";
            this.UI_Bri_Butt.UseVisualStyleBackColor = true;
            this.UI_Bri_Butt.Click += new System.EventHandler(this.UI_Bri_Butt_Click);
            // 
            // UI_Wco_Butt
            // 
            this.UI_Wco_Butt.Location = new System.Drawing.Point(13, 129);
            this.UI_Wco_Butt.Name = "UI_Wco_Butt";
            this.UI_Wco_Butt.Size = new System.Drawing.Size(265, 23);
            this.UI_Wco_Butt.TabIndex = 4;
            this.UI_Wco_Butt.Text = "Width, Color";
            this.UI_Wco_Butt.UseVisualStyleBackColor = true;
            this.UI_Wco_Butt.Click += new System.EventHandler(this.UI_Wco_Butt_Click);
            // 
            // UI_Track
            // 
            this.UI_Track.Location = new System.Drawing.Point(12, 217);
            this.UI_Track.Maximum = 190;
            this.UI_Track.Minimum = 10;
            this.UI_Track.Name = "UI_Track";
            this.UI_Track.Size = new System.Drawing.Size(265, 45);
            this.UI_Track.TabIndex = 7;
            this.UI_Track.TickFrequency = 10;
            this.UI_Track.Value = 10;
            this.UI_Track.Scroll += new System.EventHandler(this.UI_Track_Scroll);
            // 
            // BlockGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 317);
            this.Controls.Add(this.UI_Track);
            this.Controls.Add(this.UI_Lon_Butt);
            this.Controls.Add(this.UI_Bri_Butt);
            this.Controls.Add(this.UI_Wco_Butt);
            this.Controls.Add(this.UI_Wde_Butt);
            this.Controls.Add(this.UI_Wid_Butt);
            this.Controls.Add(this.UI_Col_Butt);
            this.Controls.Add(this.UI_Pop_butt);
            this.Name = "BlockGen";
            this.Text = "BlockGenerator";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BlockGen_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.UI_Track)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UI_Pop_butt;
        private System.Windows.Forms.Button UI_Col_Butt;
        private System.Windows.Forms.Button UI_Wid_Butt;
        private System.Windows.Forms.Button UI_Wde_Butt;
        private System.Windows.Forms.Button UI_Lon_Butt;
        private System.Windows.Forms.Button UI_Bri_Butt;
        private System.Windows.Forms.Button UI_Wco_Butt;
        private System.Windows.Forms.TrackBar UI_Track;
    }
}


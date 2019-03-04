namespace CMPE2300_ICA08
{
    partial class UI_Form
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
            this.components = new System.ComponentModel.Container();
            this.UI_Sim_Butt = new System.Windows.Forms.Button();
            this.UI_NumUpDown = new System.Windows.Forms.NumericUpDown();
            this.UI_ListBox = new System.Windows.Forms.ListBox();
            this.UI_timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.UI_NumUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // UI_Sim_Butt
            // 
            this.UI_Sim_Butt.Location = new System.Drawing.Point(13, 13);
            this.UI_Sim_Butt.Name = "UI_Sim_Butt";
            this.UI_Sim_Butt.Size = new System.Drawing.Size(75, 23);
            this.UI_Sim_Butt.TabIndex = 0;
            this.UI_Sim_Butt.Text = "Simulate";
            this.UI_Sim_Butt.UseVisualStyleBackColor = true;
            this.UI_Sim_Butt.Click += new System.EventHandler(this.UI_Sim_Butt_Click);
            // 
            // UI_NumUpDown
            // 
            this.UI_NumUpDown.Location = new System.Drawing.Point(95, 13);
            this.UI_NumUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UI_NumUpDown.Name = "UI_NumUpDown";
            this.UI_NumUpDown.ReadOnly = true;
            this.UI_NumUpDown.Size = new System.Drawing.Size(47, 20);
            this.UI_NumUpDown.TabIndex = 1;
            this.UI_NumUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // UI_ListBox
            // 
            this.UI_ListBox.FormattingEnabled = true;
            this.UI_ListBox.Location = new System.Drawing.Point(13, 43);
            this.UI_ListBox.Name = "UI_ListBox";
            this.UI_ListBox.Size = new System.Drawing.Size(129, 446);
            this.UI_ListBox.TabIndex = 2;
            // 
            // UI_timer
            // 
            this.UI_timer.Enabled = true;
            this.UI_timer.Tick += new System.EventHandler(this.UI_timer_Tick);
            // 
            // UI_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(160, 505);
            this.Controls.Add(this.UI_ListBox);
            this.Controls.Add(this.UI_NumUpDown);
            this.Controls.Add(this.UI_Sim_Butt);
            this.Name = "UI_Form";
            this.Text = "Queue";
            ((System.ComponentModel.ISupportInitialize)(this.UI_NumUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UI_Sim_Butt;
        private System.Windows.Forms.NumericUpDown UI_NumUpDown;
        private System.Windows.Forms.ListBox UI_ListBox;
        private System.Windows.Forms.Timer UI_timer;
    }
}


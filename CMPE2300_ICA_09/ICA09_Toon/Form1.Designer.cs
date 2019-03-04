namespace ICA09_Toon
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
            this.UI_NumUpDown = new System.Windows.Forms.NumericUpDown();
            this.UI_List_Butt = new System.Windows.Forms.Button();
            this.UI_Link_Butt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UI_NumUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // UI_NumUpDown
            // 
            this.UI_NumUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.UI_NumUpDown.Location = new System.Drawing.Point(13, 13);
            this.UI_NumUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.UI_NumUpDown.Name = "UI_NumUpDown";
            this.UI_NumUpDown.Size = new System.Drawing.Size(259, 20);
            this.UI_NumUpDown.TabIndex = 0;
            this.UI_NumUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.UI_NumUpDown.ValueChanged += new System.EventHandler(this.UI_NumUpDown_ValueChanged);
            // 
            // UI_List_Butt
            // 
            this.UI_List_Butt.Location = new System.Drawing.Point(13, 40);
            this.UI_List_Butt.Name = "UI_List_Butt";
            this.UI_List_Butt.Size = new System.Drawing.Size(259, 39);
            this.UI_List_Butt.TabIndex = 1;
            this.UI_List_Butt.Text = "Make List";
            this.UI_List_Butt.UseVisualStyleBackColor = true;
            this.UI_List_Butt.Click += new System.EventHandler(this.UI_List_Butt_Click);
            // 
            // UI_Link_Butt
            // 
            this.UI_Link_Butt.Location = new System.Drawing.Point(12, 85);
            this.UI_Link_Butt.Name = "UI_Link_Butt";
            this.UI_Link_Butt.Size = new System.Drawing.Size(259, 39);
            this.UI_Link_Butt.TabIndex = 2;
            this.UI_Link_Butt.Text = "Populate Linked List";
            this.UI_Link_Butt.UseVisualStyleBackColor = true;
            this.UI_Link_Butt.Click += new System.EventHandler(this.UI_Link_Butt_Click);
            // 
            // UI_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 137);
            this.Controls.Add(this.UI_Link_Butt);
            this.Controls.Add(this.UI_List_Butt);
            this.Controls.Add(this.UI_NumUpDown);
            this.Name = "UI_Form";
            this.Text = "ICA09";
            ((System.ComponentModel.ISupportInitialize)(this.UI_NumUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown UI_NumUpDown;
        private System.Windows.Forms.Button UI_List_Butt;
        private System.Windows.Forms.Button UI_Link_Butt;
    }
}


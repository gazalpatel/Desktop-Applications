namespace ProjGazzKey
{
    partial class ShuffleRandom
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
            this.Loriginal = new System.Windows.Forms.Label();
            this.Lshuffled = new System.Windows.Forms.Label();
            this.BTNshuffle = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Lcount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Loriginal
            // 
            this.Loriginal.AutoSize = true;
            this.Loriginal.Location = new System.Drawing.Point(22, 30);
            this.Loriginal.Name = "Loriginal";
            this.Loriginal.Size = new System.Drawing.Size(40, 13);
            this.Loriginal.TabIndex = 0;
            this.Loriginal.Text = "original";
            // 
            // Lshuffled
            // 
            this.Lshuffled.AutoSize = true;
            this.Lshuffled.Location = new System.Drawing.Point(22, 93);
            this.Lshuffled.Name = "Lshuffled";
            this.Lshuffled.Size = new System.Drawing.Size(44, 13);
            this.Lshuffled.TabIndex = 1;
            this.Lshuffled.Text = "shuffled";
            // 
            // BTNshuffle
            // 
            this.BTNshuffle.Location = new System.Drawing.Point(193, 150);
            this.BTNshuffle.Name = "BTNshuffle";
            this.BTNshuffle.Size = new System.Drawing.Size(75, 23);
            this.BTNshuffle.TabIndex = 2;
            this.BTNshuffle.Text = "Shuffle";
            this.BTNshuffle.UseVisualStyleBackColor = true;
            this.BTNshuffle.Click += new System.EventHandler(this.BTNshuffle_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Lcount
            // 
            this.Lcount.AutoSize = true;
            this.Lcount.Location = new System.Drawing.Point(388, 13);
            this.Lcount.Name = "Lcount";
            this.Lcount.Size = new System.Drawing.Size(35, 13);
            this.Lcount.TabIndex = 3;
            this.Lcount.Text = "Count";
            // 
            // ShuffleRandom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 188);
            this.Controls.Add(this.Lcount);
            this.Controls.Add(this.BTNshuffle);
            this.Controls.Add(this.Lshuffled);
            this.Controls.Add(this.Loriginal);
            this.Name = "ShuffleRandom";
            this.Text = "ShuffleRandom";
            this.Load += new System.EventHandler(this.ShuffleRandom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Loriginal;
        private System.Windows.Forms.Label Lshuffled;
        private System.Windows.Forms.Button BTNshuffle;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Lcount;
    }
}
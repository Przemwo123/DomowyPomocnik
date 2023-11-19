namespace DomowyPomocnik.Forms
{
    partial class Home
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
            this.dateText = new System.Windows.Forms.Label();
            this.timeText = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // dateText
            // 
            this.dateText.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateText.Location = new System.Drawing.Point(0, 195);
            this.dateText.Name = "dateText";
            this.dateText.Size = new System.Drawing.Size(655, 69);
            this.dateText.TabIndex = 8;
            this.dateText.Text = "01 Stycznia 2020";
            this.dateText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timeText
            // 
            this.timeText.Dock = System.Windows.Forms.DockStyle.Top;
            this.timeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeText.Location = new System.Drawing.Point(0, 0);
            this.timeText.Name = "timeText";
            this.timeText.Size = new System.Drawing.Size(655, 195);
            this.timeText.TabIndex = 7;
            this.timeText.Text = "00:00:00";
            this.timeText.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 402);
            this.Controls.Add(this.dateText);
            this.Controls.Add(this.timeText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label dateText;
        private System.Windows.Forms.Label timeText;
        private System.Windows.Forms.Timer timer1;
    }
}
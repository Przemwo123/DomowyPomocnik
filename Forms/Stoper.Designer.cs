namespace ProgramForms.Forms
{
    partial class Stoper
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
            this.stopwatchText = new System.Windows.Forms.Label();
            this.timeStartStop = new System.Windows.Forms.Button();
            this.timeResume = new System.Windows.Forms.Button();
            this.timeReset = new System.Windows.Forms.Button();
            this.timerStoper = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // stopwatchText
            // 
            this.stopwatchText.Dock = System.Windows.Forms.DockStyle.Top;
            this.stopwatchText.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stopwatchText.Location = new System.Drawing.Point(0, 0);
            this.stopwatchText.Name = "stopwatchText";
            this.stopwatchText.Size = new System.Drawing.Size(655, 195);
            this.stopwatchText.TabIndex = 8;
            this.stopwatchText.Text = "00:00.00";
            this.stopwatchText.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // timeStartStop
            // 
            this.timeStartStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.timeStartStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(27)))), ((int)(((byte)(177)))));
            this.timeStartStop.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.timeStartStop.FlatAppearance.BorderSize = 0;
            this.timeStartStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timeStartStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeStartStop.ForeColor = System.Drawing.Color.White;
            this.timeStartStop.Location = new System.Drawing.Point(265, 272);
            this.timeStartStop.Name = "timeStartStop";
            this.timeStartStop.Size = new System.Drawing.Size(124, 48);
            this.timeStartStop.TabIndex = 21;
            this.timeStartStop.Text = "Rozpocznij";
            this.timeStartStop.UseVisualStyleBackColor = false;
            this.timeStartStop.Click += new System.EventHandler(this.timeStartStop_Click);
            // 
            // timeResume
            // 
            this.timeResume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.timeResume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(27)))), ((int)(((byte)(177)))));
            this.timeResume.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.timeResume.FlatAppearance.BorderSize = 0;
            this.timeResume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timeResume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeResume.ForeColor = System.Drawing.Color.White;
            this.timeResume.Location = new System.Drawing.Point(190, 272);
            this.timeResume.Name = "timeResume";
            this.timeResume.Size = new System.Drawing.Size(124, 48);
            this.timeResume.TabIndex = 19;
            this.timeResume.Text = "Wznów";
            this.timeResume.UseVisualStyleBackColor = false;
            this.timeResume.Click += new System.EventHandler(this.timeResume_Click);
            // 
            // timeReset
            // 
            this.timeReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.timeReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(27)))), ((int)(((byte)(177)))));
            this.timeReset.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.timeReset.FlatAppearance.BorderSize = 0;
            this.timeReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timeReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeReset.ForeColor = System.Drawing.Color.White;
            this.timeReset.Location = new System.Drawing.Point(340, 272);
            this.timeReset.Name = "timeReset";
            this.timeReset.Size = new System.Drawing.Size(124, 48);
            this.timeReset.TabIndex = 20;
            this.timeReset.Text = "Resetuj";
            this.timeReset.UseVisualStyleBackColor = false;
            this.timeReset.Click += new System.EventHandler(this.timeReset_Click);
            // 
            // timerStoper
            // 
            this.timerStoper.Interval = 10;
            this.timerStoper.Tick += new System.EventHandler(this.timerStoper_Tick);
            // 
            // Stoper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 402);
            this.Controls.Add(this.timeStartStop);
            this.Controls.Add(this.timeReset);
            this.Controls.Add(this.timeResume);
            this.Controls.Add(this.stopwatchText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Stoper";
            this.Text = "Stoper";
            this.Load += new System.EventHandler(this.Stoper_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label stopwatchText;
        private System.Windows.Forms.Button timeStartStop;
        private System.Windows.Forms.Button timeResume;
        private System.Windows.Forms.Button timeReset;
        private System.Windows.Forms.Timer timerStoper;
    }
}
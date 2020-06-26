namespace ProgramForms.Forms
{
    partial class Pogoda
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
            this.cityNameText = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.temText = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.infoWeather = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cityNameLocation = new System.Windows.Forms.TextBox();
            this.btnUpdWeather = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cityNameText
            // 
            this.cityNameText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cityNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cityNameText.Location = new System.Drawing.Point(0, 73);
            this.cityNameText.Name = "cityNameText";
            this.cityNameText.Size = new System.Drawing.Size(655, 45);
            this.cityNameText.TabIndex = 2;
            this.cityNameText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cityNameText);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(655, 118);
            this.panel2.TabIndex = 9;
            // 
            // temText
            // 
            this.temText.AutoSize = true;
            this.temText.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.temText.Location = new System.Drawing.Point(306, 3);
            this.temText.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.temText.Name = "temText";
            this.temText.Size = new System.Drawing.Size(0, 64);
            this.temText.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.temText);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 118);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(655, 81);
            this.panel3.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(12, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Moja lokalizacja:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // infoWeather
            // 
            this.infoWeather.Dock = System.Windows.Forms.DockStyle.Top;
            this.infoWeather.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.infoWeather.Location = new System.Drawing.Point(0, 0);
            this.infoWeather.Name = "infoWeather";
            this.infoWeather.Size = new System.Drawing.Size(655, 37);
            this.infoWeather.TabIndex = 4;
            this.infoWeather.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.infoWeather);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 199);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(655, 64);
            this.panel4.TabIndex = 11;
            // 
            // cityNameLocation
            // 
            this.cityNameLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cityNameLocation.Location = new System.Drawing.Point(12, 361);
            this.cityNameLocation.Name = "cityNameLocation";
            this.cityNameLocation.Size = new System.Drawing.Size(153, 29);
            this.cityNameLocation.TabIndex = 6;
            this.cityNameLocation.Text = "Zielona Góra";
            // 
            // btnUpdWeather
            // 
            this.btnUpdWeather.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(111)))), ((int)(((byte)(242)))));
            this.btnUpdWeather.FlatAppearance.BorderSize = 0;
            this.btnUpdWeather.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdWeather.Image = global::ProgramForms.Properties.Resources.update;
            this.btnUpdWeather.Location = new System.Drawing.Point(593, 338);
            this.btnUpdWeather.Name = "btnUpdWeather";
            this.btnUpdWeather.Size = new System.Drawing.Size(50, 50);
            this.btnUpdWeather.TabIndex = 12;
            this.btnUpdWeather.UseVisualStyleBackColor = false;
            this.btnUpdWeather.Click += new System.EventHandler(this.btnUpdWeather_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(231, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Pogoda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 402);
            this.Controls.Add(this.btnUpdWeather);
            this.Controls.Add(this.cityNameLocation);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pogoda";
            this.Text = "Historia";
            this.Load += new System.EventHandler(this.Pogoda_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cityNameText;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label temText;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label infoWeather;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox cityNameLocation;
        private System.Windows.Forms.Button btnUpdWeather;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
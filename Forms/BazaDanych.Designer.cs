namespace DomowyPomocnik.Forms
{
    partial class BazaDanych
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataBaseConfiguration = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCon = new System.Windows.Forms.Button();
            this.statusText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataBaseConfiguration);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.btnCon);
            this.panel2.Controls.Add(this.statusText);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(655, 402);
            this.panel2.TabIndex = 15;
            // 
            // dataBaseConfiguration
            // 
            this.dataBaseConfiguration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(190)))), ((int)(((byte)(255)))));
            this.dataBaseConfiguration.FlatAppearance.BorderSize = 0;
            this.dataBaseConfiguration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataBaseConfiguration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dataBaseConfiguration.ForeColor = System.Drawing.Color.White;
            this.dataBaseConfiguration.Location = new System.Drawing.Point(141, 39);
            this.dataBaseConfiguration.Name = "dataBaseConfiguration";
            this.dataBaseConfiguration.Size = new System.Drawing.Size(123, 50);
            this.dataBaseConfiguration.TabIndex = 18;
            this.dataBaseConfiguration.Text = "Konfiguracja";
            this.dataBaseConfiguration.UseVisualStyleBackColor = false;
            this.dataBaseConfiguration.Click += new System.EventHandler(this.dataBaseConfiguration_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(642, 285);
            this.dataGridView1.TabIndex = 17;
            // 
            // btnCon
            // 
            this.btnCon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(190)))), ((int)(((byte)(255)))));
            this.btnCon.FlatAppearance.BorderSize = 0;
            this.btnCon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCon.ForeColor = System.Drawing.Color.White;
            this.btnCon.Location = new System.Drawing.Point(12, 39);
            this.btnCon.Name = "btnCon";
            this.btnCon.Size = new System.Drawing.Size(123, 50);
            this.btnCon.TabIndex = 2;
            this.btnCon.Text = "Połącz";
            this.btnCon.UseVisualStyleBackColor = false;
            this.btnCon.Click += new System.EventHandler(this.btnCon_Click);
            // 
            // statusText
            // 
            this.statusText.AutoSize = true;
            this.statusText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.statusText.Location = new System.Drawing.Point(53, 9);
            this.statusText.Margin = new System.Windows.Forms.Padding(0);
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(15, 20);
            this.statusText.TabIndex = 9;
            this.statusText.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Stan:";
            // 
            // BazaDanych
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 402);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BazaDanych";
            this.Text = "BazaDanych";
            this.Load += new System.EventHandler(this.BazaDanych_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCon;
        private System.Windows.Forms.Label statusText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button dataBaseConfiguration;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
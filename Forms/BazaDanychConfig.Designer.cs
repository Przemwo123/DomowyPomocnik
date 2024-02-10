namespace DomowyPomocnik.Forms
{
    partial class BazaDanychConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BazaDanychConfig));
            this.label5 = new System.Windows.Forms.Label();
            this.nDB = new System.Windows.Forms.TextBox();
            this.tDB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uDB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pDB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.aDB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.configDBSave = new System.Windows.Forms.Button();
            this.configDBCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Name = "label5";
            // 
            // nDB
            // 
            resources.ApplyResources(this.nDB, "nDB");
            this.nDB.Name = "nDB";
            // 
            // tDB
            // 
            resources.ApplyResources(this.tDB, "tDB");
            this.tDB.Name = "tDB";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Name = "label1";
            // 
            // uDB
            // 
            resources.ApplyResources(this.uDB, "uDB");
            this.uDB.Name = "uDB";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Name = "label2";
            // 
            // pDB
            // 
            resources.ApplyResources(this.pDB, "pDB");
            this.pDB.Name = "pDB";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Name = "label3";
            // 
            // aDB
            // 
            resources.ApplyResources(this.aDB, "aDB");
            this.aDB.Name = "aDB";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Name = "label4";
            // 
            // configDBSave
            // 
            this.configDBSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(190)))), ((int)(((byte)(255)))));
            this.configDBSave.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.configDBSave, "configDBSave");
            this.configDBSave.ForeColor = System.Drawing.Color.White;
            this.configDBSave.Name = "configDBSave";
            this.configDBSave.UseVisualStyleBackColor = false;
            this.configDBSave.Click += new System.EventHandler(this.configDBSave_Click);
            // 
            // configDBCancel
            // 
            this.configDBCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(190)))), ((int)(((byte)(255)))));
            this.configDBCancel.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.configDBCancel, "configDBCancel");
            this.configDBCancel.ForeColor = System.Drawing.Color.White;
            this.configDBCancel.Name = "configDBCancel";
            this.configDBCancel.UseVisualStyleBackColor = false;
            this.configDBCancel.Click += new System.EventHandler(this.configDBCancel_Click);
            // 
            // BazaDanychConfig
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.configDBCancel);
            this.Controls.Add(this.configDBSave);
            this.Controls.Add(this.aDB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pDB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uDB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tDB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nDB);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BazaDanychConfig";
            this.Load += new System.EventHandler(this.BazaDanychConfig_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nDB;
        private System.Windows.Forms.TextBox tDB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uDB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pDB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox aDB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button configDBSave;
        private System.Windows.Forms.Button configDBCancel;
    }
}
namespace CreateField
{
    partial class Form1
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
            this.button2 = new System.Windows.Forms.Button();
            this.servidor = new System.Windows.Forms.TextBox();
            this.basededados = new System.Windows.Forms.TextBox();
            this.userdb = new System.Windows.Forms.TextBox();
            this.senhadb = new System.Windows.Forms.TextBox();
            this.senhasap = new System.Windows.Forms.TextBox();
            this.usersap = new System.Windows.Forms.TextBox();
            this.license = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.namecampo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.aliascampo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tipocampo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tamanhocampo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tabelacampo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(180, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "Create";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // servidor
            // 
            this.servidor.Location = new System.Drawing.Point(91, 33);
            this.servidor.Name = "servidor";
            this.servidor.Size = new System.Drawing.Size(100, 20);
            this.servidor.TabIndex = 3;
            this.servidor.Text = "SGVL01SAP01";
            this.servidor.TextChanged += new System.EventHandler(this.servidor_TextChanged);
            // 
            // basededados
            // 
            this.basededados.Location = new System.Drawing.Point(91, 59);
            this.basededados.Name = "basededados";
            this.basededados.Size = new System.Drawing.Size(100, 20);
            this.basededados.TabIndex = 4;
            this.basededados.Text = "SBO_SAP";
            // 
            // userdb
            // 
            this.userdb.Location = new System.Drawing.Point(91, 85);
            this.userdb.Name = "userdb";
            this.userdb.Size = new System.Drawing.Size(100, 20);
            this.userdb.TabIndex = 5;
            this.userdb.Text = "sa";
            // 
            // senhadb
            // 
            this.senhadb.Location = new System.Drawing.Point(299, 85);
            this.senhadb.Name = "senhadb";
            this.senhadb.Size = new System.Drawing.Size(100, 20);
            this.senhadb.TabIndex = 6;
            // 
            // senhasap
            // 
            this.senhasap.Location = new System.Drawing.Point(299, 144);
            this.senhasap.Name = "senhasap";
            this.senhasap.Size = new System.Drawing.Size(100, 20);
            this.senhasap.TabIndex = 7;
            // 
            // usersap
            // 
            this.usersap.Location = new System.Drawing.Point(91, 144);
            this.usersap.Name = "usersap";
            this.usersap.Size = new System.Drawing.Size(100, 20);
            this.usersap.TabIndex = 8;
            this.usersap.Text = "manager";
            // 
            // license
            // 
            this.license.Location = new System.Drawing.Point(91, 170);
            this.license.Name = "license";
            this.license.Size = new System.Drawing.Size(100, 20);
            this.license.TabIndex = 9;
            this.license.Text = "localhost:30000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Server BD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Database";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Pw DB";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "User SAP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(217, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "PW SAP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "License Server";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "User DB";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "BD Type";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2005",
            "2008",
            "2012",
            "2014",
            "2016",
            "2017",
            "HANA"});
            this.comboBox1.Location = new System.Drawing.Point(299, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 19;
            // 
            // namecampo
            // 
            this.namecampo.Location = new System.Drawing.Point(91, 222);
            this.namecampo.Name = "namecampo";
            this.namecampo.Size = new System.Drawing.Size(100, 20);
            this.namecampo.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Field Name";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // aliascampo
            // 
            this.aliascampo.Location = new System.Drawing.Point(299, 222);
            this.aliascampo.Name = "aliascampo";
            this.aliascampo.Size = new System.Drawing.Size(100, 20);
            this.aliascampo.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(212, 225);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Aliases Name";
            // 
            // tipocampo
            // 
            this.tipocampo.FormattingEnabled = true;
            this.tipocampo.Items.AddRange(new object[] {
            "Valor",
            "Numerico",
            "Data",
            "Texto"});
            this.tipocampo.Location = new System.Drawing.Point(92, 249);
            this.tipocampo.Name = "tipocampo";
            this.tipocampo.Size = new System.Drawing.Size(99, 21);
            this.tipocampo.TabIndex = 24;
            this.tipocampo.SelectedIndexChanged += new System.EventHandler(this.tipocampo_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 251);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Field Type";
            // 
            // tamanhocampo
            // 
            this.tamanhocampo.Location = new System.Drawing.Point(299, 250);
            this.tamanhocampo.Name = "tamanhocampo";
            this.tamanhocampo.Size = new System.Drawing.Size(100, 20);
            this.tamanhocampo.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(214, 253);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Field Size";
            // 
            // tabelacampo
            // 
            this.tabelacampo.Location = new System.Drawing.Point(91, 276);
            this.tabelacampo.Name = "tabelacampo";
            this.tabelacampo.Size = new System.Drawing.Size(100, 20);
            this.tabelacampo.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 279);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Table";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(177, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(117, 15);
            this.label14.TabIndex = 30;
            this.label14.Text = "Database Config.";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(177, 117);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 15);
            this.label15.TabIndex = 31;
            this.label15.Text = "SAP Config.";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(177, 193);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 15);
            this.label16.TabIndex = 32;
            this.label16.Text = "Create Field";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(179, 359);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(103, 13);
            this.label17.TabIndex = 33;
            this.label17.Text = "Copyright MRGhidini";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 381);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tabelacampo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tamanhocampo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tipocampo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.aliascampo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.namecampo);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.license);
            this.Controls.Add(this.usersap);
            this.Controls.Add(this.senhasap);
            this.Controls.Add(this.senhadb);
            this.Controls.Add(this.userdb);
            this.Controls.Add(this.basededados);
            this.Controls.Add(this.servidor);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateField 1.1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_Closing);
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox servidor;
        private System.Windows.Forms.TextBox basededados;
        private System.Windows.Forms.TextBox userdb;
        private System.Windows.Forms.TextBox senhadb;
        private System.Windows.Forms.TextBox senhasap;
        private System.Windows.Forms.TextBox usersap;
        private System.Windows.Forms.TextBox license;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox namecampo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox aliascampo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox tipocampo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tamanhocampo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tabelacampo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
    }
}


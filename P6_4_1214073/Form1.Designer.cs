namespace P6_4_1214073
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.txttelpon = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.tbtinggi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbJabatan = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbberat = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtalamat = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.epWar = new System.Windows.Forms.ErrorProvider(this.components);
            this.epEr = new System.Windows.Forms.ErrorProvider(this.components);
            this.epcor = new System.Windows.Forms.ErrorProvider(this.components);
            this.txthobi = new System.Windows.Forms.TextBox();
            this.Hobi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.epWar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epEr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epcor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LavenderBlush;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(272, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pendaftaran PT Pamapersada";
            // 
            // txtnama
            // 
            this.txtnama.Location = new System.Drawing.Point(276, 54);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(183, 20);
            this.txtnama.TabIndex = 1;
            this.txtnama.TextChanged += new System.EventHandler(this.txtnama_TextChanged);
            this.txtnama.Leave += new System.EventHandler(this.tbnama_Leave);
            // 
            // txttelpon
            // 
            this.txttelpon.Location = new System.Drawing.Point(276, 99);
            this.txttelpon.Name = "txttelpon";
            this.txttelpon.Size = new System.Drawing.Size(183, 20);
            this.txttelpon.TabIndex = 2;
            this.txttelpon.TextChanged += new System.EventHandler(this.txttelpon_TextChanged);
            this.txttelpon.Leave += new System.EventHandler(this.txttelpon_Leave);
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(276, 146);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(183, 20);
            this.txtemail.TabIndex = 3;
            this.txtemail.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txtemail.Leave += new System.EventHandler(this.txtemail_Leave);
            // 
            // tbtinggi
            // 
            this.tbtinggi.Location = new System.Drawing.Point(276, 267);
            this.tbtinggi.Name = "tbtinggi";
            this.tbtinggi.Size = new System.Drawing.Size(51, 20);
            this.tbtinggi.TabIndex = 4;
            this.tbtinggi.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.tbtinggi.Leave += new System.EventHandler(this.tbtinggi_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(-95, -99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(99, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nama";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(99, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(99, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "No telpon";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(504, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.Location = new System.Drawing.Point(261, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label8.Location = new System.Drawing.Point(504, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label9.Location = new System.Drawing.Point(261, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label10.Location = new System.Drawing.Point(102, 310);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Berat";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label11.Location = new System.Drawing.Point(333, 310);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Kg";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label12.Location = new System.Drawing.Point(102, 267);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Tinggi";
            // 
            // cbJabatan
            // 
            this.cbJabatan.FormattingEnabled = true;
            this.cbJabatan.Items.AddRange(new object[] {
            "Staff IT",
            "Supervisor",
            "Operator",
            "Mekanik"});
            this.cbJabatan.Location = new System.Drawing.Point(276, 191);
            this.cbJabatan.Name = "cbJabatan";
            this.cbJabatan.Size = new System.Drawing.Size(144, 21);
            this.cbJabatan.TabIndex = 16;
            this.cbJabatan.Text = "-- Pilih Bidang Pekerjaan --";
            this.cbJabatan.SelectedIndexChanged += new System.EventHandler(this.cbJabatan_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label13.Location = new System.Drawing.Point(99, 194);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Pilih Posisi pekerjaan";
            // 
            // tbberat
            // 
            this.tbberat.Location = new System.Drawing.Point(276, 307);
            this.tbberat.Name = "tbberat";
            this.tbberat.Size = new System.Drawing.Size(51, 20);
            this.tbberat.TabIndex = 18;
            this.tbberat.Leave += new System.EventHandler(this.tbberat_Leave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label14.Location = new System.Drawing.Point(333, 267);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(22, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "Cm";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(97, 226);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(400, 25);
            this.label15.TabIndex = 20;
            this.label15.Text = "Tinggi Badan Harus > dari berat badan !";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label16.Location = new System.Drawing.Point(102, 349);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(39, 13);
            this.label16.TabIndex = 21;
            this.label16.Text = "Alamat";
            // 
            // txtalamat
            // 
            this.txtalamat.Location = new System.Drawing.Point(276, 341);
            this.txtalamat.Name = "txtalamat";
            this.txtalamat.Size = new System.Drawing.Size(183, 20);
            this.txtalamat.TabIndex = 22;
            this.txtalamat.Leave += new System.EventHandler(this.txtalamat_Leave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(583, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Tampikan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(703, 405);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // epWar
            // 
            this.epWar.ContainerControl = this;
            this.epWar.Icon = ((System.Drawing.Icon)(resources.GetObject("epWar.Icon")));
            // 
            // epEr
            // 
            this.epEr.ContainerControl = this;
            this.epEr.Icon = ((System.Drawing.Icon)(resources.GetObject("epEr.Icon")));
            // 
            // epcor
            // 
            this.epcor.ContainerControl = this;
            this.epcor.Icon = ((System.Drawing.Icon)(resources.GetObject("epcor.Icon")));
            // 
            // txthobi
            // 
            this.txthobi.Location = new System.Drawing.Point(276, 381);
            this.txthobi.Name = "txthobi";
            this.txthobi.Size = new System.Drawing.Size(183, 20);
            this.txthobi.TabIndex = 25;
            this.txthobi.Leave += new System.EventHandler(this.txthobi_Leave);
            // 
            // Hobi
            // 
            this.Hobi.AutoSize = true;
            this.Hobi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Hobi.Location = new System.Drawing.Point(103, 384);
            this.Hobi.Name = "Hobi";
            this.Hobi.Size = new System.Drawing.Size(29, 13);
            this.Hobi.TabIndex = 26;
            this.Hobi.Text = "Hobi";
            this.Hobi.Leave += new System.EventHandler(this.Hobi_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Hobi);
            this.Controls.Add(this.txthobi);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtalamat);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tbberat);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cbJabatan);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbtinggi);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txttelpon);
            this.Controls.Add(this.txtnama);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Nama";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epWar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epEr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epcor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnama;
        private System.Windows.Forms.TextBox txttelpon;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox tbtinggi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbJabatan;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbberat;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtalamat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider epWar;
        private System.Windows.Forms.ErrorProvider epEr;
        private System.Windows.Forms.ErrorProvider epcor;
        private System.Windows.Forms.Label Hobi;
        private System.Windows.Forms.TextBox txthobi;
    }
}


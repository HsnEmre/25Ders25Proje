
namespace _5_MasaÜstüKişiselFilmArşivi
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.txtkategori = new System.Windows.Forms.TextBox();
            this.txtlnk = new System.Windows.Forms.TextBox();
            this.btnkyt = new System.Windows.Forms.Button();
            this.btnhkkmzda = new System.Windows.Forms.Button();
            this.btnrenkdeğiştir = new System.Windows.Forms.Button();
            this.btntmekran = new System.Windows.Forms.Button();
            this.btnex = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1293, 111);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnex);
            this.groupBox1.Controls.Add(this.btnrenkdeğiştir);
            this.groupBox1.Controls.Add(this.btnhkkmzda);
            this.groupBox1.Controls.Add(this.btntmekran);
            this.groupBox1.Controls.Add(this.btnkyt);
            this.groupBox1.Controls.Add(this.txtlnk);
            this.groupBox1.Controls.Add(this.txtkategori);
            this.groupBox1.Controls.Add(this.txtad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 660);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Film";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.webBrowser1);
            this.groupBox2.Location = new System.Drawing.Point(665, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(629, 651);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ekran";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 26);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(623, 622);
            this.webBrowser1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(370, 119);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(289, 660);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Film Listesi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "AD:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Link:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kategori:";
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(60, 49);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(262, 30);
            this.txtad.TabIndex = 1;
            // 
            // txtkategori
            // 
            this.txtkategori.Location = new System.Drawing.Point(100, 90);
            this.txtkategori.Name = "txtkategori";
            this.txtkategori.Size = new System.Drawing.Size(222, 30);
            this.txtkategori.TabIndex = 2;
            // 
            // txtlnk
            // 
            this.txtlnk.Location = new System.Drawing.Point(76, 126);
            this.txtlnk.Name = "txtlnk";
            this.txtlnk.Size = new System.Drawing.Size(222, 30);
            this.txtlnk.TabIndex = 2;
            // 
            // btnkyt
            // 
            this.btnkyt.Location = new System.Drawing.Point(11, 172);
            this.btnkyt.Name = "btnkyt";
            this.btnkyt.Size = new System.Drawing.Size(320, 39);
            this.btnkyt.TabIndex = 3;
            this.btnkyt.Text = "Kaydet";
            this.btnkyt.UseVisualStyleBackColor = true;
            this.btnkyt.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnhkkmzda
            // 
            this.btnhkkmzda.Location = new System.Drawing.Point(11, 275);
            this.btnhkkmzda.Name = "btnhkkmzda";
            this.btnhkkmzda.Size = new System.Drawing.Size(320, 39);
            this.btnhkkmzda.TabIndex = 3;
            this.btnhkkmzda.Text = "Hakkımızda";
            this.btnhkkmzda.UseVisualStyleBackColor = true;
            // 
            // btnrenkdeğiştir
            // 
            this.btnrenkdeğiştir.Location = new System.Drawing.Point(6, 320);
            this.btnrenkdeğiştir.Name = "btnrenkdeğiştir";
            this.btnrenkdeğiştir.Size = new System.Drawing.Size(320, 39);
            this.btnrenkdeğiştir.TabIndex = 3;
            this.btnrenkdeğiştir.Text = "Renk Değiştir";
            this.btnrenkdeğiştir.UseVisualStyleBackColor = true;
            // 
            // btntmekran
            // 
            this.btntmekran.Location = new System.Drawing.Point(6, 217);
            this.btntmekran.Name = "btntmekran";
            this.btntmekran.Size = new System.Drawing.Size(320, 39);
            this.btntmekran.TabIndex = 3;
            this.btntmekran.Text = "Tam ekran";
            this.btntmekran.UseVisualStyleBackColor = true;
            this.btntmekran.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnex
            // 
            this.btnex.Location = new System.Drawing.Point(11, 374);
            this.btnex.Name = "btnex";
            this.btnex.Size = new System.Drawing.Size(320, 39);
            this.btnex.TabIndex = 3;
            this.btnex.Text = "Çıkış";
            this.btnex.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(283, 631);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1292, 791);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnrenkdeğiştir;
        private System.Windows.Forms.Button btnhkkmzda;
        private System.Windows.Forms.Button btnkyt;
        private System.Windows.Forms.TextBox txtlnk;
        private System.Windows.Forms.TextBox txtkategori;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnex;
        private System.Windows.Forms.Button btntmekran;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}



namespace Karar_Verme_Teknikleri
{
    partial class Karar_Verme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Karar_Verme));
            this.konum = new System.Windows.Forms.TextBox();
            this.type = new System.Windows.Forms.ComboBox();
            this.typename = new System.Windows.Forms.TextBox();
            this.alternatif = new System.Windows.Forms.TextBox();
            this.durum = new System.Windows.Forms.TextBox();
            this.alpha = new System.Windows.Forms.TextBox();
            this.alphano = new System.Windows.Forms.NumericUpDown();
            this.veri = new System.Windows.Forms.TextBox();
            this.dgvMatrix1 = new System.Windows.Forms.DataGridView();
            this.tbFila1 = new System.Windows.Forms.TextBox();
            this.tbColumn1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.alphano)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrix1)).BeginInit();
            this.SuspendLayout();
            // 
            // konum
            // 
            this.konum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.konum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.konum.ForeColor = System.Drawing.Color.LimeGreen;
            this.konum.Location = new System.Drawing.Point(50, 30);
            this.konum.Name = "konum";
            this.konum.Size = new System.Drawing.Size(515, 27);
            this.konum.TabIndex = 0;
            this.konum.Text = "BELİRSİZLİK ALTINDA KARAR VERME";
            this.konum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.konum.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // type
            // 
            this.type.AutoCompleteCustomSource.AddRange(new string[] {
            "Gelir",
            "Maliyet"});
            this.type.FormattingEnabled = true;
            this.type.Items.AddRange(new object[] {
            "Getir",
            "Maliyet"});
            this.type.Location = new System.Drawing.Point(50, 140);
            this.type.MaxDropDownItems = 3;
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(315, 24);
            this.type.TabIndex = 5;
            this.type.SelectedIndexChanged += new System.EventHandler(this.type_SelectedIndexChanged);
            // 
            // typename
            // 
            this.typename.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.typename.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.typename.ForeColor = System.Drawing.Color.LimeGreen;
            this.typename.Location = new System.Drawing.Point(50, 110);
            this.typename.Name = "typename";
            this.typename.Size = new System.Drawing.Size(315, 20);
            this.typename.TabIndex = 6;
            this.typename.Text = "Problemin yapısını seçiniz";
            this.typename.TextChanged += new System.EventHandler(this.typename_TextChanged);
            // 
            // alternatif
            // 
            this.alternatif.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.alternatif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alternatif.ForeColor = System.Drawing.Color.LimeGreen;
            this.alternatif.Location = new System.Drawing.Point(50, 190);
            this.alternatif.Name = "alternatif";
            this.alternatif.Size = new System.Drawing.Size(315, 20);
            this.alternatif.TabIndex = 7;
            this.alternatif.Text = "Alternatif sayısını seçiniz";
            // 
            // durum
            // 
            this.durum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.durum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.durum.ForeColor = System.Drawing.Color.LimeGreen;
            this.durum.Location = new System.Drawing.Point(50, 270);
            this.durum.Name = "durum";
            this.durum.Size = new System.Drawing.Size(315, 20);
            this.durum.TabIndex = 8;
            this.durum.Text = "Doğal durumlar sayısını seçiniz";
            // 
            // alpha
            // 
            this.alpha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.alpha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alpha.ForeColor = System.Drawing.Color.LimeGreen;
            this.alpha.Location = new System.Drawing.Point(50, 350);
            this.alpha.Name = "alpha";
            this.alpha.Size = new System.Drawing.Size(315, 20);
            this.alpha.TabIndex = 9;
            this.alpha.Text = "α seçiniz";
            // 
            // alphano
            // 
            this.alphano.DecimalPlaces = 2;
            this.alphano.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.alphano.Location = new System.Drawing.Point(50, 380);
            this.alphano.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.alphano.Name = "alphano";
            this.alphano.Size = new System.Drawing.Size(120, 22);
            this.alphano.TabIndex = 12;
            this.alphano.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // veri
            // 
            this.veri.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.veri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.veri.ForeColor = System.Drawing.Color.LimeGreen;
            this.veri.Location = new System.Drawing.Point(595, 110);
            this.veri.Name = "veri";
            this.veri.Size = new System.Drawing.Size(212, 20);
            this.veri.TabIndex = 13;
            this.veri.Text = "Veri girişi:";
            this.veri.TextChanged += new System.EventHandler(this.veri_TextChanged);
            // 
            // dgvMatrix1
            // 
            this.dgvMatrix1.AllowUserToOrderColumns = true;
            this.dgvMatrix1.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dgvMatrix1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatrix1.Location = new System.Drawing.Point(527, 140);
            this.dgvMatrix1.Name = "dgvMatrix1";
            this.dgvMatrix1.RowHeadersWidth = 51;
            this.dgvMatrix1.RowTemplate.Height = 24;
            this.dgvMatrix1.Size = new System.Drawing.Size(301, 231);
            this.dgvMatrix1.TabIndex = 14;
            this.dgvMatrix1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tbFila1
            // 
            this.tbFila1.Location = new System.Drawing.Point(50, 216);
            this.tbFila1.Name = "tbFila1";
            this.tbFila1.Size = new System.Drawing.Size(100, 22);
            this.tbFila1.TabIndex = 15;
            // 
            // tbColumn1
            // 
            this.tbColumn1.Location = new System.Drawing.Point(50, 296);
            this.tbColumn1.Name = "tbColumn1";
            this.tbColumn1.Size = new System.Drawing.Size(100, 22);
            this.tbColumn1.TabIndex = 16;
            this.tbColumn1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.tbColumn1.Leave += new System.EventHandler(this.tbColumn1_Leave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(595, 459);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 34);
            this.button1.TabIndex = 17;
            this.button1.Text = "HESAPLA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LimeGreen;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(773, 459);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 34);
            this.button2.TabIndex = 18;
            this.button2.Text = "ÇIKIŞ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.LimeGreen;
            this.textBox1.Location = new System.Drawing.Point(1029, 140);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 19);
            this.textBox1.TabIndex = 19;
            this.textBox1.Text = "İYİMSERLİK";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.LimeGreen;
            this.textBox2.Location = new System.Drawing.Point(1029, 191);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(136, 19);
            this.textBox2.TabIndex = 20;
            this.textBox2.Text = "KÖTÜMSERLİK";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.LimeGreen;
            this.textBox3.Location = new System.Drawing.Point(1029, 238);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(136, 19);
            this.textBox3.TabIndex = 21;
            this.textBox3.Text = "EŞ OLASILIK";
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.LimeGreen;
            this.textBox4.Location = new System.Drawing.Point(1029, 283);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(136, 19);
            this.textBox4.TabIndex = 22;
            this.textBox4.Text = "PİŞMANLIK";
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.LimeGreen;
            this.textBox5.Location = new System.Drawing.Point(1029, 325);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(136, 19);
            this.textBox5.TabIndex = 23;
            this.textBox5.Text = "HURWICS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1219, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1219, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1219, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1219, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1219, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "label5";
            // 
            // Karar_Verme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbColumn1);
            this.Controls.Add(this.tbFila1);
            this.Controls.Add(this.dgvMatrix1);
            this.Controls.Add(this.veri);
            this.Controls.Add(this.alphano);
            this.Controls.Add(this.alpha);
            this.Controls.Add(this.durum);
            this.Controls.Add(this.alternatif);
            this.Controls.Add(this.typename);
            this.Controls.Add(this.type);
            this.Controls.Add(this.konum);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Karar_Verme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Karar Verme";
            this.Load += new System.EventHandler(this.Karar_Verme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.alphano)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrix1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox konum;
        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.TextBox typename;
        private System.Windows.Forms.TextBox alternatif;
        private System.Windows.Forms.TextBox durum;
        private System.Windows.Forms.TextBox alpha;
        private System.Windows.Forms.NumericUpDown alphano;
        private System.Windows.Forms.TextBox veri;
        private System.Windows.Forms.DataGridView dgvMatrix1;
        private System.Windows.Forms.TextBox tbFila1;
        private System.Windows.Forms.TextBox tbColumn1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}


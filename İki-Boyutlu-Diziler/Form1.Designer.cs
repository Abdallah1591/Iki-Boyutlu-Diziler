namespace İki_Boyutlu_Diziler
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label1 = new Label();
            numAsutun = new NumericUpDown();
            numAsatir = new NumericUpDown();
            grpBoxİşlem = new GroupBox();
            rdBtnMAX = new RadioButton();
            rdBtnAVR = new RadioButton();
            rdBtnCarpma = new RadioButton();
            rdBtnCikarma = new RadioButton();
            rdBtnToplama = new RadioButton();
            groupBox2 = new GroupBox();
            label2 = new Label();
            numBsutun = new NumericUpDown();
            numBsatir = new NumericUpDown();
            btnVeriDoldur = new Button();
            btnHesapla = new Button();
            dgvA = new DataGridView();
            dgvB = new DataGridView();
            dgvSonuc = new DataGridView();
            lbleşit = new Label();
            lblişlem = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numAsutun).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAsatir).BeginInit();
            grpBoxİşlem.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numBsutun).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numBsatir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSonuc).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(numAsutun);
            groupBox1.Controls.Add(numAsatir);
            groupBox1.Location = new Point(30, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(222, 78);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "A Matrisi Boyutu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(97, 43);
            label1.Name = "label1";
            label1.Size = new Size(30, 32);
            label1.TabIndex = 2;
            label1.Text = "X";
            // 
            // numAsutun
            // 
            numAsutun.Location = new Point(143, 43);
            numAsutun.Name = "numAsutun";
            numAsutun.Size = new Size(60, 29);
            numAsutun.TabIndex = 1;
            // 
            // numAsatir
            // 
            numAsatir.Location = new Point(17, 43);
            numAsatir.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
            numAsatir.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numAsatir.Name = "numAsatir";
            numAsatir.Size = new Size(60, 29);
            numAsatir.TabIndex = 0;
            numAsatir.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // grpBoxİşlem
            // 
            grpBoxİşlem.Controls.Add(rdBtnMAX);
            grpBoxİşlem.Controls.Add(rdBtnAVR);
            grpBoxİşlem.Controls.Add(rdBtnCarpma);
            grpBoxİşlem.Controls.Add(rdBtnCikarma);
            grpBoxİşlem.Controls.Add(rdBtnToplama);
            grpBoxİşlem.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpBoxİşlem.Location = new Point(30, 389);
            grpBoxİşlem.Name = "grpBoxİşlem";
            grpBoxİşlem.Size = new Size(495, 98);
            grpBoxİşlem.TabIndex = 1;
            grpBoxİşlem.TabStop = false;
            grpBoxİşlem.Text = "İşlem Seçimi";
            // 
            // rdBtnMAX
            // 
            rdBtnMAX.AutoSize = true;
            rdBtnMAX.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdBtnMAX.Location = new Point(376, 53);
            rdBtnMAX.Name = "rdBtnMAX";
            rdBtnMAX.Size = new Size(91, 36);
            rdBtnMAX.TabIndex = 4;
            rdBtnMAX.TabStop = true;
            rdBtnMAX.Text = "MAX";
            rdBtnMAX.UseVisualStyleBackColor = true;
            // 
            // rdBtnAVR
            // 
            rdBtnAVR.AutoSize = true;
            rdBtnAVR.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdBtnAVR.Location = new Point(273, 53);
            rdBtnAVR.Name = "rdBtnAVR";
            rdBtnAVR.Size = new Size(83, 36);
            rdBtnAVR.TabIndex = 3;
            rdBtnAVR.TabStop = true;
            rdBtnAVR.Text = "AVR";
            rdBtnAVR.UseVisualStyleBackColor = true;
            // 
            // rdBtnCarpma
            // 
            rdBtnCarpma.AutoSize = true;
            rdBtnCarpma.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdBtnCarpma.Location = new Point(193, 53);
            rdBtnCarpma.Name = "rdBtnCarpma";
            rdBtnCarpma.Size = new Size(47, 36);
            rdBtnCarpma.TabIndex = 2;
            rdBtnCarpma.TabStop = true;
            rdBtnCarpma.Text = "x";
            rdBtnCarpma.UseVisualStyleBackColor = true;
            // 
            // rdBtnCikarma
            // 
            rdBtnCikarma.AutoSize = true;
            rdBtnCikarma.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdBtnCikarma.Location = new Point(97, 53);
            rdBtnCikarma.Name = "rdBtnCikarma";
            rdBtnCikarma.Size = new Size(42, 36);
            rdBtnCikarma.TabIndex = 1;
            rdBtnCikarma.TabStop = true;
            rdBtnCikarma.Text = "-";
            rdBtnCikarma.UseVisualStyleBackColor = true;
            // 
            // rdBtnToplama
            // 
            rdBtnToplama.AutoSize = true;
            rdBtnToplama.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdBtnToplama.Location = new Point(6, 53);
            rdBtnToplama.Name = "rdBtnToplama";
            rdBtnToplama.Size = new Size(49, 36);
            rdBtnToplama.TabIndex = 0;
            rdBtnToplama.TabStop = true;
            rdBtnToplama.Text = "+";
            rdBtnToplama.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(numBsutun);
            groupBox2.Controls.Add(numBsatir);
            groupBox2.Location = new Point(303, 62);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(222, 78);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "B Matrisi Boyutu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(97, 43);
            label2.Name = "label2";
            label2.Size = new Size(30, 32);
            label2.TabIndex = 2;
            label2.Text = "X";
            // 
            // numBsutun
            // 
            numBsutun.Location = new Point(143, 43);
            numBsutun.Name = "numBsutun";
            numBsutun.Size = new Size(60, 29);
            numBsutun.TabIndex = 1;
            // 
            // numBsatir
            // 
            numBsatir.Location = new Point(17, 43);
            numBsatir.Name = "numBsatir";
            numBsatir.Size = new Size(60, 29);
            numBsatir.TabIndex = 0;
            // 
            // btnVeriDoldur
            // 
            btnVeriDoldur.Location = new Point(547, 105);
            btnVeriDoldur.Name = "btnVeriDoldur";
            btnVeriDoldur.Size = new Size(145, 33);
            btnVeriDoldur.TabIndex = 4;
            btnVeriDoldur.Text = "VERİ DOLDUR";
            btnVeriDoldur.UseVisualStyleBackColor = true;
            btnVeriDoldur.Click += btnVeriDoldur_Click;
            // 
            // btnHesapla
            // 
            btnHesapla.Location = new Point(547, 454);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(145, 33);
            btnHesapla.TabIndex = 5;
            btnHesapla.Text = "HESAPLA";
            btnHesapla.UseVisualStyleBackColor = true;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // dgvA
            // 
            dgvA.AllowUserToAddRows = false;
            dgvA.AllowUserToDeleteRows = false;
            dgvA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvA.ColumnHeadersVisible = false;
            dgvA.Location = new Point(30, 209);
            dgvA.Name = "dgvA";
            dgvA.ReadOnly = true;
            dgvA.RowHeadersVisible = false;
            dgvA.Size = new Size(222, 148);
            dgvA.TabIndex = 6;
            // 
            // dgvB
            // 
            dgvB.AllowUserToAddRows = false;
            dgvB.AllowUserToDeleteRows = false;
            dgvB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvB.ColumnHeadersVisible = false;
            dgvB.Location = new Point(320, 209);
            dgvB.Name = "dgvB";
            dgvB.ReadOnly = true;
            dgvB.RowHeadersVisible = false;
            dgvB.Size = new Size(222, 148);
            dgvB.TabIndex = 7;
            // 
            // dgvSonuc
            // 
            dgvSonuc.AllowUserToAddRows = false;
            dgvSonuc.AllowUserToDeleteRows = false;
            dgvSonuc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvSonuc.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvSonuc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSonuc.ColumnHeadersVisible = false;
            dgvSonuc.Location = new Point(601, 209);
            dgvSonuc.Name = "dgvSonuc";
            dgvSonuc.ReadOnly = true;
            dgvSonuc.RowHeadersVisible = false;
            dgvSonuc.Size = new Size(215, 148);
            dgvSonuc.TabIndex = 8;
            // 
            // lbleşit
            // 
            lbleşit.AutoSize = true;
            lbleşit.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbleşit.Location = new Point(548, 267);
            lbleşit.Name = "lbleşit";
            lbleşit.Size = new Size(31, 32);
            lbleşit.TabIndex = 3;
            lbleşit.Text = "=";
            // 
            // lblişlem
            // 
            lblişlem.AutoSize = true;
            lblişlem.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblişlem.Location = new Point(258, 267);
            lblişlem.Name = "lblişlem";
            lblişlem.Size = new Size(25, 25);
            lblişlem.TabIndex = 3;
            lblişlem.Text = "+";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(876, 499);
            Controls.Add(lblişlem);
            Controls.Add(lbleşit);
            Controls.Add(dgvSonuc);
            Controls.Add(dgvB);
            Controls.Add(dgvA);
            Controls.Add(btnHesapla);
            Controls.Add(btnVeriDoldur);
            Controls.Add(groupBox2);
            Controls.Add(grpBoxİşlem);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Location = new Point(0, -10);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "İstatistiksel Veri Analizi ve Dinamik Tablo İşlemleri";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numAsutun).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAsatir).EndInit();
            grpBoxİşlem.ResumeLayout(false);
            grpBoxİşlem.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numBsutun).EndInit();
            ((System.ComponentModel.ISupportInitialize)numBsatir).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvA).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvB).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSonuc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private NumericUpDown numAsutun;
        private NumericUpDown numAsatir;
        private GroupBox grpBoxİşlem;
        private Label label1;
        private GroupBox groupBox2;
        private Label label2;
        private NumericUpDown numBsutun;
        private NumericUpDown numBsatir;
        private RadioButton rdBtnMAX;
        private RadioButton rdBtnAVR;
        private RadioButton rdBtnCarpma;
        private RadioButton rdBtnCikarma;
        private RadioButton rdBtnToplama;
        private Button btnVeriDoldur;
        private Button btnHesapla;
        private DataGridView dgvA;
        private DataGridView dgvB;
        private DataGridView dgvSonuc;
        private Label lbleşit;
        private Label lblişlem;
    }
}

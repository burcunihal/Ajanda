namespace DFM.PL
{
    partial class frmMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblKapat = new System.Windows.Forms.Label();
            this.btnYeni = new System.Windows.Forms.Button();
            this.txtIcerik = new System.Windows.Forms.TextBox();
            this.dtBitisTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtBaslamaTarihi = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.gridBitenler = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ajandaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel7 = new System.Windows.Forms.Panel();
            this.gridBekleyenler = new System.Windows.Forms.DataGridView();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Icerik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaslamaT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaslamaSaati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BitisT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BitisSaati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBitenler = new System.Windows.Forms.Label();
            this.lblBekleyen = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBitenler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ajandaBindingSource)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBekleyenler)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(141)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(931, 113);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel4.BackgroundImage = global::DFM.PL.Properties.Resources.TopPanel;
            this.panel4.Controls.Add(this.lblKapat);
            this.panel4.Controls.Add(this.btnYeni);
            this.panel4.Controls.Add(this.txtIcerik);
            this.panel4.Controls.Add(this.dtBitisTarihi);
            this.panel4.Controls.Add(this.dtBaslamaTarihi);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(143, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(788, 113);
            this.panel4.TabIndex = 1;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseDown);
            this.panel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
            this.panel4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseUp);
            // 
            // lblKapat
            // 
            this.lblKapat.AutoSize = true;
            this.lblKapat.Location = new System.Drawing.Point(737, 0);
            this.lblKapat.Name = "lblKapat";
            this.lblKapat.Size = new System.Drawing.Size(45, 17);
            this.lblKapat.TabIndex = 4;
            this.lblKapat.Text = "Kapat";
            this.lblKapat.Click += new System.EventHandler(this.lblKapat_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.BackColor = System.Drawing.Color.Transparent;
            this.btnYeni.BackgroundImage = global::DFM.PL.Properties.Resources.btnNewIm;
            this.btnYeni.FlatAppearance.BorderSize = 0;
            this.btnYeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeni.Location = new System.Drawing.Point(545, 32);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(190, 48);
            this.btnYeni.TabIndex = 3;
            this.btnYeni.UseVisualStyleBackColor = false;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // txtIcerik
            // 
            this.txtIcerik.Location = new System.Drawing.Point(241, 32);
            this.txtIcerik.Multiline = true;
            this.txtIcerik.Name = "txtIcerik";
            this.txtIcerik.Size = new System.Drawing.Size(298, 50);
            this.txtIcerik.TabIndex = 2;
            // 
            // dtBitisTarihi
            // 
            this.dtBitisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBitisTarihi.Location = new System.Drawing.Point(136, 60);
            this.dtBitisTarihi.Name = "dtBitisTarihi";
            this.dtBitisTarihi.Size = new System.Drawing.Size(98, 22);
            this.dtBitisTarihi.TabIndex = 1;
            this.dtBitisTarihi.ValueChanged += new System.EventHandler(this.dtBitisTarihi_ValueChanged);
            // 
            // dtBaslamaTarihi
            // 
            this.dtBaslamaTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBaslamaTarihi.Location = new System.Drawing.Point(136, 32);
            this.dtBaslamaTarihi.Name = "dtBaslamaTarihi";
            this.dtBaslamaTarihi.Size = new System.Drawing.Size(98, 22);
            this.dtBaslamaTarihi.TabIndex = 1;
            this.dtBaslamaTarihi.ValueChanged += new System.EventHandler(this.dtBaslamaTarihi_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(16, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Bitiş:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Başlangıç:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BackgroundImage = global::DFM.PL.Properties.Resources.LogoDFM;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(143, 113);
            this.panel3.TabIndex = 0;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
            this.panel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(203)))));
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(931, 367);
            this.panel2.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.BackgroundImage = global::DFM.PL.Properties.Resources.GridBack;
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(143, 0);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(5);
            this.panel6.Size = new System.Drawing.Size(788, 367);
            this.panel6.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel8.Controls.Add(this.gridBitenler);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(5, 184);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(778, 178);
            this.panel8.TabIndex = 1;
            // 
            // gridBitenler
            // 
            this.gridBitenler.AutoGenerateColumns = false;
            this.gridBitenler.BackgroundColor = System.Drawing.Color.White;
            this.gridBitenler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBitenler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.gridBitenler.DataSource = this.ajandaBindingSource;
            this.gridBitenler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridBitenler.Location = new System.Drawing.Point(0, 0);
            this.gridBitenler.Name = "gridBitenler";
            this.gridBitenler.RowHeadersVisible = false;
            this.gridBitenler.RowTemplate.Height = 24;
            this.gridBitenler.Size = new System.Drawing.Size(778, 178);
            this.gridBitenler.TabIndex = 1;
            this.gridBitenler.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridBitenler_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Icerik";
            this.dataGridViewTextBoxColumn2.HeaderText = "Ajanda Bilgisi";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "BaslamaT";
            this.dataGridViewTextBoxColumn3.HeaderText = "Başlama";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "BaslamaSaati";
            this.dataGridViewTextBoxColumn4.HeaderText = "Başlama Saati";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 130;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "BitisT";
            this.dataGridViewTextBoxColumn5.HeaderText = "Bitiş";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "BitisSaati";
            this.dataGridViewTextBoxColumn6.HeaderText = "Bitiş Saati";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // ajandaBindingSource
            // 
            this.ajandaBindingSource.DataSource = typeof(DFM.DAL.Ajanda);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel7.Controls.Add(this.gridBekleyenler);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(5, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(778, 174);
            this.panel7.TabIndex = 0;
            // 
            // gridBekleyenler
            // 
            this.gridBekleyenler.AutoGenerateColumns = false;
            this.gridBekleyenler.BackgroundColor = System.Drawing.Color.White;
            this.gridBekleyenler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBekleyenler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.Icerik,
            this.BaslamaT,
            this.BaslamaSaati,
            this.BitisT,
            this.BitisSaati});
            this.gridBekleyenler.DataSource = this.ajandaBindingSource;
            this.gridBekleyenler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridBekleyenler.Location = new System.Drawing.Point(0, 0);
            this.gridBekleyenler.Name = "gridBekleyenler";
            this.gridBekleyenler.RowHeadersVisible = false;
            this.gridBekleyenler.RowTemplate.Height = 24;
            this.gridBekleyenler.Size = new System.Drawing.Size(778, 174);
            this.gridBekleyenler.TabIndex = 0;
            this.gridBekleyenler.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridBekleyenler_CellDoubleClick);
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.Visible = false;
            // 
            // Icerik
            // 
            this.Icerik.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Icerik.DataPropertyName = "Icerik";
            this.Icerik.HeaderText = "Ajanda Bilgisi";
            this.Icerik.Name = "Icerik";
            // 
            // BaslamaT
            // 
            this.BaslamaT.DataPropertyName = "BaslamaT";
            this.BaslamaT.HeaderText = "Başlama";
            this.BaslamaT.Name = "BaslamaT";
            this.BaslamaT.ReadOnly = true;
            // 
            // BaslamaSaati
            // 
            this.BaslamaSaati.DataPropertyName = "BaslamaSaati";
            this.BaslamaSaati.HeaderText = "Başlama Saati";
            this.BaslamaSaati.Name = "BaslamaSaati";
            this.BaslamaSaati.ReadOnly = true;
            this.BaslamaSaati.Width = 130;
            // 
            // BitisT
            // 
            this.BitisT.DataPropertyName = "BitisT";
            this.BitisT.HeaderText = "Bitiş";
            this.BitisT.Name = "BitisT";
            this.BitisT.ReadOnly = true;
            // 
            // BitisSaati
            // 
            this.BitisSaati.DataPropertyName = "BitisSaati";
            this.BitisSaati.HeaderText = "Bitiş Saati";
            this.BitisSaati.Name = "BitisSaati";
            this.BitisSaati.ReadOnly = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BackgroundImage = global::DFM.PL.Properties.Resources.LeftPanel;
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.lblBitenler);
            this.panel5.Controls.Add(this.lblBekleyen);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(143, 367);
            this.panel5.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 294);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.label3.Size = new System.Drawing.Size(143, 73);
            this.label3.TabIndex = 1;
            this.label3.Text = "Vektörel Bilişim Hafta Sonu Öğlen";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblBitenler
            // 
            this.lblBitenler.AutoSize = true;
            this.lblBitenler.BackColor = System.Drawing.Color.Transparent;
            this.lblBitenler.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBitenler.ForeColor = System.Drawing.Color.White;
            this.lblBitenler.Location = new System.Drawing.Point(58, 258);
            this.lblBitenler.Name = "lblBitenler";
            this.lblBitenler.Size = new System.Drawing.Size(27, 29);
            this.lblBitenler.TabIndex = 0;
            this.lblBitenler.Text = "0";
            // 
            // lblBekleyen
            // 
            this.lblBekleyen.AutoSize = true;
            this.lblBekleyen.BackColor = System.Drawing.Color.Transparent;
            this.lblBekleyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBekleyen.ForeColor = System.Drawing.Color.White;
            this.lblBekleyen.Location = new System.Drawing.Point(50, 76);
            this.lblBekleyen.Name = "lblBekleyen";
            this.lblBekleyen.Size = new System.Drawing.Size(27, 29);
            this.lblBekleyen.TabIndex = 0;
            this.lblBekleyen.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bitenler >";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bekleyen >";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 480);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Don\'t Forget Me";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridBitenler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ajandaBindingSource)).EndInit();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridBekleyenler)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblBitenler;
        private System.Windows.Forms.Label lblBekleyen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.TextBox txtIcerik;
        private System.Windows.Forms.DateTimePicker dtBitisTarihi;
        private System.Windows.Forms.DateTimePicker dtBaslamaTarihi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.BindingSource ajandaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Icerik;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaslamaT;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaslamaSaati;
        private System.Windows.Forms.DataGridViewTextBoxColumn BitisT;
        private System.Windows.Forms.DataGridViewTextBoxColumn BitisSaati;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label lblKapat;
        public System.Windows.Forms.DataGridView gridBekleyenler;
        public System.Windows.Forms.DataGridView gridBitenler;
    }
}
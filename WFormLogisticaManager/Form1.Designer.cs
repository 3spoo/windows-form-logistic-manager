namespace WFormLogisticaManager
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pannelloIntestazione = new System.Windows.Forms.Panel();
            this.lblIntestazione = new System.Windows.Forms.Label();
            this.pannelloLaterale = new System.Windows.Forms.Panel();
            this.groupBoxProduttoriConsumatori = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNumeroProduttori = new System.Windows.Forms.Label();
            this.numericNumeroProduttori = new System.Windows.Forms.NumericUpDown();
            this.lblNumeroConsumatori = new System.Windows.Forms.Label();
            this.numericNumeroConsumatori = new System.Windows.Forms.NumericUpDown();
            this.lblUnitaMisura = new System.Windows.Forms.Label();
            this.comboUnitaMisura = new System.Windows.Forms.ComboBox();
            this.btnCreaMatrice = new System.Windows.Forms.Button();
            this.groupBoxDatiExcel = new System.Windows.Forms.GroupBox();
            this.btnIncolla = new System.Windows.Forms.Button();
            this.lblSuggerimentoExcel = new System.Windows.Forms.Label();
            this.btnRisolvi = new System.Windows.Forms.Button();
            this.groupBoxValoriCasuali = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRangeCosti = new System.Windows.Forms.Label();
            this.numericRangeCostiMin = new System.Windows.Forms.NumericUpDown();
            this.lblRangeCostiTrattino = new System.Windows.Forms.Label();
            this.numericRangeCostiMax = new System.Windows.Forms.NumericUpDown();
            this.lblRangeProduzioniFabbisogni = new System.Windows.Forms.Label();
            this.numericRangeProdMin = new System.Windows.Forms.NumericUpDown();
            this.lblRangeProdTrattino = new System.Windows.Forms.Label();
            this.numericRangeProdMax = new System.Windows.Forms.NumericUpDown();
            this.btnGenera = new System.Windows.Forms.Button();
            this.tabMatriceIniziale = new System.Windows.Forms.TabPage();
            this.dataGridViewMatrice = new System.Windows.Forms.DataGridView();
            this.tabControlMetodi = new System.Windows.Forms.TabControl();
            this.pannelloIntestazione.SuspendLayout();
            this.pannelloLaterale.SuspendLayout();
            this.groupBoxProduttoriConsumatori.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumeroProduttori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumeroConsumatori)).BeginInit();
            this.groupBoxDatiExcel.SuspendLayout();
            this.groupBoxValoriCasuali.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericRangeCostiMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRangeCostiMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRangeProdMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRangeProdMax)).BeginInit();
            this.tabMatriceIniziale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrice)).BeginInit();
            this.tabControlMetodi.SuspendLayout();
            this.SuspendLayout();
            // 
            // pannelloIntestazione
            // 
            this.pannelloIntestazione.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.pannelloIntestazione.Controls.Add(this.lblIntestazione);
            this.pannelloIntestazione.Dock = System.Windows.Forms.DockStyle.Top;
            this.pannelloIntestazione.Location = new System.Drawing.Point(0, 0);
            this.pannelloIntestazione.Name = "pannelloIntestazione";
            this.pannelloIntestazione.Size = new System.Drawing.Size(1200, 72);
            this.pannelloIntestazione.TabIndex = 2;
            // 
            // lblIntestazione
            // 
            this.lblIntestazione.AutoSize = true;
            this.lblIntestazione.BackColor = System.Drawing.Color.Transparent;
            this.lblIntestazione.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblIntestazione.ForeColor = System.Drawing.Color.White;
            this.lblIntestazione.Location = new System.Drawing.Point(12, 9);
            this.lblIntestazione.Name = "lblIntestazione";
            this.lblIntestazione.Size = new System.Drawing.Size(614, 50);
            this.lblIntestazione.TabIndex = 0;
            this.lblIntestazione.Text = "OTTIMIZZAZIONE DEI TRASPORTI";
            // 
            // pannelloLaterale
            // 
            this.pannelloLaterale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pannelloLaterale.AutoScroll = true;
            this.pannelloLaterale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.pannelloLaterale.Controls.Add(this.groupBoxProduttoriConsumatori);
            this.pannelloLaterale.Controls.Add(this.groupBoxDatiExcel);
            this.pannelloLaterale.Controls.Add(this.btnRisolvi);
            this.pannelloLaterale.Controls.Add(this.groupBoxValoriCasuali);
            this.pannelloLaterale.Location = new System.Drawing.Point(16, 88);
            this.pannelloLaterale.MinimumSize = new System.Drawing.Size(322, 0);
            this.pannelloLaterale.Name = "pannelloLaterale";
            this.pannelloLaterale.Size = new System.Drawing.Size(362, 720);
            this.pannelloLaterale.TabIndex = 0;
            // 
            // groupBoxProduttoriConsumatori
            // 
            this.groupBoxProduttoriConsumatori.BackColor = System.Drawing.Color.White;
            this.groupBoxProduttoriConsumatori.Controls.Add(this.label4);
            this.groupBoxProduttoriConsumatori.Controls.Add(this.label3);
            this.groupBoxProduttoriConsumatori.Controls.Add(this.lblNumeroProduttori);
            this.groupBoxProduttoriConsumatori.Controls.Add(this.numericNumeroProduttori);
            this.groupBoxProduttoriConsumatori.Controls.Add(this.lblNumeroConsumatori);
            this.groupBoxProduttoriConsumatori.Controls.Add(this.numericNumeroConsumatori);
            this.groupBoxProduttoriConsumatori.Controls.Add(this.lblUnitaMisura);
            this.groupBoxProduttoriConsumatori.Controls.Add(this.comboUnitaMisura);
            this.groupBoxProduttoriConsumatori.Controls.Add(this.btnCreaMatrice);
            this.groupBoxProduttoriConsumatori.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBoxProduttoriConsumatori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.groupBoxProduttoriConsumatori.Location = new System.Drawing.Point(10, 12);
            this.groupBoxProduttoriConsumatori.Name = "groupBoxProduttoriConsumatori";
            this.groupBoxProduttoriConsumatori.Size = new System.Drawing.Size(338, 245);
            this.groupBoxProduttoriConsumatori.TabIndex = 0;
            this.groupBoxProduttoriConsumatori.TabStop = false;
            this.groupBoxProduttoriConsumatori.Text = "PRODUTTORI E CONSUMATORI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(110)))), ((int)(((byte)(125)))));
            this.label4.Location = new System.Drawing.Point(14, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "(ASCISSE)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(110)))), ((int)(((byte)(125)))));
            this.label3.Location = new System.Drawing.Point(14, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "(ORDINATE)";
            // 
            // lblNumeroProduttori
            // 
            this.lblNumeroProduttori.AutoSize = true;
            this.lblNumeroProduttori.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNumeroProduttori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.lblNumeroProduttori.Location = new System.Drawing.Point(14, 31);
            this.lblNumeroProduttori.Name = "lblNumeroProduttori";
            this.lblNumeroProduttori.Size = new System.Drawing.Size(182, 20);
            this.lblNumeroProduttori.TabIndex = 0;
            this.lblNumeroProduttori.Text = "NUMERO DI PRODUTTORI";
            // 
            // numericNumeroProduttori
            // 
            this.numericNumeroProduttori.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.numericNumeroProduttori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.numericNumeroProduttori.Location = new System.Drawing.Point(249, 31);
            this.numericNumeroProduttori.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericNumeroProduttori.Name = "numericNumeroProduttori";
            this.numericNumeroProduttori.Size = new System.Drawing.Size(74, 29);
            this.numericNumeroProduttori.TabIndex = 1;
            this.numericNumeroProduttori.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericNumeroProduttori.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // lblNumeroConsumatori
            // 
            this.lblNumeroConsumatori.AutoSize = true;
            this.lblNumeroConsumatori.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNumeroConsumatori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.lblNumeroConsumatori.Location = new System.Drawing.Point(14, 73);
            this.lblNumeroConsumatori.Name = "lblNumeroConsumatori";
            this.lblNumeroConsumatori.Size = new System.Drawing.Size(196, 20);
            this.lblNumeroConsumatori.TabIndex = 2;
            this.lblNumeroConsumatori.Text = "NUMERO DI CONSUMATORI";
            // 
            // numericNumeroConsumatori
            // 
            this.numericNumeroConsumatori.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.numericNumeroConsumatori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.numericNumeroConsumatori.Location = new System.Drawing.Point(249, 70);
            this.numericNumeroConsumatori.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericNumeroConsumatori.Name = "numericNumeroConsumatori";
            this.numericNumeroConsumatori.Size = new System.Drawing.Size(74, 29);
            this.numericNumeroConsumatori.TabIndex = 3;
            this.numericNumeroConsumatori.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericNumeroConsumatori.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // lblUnitaMisura
            // 
            this.lblUnitaMisura.AutoSize = true;
            this.lblUnitaMisura.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblUnitaMisura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.lblUnitaMisura.Location = new System.Drawing.Point(14, 118);
            this.lblUnitaMisura.Name = "lblUnitaMisura";
            this.lblUnitaMisura.Size = new System.Drawing.Size(260, 20);
            this.lblUnitaMisura.TabIndex = 4;
            this.lblUnitaMisura.Text = "QUANTITA\' DI UNITA\' DA TRASFERIRE";
            // 
            // comboUnitaMisura
            // 
            this.comboUnitaMisura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboUnitaMisura.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.comboUnitaMisura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.comboUnitaMisura.FormattingEnabled = true;
            this.comboUnitaMisura.Items.AddRange(new object[] {
            "UNITA\'",
            "MIGLIAIA DI UNITA\'",
            "MILIONI DI UNITA\'",
            "MILIARDI DI UNITA\'"});
            this.comboUnitaMisura.Location = new System.Drawing.Point(14, 141);
            this.comboUnitaMisura.Name = "comboUnitaMisura";
            this.comboUnitaMisura.Size = new System.Drawing.Size(309, 29);
            this.comboUnitaMisura.TabIndex = 5;
            this.comboUnitaMisura.SelectedIndexChanged += new System.EventHandler(this.comboUnitaMisura_SelectedIndexChanged);
            // 
            // btnCreaMatrice
            // 
            this.btnCreaMatrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.btnCreaMatrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreaMatrice.FlatAppearance.BorderSize = 0;
            this.btnCreaMatrice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.btnCreaMatrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreaMatrice.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCreaMatrice.ForeColor = System.Drawing.Color.White;
            this.btnCreaMatrice.Location = new System.Drawing.Point(14, 192);
            this.btnCreaMatrice.Name = "btnCreaMatrice";
            this.btnCreaMatrice.Size = new System.Drawing.Size(309, 36);
            this.btnCreaMatrice.TabIndex = 6;
            this.btnCreaMatrice.Text = "CREA MATRICE";
            this.btnCreaMatrice.UseVisualStyleBackColor = false;
            this.btnCreaMatrice.Click += new System.EventHandler(this.btnCreaMatrice_Click);
            // 
            // groupBoxDatiExcel
            // 
            this.groupBoxDatiExcel.BackColor = System.Drawing.Color.White;
            this.groupBoxDatiExcel.Controls.Add(this.btnIncolla);
            this.groupBoxDatiExcel.Controls.Add(this.lblSuggerimentoExcel);
            this.groupBoxDatiExcel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBoxDatiExcel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.groupBoxDatiExcel.Location = new System.Drawing.Point(10, 271);
            this.groupBoxDatiExcel.Name = "groupBoxDatiExcel";
            this.groupBoxDatiExcel.Size = new System.Drawing.Size(338, 120);
            this.groupBoxDatiExcel.TabIndex = 1;
            this.groupBoxDatiExcel.TabStop = false;
            this.groupBoxDatiExcel.Text = "DATI DA EXCEL";
            // 
            // btnIncolla
            // 
            this.btnIncolla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.btnIncolla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIncolla.FlatAppearance.BorderSize = 0;
            this.btnIncolla.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.btnIncolla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncolla.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnIncolla.ForeColor = System.Drawing.Color.White;
            this.btnIncolla.Location = new System.Drawing.Point(14, 30);
            this.btnIncolla.Name = "btnIncolla";
            this.btnIncolla.Size = new System.Drawing.Size(309, 36);
            this.btnIncolla.TabIndex = 0;
            this.btnIncolla.Text = "INCOLLA";
            this.btnIncolla.UseVisualStyleBackColor = false;
            this.btnIncolla.Click += new System.EventHandler(this.btnIncolla_Click);
            // 
            // lblSuggerimentoExcel
            // 
            this.lblSuggerimentoExcel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic);
            this.lblSuggerimentoExcel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(110)))), ((int)(((byte)(125)))));
            this.lblSuggerimentoExcel.Location = new System.Drawing.Point(38, 69);
            this.lblSuggerimentoExcel.Name = "lblSuggerimentoExcel";
            this.lblSuggerimentoExcel.Size = new System.Drawing.Size(268, 36);
            this.lblSuggerimentoExcel.TabIndex = 1;
            this.lblSuggerimentoExcel.Text = "*COPIA L\'INTERVALLO DA EXCEL E \r\nINCOLLALO NELLA MATRICE";
            this.lblSuggerimentoExcel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnRisolvi
            // 
            this.btnRisolvi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.btnRisolvi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRisolvi.FlatAppearance.BorderSize = 0;
            this.btnRisolvi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(128)))), ((int)(((byte)(61)))));
            this.btnRisolvi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRisolvi.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnRisolvi.ForeColor = System.Drawing.Color.White;
            this.btnRisolvi.Location = new System.Drawing.Point(10, 648);
            this.btnRisolvi.Name = "btnRisolvi";
            this.btnRisolvi.Size = new System.Drawing.Size(338, 58);
            this.btnRisolvi.TabIndex = 3;
            this.btnRisolvi.Text = "RISOLVI";
            this.btnRisolvi.UseVisualStyleBackColor = false;
            this.btnRisolvi.Click += new System.EventHandler(this.btnRisolvi_Click);
            // 
            // groupBoxValoriCasuali
            // 
            this.groupBoxValoriCasuali.BackColor = System.Drawing.Color.White;
            this.groupBoxValoriCasuali.Controls.Add(this.label2);
            this.groupBoxValoriCasuali.Controls.Add(this.label1);
            this.groupBoxValoriCasuali.Controls.Add(this.lblRangeCosti);
            this.groupBoxValoriCasuali.Controls.Add(this.numericRangeCostiMin);
            this.groupBoxValoriCasuali.Controls.Add(this.lblRangeCostiTrattino);
            this.groupBoxValoriCasuali.Controls.Add(this.numericRangeCostiMax);
            this.groupBoxValoriCasuali.Controls.Add(this.lblRangeProduzioniFabbisogni);
            this.groupBoxValoriCasuali.Controls.Add(this.numericRangeProdMin);
            this.groupBoxValoriCasuali.Controls.Add(this.lblRangeProdTrattino);
            this.groupBoxValoriCasuali.Controls.Add(this.numericRangeProdMax);
            this.groupBoxValoriCasuali.Controls.Add(this.btnGenera);
            this.groupBoxValoriCasuali.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBoxValoriCasuali.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.groupBoxValoriCasuali.Location = new System.Drawing.Point(10, 409);
            this.groupBoxValoriCasuali.Name = "groupBoxValoriCasuali";
            this.groupBoxValoriCasuali.Size = new System.Drawing.Size(338, 176);
            this.groupBoxValoriCasuali.TabIndex = 2;
            this.groupBoxValoriCasuali.TabStop = false;
            this.groupBoxValoriCasuali.Text = "GENERA VALORI CASUALI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(110)))), ((int)(((byte)(125)))));
            this.label2.Location = new System.Drawing.Point(14, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "(U.P. A DEST.)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.label1.Location = new System.Drawing.Point(14, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "FABBISOGNO";
            // 
            // lblRangeCosti
            // 
            this.lblRangeCosti.AutoSize = true;
            this.lblRangeCosti.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRangeCosti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.lblRangeCosti.Location = new System.Drawing.Point(14, 31);
            this.lblRangeCosti.Name = "lblRangeCosti";
            this.lblRangeCosti.Size = new System.Drawing.Size(128, 20);
            this.lblRangeCosti.TabIndex = 0;
            this.lblRangeCosti.Text = "RANGE DEI COSTI";
            // 
            // numericRangeCostiMin
            // 
            this.numericRangeCostiMin.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.numericRangeCostiMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.numericRangeCostiMin.Location = new System.Drawing.Point(165, 31);
            this.numericRangeCostiMin.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numericRangeCostiMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericRangeCostiMin.Name = "numericRangeCostiMin";
            this.numericRangeCostiMin.Size = new System.Drawing.Size(62, 29);
            this.numericRangeCostiMin.TabIndex = 1;
            this.numericRangeCostiMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericRangeCostiMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblRangeCostiTrattino
            // 
            this.lblRangeCostiTrattino.AutoSize = true;
            this.lblRangeCostiTrattino.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRangeCostiTrattino.ForeColor = System.Drawing.Color.Gray;
            this.lblRangeCostiTrattino.Location = new System.Drawing.Point(236, 35);
            this.lblRangeCostiTrattino.Name = "lblRangeCostiTrattino";
            this.lblRangeCostiTrattino.Size = new System.Drawing.Size(15, 20);
            this.lblRangeCostiTrattino.TabIndex = 2;
            this.lblRangeCostiTrattino.Text = "-";
            // 
            // numericRangeCostiMax
            // 
            this.numericRangeCostiMax.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.numericRangeCostiMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.numericRangeCostiMax.Location = new System.Drawing.Point(257, 31);
            this.numericRangeCostiMax.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.numericRangeCostiMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericRangeCostiMax.Name = "numericRangeCostiMax";
            this.numericRangeCostiMax.Size = new System.Drawing.Size(66, 29);
            this.numericRangeCostiMax.TabIndex = 3;
            this.numericRangeCostiMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericRangeCostiMax.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lblRangeProduzioniFabbisogni
            // 
            this.lblRangeProduzioniFabbisogni.AutoSize = true;
            this.lblRangeProduzioniFabbisogni.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRangeProduzioniFabbisogni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.lblRangeProduzioniFabbisogni.Location = new System.Drawing.Point(14, 78);
            this.lblRangeProduzioniFabbisogni.Name = "lblRangeProduzioniFabbisogni";
            this.lblRangeProduzioniFabbisogni.Size = new System.Drawing.Size(132, 20);
            this.lblRangeProduzioniFabbisogni.TabIndex = 4;
            this.lblRangeProduzioniFabbisogni.Text = "RANGE PRODUZ. /";
            // 
            // numericRangeProdMin
            // 
            this.numericRangeProdMin.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.numericRangeProdMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.numericRangeProdMin.Location = new System.Drawing.Point(165, 78);
            this.numericRangeProdMin.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numericRangeProdMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericRangeProdMin.Name = "numericRangeProdMin";
            this.numericRangeProdMin.Size = new System.Drawing.Size(62, 29);
            this.numericRangeProdMin.TabIndex = 5;
            this.numericRangeProdMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericRangeProdMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblRangeProdTrattino
            // 
            this.lblRangeProdTrattino.AutoSize = true;
            this.lblRangeProdTrattino.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRangeProdTrattino.ForeColor = System.Drawing.Color.Gray;
            this.lblRangeProdTrattino.Location = new System.Drawing.Point(236, 81);
            this.lblRangeProdTrattino.Name = "lblRangeProdTrattino";
            this.lblRangeProdTrattino.Size = new System.Drawing.Size(15, 20);
            this.lblRangeProdTrattino.TabIndex = 6;
            this.lblRangeProdTrattino.Text = "-";
            // 
            // numericRangeProdMax
            // 
            this.numericRangeProdMax.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.numericRangeProdMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.numericRangeProdMax.Location = new System.Drawing.Point(257, 78);
            this.numericRangeProdMax.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.numericRangeProdMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericRangeProdMax.Name = "numericRangeProdMax";
            this.numericRangeProdMax.Size = new System.Drawing.Size(66, 29);
            this.numericRangeProdMax.TabIndex = 7;
            this.numericRangeProdMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericRangeProdMax.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btnGenera
            // 
            this.btnGenera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.btnGenera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenera.FlatAppearance.BorderSize = 0;
            this.btnGenera.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.btnGenera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenera.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnGenera.ForeColor = System.Drawing.Color.White;
            this.btnGenera.Location = new System.Drawing.Point(14, 126);
            this.btnGenera.Name = "btnGenera";
            this.btnGenera.Size = new System.Drawing.Size(309, 36);
            this.btnGenera.TabIndex = 8;
            this.btnGenera.Text = "GENERA";
            this.btnGenera.UseVisualStyleBackColor = false;
            this.btnGenera.Click += new System.EventHandler(this.btnGenera_Click);
            // 
            // tabMatriceIniziale
            // 
            this.tabMatriceIniziale.BackColor = System.Drawing.Color.White;
            this.tabMatriceIniziale.Controls.Add(this.dataGridViewMatrice);
            this.tabMatriceIniziale.Location = new System.Drawing.Point(4, 32);
            this.tabMatriceIniziale.Name = "tabMatriceIniziale";
            this.tabMatriceIniziale.Padding = new System.Windows.Forms.Padding(8);
            this.tabMatriceIniziale.Size = new System.Drawing.Size(775, 686);
            this.tabMatriceIniziale.TabIndex = 0;
            this.tabMatriceIniziale.Text = "MATRICE";
            this.tabMatriceIniziale.UseVisualStyleBackColor = true;
            // 
            // dataGridViewMatrice
            // 
            this.dataGridViewMatrice.AllowUserToAddRows = false;
            this.dataGridViewMatrice.AllowUserToDeleteRows = false;
            this.dataGridViewMatrice.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.dataGridViewMatrice.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewMatrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMatrice.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dataGridViewMatrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewMatrice.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewMatrice.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMatrice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewMatrice.ColumnHeadersHeight = 44;
            this.dataGridViewMatrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(196)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMatrice.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewMatrice.EnableHeadersVisualStyles = false;
            this.dataGridViewMatrice.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dataGridViewMatrice.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewMatrice.Name = "dataGridViewMatrice";
            this.dataGridViewMatrice.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMatrice.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewMatrice.RowHeadersWidth = 150;
            this.dataGridViewMatrice.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(196)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.dataGridViewMatrice.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewMatrice.RowTemplate.Height = 38;
            this.dataGridViewMatrice.Size = new System.Drawing.Size(767, 686);
            this.dataGridViewMatrice.TabIndex = 0;
            this.dataGridViewMatrice.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewMatrice_CellFormatting);
            this.dataGridViewMatrice.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMatrice_CellMouseEnter);
            this.dataGridViewMatrice.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMatrice_CellMouseLeave);
            this.dataGridViewMatrice.MouseLeave += new System.EventHandler(this.dataGridViewMatrice_MouseLeave);
            // 
            // tabControlMetodi
            // 
            this.tabControlMetodi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMetodi.Controls.Add(this.tabMatriceIniziale);
            this.tabControlMetodi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tabControlMetodi.Location = new System.Drawing.Point(401, 88);
            this.tabControlMetodi.Name = "tabControlMetodi";
            this.tabControlMetodi.SelectedIndex = 0;
            this.tabControlMetodi.Size = new System.Drawing.Size(783, 722);
            this.tabControlMetodi.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1200, 820);
            this.Controls.Add(this.tabControlMetodi);
            this.Controls.Add(this.pannelloLaterale);
            this.Controls.Add(this.pannelloIntestazione);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1000, 640);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OTTIMIZZAZIONE DEI TRASPORTI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pannelloIntestazione.ResumeLayout(false);
            this.pannelloIntestazione.PerformLayout();
            this.pannelloLaterale.ResumeLayout(false);
            this.groupBoxProduttoriConsumatori.ResumeLayout(false);
            this.groupBoxProduttoriConsumatori.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumeroProduttori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumeroConsumatori)).EndInit();
            this.groupBoxDatiExcel.ResumeLayout(false);
            this.groupBoxValoriCasuali.ResumeLayout(false);
            this.groupBoxValoriCasuali.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericRangeCostiMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRangeCostiMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRangeProdMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRangeProdMax)).EndInit();
            this.tabMatriceIniziale.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrice)).EndInit();
            this.tabControlMetodi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pannelloIntestazione;
        private System.Windows.Forms.Label lblIntestazione;

        private System.Windows.Forms.Panel pannelloLaterale;

        private System.Windows.Forms.GroupBox groupBoxProduttoriConsumatori;
        private System.Windows.Forms.Label lblNumeroProduttori;
        private System.Windows.Forms.NumericUpDown numericNumeroProduttori;
        private System.Windows.Forms.Label lblNumeroConsumatori;
        private System.Windows.Forms.NumericUpDown numericNumeroConsumatori;
        private System.Windows.Forms.Label lblUnitaMisura;
        private System.Windows.Forms.ComboBox comboUnitaMisura;
        private System.Windows.Forms.Button btnCreaMatrice;

        private System.Windows.Forms.GroupBox groupBoxDatiExcel;
        private System.Windows.Forms.Button btnIncolla;
        private System.Windows.Forms.Label lblSuggerimentoExcel;

        private System.Windows.Forms.GroupBox groupBoxValoriCasuali;
        private System.Windows.Forms.Label lblRangeCosti;
        private System.Windows.Forms.NumericUpDown numericRangeCostiMin;
        private System.Windows.Forms.Label lblRangeCostiTrattino;
        private System.Windows.Forms.NumericUpDown numericRangeCostiMax;
        private System.Windows.Forms.Label lblRangeProduzioniFabbisogni;
        private System.Windows.Forms.NumericUpDown numericRangeProdMin;
        private System.Windows.Forms.Label lblRangeProdTrattino;
        private System.Windows.Forms.NumericUpDown numericRangeProdMax;
        private System.Windows.Forms.Button btnGenera;

        private System.Windows.Forms.Button btnRisolvi;

        private System.Windows.Forms.TabPage tabMatriceIniziale;
        private System.Windows.Forms.DataGridView dataGridViewMatrice;
        private System.Windows.Forms.TabControl tabControlMetodi;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}
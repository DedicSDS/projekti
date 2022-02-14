
namespace Projekt_D1
{
    partial class Form3
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
            System.Windows.Forms.Label imeLabel;
            System.Windows.Forms.Label priimekLabel;
            System.Windows.Forms.Label naslovLabel;
            System.Windows.Forms.Label datum_rojstvaLabel;
            System.Windows.Forms.Label zZZSLabel;
            System.Windows.Forms.Label ime_oddelkaLabel;
            System.Windows.Forms.Label ime_sobeLabel;
            System.Windows.Forms.Label st_posteljLabel;
            System.Windows.Forms.Label opravljene_storitveLabel;
            System.Windows.Forms.Label zapiskiLabel;
            System.Windows.Forms.Label cas_prijaveLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.pacientiBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.pacientiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet1 = new Projekt_D1.Database1DataSet();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.imeTextBox = new System.Windows.Forms.TextBox();
            this.priimekTextBox = new System.Windows.Forms.TextBox();
            this.naslovTextBox = new System.Windows.Forms.TextBox();
            this.datum_rojstvaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.zZZSTextBox = new System.Windows.Forms.TextBox();
            this.ime_oddelkaTextBox = new System.Windows.Forms.TextBox();
            this.oddelkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ime_sobeTextBox = new System.Windows.Forms.TextBox();
            this.sobeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.st_posteljTextBox = new System.Windows.Forms.TextBox();
            this.opravljene_storitveTextBox = new System.Windows.Forms.TextBox();
            this.glavna_tabelaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zapiskiTextBox = new System.Windows.Forms.TextBox();
            this.cas_prijaveDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pacientiTableAdapter = new Projekt_D1.Database1DataSetTableAdapters.PacientiTableAdapter();
            this.tableAdapterManager = new Projekt_D1.Database1DataSetTableAdapters.TableAdapterManager();
            this.oddelkiTableAdapter = new Projekt_D1.Database1DataSetTableAdapters.OddelkiTableAdapter();
            this.sobeTableAdapter = new Projekt_D1.Database1DataSetTableAdapters.SobeTableAdapter();
            this.glavna_tabelaTableAdapter = new Projekt_D1.Database1DataSetTableAdapters.Glavna_tabelaTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            imeLabel = new System.Windows.Forms.Label();
            priimekLabel = new System.Windows.Forms.Label();
            naslovLabel = new System.Windows.Forms.Label();
            datum_rojstvaLabel = new System.Windows.Forms.Label();
            zZZSLabel = new System.Windows.Forms.Label();
            ime_oddelkaLabel = new System.Windows.Forms.Label();
            ime_sobeLabel = new System.Windows.Forms.Label();
            st_posteljLabel = new System.Windows.Forms.Label();
            opravljene_storitveLabel = new System.Windows.Forms.Label();
            zapiskiLabel = new System.Windows.Forms.Label();
            cas_prijaveLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pacientiBindingNavigator)).BeginInit();
            this.pacientiBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacientiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oddelkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sobeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glavna_tabelaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // imeLabel
            // 
            imeLabel.AutoSize = true;
            imeLabel.Location = new System.Drawing.Point(7, 60);
            imeLabel.Name = "imeLabel";
            imeLabel.Size = new System.Drawing.Size(34, 17);
            imeLabel.TabIndex = 1;
            imeLabel.Text = "Ime:";
            // 
            // priimekLabel
            // 
            priimekLabel.AutoSize = true;
            priimekLabel.Location = new System.Drawing.Point(6, 88);
            priimekLabel.Name = "priimekLabel";
            priimekLabel.Size = new System.Drawing.Size(58, 17);
            priimekLabel.TabIndex = 3;
            priimekLabel.Text = "Priimek:";
            // 
            // naslovLabel
            // 
            naslovLabel.AutoSize = true;
            naslovLabel.Location = new System.Drawing.Point(7, 116);
            naslovLabel.Name = "naslovLabel";
            naslovLabel.Size = new System.Drawing.Size(55, 17);
            naslovLabel.TabIndex = 5;
            naslovLabel.Text = "Naslov:";
            // 
            // datum_rojstvaLabel
            // 
            datum_rojstvaLabel.AutoSize = true;
            datum_rojstvaLabel.Location = new System.Drawing.Point(6, 145);
            datum_rojstvaLabel.Name = "datum_rojstvaLabel";
            datum_rojstvaLabel.Size = new System.Drawing.Size(99, 17);
            datum_rojstvaLabel.TabIndex = 7;
            datum_rojstvaLabel.Text = "Datum rojstva:";
            // 
            // zZZSLabel
            // 
            zZZSLabel.AutoSize = true;
            zZZSLabel.Location = new System.Drawing.Point(7, 175);
            zZZSLabel.Name = "zZZSLabel";
            zZZSLabel.Size = new System.Drawing.Size(48, 17);
            zZZSLabel.TabIndex = 9;
            zZZSLabel.Text = "ZZZS:";
            // 
            // ime_oddelkaLabel
            // 
            ime_oddelkaLabel.AutoSize = true;
            ime_oddelkaLabel.Location = new System.Drawing.Point(6, 204);
            ime_oddelkaLabel.Name = "ime_oddelkaLabel";
            ime_oddelkaLabel.Size = new System.Drawing.Size(88, 17);
            ime_oddelkaLabel.TabIndex = 11;
            ime_oddelkaLabel.Text = "Ime oddelka:";
            // 
            // ime_sobeLabel
            // 
            ime_sobeLabel.AutoSize = true;
            ime_sobeLabel.Location = new System.Drawing.Point(6, 233);
            ime_sobeLabel.Name = "ime_sobeLabel";
            ime_sobeLabel.Size = new System.Drawing.Size(69, 17);
            ime_sobeLabel.TabIndex = 13;
            ime_sobeLabel.Text = "Ime sobe:";
            // 
            // st_posteljLabel
            // 
            st_posteljLabel.AutoSize = true;
            st_posteljLabel.Location = new System.Drawing.Point(7, 261);
            st_posteljLabel.Name = "st_posteljLabel";
            st_posteljLabel.Size = new System.Drawing.Size(68, 17);
            st_posteljLabel.TabIndex = 15;
            st_posteljLabel.Text = "st postelj:";
            // 
            // opravljene_storitveLabel
            // 
            opravljene_storitveLabel.AutoSize = true;
            opravljene_storitveLabel.Location = new System.Drawing.Point(7, 292);
            opravljene_storitveLabel.Name = "opravljene_storitveLabel";
            opravljene_storitveLabel.Size = new System.Drawing.Size(131, 17);
            opravljene_storitveLabel.TabIndex = 17;
            opravljene_storitveLabel.Text = "Opravljene storitve:";
            // 
            // zapiskiLabel
            // 
            zapiskiLabel.AutoSize = true;
            zapiskiLabel.Location = new System.Drawing.Point(7, 321);
            zapiskiLabel.Name = "zapiskiLabel";
            zapiskiLabel.Size = new System.Drawing.Size(57, 17);
            zapiskiLabel.TabIndex = 19;
            zapiskiLabel.Text = "Zapiski:";
            // 
            // cas_prijaveLabel
            // 
            cas_prijaveLabel.AutoSize = true;
            cas_prijaveLabel.Location = new System.Drawing.Point(7, 354);
            cas_prijaveLabel.Name = "cas_prijaveLabel";
            cas_prijaveLabel.Size = new System.Drawing.Size(82, 17);
            cas_prijaveLabel.TabIndex = 21;
            cas_prijaveLabel.Text = "Cas prijave:";
            // 
            // pacientiBindingNavigator
            // 
            this.pacientiBindingNavigator.AddNewItem = null;
            this.pacientiBindingNavigator.BindingSource = this.pacientiBindingSource;
            this.pacientiBindingNavigator.CountItem = null;
            this.pacientiBindingNavigator.DeleteItem = null;
            this.pacientiBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.pacientiBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripComboBox1,
            this.toolStripSeparator1,
            this.toolStripButton1,
            this.toolStripSeparator2,
            this.toolStripButton2});
            this.pacientiBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pacientiBindingNavigator.MoveFirstItem = null;
            this.pacientiBindingNavigator.MoveLastItem = null;
            this.pacientiBindingNavigator.MoveNextItem = null;
            this.pacientiBindingNavigator.MovePreviousItem = null;
            this.pacientiBindingNavigator.Name = "pacientiBindingNavigator";
            this.pacientiBindingNavigator.PositionItem = null;
            this.pacientiBindingNavigator.Size = new System.Drawing.Size(845, 28);
            this.pacientiBindingNavigator.TabIndex = 0;
            this.pacientiBindingNavigator.Text = "bindingNavigator1";
            // 
            // pacientiBindingSource
            // 
            this.pacientiBindingSource.DataMember = "Pacienti";
            this.pacientiBindingSource.DataSource = this.database1DataSet1;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(72, 25);
            this.toolStripLabel1.Text = "Oddelki:  ";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "SELECT Ime_oddelka FROM Oddelki;"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 28);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toolStripButton1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(47, 25);
            this.toolStripButton1.Text = "išči...";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // imeTextBox
            // 
            this.imeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.imeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientiBindingSource, "Ime", true));
            this.imeTextBox.Location = new System.Drawing.Point(142, 61);
            this.imeTextBox.Name = "imeTextBox";
            this.imeTextBox.ReadOnly = true;
            this.imeTextBox.Size = new System.Drawing.Size(224, 15);
            this.imeTextBox.TabIndex = 2;
            // 
            // priimekTextBox
            // 
            this.priimekTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.priimekTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientiBindingSource, "Priimek", true));
            this.priimekTextBox.Location = new System.Drawing.Point(142, 89);
            this.priimekTextBox.Name = "priimekTextBox";
            this.priimekTextBox.ReadOnly = true;
            this.priimekTextBox.Size = new System.Drawing.Size(224, 15);
            this.priimekTextBox.TabIndex = 4;
            // 
            // naslovTextBox
            // 
            this.naslovTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.naslovTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientiBindingSource, "Naslov", true));
            this.naslovTextBox.Location = new System.Drawing.Point(142, 117);
            this.naslovTextBox.Name = "naslovTextBox";
            this.naslovTextBox.ReadOnly = true;
            this.naslovTextBox.Size = new System.Drawing.Size(224, 15);
            this.naslovTextBox.TabIndex = 6;
            // 
            // datum_rojstvaDateTimePicker
            // 
            this.datum_rojstvaDateTimePicker.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.datum_rojstvaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pacientiBindingSource, "Datum_rojstva", true));
            this.datum_rojstvaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datum_rojstvaDateTimePicker.Location = new System.Drawing.Point(142, 142);
            this.datum_rojstvaDateTimePicker.Name = "datum_rojstvaDateTimePicker";
            this.datum_rojstvaDateTimePicker.Size = new System.Drawing.Size(224, 22);
            this.datum_rojstvaDateTimePicker.TabIndex = 8;
            // 
            // zZZSTextBox
            // 
            this.zZZSTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.zZZSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientiBindingSource, "ZZZS", true));
            this.zZZSTextBox.Location = new System.Drawing.Point(142, 173);
            this.zZZSTextBox.Name = "zZZSTextBox";
            this.zZZSTextBox.ReadOnly = true;
            this.zZZSTextBox.Size = new System.Drawing.Size(225, 15);
            this.zZZSTextBox.TabIndex = 10;
            // 
            // ime_oddelkaTextBox
            // 
            this.ime_oddelkaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ime_oddelkaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oddelkiBindingSource, "Ime_oddelka", true));
            this.ime_oddelkaTextBox.Location = new System.Drawing.Point(142, 202);
            this.ime_oddelkaTextBox.Name = "ime_oddelkaTextBox";
            this.ime_oddelkaTextBox.ReadOnly = true;
            this.ime_oddelkaTextBox.Size = new System.Drawing.Size(225, 15);
            this.ime_oddelkaTextBox.TabIndex = 12;
            // 
            // oddelkiBindingSource
            // 
            this.oddelkiBindingSource.DataMember = "Oddelki";
            this.oddelkiBindingSource.DataSource = this.database1DataSet1;
            // 
            // ime_sobeTextBox
            // 
            this.ime_sobeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ime_sobeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sobeBindingSource, "Ime_sobe", true));
            this.ime_sobeTextBox.Location = new System.Drawing.Point(142, 231);
            this.ime_sobeTextBox.Name = "ime_sobeTextBox";
            this.ime_sobeTextBox.ReadOnly = true;
            this.ime_sobeTextBox.Size = new System.Drawing.Size(225, 15);
            this.ime_sobeTextBox.TabIndex = 14;
            // 
            // sobeBindingSource
            // 
            this.sobeBindingSource.DataMember = "Sobe";
            this.sobeBindingSource.DataSource = this.database1DataSet1;
            // 
            // st_posteljTextBox
            // 
            this.st_posteljTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.st_posteljTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sobeBindingSource, "st_postelj", true));
            this.st_posteljTextBox.Location = new System.Drawing.Point(142, 259);
            this.st_posteljTextBox.Name = "st_posteljTextBox";
            this.st_posteljTextBox.ReadOnly = true;
            this.st_posteljTextBox.Size = new System.Drawing.Size(225, 15);
            this.st_posteljTextBox.TabIndex = 16;
            // 
            // opravljene_storitveTextBox
            // 
            this.opravljene_storitveTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.opravljene_storitveTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.glavna_tabelaBindingSource, "Opravljene_storitve", true));
            this.opravljene_storitveTextBox.Location = new System.Drawing.Point(142, 290);
            this.opravljene_storitveTextBox.Name = "opravljene_storitveTextBox";
            this.opravljene_storitveTextBox.ReadOnly = true;
            this.opravljene_storitveTextBox.Size = new System.Drawing.Size(224, 15);
            this.opravljene_storitveTextBox.TabIndex = 18;
            // 
            // glavna_tabelaBindingSource
            // 
            this.glavna_tabelaBindingSource.DataMember = "Glavna_tabela";
            this.glavna_tabelaBindingSource.DataSource = this.database1DataSet1;
            // 
            // zapiskiTextBox
            // 
            this.zapiskiTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.zapiskiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.glavna_tabelaBindingSource, "Zapiski", true));
            this.zapiskiTextBox.Location = new System.Drawing.Point(142, 319);
            this.zapiskiTextBox.Name = "zapiskiTextBox";
            this.zapiskiTextBox.ReadOnly = true;
            this.zapiskiTextBox.Size = new System.Drawing.Size(225, 15);
            this.zapiskiTextBox.TabIndex = 20;
            // 
            // cas_prijaveDateTimePicker
            // 
            this.cas_prijaveDateTimePicker.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.cas_prijaveDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.glavna_tabelaBindingSource, "Cas_prijave", true));
            this.cas_prijaveDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.cas_prijaveDateTimePicker.Location = new System.Drawing.Point(141, 349);
            this.cas_prijaveDateTimePicker.Name = "cas_prijaveDateTimePicker";
            this.cas_prijaveDateTimePicker.Size = new System.Drawing.Size(225, 22);
            this.cas_prijaveDateTimePicker.TabIndex = 22;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(387, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(329, 286);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // pacientiTableAdapter
            // 
            this.pacientiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Glavna_tabelaTableAdapter = null;
            this.tableAdapterManager.OddelkiTableAdapter = null;
            this.tableAdapterManager.PacientiTableAdapter = this.pacientiTableAdapter;
            this.tableAdapterManager.SobeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projekt_D1.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // oddelkiTableAdapter
            // 
            this.oddelkiTableAdapter.ClearBeforeFill = true;
            // 
            // sobeTableAdapter
            // 
            this.sobeTableAdapter.ClearBeforeFill = true;
            // 
            // glavna_tabelaTableAdapter
            // 
            this.glavna_tabelaTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(695, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 59);
            this.button1.TabIndex = 24;
            this.button1.Text = "Nazaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripButton2.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(86, 25);
            this.toolStripButton2.Text = "prikaži vse";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(cas_prijaveLabel);
            this.Controls.Add(this.cas_prijaveDateTimePicker);
            this.Controls.Add(zapiskiLabel);
            this.Controls.Add(this.zapiskiTextBox);
            this.Controls.Add(opravljene_storitveLabel);
            this.Controls.Add(this.opravljene_storitveTextBox);
            this.Controls.Add(st_posteljLabel);
            this.Controls.Add(this.st_posteljTextBox);
            this.Controls.Add(ime_sobeLabel);
            this.Controls.Add(this.ime_sobeTextBox);
            this.Controls.Add(ime_oddelkaLabel);
            this.Controls.Add(this.ime_oddelkaTextBox);
            this.Controls.Add(zZZSLabel);
            this.Controls.Add(this.zZZSTextBox);
            this.Controls.Add(datum_rojstvaLabel);
            this.Controls.Add(this.datum_rojstvaDateTimePicker);
            this.Controls.Add(naslovLabel);
            this.Controls.Add(this.naslovTextBox);
            this.Controls.Add(priimekLabel);
            this.Controls.Add(this.priimekTextBox);
            this.Controls.Add(imeLabel);
            this.Controls.Add(this.imeTextBox);
            this.Controls.Add(this.pacientiBindingNavigator);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pacientiBindingNavigator)).EndInit();
            this.pacientiBindingNavigator.ResumeLayout(false);
            this.pacientiBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacientiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oddelkiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sobeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glavna_tabelaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Database1DataSet database1DataSet1;
        private System.Windows.Forms.BindingSource pacientiBindingSource;
        private Database1DataSetTableAdapters.PacientiTableAdapter pacientiTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pacientiBindingNavigator;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.TextBox imeTextBox;
        private System.Windows.Forms.TextBox priimekTextBox;
        private System.Windows.Forms.TextBox naslovTextBox;
        private System.Windows.Forms.DateTimePicker datum_rojstvaDateTimePicker;
        private System.Windows.Forms.TextBox zZZSTextBox;
        private System.Windows.Forms.BindingSource oddelkiBindingSource;
        private Database1DataSetTableAdapters.OddelkiTableAdapter oddelkiTableAdapter;
        private System.Windows.Forms.TextBox ime_oddelkaTextBox;
        private System.Windows.Forms.BindingSource sobeBindingSource;
        private Database1DataSetTableAdapters.SobeTableAdapter sobeTableAdapter;
        private System.Windows.Forms.TextBox ime_sobeTextBox;
        private System.Windows.Forms.TextBox st_posteljTextBox;
        private System.Windows.Forms.BindingSource glavna_tabelaBindingSource;
        private Database1DataSetTableAdapters.Glavna_tabelaTableAdapter glavna_tabelaTableAdapter;
        private System.Windows.Forms.TextBox opravljene_storitveTextBox;
        private System.Windows.Forms.TextBox zapiskiTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DateTimePicker cas_prijaveDateTimePicker;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}
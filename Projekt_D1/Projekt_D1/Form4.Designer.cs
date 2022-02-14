
namespace Projekt_D1
{
    partial class Form4
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
            System.Windows.Forms.Label cas_odjaveLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.database1DataSet = new Projekt_D1.Database1DataSet();
            this.glavna_tabelaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.glavna_tabelaTableAdapter = new Projekt_D1.Database1DataSetTableAdapters.Glavna_tabelaTableAdapter();
            this.tableAdapterManager = new Projekt_D1.Database1DataSetTableAdapters.TableAdapterManager();
            this.oddelkiTableAdapter = new Projekt_D1.Database1DataSetTableAdapters.OddelkiTableAdapter();
            this.pacientiTableAdapter = new Projekt_D1.Database1DataSetTableAdapters.PacientiTableAdapter();
            this.sobeTableAdapter = new Projekt_D1.Database1DataSetTableAdapters.SobeTableAdapter();
            this.glavna_tabelaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.pacientiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imeTextBox = new System.Windows.Forms.TextBox();
            this.priimekTextBox = new System.Windows.Forms.TextBox();
            this.naslovTextBox = new System.Windows.Forms.TextBox();
            this.datum_rojstvaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.zZZSTextBox = new System.Windows.Forms.TextBox();
            this.oddelkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ime_oddelkaTextBox = new System.Windows.Forms.TextBox();
            this.sobeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ime_sobeTextBox = new System.Windows.Forms.TextBox();
            this.st_posteljTextBox = new System.Windows.Forms.TextBox();
            this.opravljene_storitveTextBox = new System.Windows.Forms.TextBox();
            this.zapiskiTextBox = new System.Windows.Forms.TextBox();
            this.cas_prijaveDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cas_odjaveDateTimePicker = new System.Windows.Forms.DateTimePicker();
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
            cas_odjaveLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glavna_tabelaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glavna_tabelaBindingNavigator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oddelkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sobeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // imeLabel
            // 
            imeLabel.AutoSize = true;
            imeLabel.Location = new System.Drawing.Point(450, 41);
            imeLabel.Name = "imeLabel";
            imeLabel.Size = new System.Drawing.Size(34, 17);
            imeLabel.TabIndex = 3;
            imeLabel.Text = "Ime:";
            // 
            // priimekLabel
            // 
            priimekLabel.AutoSize = true;
            priimekLabel.Location = new System.Drawing.Point(450, 70);
            priimekLabel.Name = "priimekLabel";
            priimekLabel.Size = new System.Drawing.Size(58, 17);
            priimekLabel.TabIndex = 5;
            priimekLabel.Text = "Priimek:";
            // 
            // naslovLabel
            // 
            naslovLabel.AutoSize = true;
            naslovLabel.Location = new System.Drawing.Point(450, 98);
            naslovLabel.Name = "naslovLabel";
            naslovLabel.Size = new System.Drawing.Size(55, 17);
            naslovLabel.TabIndex = 7;
            naslovLabel.Text = "Naslov:";
            // 
            // datum_rojstvaLabel
            // 
            datum_rojstvaLabel.AutoSize = true;
            datum_rojstvaLabel.Location = new System.Drawing.Point(450, 128);
            datum_rojstvaLabel.Name = "datum_rojstvaLabel";
            datum_rojstvaLabel.Size = new System.Drawing.Size(99, 17);
            datum_rojstvaLabel.TabIndex = 9;
            datum_rojstvaLabel.Text = "Datum rojstva:";
            // 
            // zZZSLabel
            // 
            zZZSLabel.AutoSize = true;
            zZZSLabel.Location = new System.Drawing.Point(450, 154);
            zZZSLabel.Name = "zZZSLabel";
            zZZSLabel.Size = new System.Drawing.Size(48, 17);
            zZZSLabel.TabIndex = 11;
            zZZSLabel.Text = "ZZZS:";
            // 
            // ime_oddelkaLabel
            // 
            ime_oddelkaLabel.AutoSize = true;
            ime_oddelkaLabel.Location = new System.Drawing.Point(450, 182);
            ime_oddelkaLabel.Name = "ime_oddelkaLabel";
            ime_oddelkaLabel.Size = new System.Drawing.Size(88, 17);
            ime_oddelkaLabel.TabIndex = 13;
            ime_oddelkaLabel.Text = "Ime oddelka:";
            // 
            // ime_sobeLabel
            // 
            ime_sobeLabel.AutoSize = true;
            ime_sobeLabel.Location = new System.Drawing.Point(450, 210);
            ime_sobeLabel.Name = "ime_sobeLabel";
            ime_sobeLabel.Size = new System.Drawing.Size(69, 17);
            ime_sobeLabel.TabIndex = 15;
            ime_sobeLabel.Text = "Ime sobe:";
            // 
            // st_posteljLabel
            // 
            st_posteljLabel.AutoSize = true;
            st_posteljLabel.Location = new System.Drawing.Point(450, 238);
            st_posteljLabel.Name = "st_posteljLabel";
            st_posteljLabel.Size = new System.Drawing.Size(68, 17);
            st_posteljLabel.TabIndex = 17;
            st_posteljLabel.Text = "st postelj:";
            // 
            // opravljene_storitveLabel
            // 
            opravljene_storitveLabel.AutoSize = true;
            opravljene_storitveLabel.Location = new System.Drawing.Point(450, 266);
            opravljene_storitveLabel.Name = "opravljene_storitveLabel";
            opravljene_storitveLabel.Size = new System.Drawing.Size(131, 17);
            opravljene_storitveLabel.TabIndex = 19;
            opravljene_storitveLabel.Text = "Opravljene storitve:";
            // 
            // zapiskiLabel
            // 
            zapiskiLabel.AutoSize = true;
            zapiskiLabel.Location = new System.Drawing.Point(450, 294);
            zapiskiLabel.Name = "zapiskiLabel";
            zapiskiLabel.Size = new System.Drawing.Size(57, 17);
            zapiskiLabel.TabIndex = 21;
            zapiskiLabel.Text = "Zapiski:";
            // 
            // cas_prijaveLabel
            // 
            cas_prijaveLabel.AutoSize = true;
            cas_prijaveLabel.Location = new System.Drawing.Point(450, 324);
            cas_prijaveLabel.Name = "cas_prijaveLabel";
            cas_prijaveLabel.Size = new System.Drawing.Size(82, 17);
            cas_prijaveLabel.TabIndex = 23;
            cas_prijaveLabel.Text = "Cas prijave:";
            // 
            // cas_odjaveLabel
            // 
            cas_odjaveLabel.AutoSize = true;
            cas_odjaveLabel.Location = new System.Drawing.Point(450, 352);
            cas_odjaveLabel.Name = "cas_odjaveLabel";
            cas_odjaveLabel.Size = new System.Drawing.Size(82, 17);
            cas_odjaveLabel.TabIndex = 25;
            cas_odjaveLabel.Text = "Cas odjave:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(745, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "Nazaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(317, 430);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // glavna_tabelaBindingSource
            // 
            this.glavna_tabelaBindingSource.DataMember = "Glavna_tabela";
            this.glavna_tabelaBindingSource.DataSource = this.database1DataSet;
            // 
            // glavna_tabelaTableAdapter
            // 
            this.glavna_tabelaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Glavna_tabelaTableAdapter = this.glavna_tabelaTableAdapter;
            this.tableAdapterManager.OddelkiTableAdapter = this.oddelkiTableAdapter;
            this.tableAdapterManager.PacientiTableAdapter = this.pacientiTableAdapter;
            this.tableAdapterManager.SobeTableAdapter = this.sobeTableAdapter;
            this.tableAdapterManager.UpdateOrder = Projekt_D1.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // oddelkiTableAdapter
            // 
            this.oddelkiTableAdapter.ClearBeforeFill = true;
            // 
            // pacientiTableAdapter
            // 
            this.pacientiTableAdapter.ClearBeforeFill = true;
            // 
            // sobeTableAdapter
            // 
            this.sobeTableAdapter.ClearBeforeFill = true;
            // 
            // glavna_tabelaBindingNavigator
            // 
            this.glavna_tabelaBindingNavigator.AddNewItem = null;
            this.glavna_tabelaBindingNavigator.BindingSource = this.glavna_tabelaBindingSource;
            this.glavna_tabelaBindingNavigator.CountItem = null;
            this.glavna_tabelaBindingNavigator.DeleteItem = null;
            this.glavna_tabelaBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.glavna_tabelaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.glavna_tabelaBindingNavigator.MoveFirstItem = null;
            this.glavna_tabelaBindingNavigator.MoveLastItem = null;
            this.glavna_tabelaBindingNavigator.MoveNextItem = null;
            this.glavna_tabelaBindingNavigator.MovePreviousItem = null;
            this.glavna_tabelaBindingNavigator.Name = "glavna_tabelaBindingNavigator";
            this.glavna_tabelaBindingNavigator.PositionItem = null;
            this.glavna_tabelaBindingNavigator.Size = new System.Drawing.Size(890, 31);
            this.glavna_tabelaBindingNavigator.TabIndex = 2;
            this.glavna_tabelaBindingNavigator.Text = "bindingNavigator1";
            // 
            // pacientiBindingSource
            // 
            this.pacientiBindingSource.DataMember = "Pacienti";
            this.pacientiBindingSource.DataSource = this.database1DataSet;
            // 
            // imeTextBox
            // 
            this.imeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.imeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientiBindingSource, "Ime", true));
            this.imeTextBox.Location = new System.Drawing.Point(589, 38);
            this.imeTextBox.Name = "imeTextBox";
            this.imeTextBox.ReadOnly = true;
            this.imeTextBox.Size = new System.Drawing.Size(200, 15);
            this.imeTextBox.TabIndex = 4;
            // 
            // priimekTextBox
            // 
            this.priimekTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.priimekTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientiBindingSource, "Priimek", true));
            this.priimekTextBox.Location = new System.Drawing.Point(589, 67);
            this.priimekTextBox.Name = "priimekTextBox";
            this.priimekTextBox.ReadOnly = true;
            this.priimekTextBox.Size = new System.Drawing.Size(200, 15);
            this.priimekTextBox.TabIndex = 6;
            // 
            // naslovTextBox
            // 
            this.naslovTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.naslovTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientiBindingSource, "Naslov", true));
            this.naslovTextBox.Location = new System.Drawing.Point(589, 95);
            this.naslovTextBox.Name = "naslovTextBox";
            this.naslovTextBox.ReadOnly = true;
            this.naslovTextBox.Size = new System.Drawing.Size(200, 15);
            this.naslovTextBox.TabIndex = 8;
            // 
            // datum_rojstvaDateTimePicker
            // 
            this.datum_rojstvaDateTimePicker.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.datum_rojstvaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pacientiBindingSource, "Datum_rojstva", true));
            this.datum_rojstvaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datum_rojstvaDateTimePicker.Location = new System.Drawing.Point(589, 123);
            this.datum_rojstvaDateTimePicker.Name = "datum_rojstvaDateTimePicker";
            this.datum_rojstvaDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.datum_rojstvaDateTimePicker.TabIndex = 10;
            // 
            // zZZSTextBox
            // 
            this.zZZSTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.zZZSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientiBindingSource, "ZZZS", true));
            this.zZZSTextBox.Location = new System.Drawing.Point(589, 151);
            this.zZZSTextBox.Name = "zZZSTextBox";
            this.zZZSTextBox.ReadOnly = true;
            this.zZZSTextBox.Size = new System.Drawing.Size(200, 15);
            this.zZZSTextBox.TabIndex = 12;
            // 
            // oddelkiBindingSource
            // 
            this.oddelkiBindingSource.DataMember = "Oddelki";
            this.oddelkiBindingSource.DataSource = this.database1DataSet;
            // 
            // ime_oddelkaTextBox
            // 
            this.ime_oddelkaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ime_oddelkaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oddelkiBindingSource, "Ime_oddelka", true));
            this.ime_oddelkaTextBox.Location = new System.Drawing.Point(589, 179);
            this.ime_oddelkaTextBox.Name = "ime_oddelkaTextBox";
            this.ime_oddelkaTextBox.ReadOnly = true;
            this.ime_oddelkaTextBox.Size = new System.Drawing.Size(200, 15);
            this.ime_oddelkaTextBox.TabIndex = 14;
            // 
            // sobeBindingSource
            // 
            this.sobeBindingSource.DataMember = "Sobe";
            this.sobeBindingSource.DataSource = this.database1DataSet;
            // 
            // ime_sobeTextBox
            // 
            this.ime_sobeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ime_sobeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sobeBindingSource, "Ime_sobe", true));
            this.ime_sobeTextBox.Location = new System.Drawing.Point(589, 207);
            this.ime_sobeTextBox.Name = "ime_sobeTextBox";
            this.ime_sobeTextBox.ReadOnly = true;
            this.ime_sobeTextBox.Size = new System.Drawing.Size(200, 15);
            this.ime_sobeTextBox.TabIndex = 16;
            // 
            // st_posteljTextBox
            // 
            this.st_posteljTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.st_posteljTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sobeBindingSource, "st_postelj", true));
            this.st_posteljTextBox.Location = new System.Drawing.Point(589, 235);
            this.st_posteljTextBox.Name = "st_posteljTextBox";
            this.st_posteljTextBox.ReadOnly = true;
            this.st_posteljTextBox.Size = new System.Drawing.Size(200, 15);
            this.st_posteljTextBox.TabIndex = 18;
            // 
            // opravljene_storitveTextBox
            // 
            this.opravljene_storitveTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.opravljene_storitveTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.glavna_tabelaBindingSource, "Opravljene_storitve", true));
            this.opravljene_storitveTextBox.Location = new System.Drawing.Point(589, 263);
            this.opravljene_storitveTextBox.Name = "opravljene_storitveTextBox";
            this.opravljene_storitveTextBox.ReadOnly = true;
            this.opravljene_storitveTextBox.Size = new System.Drawing.Size(200, 15);
            this.opravljene_storitveTextBox.TabIndex = 20;
            // 
            // zapiskiTextBox
            // 
            this.zapiskiTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.zapiskiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.glavna_tabelaBindingSource, "Zapiski", true));
            this.zapiskiTextBox.Location = new System.Drawing.Point(589, 291);
            this.zapiskiTextBox.Name = "zapiskiTextBox";
            this.zapiskiTextBox.ReadOnly = true;
            this.zapiskiTextBox.Size = new System.Drawing.Size(200, 15);
            this.zapiskiTextBox.TabIndex = 22;
            // 
            // cas_prijaveDateTimePicker
            // 
            this.cas_prijaveDateTimePicker.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.cas_prijaveDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.glavna_tabelaBindingSource, "Cas_prijave", true));
            this.cas_prijaveDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.cas_prijaveDateTimePicker.Location = new System.Drawing.Point(589, 319);
            this.cas_prijaveDateTimePicker.Name = "cas_prijaveDateTimePicker";
            this.cas_prijaveDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.cas_prijaveDateTimePicker.TabIndex = 24;
            // 
            // cas_odjaveDateTimePicker
            // 
            this.cas_odjaveDateTimePicker.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.cas_odjaveDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.glavna_tabelaBindingSource, "Cas_odjave", true));
            this.cas_odjaveDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.cas_odjaveDateTimePicker.Location = new System.Drawing.Point(589, 347);
            this.cas_odjaveDateTimePicker.Name = "cas_odjaveDateTimePicker";
            this.cas_odjaveDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.cas_odjaveDateTimePicker.TabIndex = 26;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 483);
            this.Controls.Add(cas_odjaveLabel);
            this.Controls.Add(this.cas_odjaveDateTimePicker);
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
            this.Controls.Add(this.glavna_tabelaBindingNavigator);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form4_FormClosing);
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glavna_tabelaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glavna_tabelaBindingNavigator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oddelkiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sobeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource glavna_tabelaBindingSource;
        private Database1DataSetTableAdapters.Glavna_tabelaTableAdapter glavna_tabelaTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator glavna_tabelaBindingNavigator;
        private Database1DataSetTableAdapters.PacientiTableAdapter pacientiTableAdapter;
        private System.Windows.Forms.BindingSource pacientiBindingSource;
        private System.Windows.Forms.TextBox imeTextBox;
        private System.Windows.Forms.TextBox priimekTextBox;
        private System.Windows.Forms.TextBox naslovTextBox;
        private System.Windows.Forms.DateTimePicker datum_rojstvaDateTimePicker;
        private System.Windows.Forms.TextBox zZZSTextBox;
        private Database1DataSetTableAdapters.OddelkiTableAdapter oddelkiTableAdapter;
        private System.Windows.Forms.BindingSource oddelkiBindingSource;
        private Database1DataSetTableAdapters.SobeTableAdapter sobeTableAdapter;
        private System.Windows.Forms.TextBox ime_oddelkaTextBox;
        private System.Windows.Forms.BindingSource sobeBindingSource;
        private System.Windows.Forms.TextBox ime_sobeTextBox;
        private System.Windows.Forms.TextBox st_posteljTextBox;
        private System.Windows.Forms.TextBox opravljene_storitveTextBox;
        private System.Windows.Forms.TextBox zapiskiTextBox;
        private System.Windows.Forms.DateTimePicker cas_prijaveDateTimePicker;
        private System.Windows.Forms.DateTimePicker cas_odjaveDateTimePicker;
    }
}
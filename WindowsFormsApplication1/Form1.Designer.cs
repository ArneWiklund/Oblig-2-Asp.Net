namespace WindowsFormsApplication1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fornavn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etternavnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datoFraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datoTilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordreDataSet2 = new WindowsFormsApplication1.ordreDataSet2();
            this.ordreTableAdapter = new WindowsFormsApplication1.ordreDataSet2TableAdapters.ordreTableAdapter();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordreDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(557, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(657, 496);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(649, 467);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(649, 467);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(649, 467);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fornavn,
            this.etternavnDataGridViewTextBoxColumn,
            this.adresse,
            this.datoFraDataGridViewTextBoxColumn,
            this.datoTilDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ordreBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(5, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(546, 458);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDown);
            this.dataGridView1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseMove);
            // 
            // fornavn
            // 
            this.fornavn.DataPropertyName = "fornavn";
            this.fornavn.HeaderText = "fornavn";
            this.fornavn.Name = "fornavn";
            // 
            // etternavnDataGridViewTextBoxColumn
            // 
            this.etternavnDataGridViewTextBoxColumn.DataPropertyName = "etternavn";
            this.etternavnDataGridViewTextBoxColumn.HeaderText = "etternavn";
            this.etternavnDataGridViewTextBoxColumn.Name = "etternavnDataGridViewTextBoxColumn";
            // 
            // adresse
            // 
            this.adresse.DataPropertyName = "adresse";
            this.adresse.HeaderText = "adresse";
            this.adresse.Name = "adresse";
            // 
            // datoFraDataGridViewTextBoxColumn
            // 
            this.datoFraDataGridViewTextBoxColumn.DataPropertyName = "datoFra";
            this.datoFraDataGridViewTextBoxColumn.HeaderText = "datoFra";
            this.datoFraDataGridViewTextBoxColumn.Name = "datoFraDataGridViewTextBoxColumn";
            // 
            // datoTilDataGridViewTextBoxColumn
            // 
            this.datoTilDataGridViewTextBoxColumn.DataPropertyName = "datoTil";
            this.datoTilDataGridViewTextBoxColumn.HeaderText = "datoTil";
            this.datoTilDataGridViewTextBoxColumn.Name = "datoTilDataGridViewTextBoxColumn";
            // 
            // ordreBindingSource
            // 
            this.ordreBindingSource.DataMember = "ordre";
            this.ordreBindingSource.DataSource = this.ordreDataSet2;
            // 
            // ordreDataSet2
            // 
            this.ordreDataSet2.DataSetName = "ordreDataSet2";
            this.ordreDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordreTableAdapter
            // 
            this.ordreTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 546);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordreDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ordreDataSet2 ordreDataSet2;
        private System.Windows.Forms.BindingSource ordreBindingSource;
        private ordreDataSet2TableAdapters.ordreTableAdapter ordreTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn etternavnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datoFraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datoTilDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip fillBy1ToolStrip;
        private System.Windows.Forms.ToolStripButton fillBy1ToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornavn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresse;
    }
}


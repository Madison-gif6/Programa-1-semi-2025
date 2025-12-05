namespace MiPrimerProyectoCsharp
{
    partial class frmNotas
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
            System.Windows.Forms.Label idNotas;
            System.Windows.Forms.Label lblMaterias;
            System.Windows.Forms.Label lblPeriodo;
            System.Windows.Forms.Label lblfecha;
            this.db_academicaDataSet = new MiPrimerProyectoCsharp.db_academicaDataSet();
            this.notasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notasTableAdapter = new MiPrimerProyectoCsharp.db_academicaDataSetTableAdapters.notasTableAdapter();
            this.tableAdapterManager = new MiPrimerProyectoCsharp.db_academicaDataSetTableAdapters.TableAdapterManager();
            this.idNotasLabel1 = new System.Windows.Forms.Label();
            this.cboMateria = new System.Windows.Forms.ComboBox();
            this.materiasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cboPeriodos = new System.Windows.Forms.ComboBox();
            this.periodosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.periodosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dnotasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dnotasTableAdapter = new MiPrimerProyectoCsharp.db_academicaDataSetTableAdapters.dnotasTableAdapter();
            this.dnotasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.materiasTableAdapter = new MiPrimerProyectoCsharp.db_academicaDataSetTableAdapters.MateriasTableAdapter();
            this.periodosTableAdapter = new MiPrimerProyectoCsharp.db_academicaDataSetTableAdapters.PeriodosTableAdapter();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.materiasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dnotasDataGridView = new System.Windows.Forms.DataGridView();
            this.idDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lab1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lab2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota_final = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idNotas = new System.Windows.Forms.Label();
            lblMaterias = new System.Windows.Forms.Label();
            lblPeriodo = new System.Windows.Forms.Label();
            lblfecha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.db_academicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnotasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnotasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnotasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idNotas
            // 
            idNotas.AutoSize = true;
            idNotas.Location = new System.Drawing.Point(37, 71);
            idNotas.Name = "idNotas";
            idNotas.Size = new System.Drawing.Size(23, 16);
            idNotas.TabIndex = 1;
            idNotas.Text = "ID:";
            // 
            // lblMaterias
            // 
            lblMaterias.AutoSize = true;
            lblMaterias.Location = new System.Drawing.Point(37, 100);
            lblMaterias.Name = "lblMaterias";
            lblMaterias.Size = new System.Drawing.Size(55, 16);
            lblMaterias.TabIndex = 3;
            lblMaterias.Text = "Materia:";
            // 
            // lblPeriodo
            // 
            lblPeriodo.AutoSize = true;
            lblPeriodo.Location = new System.Drawing.Point(389, 100);
            lblPeriodo.Name = "lblPeriodo";
            lblPeriodo.Size = new System.Drawing.Size(58, 16);
            lblPeriodo.TabIndex = 5;
            lblPeriodo.Text = "Periodo:";
            // 
            // lblfecha
            // 
            lblfecha.AutoSize = true;
            lblfecha.Location = new System.Drawing.Point(37, 142);
            lblfecha.Name = "lblfecha";
            lblfecha.Size = new System.Drawing.Size(55, 16);
            lblfecha.TabIndex = 7;
            lblfecha.Text = "FECHA:";
            // 
            // db_academicaDataSet
            // 
            this.db_academicaDataSet.DataSetName = "db_academicaDataSet";
            this.db_academicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // notasBindingSource
            // 
            this.notasBindingSource.DataMember = "notas";
            this.notasBindingSource.DataSource = this.db_academicaDataSet;
            // 
            // notasTableAdapter
            // 
            this.notasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.alumnosTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.dnotasTableAdapter = null;
            this.tableAdapterManager.docentesTableAdapter = null;
            this.tableAdapterManager.MateriasTableAdapter = null;
            this.tableAdapterManager.notasTableAdapter = this.notasTableAdapter;
            this.tableAdapterManager.PeriodosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MiPrimerProyectoCsharp.db_academicaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // idNotasLabel1
            // 
            this.idNotasLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notasBindingSource, "IdNotas", true));
            this.idNotasLabel1.Location = new System.Drawing.Point(119, 71);
            this.idNotasLabel1.Name = "idNotasLabel1";
            this.idNotasLabel1.Size = new System.Drawing.Size(200, 23);
            this.idNotasLabel1.TabIndex = 2;
            this.idNotasLabel1.Text = "label1";
            // 
            // cboMateria
            // 
            this.cboMateria.DataSource = this.materiasBindingSource1;
            this.cboMateria.DisplayMember = "Nombre";
            this.cboMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMateria.FormattingEnabled = true;
            this.cboMateria.Location = new System.Drawing.Point(119, 97);
            this.cboMateria.Name = "cboMateria";
            this.cboMateria.Size = new System.Drawing.Size(200, 24);
            this.cboMateria.TabIndex = 4;
            this.cboMateria.ValueMember = "IdMaterias";
            this.cboMateria.SelectedValueChanged += new System.EventHandler(this.cboMateria_SelectedValueChanged_1);
            // 
            // materiasBindingSource1
            // 
            this.materiasBindingSource1.DataMember = "Materias";
            this.materiasBindingSource1.DataSource = this.db_academicaDataSet;
            // 
            // cboPeriodos
            // 
            this.cboPeriodos.DataSource = this.periodosBindingSource1;
            this.cboPeriodos.DisplayMember = "periodo";
            this.cboPeriodos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPeriodos.FormattingEnabled = true;
            this.cboPeriodos.Location = new System.Drawing.Point(471, 97);
            this.cboPeriodos.Name = "cboPeriodos";
            this.cboPeriodos.Size = new System.Drawing.Size(200, 24);
            this.cboPeriodos.TabIndex = 6;
            this.cboPeriodos.ValueMember = "IdPeriodos";
            this.cboPeriodos.SelectedValueChanged += new System.EventHandler(this.cboPeriodos_SelectedValueChanged_1);
            // 
            // periodosBindingSource1
            // 
            this.periodosBindingSource1.DataMember = "Periodos";
            this.periodosBindingSource1.DataSource = this.db_academicaDataSet;
            // 
            // periodosBindingSource
            // 
            this.periodosBindingSource.DataMember = "Periodos";
            this.periodosBindingSource.DataSource = this.db_academicaDataSet;
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.notasBindingSource, "fecha", true));
            this.fechaDateTimePicker.Location = new System.Drawing.Point(119, 138);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(289, 22);
            this.fechaDateTimePicker.TabIndex = 8;
            // 
            // dnotasBindingSource
            // 
            this.dnotasBindingSource.DataMember = "dnotas";
            this.dnotasBindingSource.DataSource = this.db_academicaDataSet;
            // 
            // dnotasTableAdapter
            // 
            this.dnotasTableAdapter.ClearBeforeFill = true;
            // 
            // dnotasBindingSource1
            // 
            this.dnotasBindingSource1.DataMember = "dnotas";
            this.dnotasBindingSource1.DataSource = this.db_academicaDataSet;
            // 
            // materiasTableAdapter
            // 
            this.materiasTableAdapter.ClearBeforeFill = true;
            // 
            // periodosTableAdapter
            // 
            this.periodosTableAdapter.ClearBeforeFill = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(818, 189);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // materiasBindingSource
            // 
            this.materiasBindingSource.DataMember = "Materias";
            this.materiasBindingSource.DataSource = this.db_academicaDataSet;
            // 
            // dnotasDataGridView
            // 
            this.dnotasDataGridView.AllowUserToAddRows = false;
            this.dnotasDataGridView.AllowUserToDeleteRows = false;
            this.dnotasDataGridView.AutoGenerateColumns = false;
            this.dnotasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dnotasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDetalle,
            this.alumno,
            this.lab1,
            this.lab2,
            this.parcial,
            this.nota_final});
            this.dnotasDataGridView.DataSource = this.dnotasBindingSource;
            this.dnotasDataGridView.Location = new System.Drawing.Point(40, 191);
            this.dnotasDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dnotasDataGridView.Name = "dnotasDataGridView";
            this.dnotasDataGridView.RowHeadersWidth = 51;
            this.dnotasDataGridView.Size = new System.Drawing.Size(755, 183);
            this.dnotasDataGridView.TabIndex = 11;
            // 
            // idDetalle
            // 
            this.idDetalle.DataPropertyName = "idDetalle";
            this.idDetalle.HeaderText = "ID";
            this.idDetalle.MinimumWidth = 6;
            this.idDetalle.Name = "idDetalle";
            this.idDetalle.ReadOnly = true;
            this.idDetalle.Visible = false;
            this.idDetalle.Width = 50;
            // 
            // alumno
            // 
            this.alumno.DataPropertyName = "nombre";
            this.alumno.HeaderText = "ALUMNO";
            this.alumno.MinimumWidth = 6;
            this.alumno.Name = "alumno";
            this.alumno.ReadOnly = true;
            this.alumno.Width = 200;
            // 
            // lab1
            // 
            this.lab1.DataPropertyName = "lab1";
            this.lab1.HeaderText = "LAB1";
            this.lab1.MinimumWidth = 6;
            this.lab1.Name = "lab1";
            this.lab1.Width = 125;
            // 
            // lab2
            // 
            this.lab2.DataPropertyName = "lab2";
            this.lab2.HeaderText = "LAB2";
            this.lab2.MinimumWidth = 6;
            this.lab2.Name = "lab2";
            this.lab2.Width = 125;
            // 
            // parcial
            // 
            this.parcial.DataPropertyName = "parcial";
            this.parcial.HeaderText = "PARCIAL";
            this.parcial.MinimumWidth = 6;
            this.parcial.Name = "parcial";
            this.parcial.Width = 125;
            // 
            // nota_final
            // 
            this.nota_final.DataPropertyName = "nf";
            this.nota_final.HeaderText = "NF";
            this.nota_final.MinimumWidth = 6;
            this.nota_final.Name = "nota_final";
            this.nota_final.ReadOnly = true;
            this.nota_final.Width = 125;
            // 
            // frmNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 455);
            this.Controls.Add(this.dnotasDataGridView);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(idNotas);
            this.Controls.Add(this.idNotasLabel1);
            this.Controls.Add(lblMaterias);
            this.Controls.Add(this.cboMateria);
            this.Controls.Add(lblPeriodo);
            this.Controls.Add(this.cboPeriodos);
            this.Controls.Add(lblfecha);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Name = "frmNotas";
            this.Text = "frmNotas";
            this.Load += new System.EventHandler(this.frmNotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_academicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnotasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnotasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnotasDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private db_academicaDataSet db_academicaDataSet;
        private System.Windows.Forms.BindingSource notasBindingSource;
        private db_academicaDataSetTableAdapters.notasTableAdapter notasTableAdapter;
        private db_academicaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label idNotasLabel1;
        private System.Windows.Forms.ComboBox cboMateria;
        private System.Windows.Forms.ComboBox cboPeriodos;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.BindingSource dnotasBindingSource;
        private db_academicaDataSetTableAdapters.dnotasTableAdapter dnotasTableAdapter;
        private db_academicaDataSetTableAdapters.MateriasTableAdapter materiasTableAdapter;
        private System.Windows.Forms.BindingSource periodosBindingSource;
        private db_academicaDataSetTableAdapters.PeriodosTableAdapter periodosTableAdapter;
        private System.Windows.Forms.BindingSource periodosBindingSource1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.BindingSource materiasBindingSource;
        private System.Windows.Forms.BindingSource materiasBindingSource1;
        private System.Windows.Forms.BindingSource dnotasBindingSource1;
        private System.Windows.Forms.DataGridView dnotasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn alumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn lab1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lab2;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcial;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota_final;
    }
}
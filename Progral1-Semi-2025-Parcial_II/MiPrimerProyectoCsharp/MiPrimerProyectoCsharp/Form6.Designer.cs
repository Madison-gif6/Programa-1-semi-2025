namespace MiPrimerProyectoCsharp
{
    partial class Form6
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
            this.grbBusquedaMaterias = new System.Windows.Forms.GroupBox();
            this.grdMaterias = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscarMaterias = new System.Windows.Forms.TextBox();
            this.grbEdicionMaterias = new System.Windows.Forms.GroupBox();
            this.btnEliminarMaterias = new System.Windows.Forms.Button();
            this.btnModificarMateria = new System.Windows.Forms.Button();
            this.btnAgregarMateria = new System.Windows.Forms.Button();
            this.grbNavegacionMaterias = new System.Windows.Forms.GroupBox();
            this.lblnRegistrosMaterias = new System.Windows.Forms.Label();
            this.btnUltimoMaterias = new System.Windows.Forms.Button();
            this.btnSiguienteMaterias = new System.Windows.Forms.Button();
            this.btnAnteriorMaterias = new System.Windows.Forms.Button();
            this.btnPrimeroMaterias = new System.Windows.Forms.Button();
            this.grbDatosMaterias = new System.Windows.Forms.GroupBox();
            this.idMateria = new System.Windows.Forms.Label();
            this.txtUV = new System.Windows.Forms.TextBox();
            this.lblUV = new System.Windows.Forms.Label();
            this.txtNombreMateria = new System.Windows.Forms.TextBox();
            this.lblNombreMateria = new System.Windows.Forms.Label();
            this.txtCodigoMateria = new System.Windows.Forms.TextBox();
            this.lblCodigoMateria = new System.Windows.Forms.Label();
            this.lblidMateria = new System.Windows.Forms.Label();
            this.grbBusquedaMaterias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMaterias)).BeginInit();
            this.grbEdicionMaterias.SuspendLayout();
            this.grbNavegacionMaterias.SuspendLayout();
            this.grbDatosMaterias.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbBusquedaMaterias
            // 
            this.grbBusquedaMaterias.Controls.Add(this.grdMaterias);
            this.grbBusquedaMaterias.Controls.Add(this.txtBuscarMaterias);
            this.grbBusquedaMaterias.Location = new System.Drawing.Point(512, 32);
            this.grbBusquedaMaterias.Name = "grbBusquedaMaterias";
            this.grbBusquedaMaterias.Size = new System.Drawing.Size(544, 308);
            this.grbBusquedaMaterias.TabIndex = 7;
            this.grbBusquedaMaterias.TabStop = false;
            this.grbBusquedaMaterias.Text = "Busqueda Materias";
            // 
            // grdMaterias
            // 
            this.grdMaterias.AllowUserToAddRows = false;
            this.grdMaterias.AllowUserToDeleteRows = false;
            this.grdMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMaterias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Codigo,
            this.Nombre,
            this.UV});
            this.grdMaterias.Location = new System.Drawing.Point(19, 59);
            this.grdMaterias.Name = "grdMaterias";
            this.grdMaterias.ReadOnly = true;
            this.grdMaterias.RowHeadersWidth = 51;
            this.grdMaterias.RowTemplate.Height = 24;
            this.grdMaterias.Size = new System.Drawing.Size(501, 243);
            this.grdMaterias.TabIndex = 7;
            this.grdMaterias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMaterias_CellClick);
           
            // 
            // id
            // 
            this.id.DataPropertyName = "idAlumno";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 125;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "codigo";
            this.Codigo.HeaderText = "CODIGO";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "nombre";
            this.Nombre.HeaderText = "NOMBRE";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 200;
            // 
            // UV
            // 
            this.UV.DataPropertyName = "UV";
            this.UV.HeaderText = "UV";
            this.UV.MinimumWidth = 6;
            this.UV.Name = "UV";
            this.UV.ReadOnly = true;
            this.UV.Width = 125;
            // 
            // txtBuscarMaterias
            // 
            this.txtBuscarMaterias.Location = new System.Drawing.Point(19, 31);
            this.txtBuscarMaterias.Name = "txtBuscarMaterias";
            this.txtBuscarMaterias.Size = new System.Drawing.Size(501, 22);
            this.txtBuscarMaterias.TabIndex = 6;
            this.txtBuscarMaterias.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarMaterias_KeyUp);
            // 
            // grbEdicionMaterias
            // 
            this.grbEdicionMaterias.Controls.Add(this.btnEliminarMaterias);
            this.grbEdicionMaterias.Controls.Add(this.btnModificarMateria);
            this.grbEdicionMaterias.Controls.Add(this.btnAgregarMateria);
            this.grbEdicionMaterias.Location = new System.Drawing.Point(30, 434);
            this.grbEdicionMaterias.Name = "grbEdicionMaterias";
            this.grbEdicionMaterias.Size = new System.Drawing.Size(452, 78);
            this.grbEdicionMaterias.TabIndex = 6;
            this.grbEdicionMaterias.TabStop = false;
            this.grbEdicionMaterias.Text = "EDICION";
            // 
            // btnEliminarMaterias
            // 
            this.btnEliminarMaterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarMaterias.Location = new System.Drawing.Point(305, 21);
            this.btnEliminarMaterias.Name = "btnEliminarMaterias";
            this.btnEliminarMaterias.Size = new System.Drawing.Size(116, 34);
            this.btnEliminarMaterias.TabIndex = 3;
            this.btnEliminarMaterias.Text = "Eliminar";
            this.btnEliminarMaterias.UseVisualStyleBackColor = true;
            this.btnEliminarMaterias.Click += new System.EventHandler(this.btnEliminarMaterias_Click);
            // 
            // btnModificarMateria
            // 
            this.btnModificarMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarMateria.Location = new System.Drawing.Point(151, 21);
            this.btnModificarMateria.Name = "btnModificarMateria";
            this.btnModificarMateria.Size = new System.Drawing.Size(124, 34);
            this.btnModificarMateria.TabIndex = 1;
            this.btnModificarMateria.Text = "Modificar";
            this.btnModificarMateria.UseVisualStyleBackColor = true;
            this.btnModificarMateria.Click += new System.EventHandler(this.btnModificarMateria_Click);
            // 
            // btnAgregarMateria
            // 
            this.btnAgregarMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMateria.Location = new System.Drawing.Point(6, 21);
            this.btnAgregarMateria.Name = "btnAgregarMateria";
            this.btnAgregarMateria.Size = new System.Drawing.Size(109, 34);
            this.btnAgregarMateria.TabIndex = 0;
            this.btnAgregarMateria.Text = "Nuevo";
            this.btnAgregarMateria.UseVisualStyleBackColor = true;
            this.btnAgregarMateria.Click += new System.EventHandler(this.btnAgregarMaterias_Click);
            // 
            // grbNavegacionMaterias
            // 
            this.grbNavegacionMaterias.Controls.Add(this.lblnRegistrosMaterias);
            this.grbNavegacionMaterias.Controls.Add(this.btnUltimoMaterias);
            this.grbNavegacionMaterias.Controls.Add(this.btnSiguienteMaterias);
            this.grbNavegacionMaterias.Controls.Add(this.btnAnteriorMaterias);
            this.grbNavegacionMaterias.Controls.Add(this.btnPrimeroMaterias);
            this.grbNavegacionMaterias.Location = new System.Drawing.Point(30, 350);
            this.grbNavegacionMaterias.Name = "grbNavegacionMaterias";
            this.grbNavegacionMaterias.Size = new System.Drawing.Size(321, 78);
            this.grbNavegacionMaterias.TabIndex = 5;
            this.grbNavegacionMaterias.TabStop = false;
            this.grbNavegacionMaterias.Text = "NAVEGACION";
            // 
            // lblnRegistrosMaterias
            // 
            this.lblnRegistrosMaterias.AutoSize = true;
            this.lblnRegistrosMaterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnRegistrosMaterias.Location = new System.Drawing.Point(127, 33);
            this.lblnRegistrosMaterias.Name = "lblnRegistrosMaterias";
            this.lblnRegistrosMaterias.Size = new System.Drawing.Size(48, 16);
            this.lblnRegistrosMaterias.TabIndex = 9;
            this.lblnRegistrosMaterias.Text = "x de n";
            // 
            // btnUltimoMaterias
            // 
            this.btnUltimoMaterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimoMaterias.Location = new System.Drawing.Point(254, 21);
            this.btnUltimoMaterias.Name = "btnUltimoMaterias";
            this.btnUltimoMaterias.Size = new System.Drawing.Size(57, 34);
            this.btnUltimoMaterias.TabIndex = 3;
            this.btnUltimoMaterias.Text = ">|";
            this.btnUltimoMaterias.UseVisualStyleBackColor = true;
            this.btnUltimoMaterias.Click += new System.EventHandler(this.btnUltimoMaterias_Click);
            // 
            // btnSiguienteMaterias
            // 
            this.btnSiguienteMaterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteMaterias.Location = new System.Drawing.Point(192, 21);
            this.btnSiguienteMaterias.Name = "btnSiguienteMaterias";
            this.btnSiguienteMaterias.Size = new System.Drawing.Size(56, 34);
            this.btnSiguienteMaterias.TabIndex = 2;
            this.btnSiguienteMaterias.Text = ">";
            this.btnSiguienteMaterias.UseVisualStyleBackColor = true;
            this.btnSiguienteMaterias.Click += new System.EventHandler(this.btnSiguienteMaterias_Click);
            // 
            // btnAnteriorMaterias
            // 
            this.btnAnteriorMaterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteriorMaterias.Location = new System.Drawing.Point(69, 21);
            this.btnAnteriorMaterias.Name = "btnAnteriorMaterias";
            this.btnAnteriorMaterias.Size = new System.Drawing.Size(52, 34);
            this.btnAnteriorMaterias.TabIndex = 1;
            this.btnAnteriorMaterias.Text = "<";
            this.btnAnteriorMaterias.UseVisualStyleBackColor = true;
            this.btnAnteriorMaterias.Click += new System.EventHandler(this.btnAnteriorMaterias_Click);
            // 
            // btnPrimeroMaterias
            // 
            this.btnPrimeroMaterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeroMaterias.Location = new System.Drawing.Point(16, 21);
            this.btnPrimeroMaterias.Name = "btnPrimeroMaterias";
            this.btnPrimeroMaterias.Size = new System.Drawing.Size(53, 34);
            this.btnPrimeroMaterias.TabIndex = 0;
            this.btnPrimeroMaterias.Text = "|<";
            this.btnPrimeroMaterias.UseVisualStyleBackColor = true;
            this.btnPrimeroMaterias.Click += new System.EventHandler(this.btnPrimeroMaterias_Click);
            // 
            // grbDatosMaterias
            // 
            this.grbDatosMaterias.Controls.Add(this.idMateria);
            this.grbDatosMaterias.Controls.Add(this.txtUV);
            this.grbDatosMaterias.Controls.Add(this.lblUV);
            this.grbDatosMaterias.Controls.Add(this.txtNombreMateria);
            this.grbDatosMaterias.Controls.Add(this.lblNombreMateria);
            this.grbDatosMaterias.Controls.Add(this.txtCodigoMateria);
            this.grbDatosMaterias.Controls.Add(this.lblCodigoMateria);
            this.grbDatosMaterias.Controls.Add(this.lblidMateria);
            this.grbDatosMaterias.Enabled = false;
            this.grbDatosMaterias.Location = new System.Drawing.Point(30, 32);
            this.grbDatosMaterias.Name = "grbDatosMaterias";
            this.grbDatosMaterias.Size = new System.Drawing.Size(370, 308);
            this.grbDatosMaterias.TabIndex = 4;
            this.grbDatosMaterias.TabStop = false;
            this.grbDatosMaterias.Text = "DATOS";
            // 
            // idMateria
            // 
            this.idMateria.AutoSize = true;
            this.idMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idMateria.Location = new System.Drawing.Point(156, 57);
            this.idMateria.Name = "idMateria";
            this.idMateria.Size = new System.Drawing.Size(19, 16);
            this.idMateria.TabIndex = 10;
            this.idMateria.Text = "...";
            // 
            // txtUV
            // 
            this.txtUV.Location = new System.Drawing.Point(156, 184);
            this.txtUV.Name = "txtUV";
            this.txtUV.Size = new System.Drawing.Size(140, 22);
            this.txtUV.TabIndex = 7;
            // 
            // lblUV
            // 
            this.lblUV.AutoSize = true;
            this.lblUV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUV.Location = new System.Drawing.Point(89, 190);
            this.lblUV.Name = "lblUV";
            this.lblUV.Size = new System.Drawing.Size(32, 16);
            this.lblUV.TabIndex = 6;
            this.lblUV.Text = "UV:";
            // 
            // txtNombreMateria
            // 
            this.txtNombreMateria.Location = new System.Drawing.Point(156, 132);
            this.txtNombreMateria.Name = "txtNombreMateria";
            this.txtNombreMateria.Size = new System.Drawing.Size(181, 22);
            this.txtNombreMateria.TabIndex = 5;
            // 
            // lblNombreMateria
            // 
            this.lblNombreMateria.AutoSize = true;
            this.lblNombreMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMateria.Location = new System.Drawing.Point(45, 138);
            this.lblNombreMateria.Name = "lblNombreMateria";
            this.lblNombreMateria.Size = new System.Drawing.Size(76, 16);
            this.lblNombreMateria.TabIndex = 4;
            this.lblNombreMateria.Text = "NOMBRE:";
            // 
            // txtCodigoMateria
            // 
            this.txtCodigoMateria.Location = new System.Drawing.Point(156, 91);
            this.txtCodigoMateria.Name = "txtCodigoMateria";
            this.txtCodigoMateria.Size = new System.Drawing.Size(112, 22);
            this.txtCodigoMateria.TabIndex = 3;
            // 
            // lblCodigoMateria
            // 
            this.lblCodigoMateria.AutoSize = true;
            this.lblCodigoMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoMateria.Location = new System.Drawing.Point(52, 94);
            this.lblCodigoMateria.Name = "lblCodigoMateria";
            this.lblCodigoMateria.Size = new System.Drawing.Size(69, 16);
            this.lblCodigoMateria.TabIndex = 2;
            this.lblCodigoMateria.Text = "CODIGO:";
            // 
            // lblidMateria
            // 
            this.lblidMateria.AutoSize = true;
            this.lblidMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidMateria.Location = new System.Drawing.Point(95, 57);
            this.lblidMateria.Name = "lblidMateria";
            this.lblidMateria.Size = new System.Drawing.Size(26, 16);
            this.lblidMateria.TabIndex = 0;
            this.lblidMateria.Text = "ID:";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 535);
            this.Controls.Add(this.grbBusquedaMaterias);
            this.Controls.Add(this.grbEdicionMaterias);
            this.Controls.Add(this.grbNavegacionMaterias);
            this.Controls.Add(this.grbDatosMaterias);
            this.Name = "Form6";
            this.Text = "AMINISTRADOR DE MATERIAS";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.grbBusquedaMaterias.ResumeLayout(false);
            this.grbBusquedaMaterias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMaterias)).EndInit();
            this.grbEdicionMaterias.ResumeLayout(false);
            this.grbNavegacionMaterias.ResumeLayout(false);
            this.grbNavegacionMaterias.PerformLayout();
            this.grbDatosMaterias.ResumeLayout(false);
            this.grbDatosMaterias.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbBusquedaMaterias;
        private System.Windows.Forms.DataGridView grdMaterias;
        private System.Windows.Forms.TextBox txtBuscarMaterias;
        private System.Windows.Forms.GroupBox grbEdicionMaterias;
        private System.Windows.Forms.Button btnEliminarMaterias;
        private System.Windows.Forms.Button btnModificarMateria;
        private System.Windows.Forms.Button btnAgregarMateria;
        private System.Windows.Forms.GroupBox grbNavegacionMaterias;
        private System.Windows.Forms.Label lblnRegistrosMaterias;
        private System.Windows.Forms.Button btnUltimoMaterias;
        private System.Windows.Forms.Button btnSiguienteMaterias;
        private System.Windows.Forms.Button btnAnteriorMaterias;
        private System.Windows.Forms.Button btnPrimeroMaterias;
        private System.Windows.Forms.GroupBox grbDatosMaterias;
        private System.Windows.Forms.Label idMateria;
        private System.Windows.Forms.TextBox txtUV;
        private System.Windows.Forms.Label lblUV;
        private System.Windows.Forms.TextBox txtNombreMateria;
        private System.Windows.Forms.Label lblNombreMateria;
        private System.Windows.Forms.TextBox txtCodigoMateria;
        private System.Windows.Forms.Label lblCodigoMateria;
        private System.Windows.Forms.Label lblidMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn UV;
    }
}
namespace MiPrimerProyectoCsharp
{
    partial class Almacenamiento
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
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDestino = new System.Windows.Forms.GroupBox();
            this.optBit = new System.Windows.Forms.RadioButton();
            this.optYottabyte = new System.Windows.Forms.RadioButton();
            this.optZettabyte = new System.Windows.Forms.RadioButton();
            this.optExabyte = new System.Windows.Forms.RadioButton();
            this.optPetabyte = new System.Windows.Forms.RadioButton();
            this.optTerabyte = new System.Windows.Forms.RadioButton();
            this.optGigabyte = new System.Windows.Forms.RadioButton();
            this.optMegabyte = new System.Windows.Forms.RadioButton();
            this.optKilobyte = new System.Windows.Forms.RadioButton();
            this.optByte = new System.Windows.Forms.RadioButton();
            this.txtAlmacenamiento = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblConversorDeAlmacenamiento = new System.Windows.Forms.Label();
            this.gbSeleccionar = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.gbDestino.SuspendLayout();
            this.gbSeleccionar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(261, 184);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(99, 20);
            this.lblResultado.TabIndex = 20;
            this.lblResultado.Text = "Resultado:";
            // 
            // btnConvertir
            // 
            this.btnConvertir.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertir.Location = new System.Drawing.Point(277, 347);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(181, 78);
            this.btnConvertir.TabIndex = 19;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 18;
            // 
            // gbDestino
            // 
            this.gbDestino.Controls.Add(this.optBit);
            this.gbDestino.Controls.Add(this.optYottabyte);
            this.gbDestino.Controls.Add(this.optZettabyte);
            this.gbDestino.Controls.Add(this.optExabyte);
            this.gbDestino.Controls.Add(this.optPetabyte);
            this.gbDestino.Controls.Add(this.optTerabyte);
            this.gbDestino.Controls.Add(this.optGigabyte);
            this.gbDestino.Controls.Add(this.optMegabyte);
            this.gbDestino.Controls.Add(this.optKilobyte);
            this.gbDestino.Controls.Add(this.optByte);
            this.gbDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDestino.Location = new System.Drawing.Point(707, 113);
            this.gbDestino.Name = "gbDestino";
            this.gbDestino.Size = new System.Drawing.Size(197, 312);
            this.gbDestino.TabIndex = 17;
            this.gbDestino.TabStop = false;
            this.gbDestino.Text = "Seleccionar";
            // 
            // optBit
            // 
            this.optBit.AutoSize = true;
            this.optBit.Location = new System.Drawing.Point(6, 279);
            this.optBit.Name = "optBit";
            this.optBit.Size = new System.Drawing.Size(51, 24);
            this.optBit.TabIndex = 9;
            this.optBit.TabStop = true;
            this.optBit.Text = "Bit";
            this.optBit.UseVisualStyleBackColor = true;
            // 
            // optYottabyte
            // 
            this.optYottabyte.AutoSize = true;
            this.optYottabyte.Location = new System.Drawing.Point(6, 252);
            this.optYottabyte.Name = "optYottabyte";
            this.optYottabyte.Size = new System.Drawing.Size(99, 24);
            this.optYottabyte.TabIndex = 8;
            this.optYottabyte.TabStop = true;
            this.optYottabyte.Text = "Yottabyte";
            this.optYottabyte.UseVisualStyleBackColor = true;
            // 
            // optZettabyte
            // 
            this.optZettabyte.AutoSize = true;
            this.optZettabyte.Location = new System.Drawing.Point(6, 225);
            this.optZettabyte.Name = "optZettabyte";
            this.optZettabyte.Size = new System.Drawing.Size(98, 24);
            this.optZettabyte.TabIndex = 7;
            this.optZettabyte.TabStop = true;
            this.optZettabyte.Text = "Zettabyte";
            this.optZettabyte.UseVisualStyleBackColor = true;
            // 
            // optExabyte
            // 
            this.optExabyte.AutoSize = true;
            this.optExabyte.Location = new System.Drawing.Point(6, 198);
            this.optExabyte.Name = "optExabyte";
            this.optExabyte.Size = new System.Drawing.Size(89, 24);
            this.optExabyte.TabIndex = 6;
            this.optExabyte.TabStop = true;
            this.optExabyte.Text = "Exabyte";
            this.optExabyte.UseVisualStyleBackColor = true;
            // 
            // optPetabyte
            // 
            this.optPetabyte.AutoSize = true;
            this.optPetabyte.Location = new System.Drawing.Point(6, 171);
            this.optPetabyte.Name = "optPetabyte";
            this.optPetabyte.Size = new System.Drawing.Size(95, 24);
            this.optPetabyte.TabIndex = 5;
            this.optPetabyte.TabStop = true;
            this.optPetabyte.Text = "Petabyte";
            this.optPetabyte.UseVisualStyleBackColor = true;
            // 
            // optTerabyte
            // 
            this.optTerabyte.AutoSize = true;
            this.optTerabyte.Location = new System.Drawing.Point(6, 144);
            this.optTerabyte.Name = "optTerabyte";
            this.optTerabyte.Size = new System.Drawing.Size(95, 24);
            this.optTerabyte.TabIndex = 4;
            this.optTerabyte.TabStop = true;
            this.optTerabyte.Text = "Terabyte";
            this.optTerabyte.UseVisualStyleBackColor = true;
            // 
            // optGigabyte
            // 
            this.optGigabyte.AutoSize = true;
            this.optGigabyte.Location = new System.Drawing.Point(6, 117);
            this.optGigabyte.Name = "optGigabyte";
            this.optGigabyte.Size = new System.Drawing.Size(96, 24);
            this.optGigabyte.TabIndex = 3;
            this.optGigabyte.TabStop = true;
            this.optGigabyte.Text = "Gigabyte";
            this.optGigabyte.UseVisualStyleBackColor = true;
            // 
            // optMegabyte
            // 
            this.optMegabyte.AutoSize = true;
            this.optMegabyte.Location = new System.Drawing.Point(7, 90);
            this.optMegabyte.Name = "optMegabyte";
            this.optMegabyte.Size = new System.Drawing.Size(102, 24);
            this.optMegabyte.TabIndex = 2;
            this.optMegabyte.TabStop = true;
            this.optMegabyte.Text = "Megabyte";
            this.optMegabyte.UseVisualStyleBackColor = true;
            // 
            // optKilobyte
            // 
            this.optKilobyte.AutoSize = true;
            this.optKilobyte.Location = new System.Drawing.Point(7, 63);
            this.optKilobyte.Name = "optKilobyte";
            this.optKilobyte.Size = new System.Drawing.Size(89, 24);
            this.optKilobyte.TabIndex = 1;
            this.optKilobyte.TabStop = true;
            this.optKilobyte.Text = "Kilobyte";
            this.optKilobyte.UseVisualStyleBackColor = true;
            // 
            // optByte
            // 
            this.optByte.AutoSize = true;
            this.optByte.Location = new System.Drawing.Point(6, 37);
            this.optByte.Name = "optByte";
            this.optByte.Size = new System.Drawing.Size(64, 24);
            this.optByte.TabIndex = 0;
            this.optByte.TabStop = true;
            this.optByte.Text = "Byte";
            this.optByte.UseVisualStyleBackColor = true;
            // 
            // txtAlmacenamiento
            // 
            this.txtAlmacenamiento.Location = new System.Drawing.Point(363, 125);
            this.txtAlmacenamiento.Name = "txtAlmacenamiento";
            this.txtAlmacenamiento.Size = new System.Drawing.Size(109, 22);
            this.txtAlmacenamiento.TabIndex = 16;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(260, 125);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(97, 25);
            this.lblCantidad.TabIndex = 15;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblConversorDeAlmacenamiento
            // 
            this.lblConversorDeAlmacenamiento.AutoSize = true;
            this.lblConversorDeAlmacenamiento.Font = new System.Drawing.Font("Modern No. 20", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConversorDeAlmacenamiento.Location = new System.Drawing.Point(27, 20);
            this.lblConversorDeAlmacenamiento.Name = "lblConversorDeAlmacenamiento";
            this.lblConversorDeAlmacenamiento.Size = new System.Drawing.Size(629, 48);
            this.lblConversorDeAlmacenamiento.TabIndex = 14;
            this.lblConversorDeAlmacenamiento.Text = "Conversor De Almacenamiento";
            // 
            // gbSeleccionar
            // 
            this.gbSeleccionar.Controls.Add(this.radioButton1);
            this.gbSeleccionar.Controls.Add(this.radioButton2);
            this.gbSeleccionar.Controls.Add(this.radioButton3);
            this.gbSeleccionar.Controls.Add(this.radioButton4);
            this.gbSeleccionar.Controls.Add(this.radioButton5);
            this.gbSeleccionar.Controls.Add(this.radioButton6);
            this.gbSeleccionar.Controls.Add(this.radioButton7);
            this.gbSeleccionar.Controls.Add(this.radioButton8);
            this.gbSeleccionar.Controls.Add(this.radioButton9);
            this.gbSeleccionar.Controls.Add(this.radioButton10);
            this.gbSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSeleccionar.Location = new System.Drawing.Point(35, 113);
            this.gbSeleccionar.Name = "gbSeleccionar";
            this.gbSeleccionar.Size = new System.Drawing.Size(197, 312);
            this.gbSeleccionar.TabIndex = 21;
            this.gbSeleccionar.TabStop = false;
            this.gbSeleccionar.Text = "Seleccionar";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 279);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(51, 24);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Bit";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 252);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(99, 24);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Yottabyte";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 225);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(98, 24);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Zettabyte";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 198);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(89, 24);
            this.radioButton4.TabIndex = 6;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Exabyte";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(6, 171);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(95, 24);
            this.radioButton5.TabIndex = 5;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Petabyte";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(6, 144);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(95, 24);
            this.radioButton6.TabIndex = 4;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Terabyte";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(6, 117);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(96, 24);
            this.radioButton7.TabIndex = 3;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Gigabyte";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(7, 90);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(102, 24);
            this.radioButton8.TabIndex = 2;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Megabyte";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(7, 63);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(89, 24);
            this.radioButton9.TabIndex = 1;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "Kilobyte";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point(6, 37);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(64, 24);
            this.radioButton10.TabIndex = 0;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "Byte";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 450);
            this.Controls.Add(this.gbSeleccionar);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbDestino);
            this.Controls.Add(this.txtAlmacenamiento);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblConversorDeAlmacenamiento);
            this.Name = "Form3";
            this.Text = "Form3";
            this.gbDestino.ResumeLayout(false);
            this.gbDestino.PerformLayout();
            this.gbSeleccionar.ResumeLayout(false);
            this.gbSeleccionar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbDestino;
        private System.Windows.Forms.RadioButton optBit;
        private System.Windows.Forms.RadioButton optYottabyte;
        private System.Windows.Forms.RadioButton optZettabyte;
        private System.Windows.Forms.RadioButton optExabyte;
        private System.Windows.Forms.RadioButton optPetabyte;
        private System.Windows.Forms.RadioButton optTerabyte;
        private System.Windows.Forms.RadioButton optGigabyte;
        private System.Windows.Forms.RadioButton optMegabyte;
        private System.Windows.Forms.RadioButton optKilobyte;
        private System.Windows.Forms.RadioButton optByte;
        private System.Windows.Forms.TextBox txtAlmacenamiento;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblConversorDeAlmacenamiento;
        private System.Windows.Forms.GroupBox gbSeleccionar;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton10;
    }
}
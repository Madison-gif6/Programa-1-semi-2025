namespace MiPrimerProyectoCsharp
{
    partial class Tiempo
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
            this.optMilenio = new System.Windows.Forms.RadioButton();
            this.optSiglo = new System.Windows.Forms.RadioButton();
            this.optDécada = new System.Windows.Forms.RadioButton();
            this.optAño = new System.Windows.Forms.RadioButton();
            this.optMes = new System.Windows.Forms.RadioButton();
            this.optSemana = new System.Windows.Forms.RadioButton();
            this.optDía = new System.Windows.Forms.RadioButton();
            this.optHora = new System.Windows.Forms.RadioButton();
            this.optMinuto = new System.Windows.Forms.RadioButton();
            this.optSegundo = new System.Windows.Forms.RadioButton();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblConversorDeTiempo = new System.Windows.Forms.Label();
            this.gbOrigen = new System.Windows.Forms.GroupBox();
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
            this.gbOrigen.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(264, 176);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(99, 20);
            this.lblResultado.TabIndex = 36;
            this.lblResultado.Text = "Resultado:";
            // 
            // btnConvertir
            // 
            this.btnConvertir.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertir.Location = new System.Drawing.Point(280, 339);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(181, 78);
            this.btnConvertir.TabIndex = 35;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-23, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 34;
            // 
            // gbDestino
            // 
            this.gbDestino.Controls.Add(this.optMilenio);
            this.gbDestino.Controls.Add(this.optSiglo);
            this.gbDestino.Controls.Add(this.optDécada);
            this.gbDestino.Controls.Add(this.optAño);
            this.gbDestino.Controls.Add(this.optMes);
            this.gbDestino.Controls.Add(this.optSemana);
            this.gbDestino.Controls.Add(this.optDía);
            this.gbDestino.Controls.Add(this.optHora);
            this.gbDestino.Controls.Add(this.optMinuto);
            this.gbDestino.Controls.Add(this.optSegundo);
            this.gbDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDestino.Location = new System.Drawing.Point(657, 108);
            this.gbDestino.Name = "gbDestino";
            this.gbDestino.Size = new System.Drawing.Size(197, 312);
            this.gbDestino.TabIndex = 33;
            this.gbDestino.TabStop = false;
            this.gbDestino.Text = "Seleccionar";
            // 
            // optMilenio
            // 
            this.optMilenio.AutoSize = true;
            this.optMilenio.Location = new System.Drawing.Point(6, 279);
            this.optMilenio.Name = "optMilenio";
            this.optMilenio.Size = new System.Drawing.Size(83, 24);
            this.optMilenio.TabIndex = 9;
            this.optMilenio.TabStop = true;
            this.optMilenio.Text = "Milenio";
            this.optMilenio.UseVisualStyleBackColor = true;
            // 
            // optSiglo
            // 
            this.optSiglo.AutoSize = true;
            this.optSiglo.Location = new System.Drawing.Point(6, 252);
            this.optSiglo.Name = "optSiglo";
            this.optSiglo.Size = new System.Drawing.Size(67, 24);
            this.optSiglo.TabIndex = 8;
            this.optSiglo.TabStop = true;
            this.optSiglo.Text = "Siglo";
            this.optSiglo.UseVisualStyleBackColor = true;
            // 
            // optDécada
            // 
            this.optDécada.AutoSize = true;
            this.optDécada.Location = new System.Drawing.Point(6, 225);
            this.optDécada.Name = "optDécada";
            this.optDécada.Size = new System.Drawing.Size(88, 24);
            this.optDécada.TabIndex = 7;
            this.optDécada.TabStop = true;
            this.optDécada.Text = "Década";
            this.optDécada.UseVisualStyleBackColor = true;
            // 
            // optAño
            // 
            this.optAño.AutoSize = true;
            this.optAño.Location = new System.Drawing.Point(6, 198);
            this.optAño.Name = "optAño";
            this.optAño.Size = new System.Drawing.Size(59, 24);
            this.optAño.TabIndex = 6;
            this.optAño.TabStop = true;
            this.optAño.Text = "Año";
            this.optAño.UseVisualStyleBackColor = true;
            // 
            // optMes
            // 
            this.optMes.AutoSize = true;
            this.optMes.Location = new System.Drawing.Point(6, 171);
            this.optMes.Name = "optMes";
            this.optMes.Size = new System.Drawing.Size(62, 24);
            this.optMes.TabIndex = 5;
            this.optMes.TabStop = true;
            this.optMes.Text = "Mes";
            this.optMes.UseVisualStyleBackColor = true;
            // 
            // optSemana
            // 
            this.optSemana.AutoSize = true;
            this.optSemana.Location = new System.Drawing.Point(6, 144);
            this.optSemana.Name = "optSemana";
            this.optSemana.Size = new System.Drawing.Size(91, 24);
            this.optSemana.TabIndex = 4;
            this.optSemana.TabStop = true;
            this.optSemana.Text = "Semana";
            this.optSemana.UseVisualStyleBackColor = true;
            // 
            // optDía
            // 
            this.optDía.AutoSize = true;
            this.optDía.Location = new System.Drawing.Point(6, 117);
            this.optDía.Name = "optDía";
            this.optDía.Size = new System.Drawing.Size(56, 24);
            this.optDía.TabIndex = 3;
            this.optDía.TabStop = true;
            this.optDía.Text = "Día";
            this.optDía.UseVisualStyleBackColor = true;
            // 
            // optHora
            // 
            this.optHora.AutoSize = true;
            this.optHora.Location = new System.Drawing.Point(7, 90);
            this.optHora.Name = "optHora";
            this.optHora.Size = new System.Drawing.Size(67, 24);
            this.optHora.TabIndex = 2;
            this.optHora.TabStop = true;
            this.optHora.Text = "Hora";
            this.optHora.UseVisualStyleBackColor = true;
            // 
            // optMinuto
            // 
            this.optMinuto.AutoSize = true;
            this.optMinuto.Location = new System.Drawing.Point(7, 63);
            this.optMinuto.Name = "optMinuto";
            this.optMinuto.Size = new System.Drawing.Size(80, 24);
            this.optMinuto.TabIndex = 1;
            this.optMinuto.TabStop = true;
            this.optMinuto.Text = "Minuto";
            this.optMinuto.UseVisualStyleBackColor = true;
            // 
            // optSegundo
            // 
            this.optSegundo.AutoSize = true;
            this.optSegundo.Location = new System.Drawing.Point(6, 37);
            this.optSegundo.Name = "optSegundo";
            this.optSegundo.Size = new System.Drawing.Size(95, 24);
            this.optSegundo.TabIndex = 0;
            this.optSegundo.TabStop = true;
            this.optSegundo.Text = "Segundo";
            this.optSegundo.UseVisualStyleBackColor = true;
            // 
            // txtTiempo
            // 
            this.txtTiempo.Location = new System.Drawing.Point(366, 117);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(109, 22);
            this.txtTiempo.TabIndex = 32;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(263, 117);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(97, 25);
            this.lblCantidad.TabIndex = 31;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblConversorDeTiempo
            // 
            this.lblConversorDeTiempo.AutoSize = true;
            this.lblConversorDeTiempo.Font = new System.Drawing.Font("Modern No. 20", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConversorDeTiempo.Location = new System.Drawing.Point(24, 21);
            this.lblConversorDeTiempo.Name = "lblConversorDeTiempo";
            this.lblConversorDeTiempo.Size = new System.Drawing.Size(443, 48);
            this.lblConversorDeTiempo.TabIndex = 30;
            this.lblConversorDeTiempo.Text = "Conversor De Tiempo";
            // 
            // gbOrigen
            // 
            this.gbOrigen.Controls.Add(this.radioButton1);
            this.gbOrigen.Controls.Add(this.radioButton2);
            this.gbOrigen.Controls.Add(this.radioButton3);
            this.gbOrigen.Controls.Add(this.radioButton4);
            this.gbOrigen.Controls.Add(this.radioButton5);
            this.gbOrigen.Controls.Add(this.radioButton6);
            this.gbOrigen.Controls.Add(this.radioButton7);
            this.gbOrigen.Controls.Add(this.radioButton8);
            this.gbOrigen.Controls.Add(this.radioButton9);
            this.gbOrigen.Controls.Add(this.radioButton10);
            this.gbOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOrigen.Location = new System.Drawing.Point(48, 108);
            this.gbOrigen.Name = "gbOrigen";
            this.gbOrigen.Size = new System.Drawing.Size(197, 312);
            this.gbOrigen.TabIndex = 37;
            this.gbOrigen.TabStop = false;
            this.gbOrigen.Text = "Seleccionar";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 279);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(83, 24);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Milenio";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 252);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(67, 24);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Siglo";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 225);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(88, 24);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Década";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 198);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(59, 24);
            this.radioButton4.TabIndex = 6;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Año";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(6, 171);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(62, 24);
            this.radioButton5.TabIndex = 5;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Mes";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(6, 144);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(91, 24);
            this.radioButton6.TabIndex = 4;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Semana";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(6, 117);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(56, 24);
            this.radioButton7.TabIndex = 3;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Día";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(7, 90);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(67, 24);
            this.radioButton8.TabIndex = 2;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Hora";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(7, 63);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(80, 24);
            this.radioButton9.TabIndex = 1;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "Minuto";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point(6, 37);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(95, 24);
            this.radioButton10.TabIndex = 0;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "Segundo";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 450);
            this.Controls.Add(this.gbOrigen);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbDestino);
            this.Controls.Add(this.txtTiempo);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblConversorDeTiempo);
            this.Name = "Form5";
            this.Text = "Form5";
            this.gbDestino.ResumeLayout(false);
            this.gbDestino.PerformLayout();
            this.gbOrigen.ResumeLayout(false);
            this.gbOrigen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbDestino;
        private System.Windows.Forms.RadioButton optMilenio;
        private System.Windows.Forms.RadioButton optSiglo;
        private System.Windows.Forms.RadioButton optDécada;
        private System.Windows.Forms.RadioButton optAño;
        private System.Windows.Forms.RadioButton optMes;
        private System.Windows.Forms.RadioButton optSemana;
        private System.Windows.Forms.RadioButton optDía;
        private System.Windows.Forms.RadioButton optHora;
        private System.Windows.Forms.RadioButton optMinuto;
        private System.Windows.Forms.RadioButton optSegundo;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblConversorDeTiempo;
        private System.Windows.Forms.GroupBox gbOrigen;
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
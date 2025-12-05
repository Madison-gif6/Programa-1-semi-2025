namespace MiPrimerProyectoCsharp
{
    partial class Volumen
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
            this.btnConvertir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbOrigen = new System.Windows.Forms.GroupBox();
            this.optBarril = new System.Windows.Forms.RadioButton();
            this.optPieCúbico = new System.Windows.Forms.RadioButton();
            this.optOnzaLíquida = new System.Windows.Forms.RadioButton();
            this.optTaza = new System.Windows.Forms.RadioButton();
            this.optPinta = new System.Windows.Forms.RadioButton();
            this.optGalón = new System.Windows.Forms.RadioButton();
            this.optCentímetroCúbico = new System.Windows.Forms.RadioButton();
            this.optMetroCúbico = new System.Windows.Forms.RadioButton();
            this.optMililitro = new System.Windows.Forms.RadioButton();
            this.optLitro = new System.Windows.Forms.RadioButton();
            this.txtVolumen = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblConversorDeVolumen = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.gbDestino = new System.Windows.Forms.GroupBox();
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
            this.gbOrigen.SuspendLayout();
            this.gbDestino.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConvertir
            // 
            this.btnConvertir.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertir.Location = new System.Drawing.Point(317, 296);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(181, 78);
            this.btnConvertir.TabIndex = 12;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 11;
            // 
            // gbOrigen
            // 
            this.gbOrigen.Controls.Add(this.optBarril);
            this.gbOrigen.Controls.Add(this.optPieCúbico);
            this.gbOrigen.Controls.Add(this.optOnzaLíquida);
            this.gbOrigen.Controls.Add(this.optTaza);
            this.gbOrigen.Controls.Add(this.optPinta);
            this.gbOrigen.Controls.Add(this.optGalón);
            this.gbOrigen.Controls.Add(this.optCentímetroCúbico);
            this.gbOrigen.Controls.Add(this.optMetroCúbico);
            this.gbOrigen.Controls.Add(this.optMililitro);
            this.gbOrigen.Controls.Add(this.optLitro);
            this.gbOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOrigen.Location = new System.Drawing.Point(28, 111);
            this.gbOrigen.Name = "gbOrigen";
            this.gbOrigen.Size = new System.Drawing.Size(197, 312);
            this.gbOrigen.TabIndex = 10;
            this.gbOrigen.TabStop = false;
            this.gbOrigen.Text = "Seleccionar";
            // 
            // optBarril
            // 
            this.optBarril.AutoSize = true;
            this.optBarril.Location = new System.Drawing.Point(6, 279);
            this.optBarril.Name = "optBarril";
            this.optBarril.Size = new System.Drawing.Size(71, 24);
            this.optBarril.TabIndex = 9;
            this.optBarril.TabStop = true;
            this.optBarril.Text = "Barril";
            this.optBarril.UseVisualStyleBackColor = true;
            // 
            // optPieCúbico
            // 
            this.optPieCúbico.AutoSize = true;
            this.optPieCúbico.Location = new System.Drawing.Point(6, 252);
            this.optPieCúbico.Name = "optPieCúbico";
            this.optPieCúbico.Size = new System.Drawing.Size(111, 24);
            this.optPieCúbico.TabIndex = 8;
            this.optPieCúbico.TabStop = true;
            this.optPieCúbico.Text = "Pie Cúbico";
            this.optPieCúbico.UseVisualStyleBackColor = true;
            // 
            // optOnzaLíquida
            // 
            this.optOnzaLíquida.AutoSize = true;
            this.optOnzaLíquida.Location = new System.Drawing.Point(6, 225);
            this.optOnzaLíquida.Name = "optOnzaLíquida";
            this.optOnzaLíquida.Size = new System.Drawing.Size(129, 24);
            this.optOnzaLíquida.TabIndex = 7;
            this.optOnzaLíquida.TabStop = true;
            this.optOnzaLíquida.Text = "Onza Líquida";
            this.optOnzaLíquida.UseVisualStyleBackColor = true;
            // 
            // optTaza
            // 
            this.optTaza.AutoSize = true;
            this.optTaza.Location = new System.Drawing.Point(6, 198);
            this.optTaza.Name = "optTaza";
            this.optTaza.Size = new System.Drawing.Size(67, 24);
            this.optTaza.TabIndex = 6;
            this.optTaza.TabStop = true;
            this.optTaza.Text = "Taza";
            this.optTaza.UseVisualStyleBackColor = true;
            // 
            // optPinta
            // 
            this.optPinta.AutoSize = true;
            this.optPinta.Location = new System.Drawing.Point(6, 171);
            this.optPinta.Name = "optPinta";
            this.optPinta.Size = new System.Drawing.Size(68, 24);
            this.optPinta.TabIndex = 5;
            this.optPinta.TabStop = true;
            this.optPinta.Text = "Pinta";
            this.optPinta.UseVisualStyleBackColor = true;
            // 
            // optGalón
            // 
            this.optGalón.AutoSize = true;
            this.optGalón.Location = new System.Drawing.Point(6, 144);
            this.optGalón.Name = "optGalón";
            this.optGalón.Size = new System.Drawing.Size(74, 24);
            this.optGalón.TabIndex = 4;
            this.optGalón.TabStop = true;
            this.optGalón.Text = "Galón";
            this.optGalón.UseVisualStyleBackColor = true;
            // 
            // optCentímetroCúbico
            // 
            this.optCentímetroCúbico.AutoSize = true;
            this.optCentímetroCúbico.Location = new System.Drawing.Point(6, 117);
            this.optCentímetroCúbico.Name = "optCentímetroCúbico";
            this.optCentímetroCúbico.Size = new System.Drawing.Size(166, 24);
            this.optCentímetroCúbico.TabIndex = 3;
            this.optCentímetroCúbico.TabStop = true;
            this.optCentímetroCúbico.Text = "Centímetro cúbico";
            this.optCentímetroCúbico.UseVisualStyleBackColor = true;
            // 
            // optMetroCúbico
            // 
            this.optMetroCúbico.AutoSize = true;
            this.optMetroCúbico.Location = new System.Drawing.Point(7, 90);
            this.optMetroCúbico.Name = "optMetroCúbico";
            this.optMetroCúbico.Size = new System.Drawing.Size(130, 24);
            this.optMetroCúbico.TabIndex = 2;
            this.optMetroCúbico.TabStop = true;
            this.optMetroCúbico.Text = "Metro Cúbico";
            this.optMetroCúbico.UseVisualStyleBackColor = true;
            // 
            // optMililitro
            // 
            this.optMililitro.AutoSize = true;
            this.optMililitro.Location = new System.Drawing.Point(7, 63);
            this.optMililitro.Name = "optMililitro";
            this.optMililitro.Size = new System.Drawing.Size(84, 24);
            this.optMililitro.TabIndex = 1;
            this.optMililitro.TabStop = true;
            this.optMililitro.Text = "Mililitro";
            this.optMililitro.UseVisualStyleBackColor = true;
            // 
            // optLitro
            // 
            this.optLitro.AutoSize = true;
            this.optLitro.Location = new System.Drawing.Point(6, 37);
            this.optLitro.Name = "optLitro";
            this.optLitro.Size = new System.Drawing.Size(64, 24);
            this.optLitro.TabIndex = 0;
            this.optLitro.TabStop = true;
            this.optLitro.Text = "Litro";
            this.optLitro.UseVisualStyleBackColor = true;
            // 
            // txtVolumen
            // 
            this.txtVolumen.Location = new System.Drawing.Point(353, 129);
            this.txtVolumen.Name = "txtVolumen";
            this.txtVolumen.Size = new System.Drawing.Size(109, 22);
            this.txtVolumen.TabIndex = 9;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(250, 125);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(97, 25);
            this.lblCantidad.TabIndex = 8;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblConversorDeVolumen
            // 
            this.lblConversorDeVolumen.AutoSize = true;
            this.lblConversorDeVolumen.Font = new System.Drawing.Font("Modern No. 20", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConversorDeVolumen.Location = new System.Drawing.Point(31, 21);
            this.lblConversorDeVolumen.Name = "lblConversorDeVolumen";
            this.lblConversorDeVolumen.Size = new System.Drawing.Size(473, 48);
            this.lblConversorDeVolumen.TabIndex = 7;
            this.lblConversorDeVolumen.Text = "Conversor De Volumen";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(251, 188);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(99, 20);
            this.lblResultado.TabIndex = 13;
            this.lblResultado.Text = "Resultado:";
            // 
            // gbDestino
            // 
            this.gbDestino.Controls.Add(this.radioButton1);
            this.gbDestino.Controls.Add(this.radioButton2);
            this.gbDestino.Controls.Add(this.radioButton3);
            this.gbDestino.Controls.Add(this.radioButton4);
            this.gbDestino.Controls.Add(this.radioButton5);
            this.gbDestino.Controls.Add(this.radioButton6);
            this.gbDestino.Controls.Add(this.radioButton7);
            this.gbDestino.Controls.Add(this.radioButton8);
            this.gbDestino.Controls.Add(this.radioButton9);
            this.gbDestino.Controls.Add(this.radioButton10);
            this.gbDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDestino.Location = new System.Drawing.Point(706, 111);
            this.gbDestino.Name = "gbDestino";
            this.gbDestino.Size = new System.Drawing.Size(197, 312);
            this.gbDestino.TabIndex = 14;
            this.gbDestino.TabStop = false;
            this.gbDestino.Text = "Seleccionar";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 279);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(71, 24);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Barril";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 252);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(111, 24);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Pie Cúbico";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 225);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(129, 24);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Onza Líquida";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 198);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(67, 24);
            this.radioButton4.TabIndex = 6;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Taza";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(6, 171);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(68, 24);
            this.radioButton5.TabIndex = 5;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Pinta";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(6, 144);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(74, 24);
            this.radioButton6.TabIndex = 4;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Galón";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(6, 117);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(166, 24);
            this.radioButton7.TabIndex = 3;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Centímetro cúbico";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(7, 90);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(130, 24);
            this.radioButton8.TabIndex = 2;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Metro Cúbico";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(7, 63);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(84, 24);
            this.radioButton9.TabIndex = 1;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "Mililitro";
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
            this.radioButton10.Text = "Litro";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // Volumen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 450);
            this.Controls.Add(this.gbDestino);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbOrigen);
            this.Controls.Add(this.txtVolumen);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblConversorDeVolumen);
            this.Name = "Volumen";
            this.Text = "Form3";
            this.gbOrigen.ResumeLayout(false);
            this.gbOrigen.PerformLayout();
            this.gbDestino.ResumeLayout(false);
            this.gbDestino.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbOrigen;
        private System.Windows.Forms.RadioButton optBarril;
        private System.Windows.Forms.RadioButton optPieCúbico;
        private System.Windows.Forms.RadioButton optOnzaLíquida;
        private System.Windows.Forms.RadioButton optTaza;
        private System.Windows.Forms.RadioButton optPinta;
        private System.Windows.Forms.RadioButton optGalón;
        private System.Windows.Forms.RadioButton optCentímetroCúbico;
        private System.Windows.Forms.RadioButton optMetroCúbico;
        private System.Windows.Forms.RadioButton optMililitro;
        private System.Windows.Forms.RadioButton optLitro;
        private System.Windows.Forms.TextBox txtVolumen;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblConversorDeVolumen;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.GroupBox gbDestino;
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
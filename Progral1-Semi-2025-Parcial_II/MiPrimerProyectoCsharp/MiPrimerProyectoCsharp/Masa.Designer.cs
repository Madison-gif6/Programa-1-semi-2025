namespace MiPrimerProyectoCsharp
{
    partial class Masa
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
            this.optToneladaCorta = new System.Windows.Forms.RadioButton();
            this.optKilate = new System.Windows.Forms.RadioButton();
            this.optMicrogramo = new System.Windows.Forms.RadioButton();
            this.optStone = new System.Windows.Forms.RadioButton();
            this.optOnza = new System.Windows.Forms.RadioButton();
            this.optLibra = new System.Windows.Forms.RadioButton();
            this.optToneladaMétrica = new System.Windows.Forms.RadioButton();
            this.optMiligramo = new System.Windows.Forms.RadioButton();
            this.optGramo = new System.Windows.Forms.RadioButton();
            this.optKilogramo = new System.Windows.Forms.RadioButton();
            this.txtMasa = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblConversorDeMasa = new System.Windows.Forms.Label();
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
            this.lblResultado.Location = new System.Drawing.Point(274, 175);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(99, 20);
            this.lblResultado.TabIndex = 28;
            this.lblResultado.Text = "Resultado:";
            // 
            // btnConvertir
            // 
            this.btnConvertir.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertir.Location = new System.Drawing.Point(290, 338);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(181, 78);
            this.btnConvertir.TabIndex = 27;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 26;
            // 
            // gbDestino
            // 
            this.gbDestino.Controls.Add(this.optToneladaCorta);
            this.gbDestino.Controls.Add(this.optKilate);
            this.gbDestino.Controls.Add(this.optMicrogramo);
            this.gbDestino.Controls.Add(this.optStone);
            this.gbDestino.Controls.Add(this.optOnza);
            this.gbDestino.Controls.Add(this.optLibra);
            this.gbDestino.Controls.Add(this.optToneladaMétrica);
            this.gbDestino.Controls.Add(this.optMiligramo);
            this.gbDestino.Controls.Add(this.optGramo);
            this.gbDestino.Controls.Add(this.optKilogramo);
            this.gbDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDestino.Location = new System.Drawing.Point(691, 116);
            this.gbDestino.Name = "gbDestino";
            this.gbDestino.Size = new System.Drawing.Size(197, 312);
            this.gbDestino.TabIndex = 25;
            this.gbDestino.TabStop = false;
            this.gbDestino.Text = "Seleccionar";
            // 
            // optToneladaCorta
            // 
            this.optToneladaCorta.AutoSize = true;
            this.optToneladaCorta.Location = new System.Drawing.Point(6, 279);
            this.optToneladaCorta.Name = "optToneladaCorta";
            this.optToneladaCorta.Size = new System.Drawing.Size(139, 24);
            this.optToneladaCorta.TabIndex = 9;
            this.optToneladaCorta.TabStop = true;
            this.optToneladaCorta.Text = "ToneladaCorta";
            this.optToneladaCorta.UseVisualStyleBackColor = true;
            // 
            // optKilate
            // 
            this.optKilate.AutoSize = true;
            this.optKilate.Location = new System.Drawing.Point(6, 252);
            this.optKilate.Name = "optKilate";
            this.optKilate.Size = new System.Drawing.Size(72, 24);
            this.optKilate.TabIndex = 8;
            this.optKilate.TabStop = true;
            this.optKilate.Text = "Kilate";
            this.optKilate.UseVisualStyleBackColor = true;
            // 
            // optMicrogramo
            // 
            this.optMicrogramo.AutoSize = true;
            this.optMicrogramo.Location = new System.Drawing.Point(6, 225);
            this.optMicrogramo.Name = "optMicrogramo";
            this.optMicrogramo.Size = new System.Drawing.Size(119, 24);
            this.optMicrogramo.TabIndex = 7;
            this.optMicrogramo.TabStop = true;
            this.optMicrogramo.Text = "Microgramo";
            this.optMicrogramo.UseVisualStyleBackColor = true;
            // 
            // optStone
            // 
            this.optStone.AutoSize = true;
            this.optStone.Location = new System.Drawing.Point(6, 198);
            this.optStone.Name = "optStone";
            this.optStone.Size = new System.Drawing.Size(73, 24);
            this.optStone.TabIndex = 6;
            this.optStone.TabStop = true;
            this.optStone.Text = "Stone";
            this.optStone.UseVisualStyleBackColor = true;
            // 
            // optOnza
            // 
            this.optOnza.AutoSize = true;
            this.optOnza.Location = new System.Drawing.Point(6, 171);
            this.optOnza.Name = "optOnza";
            this.optOnza.Size = new System.Drawing.Size(70, 24);
            this.optOnza.TabIndex = 5;
            this.optOnza.TabStop = true;
            this.optOnza.Text = "Onza";
            this.optOnza.UseVisualStyleBackColor = true;
            // 
            // optLibra
            // 
            this.optLibra.AutoSize = true;
            this.optLibra.Location = new System.Drawing.Point(6, 144);
            this.optLibra.Name = "optLibra";
            this.optLibra.Size = new System.Drawing.Size(68, 24);
            this.optLibra.TabIndex = 4;
            this.optLibra.TabStop = true;
            this.optLibra.Text = "Libra";
            this.optLibra.UseVisualStyleBackColor = true;
            // 
            // optToneladaMétrica
            // 
            this.optToneladaMétrica.AutoSize = true;
            this.optToneladaMétrica.Location = new System.Drawing.Point(6, 117);
            this.optToneladaMétrica.Name = "optToneladaMétrica";
            this.optToneladaMétrica.Size = new System.Drawing.Size(159, 24);
            this.optToneladaMétrica.TabIndex = 3;
            this.optToneladaMétrica.TabStop = true;
            this.optToneladaMétrica.Text = "Tonelada Métrica";
            this.optToneladaMétrica.UseVisualStyleBackColor = true;
            // 
            // optMiligramo
            // 
            this.optMiligramo.AutoSize = true;
            this.optMiligramo.Location = new System.Drawing.Point(7, 90);
            this.optMiligramo.Name = "optMiligramo";
            this.optMiligramo.Size = new System.Drawing.Size(103, 24);
            this.optMiligramo.TabIndex = 2;
            this.optMiligramo.TabStop = true;
            this.optMiligramo.Text = "Miligramo";
            this.optMiligramo.UseVisualStyleBackColor = true;
            // 
            // optGramo
            // 
            this.optGramo.AutoSize = true;
            this.optGramo.Location = new System.Drawing.Point(7, 63);
            this.optGramo.Name = "optGramo";
            this.optGramo.Size = new System.Drawing.Size(81, 24);
            this.optGramo.TabIndex = 1;
            this.optGramo.TabStop = true;
            this.optGramo.Text = "Gramo";
            this.optGramo.UseVisualStyleBackColor = true;
            // 
            // optKilogramo
            // 
            this.optKilogramo.AutoSize = true;
            this.optKilogramo.Location = new System.Drawing.Point(6, 37);
            this.optKilogramo.Name = "optKilogramo";
            this.optKilogramo.Size = new System.Drawing.Size(105, 24);
            this.optKilogramo.TabIndex = 0;
            this.optKilogramo.TabStop = true;
            this.optKilogramo.Text = "Kilogramo";
            this.optKilogramo.UseVisualStyleBackColor = true;
            // 
            // txtMasa
            // 
            this.txtMasa.Location = new System.Drawing.Point(376, 116);
            this.txtMasa.Name = "txtMasa";
            this.txtMasa.Size = new System.Drawing.Size(109, 22);
            this.txtMasa.TabIndex = 24;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(273, 116);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(97, 25);
            this.lblCantidad.TabIndex = 23;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblConversorDeMasa
            // 
            this.lblConversorDeMasa.AutoSize = true;
            this.lblConversorDeMasa.Font = new System.Drawing.Font("Modern No. 20", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConversorDeMasa.Location = new System.Drawing.Point(12, 20);
            this.lblConversorDeMasa.Name = "lblConversorDeMasa";
            this.lblConversorDeMasa.Size = new System.Drawing.Size(398, 48);
            this.lblConversorDeMasa.TabIndex = 22;
            this.lblConversorDeMasa.Text = "Conversor De Masa";
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
            this.gbOrigen.Location = new System.Drawing.Point(33, 107);
            this.gbOrigen.Name = "gbOrigen";
            this.gbOrigen.Size = new System.Drawing.Size(197, 312);
            this.gbOrigen.TabIndex = 29;
            this.gbOrigen.TabStop = false;
            this.gbOrigen.Text = "Seleccionar";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 279);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(139, 24);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "ToneladaCorta";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 252);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(72, 24);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Kilate";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 225);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(119, 24);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Microgramo";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 198);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(73, 24);
            this.radioButton4.TabIndex = 6;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Stone";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(6, 171);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(70, 24);
            this.radioButton5.TabIndex = 5;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Onza";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(6, 144);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(68, 24);
            this.radioButton6.TabIndex = 4;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Libra";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(6, 117);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(159, 24);
            this.radioButton7.TabIndex = 3;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Tonelada Métrica";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(7, 90);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(103, 24);
            this.radioButton8.TabIndex = 2;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Miligramo";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(7, 63);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(81, 24);
            this.radioButton9.TabIndex = 1;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "Gramo";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point(6, 37);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(105, 24);
            this.radioButton10.TabIndex = 0;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "Kilogramo";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 450);
            this.Controls.Add(this.gbOrigen);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbDestino);
            this.Controls.Add(this.txtMasa);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblConversorDeMasa);
            this.Name = "Form3";
            this.Text = "Form3";
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
        private System.Windows.Forms.RadioButton optToneladaCorta;
        private System.Windows.Forms.RadioButton optKilate;
        private System.Windows.Forms.RadioButton optMicrogramo;
        private System.Windows.Forms.RadioButton optStone;
        private System.Windows.Forms.RadioButton optOnza;
        private System.Windows.Forms.RadioButton optLibra;
        private System.Windows.Forms.RadioButton optToneladaMétrica;
        private System.Windows.Forms.RadioButton optMiligramo;
        private System.Windows.Forms.RadioButton optGramo;
        private System.Windows.Forms.RadioButton optKilogramo;
        private System.Windows.Forms.TextBox txtMasa;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblConversorDeMasa;
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
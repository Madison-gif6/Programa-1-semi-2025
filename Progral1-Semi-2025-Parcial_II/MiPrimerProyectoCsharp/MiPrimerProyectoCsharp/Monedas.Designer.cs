namespace MiPrimerProyectoCsharp
{
    partial class Monedas
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
            this.lblConversorDemonedas = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtMonedas = new System.Windows.Forms.TextBox();
            this.gbDestino = new System.Windows.Forms.GroupBox();
            this.optYenJapones = new System.Windows.Forms.RadioButton();
            this.optSolPeruano = new System.Windows.Forms.RadioButton();
            this.optColónCostarricense = new System.Windows.Forms.RadioButton();
            this.optPesoColombiano = new System.Windows.Forms.RadioButton();
            this.optPesoArgentino = new System.Windows.Forms.RadioButton();
            this.optPesoMexicano = new System.Windows.Forms.RadioButton();
            this.optEuro = new System.Windows.Forms.RadioButton();
            this.optCórdoba = new System.Windows.Forms.RadioButton();
            this.optLempira = new System.Windows.Forms.RadioButton();
            this.optQuetzal = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.gbOrigen = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.gbDestino.SuspendLayout();
            this.gbOrigen.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblConversorDemonedas
            // 
            this.lblConversorDemonedas.AutoSize = true;
            this.lblConversorDemonedas.Font = new System.Drawing.Font("Modern No. 20", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConversorDemonedas.Location = new System.Drawing.Point(12, 19);
            this.lblConversorDemonedas.Name = "lblConversorDemonedas";
            this.lblConversorDemonedas.Size = new System.Drawing.Size(480, 48);
            this.lblConversorDemonedas.TabIndex = 0;
            this.lblConversorDemonedas.Text = "Conversor De Monedas ";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(204, 100);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(80, 20);
            this.lblCantidad.TabIndex = 1;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // txtMonedas
            // 
            this.txtMonedas.Location = new System.Drawing.Point(311, 100);
            this.txtMonedas.Name = "txtMonedas";
            this.txtMonedas.Size = new System.Drawing.Size(109, 22);
            this.txtMonedas.TabIndex = 3;
            // 
            // gbDestino
            // 
            this.gbDestino.Controls.Add(this.optYenJapones);
            this.gbDestino.Controls.Add(this.optSolPeruano);
            this.gbDestino.Controls.Add(this.optColónCostarricense);
            this.gbDestino.Controls.Add(this.optPesoColombiano);
            this.gbDestino.Controls.Add(this.optPesoArgentino);
            this.gbDestino.Controls.Add(this.optPesoMexicano);
            this.gbDestino.Controls.Add(this.optEuro);
            this.gbDestino.Controls.Add(this.optCórdoba);
            this.gbDestino.Controls.Add(this.optLempira);
            this.gbDestino.Controls.Add(this.optQuetzal);
            this.gbDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDestino.Location = new System.Drawing.Point(608, 100);
            this.gbDestino.Name = "gbDestino";
            this.gbDestino.Size = new System.Drawing.Size(262, 312);
            this.gbDestino.TabIndex = 4;
            this.gbDestino.TabStop = false;
            this.gbDestino.Text = "Seleccionar Moneda";
            // 
            // optYenJapones
            // 
            this.optYenJapones.AutoSize = true;
            this.optYenJapones.Location = new System.Drawing.Point(6, 279);
            this.optYenJapones.Name = "optYenJapones";
            this.optYenJapones.Size = new System.Drawing.Size(126, 24);
            this.optYenJapones.TabIndex = 9;
            this.optYenJapones.TabStop = true;
            this.optYenJapones.Text = "Yen Japones";
            this.optYenJapones.UseVisualStyleBackColor = true;
            // 
            // optSolPeruano
            // 
            this.optSolPeruano.AutoSize = true;
            this.optSolPeruano.Location = new System.Drawing.Point(6, 252);
            this.optSolPeruano.Name = "optSolPeruano";
            this.optSolPeruano.Size = new System.Drawing.Size(121, 24);
            this.optSolPeruano.TabIndex = 8;
            this.optSolPeruano.TabStop = true;
            this.optSolPeruano.Text = "Sol Peruano";
            this.optSolPeruano.UseVisualStyleBackColor = true;
            // 
            // optColónCostarricense
            // 
            this.optColónCostarricense.AutoSize = true;
            this.optColónCostarricense.Location = new System.Drawing.Point(6, 225);
            this.optColónCostarricense.Name = "optColónCostarricense";
            this.optColónCostarricense.Size = new System.Drawing.Size(183, 24);
            this.optColónCostarricense.TabIndex = 7;
            this.optColónCostarricense.TabStop = true;
            this.optColónCostarricense.Text = "Colón Costarricense";
            this.optColónCostarricense.UseVisualStyleBackColor = true;
            // 
            // optPesoColombiano
            // 
            this.optPesoColombiano.AutoSize = true;
            this.optPesoColombiano.Location = new System.Drawing.Point(6, 198);
            this.optPesoColombiano.Name = "optPesoColombiano";
            this.optPesoColombiano.Size = new System.Drawing.Size(161, 24);
            this.optPesoColombiano.TabIndex = 6;
            this.optPesoColombiano.TabStop = true;
            this.optPesoColombiano.Text = "Peso Colombiano";
            this.optPesoColombiano.UseVisualStyleBackColor = true;
            // 
            // optPesoArgentino
            // 
            this.optPesoArgentino.AutoSize = true;
            this.optPesoArgentino.Location = new System.Drawing.Point(6, 171);
            this.optPesoArgentino.Name = "optPesoArgentino";
            this.optPesoArgentino.Size = new System.Drawing.Size(144, 24);
            this.optPesoArgentino.TabIndex = 5;
            this.optPesoArgentino.TabStop = true;
            this.optPesoArgentino.Text = "Peso Argentino";
            this.optPesoArgentino.UseVisualStyleBackColor = true;
            // 
            // optPesoMexicano
            // 
            this.optPesoMexicano.AutoSize = true;
            this.optPesoMexicano.Location = new System.Drawing.Point(6, 144);
            this.optPesoMexicano.Name = "optPesoMexicano";
            this.optPesoMexicano.Size = new System.Drawing.Size(144, 24);
            this.optPesoMexicano.TabIndex = 4;
            this.optPesoMexicano.TabStop = true;
            this.optPesoMexicano.Text = "Peso Mexicano";
            this.optPesoMexicano.UseVisualStyleBackColor = true;
            // 
            // optEuro
            // 
            this.optEuro.AutoSize = true;
            this.optEuro.Location = new System.Drawing.Point(6, 117);
            this.optEuro.Name = "optEuro";
            this.optEuro.Size = new System.Drawing.Size(65, 24);
            this.optEuro.TabIndex = 3;
            this.optEuro.TabStop = true;
            this.optEuro.Text = "Euro";
            this.optEuro.UseVisualStyleBackColor = true;
            // 
            // optCórdoba
            // 
            this.optCórdoba.AutoSize = true;
            this.optCórdoba.Location = new System.Drawing.Point(7, 90);
            this.optCórdoba.Name = "optCórdoba";
            this.optCórdoba.Size = new System.Drawing.Size(93, 24);
            this.optCórdoba.TabIndex = 2;
            this.optCórdoba.TabStop = true;
            this.optCórdoba.Text = "Córdoba";
            this.optCórdoba.UseVisualStyleBackColor = true;
            // 
            // optLempira
            // 
            this.optLempira.AutoSize = true;
            this.optLempira.Location = new System.Drawing.Point(7, 63);
            this.optLempira.Name = "optLempira";
            this.optLempira.Size = new System.Drawing.Size(91, 24);
            this.optLempira.TabIndex = 1;
            this.optLempira.TabStop = true;
            this.optLempira.Text = "Lempira";
            this.optLempira.UseVisualStyleBackColor = true;
            // 
            // optQuetzal
            // 
            this.optQuetzal.AutoSize = true;
            this.optQuetzal.Location = new System.Drawing.Point(6, 37);
            this.optQuetzal.Name = "optQuetzal";
            this.optQuetzal.Size = new System.Drawing.Size(88, 24);
            this.optQuetzal.TabIndex = 0;
            this.optQuetzal.TabStop = true;
            this.optQuetzal.Text = "Quetzal";
            this.optQuetzal.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(431, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 5;
            // 
            // btnConvertir
            // 
            this.btnConvertir.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertir.Location = new System.Drawing.Point(269, 244);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(190, 78);
            this.btnConvertir.TabIndex = 6;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(204, 150);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(89, 20);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.Text = "Resultado:";
            // 
            // gbOrigen
            // 
            this.gbOrigen.Controls.Add(this.radioButton2);
            this.gbOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOrigen.Location = new System.Drawing.Point(12, 100);
            this.gbOrigen.Name = "gbOrigen";
            this.gbOrigen.Size = new System.Drawing.Size(186, 87);
            this.gbOrigen.TabIndex = 8;
            this.gbOrigen.TabStop = false;
            this.gbOrigen.Text = "Moneda ";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(8, 46);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(71, 24);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Dolar";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Monedas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 450);
            this.Controls.Add(this.gbOrigen);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbDestino);
            this.Controls.Add(this.txtMonedas);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblConversorDemonedas);
            this.Name = "Monedas";
            this.Text = "Form3";
            this.gbDestino.ResumeLayout(false);
            this.gbDestino.PerformLayout();
            this.gbOrigen.ResumeLayout(false);
            this.gbOrigen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConversorDemonedas;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtMonedas;
        private System.Windows.Forms.GroupBox gbDestino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton optSolPeruano;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.GroupBox gbOrigen;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton optYenJapones;
        private System.Windows.Forms.RadioButton optColónCostarricense;
        private System.Windows.Forms.RadioButton optPesoColombiano;
        private System.Windows.Forms.RadioButton optPesoArgentino;
        private System.Windows.Forms.RadioButton optPesoMexicano;
        private System.Windows.Forms.RadioButton optEuro;
        private System.Windows.Forms.RadioButton optCórdoba;
        private System.Windows.Forms.RadioButton optLempira;
        private System.Windows.Forms.RadioButton optQuetzal;
    }
}
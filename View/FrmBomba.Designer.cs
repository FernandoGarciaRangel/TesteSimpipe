namespace TesteSimpipe
{
    partial class FrmBomba
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.inputPressaoDescarga = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PotenciaMotorInput = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.inputUnidadeMedida2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.inputEficienciaBomba = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.inputPressaoSuccao = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.inputVazaoBombeio = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.PotenciaHidraulicaInput = new System.Windows.Forms.TextBox();
            this.inputUnidadeMedida1 = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.inputFormula = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.inputFatorPotencia = new System.Windows.Forms.TextBox();
            this.inputEficienciaMotor = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.inputPressaoDescarga);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(47, 293);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(620, 56);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            // 
            // inputPressaoDescarga
            // 
            this.inputPressaoDescarga.Location = new System.Drawing.Point(188, 22);
            this.inputPressaoDescarga.Name = "inputPressaoDescarga";
            this.inputPressaoDescarga.Size = new System.Drawing.Size(120, 20);
            this.inputPressaoDescarga.TabIndex = 5;
            this.inputPressaoDescarga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarNumeral);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.Blue;
            this.label20.Location = new System.Drawing.Point(24, 25);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(109, 13);
            this.label20.TabIndex = 33;
            this.label20.Text = "Pressão de Descarga";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(480, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "kgf/cm²";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Controls.Add(this.PotenciaMotorInput);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.inputUnidadeMedida2);
            this.groupBox1.Location = new System.Drawing.Point(47, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(620, 56);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            // 
            // PotenciaMotorInput
            // 
            this.PotenciaMotorInput.Location = new System.Drawing.Point(188, 25);
            this.PotenciaMotorInput.Name = "PotenciaMotorInput";
            this.PotenciaMotorInput.ReadOnly = true;
            this.PotenciaMotorInput.Size = new System.Drawing.Size(120, 20);
            this.PotenciaMotorInput.TabIndex = 2;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.ForeColor = System.Drawing.Color.Red;
            this.label25.Location = new System.Drawing.Point(24, 25);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(94, 13);
            this.label25.TabIndex = 34;
            this.label25.Text = "Potência do Motor";
            // 
            // inputUnidadeMedida2
            // 
            this.inputUnidadeMedida2.FormattingEnabled = true;
            this.inputUnidadeMedida2.Items.AddRange(new object[] {
            "HP",
            "KW"});
            this.inputUnidadeMedida2.Location = new System.Drawing.Point(460, 17);
            this.inputUnidadeMedida2.Name = "inputUnidadeMedida2";
            this.inputUnidadeMedida2.Size = new System.Drawing.Size(89, 21);
            this.inputUnidadeMedida2.TabIndex = 38;
            this.inputUnidadeMedida2.Text = "HP";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(32, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Fator de Potência";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.inputEficienciaBomba);
            this.groupBox11.Controls.Add(this.label17);
            this.groupBox11.Controls.Add(this.label18);
            this.groupBox11.Location = new System.Drawing.Point(47, 355);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(620, 56);
            this.groupBox11.TabIndex = 47;
            this.groupBox11.TabStop = false;
            // 
            // inputEficienciaBomba
            // 
            this.inputEficienciaBomba.Location = new System.Drawing.Point(188, 18);
            this.inputEficienciaBomba.Name = "inputEficienciaBomba";
            this.inputEficienciaBomba.Size = new System.Drawing.Size(120, 20);
            this.inputEficienciaBomba.TabIndex = 6;
            this.inputEficienciaBomba.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarNumeral);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Blue;
            this.label17.Location = new System.Drawing.Point(491, 23);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(19, 16);
            this.label17.TabIndex = 5;
            this.label17.Text = "%";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Blue;
            this.label18.Location = new System.Drawing.Point(24, 25);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(104, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Eficiência da Bomba";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.inputPressaoSuccao);
            this.groupBox13.Controls.Add(this.label21);
            this.groupBox13.Controls.Add(this.label22);
            this.groupBox13.Location = new System.Drawing.Point(47, 231);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(620, 56);
            this.groupBox13.TabIndex = 44;
            this.groupBox13.TabStop = false;
            // 
            // inputPressaoSuccao
            // 
            this.inputPressaoSuccao.Location = new System.Drawing.Point(188, 22);
            this.inputPressaoSuccao.Name = "inputPressaoSuccao";
            this.inputPressaoSuccao.Size = new System.Drawing.Size(120, 20);
            this.inputPressaoSuccao.TabIndex = 4;
            this.inputPressaoSuccao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarNumeral);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Blue;
            this.label21.Location = new System.Drawing.Point(480, 23);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(51, 16);
            this.label21.TabIndex = 3;
            this.label21.Text = "kgf/cm²";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.Blue;
            this.label22.Location = new System.Drawing.Point(24, 25);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(100, 13);
            this.label22.TabIndex = 0;
            this.label22.Text = "Pressão de Sucção";
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.inputVazaoBombeio);
            this.groupBox14.Controls.Add(this.label23);
            this.groupBox14.Controls.Add(this.label24);
            this.groupBox14.Location = new System.Drawing.Point(47, 169);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(620, 56);
            this.groupBox14.TabIndex = 45;
            this.groupBox14.TabStop = false;
            // 
            // inputVazaoBombeio
            // 
            this.inputVazaoBombeio.Location = new System.Drawing.Point(188, 30);
            this.inputVazaoBombeio.Name = "inputVazaoBombeio";
            this.inputVazaoBombeio.Size = new System.Drawing.Size(120, 20);
            this.inputVazaoBombeio.TabIndex = 3;
            this.inputVazaoBombeio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarNumeral);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Blue;
            this.label23.Location = new System.Drawing.Point(491, 23);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(33, 16);
            this.label23.TabIndex = 2;
            this.label23.Text = "m³/h";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.Color.Blue;
            this.label24.Location = new System.Drawing.Point(24, 25);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(96, 13);
            this.label24.TabIndex = 0;
            this.label24.Text = "Vazão de Bombeio";
            // 
            // groupBox16
            // 
            this.groupBox16.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox16.Controls.Add(this.PotenciaHidraulicaInput);
            this.groupBox16.Controls.Add(this.inputUnidadeMedida1);
            this.groupBox16.Controls.Add(this.label26);
            this.groupBox16.Location = new System.Drawing.Point(47, 45);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(620, 56);
            this.groupBox16.TabIndex = 43;
            this.groupBox16.TabStop = false;
            // 
            // PotenciaHidraulicaInput
            // 
            this.PotenciaHidraulicaInput.Location = new System.Drawing.Point(188, 25);
            this.PotenciaHidraulicaInput.Name = "PotenciaHidraulicaInput";
            this.PotenciaHidraulicaInput.ReadOnly = true;
            this.PotenciaHidraulicaInput.Size = new System.Drawing.Size(120, 20);
            this.PotenciaHidraulicaInput.TabIndex = 1;
            // 
            // inputUnidadeMedida1
            // 
            this.inputUnidadeMedida1.FormattingEnabled = true;
            this.inputUnidadeMedida1.Items.AddRange(new object[] {
            "HP",
            "KW"});
            this.inputUnidadeMedida1.Location = new System.Drawing.Point(460, 22);
            this.inputUnidadeMedida1.Name = "inputUnidadeMedida1";
            this.inputUnidadeMedida1.Size = new System.Drawing.Size(89, 21);
            this.inputUnidadeMedida1.TabIndex = 2;
            this.inputUnidadeMedida1.Text = "HP";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.ForeColor = System.Drawing.Color.Red;
            this.label26.Location = new System.Drawing.Point(24, 25);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(99, 13);
            this.label26.TabIndex = 0;
            this.label26.Text = "Potência Hidráulica";
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(507, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 21);
            this.button1.TabIndex = 42;
            this.button1.Text = "Calcular";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputFormula
            // 
            this.inputFormula.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.inputFormula.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.inputFormula.ForeColor = System.Drawing.SystemColors.InfoText;
            this.inputFormula.FormattingEnabled = true;
            this.inputFormula.Items.AddRange(new object[] {
            "Potência Hidráulica e do Motor"});
            this.inputFormula.Location = new System.Drawing.Point(47, 9);
            this.inputFormula.Name = "inputFormula";
            this.inputFormula.Size = new System.Drawing.Size(343, 21);
            this.inputFormula.TabIndex = 41;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.inputFatorPotencia);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(47, 479);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(620, 56);
            this.groupBox3.TabIndex = 50;
            this.groupBox3.TabStop = false;
            // 
            // inputFatorPotencia
            // 
            this.inputFatorPotencia.Location = new System.Drawing.Point(188, 18);
            this.inputFatorPotencia.Name = "inputFatorPotencia";
            this.inputFatorPotencia.Size = new System.Drawing.Size(120, 20);
            this.inputFatorPotencia.TabIndex = 8;
            this.inputFatorPotencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarNumeral);
            // 
            // inputEficienciaMotor
            // 
            this.inputEficienciaMotor.Location = new System.Drawing.Point(188, 26);
            this.inputEficienciaMotor.Name = "inputEficienciaMotor";
            this.inputEficienciaMotor.Size = new System.Drawing.Size(120, 20);
            this.inputEficienciaMotor.TabIndex = 7;
            this.inputEficienciaMotor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarNumeral);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Blue;
            this.label16.Location = new System.Drawing.Point(30, 29);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(98, 13);
            this.label16.TabIndex = 17;
            this.label16.Text = "Eficiência do Motor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(491, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "%";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.inputEficienciaMotor);
            this.groupBox9.Controls.Add(this.label1);
            this.groupBox9.Controls.Add(this.label16);
            this.groupBox9.Location = new System.Drawing.Point(47, 417);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(620, 56);
            this.groupBox9.TabIndex = 49;
            this.groupBox9.TabStop = false;
            // 
            // FrmBomba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(713, 577);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.groupBox13);
            this.Controls.Add(this.groupBox14);
            this.Controls.Add(this.groupBox16);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputFormula);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBomba";
            this.Text = "FrmBomba";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox inputUnidadeMedida2;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.ComboBox inputUnidadeMedida1;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox inputFormula;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox PotenciaMotorInput;
        private System.Windows.Forms.TextBox PotenciaHidraulicaInput;
        private System.Windows.Forms.TextBox inputEficienciaMotor;
        private System.Windows.Forms.TextBox inputEficienciaBomba;
        private System.Windows.Forms.TextBox inputVazaoBombeio;
        private System.Windows.Forms.TextBox inputFatorPotencia;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox inputPressaoDescarga;
        private System.Windows.Forms.TextBox inputPressaoSuccao;
    }
}
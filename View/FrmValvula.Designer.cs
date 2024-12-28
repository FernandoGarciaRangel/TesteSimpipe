namespace TesteSimpipe
{ 
    partial class FrmValvula
    {

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
            this.inputCoeficienteValvula = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputPressaoDescarga = new System.Windows.Forms.TextBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.inputDensidadeRelativa = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.inputPressaoSuccao = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.outputVazaoValvula = new System.Windows.Forms.TextBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.inputFormula = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.inputCoeficienteValvula);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(47, 231);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(620, 56);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            // 
            // inputCoeficienteValvula
            // 
            this.inputCoeficienteValvula.Location = new System.Drawing.Point(188, 22);
            this.inputCoeficienteValvula.Name = "inputCoeficienteValvula";
            this.inputCoeficienteValvula.Size = new System.Drawing.Size(120, 20);
            this.inputCoeficienteValvula.TabIndex = 41;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.ForeColor = System.Drawing.Color.Blue;
            this.label25.Location = new System.Drawing.Point(30, 25);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(113, 13);
            this.label25.TabIndex = 34;
            this.label25.Text = "Coeficiente da Válvula";
            this.label25.Click += new System.EventHandler(this.label25_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(469, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "gpm/psi^0.5";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.Blue;
            this.label20.Location = new System.Drawing.Point(30, 28);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(109, 13);
            this.label20.TabIndex = 33;
            this.label20.Text = "Pressão de Descarga";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.inputPressaoDescarga);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Location = new System.Drawing.Point(47, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(620, 56);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(491, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 16);
            this.label3.TabIndex = 41;
            this.label3.Text = "psi";
            // 
            // inputPressaoDescarga
            // 
            this.inputPressaoDescarga.Location = new System.Drawing.Point(188, 25);
            this.inputPressaoDescarga.Name = "inputPressaoDescarga";
            this.inputPressaoDescarga.Size = new System.Drawing.Size(120, 20);
            this.inputPressaoDescarga.TabIndex = 4;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.inputDensidadeRelativa);
            this.groupBox11.Controls.Add(this.label18);
            this.groupBox11.Location = new System.Drawing.Point(47, 293);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(620, 56);
            this.groupBox11.TabIndex = 47;
            this.groupBox11.TabStop = false;
            // 
            // inputDensidadeRelativa
            // 
            this.inputDensidadeRelativa.Location = new System.Drawing.Point(188, 22);
            this.inputDensidadeRelativa.Name = "inputDensidadeRelativa";
            this.inputDensidadeRelativa.Size = new System.Drawing.Size(120, 20);
            this.inputDensidadeRelativa.TabIndex = 42;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Blue;
            this.label18.Location = new System.Drawing.Point(24, 25);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(155, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Densidade Relativa do Produto";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.Blue;
            this.label22.Location = new System.Drawing.Point(30, 28);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(100, 13);
            this.label22.TabIndex = 0;
            this.label22.Text = "Pressão de Sucção";
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.inputPressaoSuccao);
            this.groupBox14.Controls.Add(this.label23);
            this.groupBox14.Controls.Add(this.label22);
            this.groupBox14.Location = new System.Drawing.Point(47, 169);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(620, 56);
            this.groupBox14.TabIndex = 45;
            this.groupBox14.TabStop = false;
            // 
            // inputPressaoSuccao
            // 
            this.inputPressaoSuccao.Location = new System.Drawing.Point(188, 25);
            this.inputPressaoSuccao.Name = "inputPressaoSuccao";
            this.inputPressaoSuccao.Size = new System.Drawing.Size(120, 20);
            this.inputPressaoSuccao.TabIndex = 40;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Blue;
            this.label23.Location = new System.Drawing.Point(491, 23);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(25, 16);
            this.label23.TabIndex = 2;
            this.label23.Text = "psi";
            // 
            // groupBox16
            // 
            this.groupBox16.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox16.Controls.Add(this.outputVazaoValvula);
            this.groupBox16.Controls.Add(this.comboBox5);
            this.groupBox16.Controls.Add(this.label26);
            this.groupBox16.Location = new System.Drawing.Point(47, 45);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(620, 56);
            this.groupBox16.TabIndex = 43;
            this.groupBox16.TabStop = false;
            // 
            // outputVazaoValvula
            // 
            this.outputVazaoValvula.Location = new System.Drawing.Point(188, 25);
            this.outputVazaoValvula.Name = "outputVazaoValvula";
            this.outputVazaoValvula.ReadOnly = true;
            this.outputVazaoValvula.Size = new System.Drawing.Size(120, 20);
            this.outputVazaoValvula.TabIndex = 3;
            this.outputVazaoValvula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarNumeral);
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "HP",
            "KW"});
            this.comboBox5.Location = new System.Drawing.Point(460, 22);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(89, 21);
            this.comboBox5.TabIndex = 2;
            this.comboBox5.Text = "HP";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.ForeColor = System.Drawing.Color.Red;
            this.label26.Location = new System.Drawing.Point(24, 25);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(128, 13);
            this.label26.TabIndex = 0;
            this.label26.Text = "Vazão através da Válvula";
            this.label26.Click += new System.EventHandler(this.label26_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(507, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 21);
            this.button1.TabIndex = 42;
            this.button1.Text = "Calcular";
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
            "Vazão Através da Válvula",
            "Perda de Pressão Através da Válvula",
            "Coeficiente de Vazão"});
            this.inputFormula.Location = new System.Drawing.Point(47, 9);
            this.inputFormula.Name = "inputFormula";
            this.inputFormula.Size = new System.Drawing.Size(343, 21);
            this.inputFormula.TabIndex = 41;
            // 
            // FrmValvula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(713, 577);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.groupBox14);
            this.Controls.Add(this.groupBox16);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputFormula);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmValvula";
            this.Load += new System.EventHandler(this.FrmValvula_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox inputFormula;
        private System.Windows.Forms.TextBox inputPressaoDescarga;
        private System.Windows.Forms.TextBox outputVazaoValvula;
        private System.Windows.Forms.TextBox inputCoeficienteValvula;
        private System.Windows.Forms.TextBox inputDensidadeRelativa;
        private System.Windows.Forms.TextBox inputPressaoSuccao;
        private System.Windows.Forms.Label label3;
    }
}
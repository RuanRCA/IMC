namespace WinFormsApp9
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblIMC = new Label();
            lblAltura = new Label();
            mskaltura = new MaskedTextBox();
            lblMetros = new Label();
            lblPeso = new Label();
            mskPeso = new MaskedTextBox();
            lblQuilogramas = new Label();
            lblSexo = new Label();
            rbdMasculino = new RadioButton();
            rdbFeminino = new RadioButton();
            lblDefinicao = new Label();
            lblIndiceMassa = new Label();
            btnOK = new Button();
            pcbPesos = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pcbPesos).BeginInit();
            SuspendLayout();
            // 
            // lblIMC
            // 
            lblIMC.AutoSize = true;
            lblIMC.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblIMC.Location = new Point(277, 9);
            lblIMC.Name = "lblIMC";
            lblIMC.Size = new Size(157, 47);
            lblIMC.TabIndex = 0;
            lblIMC.Text = "Seu IMC";
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.Location = new Point(149, 127);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(39, 15);
            lblAltura.TabIndex = 1;
            lblAltura.Text = "Altura";
            // 
            // mskaltura
            // 
            mskaltura.Location = new Point(194, 124);
            mskaltura.Mask = "0.00";
            mskaltura.Name = "mskaltura";
            mskaltura.Size = new Size(73, 23);
            mskaltura.TabIndex = 2;
            // 
            // lblMetros
            // 
            lblMetros.AutoSize = true;
            lblMetros.Location = new Point(273, 127);
            lblMetros.Name = "lblMetros";
            lblMetros.Size = new Size(44, 15);
            lblMetros.TabIndex = 3;
            lblMetros.Text = "Metros";
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Location = new Point(153, 163);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(32, 15);
            lblPeso.TabIndex = 4;
            lblPeso.Text = "Peso";
            // 
            // mskPeso
            // 
            mskPeso.Location = new Point(194, 160);
            mskPeso.Mask = "00.00";
            mskPeso.Name = "mskPeso";
            mskPeso.Size = new Size(88, 23);
            mskPeso.TabIndex = 5;
            // 
            // lblQuilogramas
            // 
            lblQuilogramas.AutoSize = true;
            lblQuilogramas.Location = new Point(291, 164);
            lblQuilogramas.Name = "lblQuilogramas";
            lblQuilogramas.Size = new Size(75, 15);
            lblQuilogramas.TabIndex = 6;
            lblQuilogramas.Text = "Quilogramas";
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Location = new Point(153, 208);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(32, 15);
            lblSexo.TabIndex = 7;
            lblSexo.Text = "Sexo";
            // 
            // rbdMasculino
            // 
            rbdMasculino.AutoSize = true;
            rbdMasculino.Location = new Point(202, 208);
            rbdMasculino.Name = "rbdMasculino";
            rbdMasculino.Size = new Size(80, 19);
            rbdMasculino.TabIndex = 8;
            rbdMasculino.TabStop = true;
            rbdMasculino.Text = "Masculino";
            rbdMasculino.UseVisualStyleBackColor = true;
            // 
            // rdbFeminino
            // 
            rdbFeminino.AutoSize = true;
            rdbFeminino.Location = new Point(307, 208);
            rdbFeminino.Name = "rdbFeminino";
            rdbFeminino.Size = new Size(75, 19);
            rdbFeminino.TabIndex = 9;
            rdbFeminino.TabStop = true;
            rdbFeminino.Text = "Feminino";
            rdbFeminino.UseVisualStyleBackColor = true;
            // 
            // lblDefinicao
            // 
            lblDefinicao.AutoSize = true;
            lblDefinicao.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDefinicao.Location = new Point(149, 261);
            lblDefinicao.Name = "lblDefinicao";
            lblDefinicao.Size = new Size(82, 47);
            lblDefinicao.TabIndex = 10;
            lblDefinicao.Text = "IMC";
            // 
            // lblIndiceMassa
            // 
            lblIndiceMassa.AutoSize = true;
            lblIndiceMassa.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblIndiceMassa.Location = new Point(202, 365);
            lblIndiceMassa.Name = "lblIndiceMassa";
            lblIndiceMassa.Size = new Size(299, 47);
            lblIndiceMassa.TabIndex = 11;
            lblIndiceMassa.Text = "Definição de peso";
            // 
            // btnOK
            // 
            btnOK.Location = new Point(562, 299);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 12;
            btnOK.Text = "Ok";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // pcbPesos
            // 
            pcbPesos.Location = new Point(549, 95);
            pcbPesos.Name = "pcbPesos";
            pcbPesos.Size = new Size(141, 132);
            pcbPesos.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbPesos.TabIndex = 13;
            pcbPesos.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pcbPesos);
            Controls.Add(btnOK);
            Controls.Add(lblIndiceMassa);
            Controls.Add(lblDefinicao);
            Controls.Add(rdbFeminino);
            Controls.Add(rbdMasculino);
            Controls.Add(lblSexo);
            Controls.Add(lblQuilogramas);
            Controls.Add(mskPeso);
            Controls.Add(lblPeso);
            Controls.Add(lblMetros);
            Controls.Add(mskaltura);
            Controls.Add(lblAltura);
            Controls.Add(lblIMC);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pcbPesos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIMC;
        private Label lblAltura;
        private MaskedTextBox mskaltura;
        private Label lblMetros;
        private Label lblPeso;
        private MaskedTextBox mskPeso;
        private Label lblQuilogramas;
        private Label lblSexo;
        private RadioButton rbdMasculino;
        private RadioButton rdbFeminino;
        private Label lblDefinicao;
        private Label lblIndiceMassa;
        private Button btnOK;
        private PictureBox pcbPesos;
    }
}
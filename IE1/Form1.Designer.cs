namespace IE1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            txtDNI = new TextBox();
            comboBox1 = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            lstClinica = new ListBox();
            lstPediatria = new ListBox();
            lstGuardia = new ListBox();
            groupBox1 = new GroupBox();
            cmdLlamar = new Button();
            optGuardia = new RadioButton();
            optPediatria = new RadioButton();
            optClinica = new RadioButton();
            cmdInsertar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 18);
            label1.Name = "label1";
            label1.Size = new Size(37, 21);
            label1.TabIndex = 0;
            label1.Text = "DNI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(235, 18);
            label2.Name = "label2";
            label2.Size = new Size(67, 21);
            label2.TabIndex = 1;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(472, 18);
            label3.Name = "label3";
            label3.Size = new Size(68, 21);
            label3.TabIndex = 2;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(684, 18);
            label4.Name = "label4";
            label4.Size = new Size(95, 21);
            label4.TabIndex = 3;
            label4.Text = "Especialidad";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(235, 42);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(208, 29);
            txtApellido.TabIndex = 4;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(472, 42);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(179, 29);
            txtNombre.TabIndex = 5;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(24, 42);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(179, 29);
            txtDNI.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Clínica", "Pediatría", "Guardia" });
            comboBox1.Location = new Point(684, 42);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(211, 29);
            comboBox1.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 129);
            label5.Name = "label5";
            label5.Size = new Size(106, 21);
            label5.TabIndex = 8;
            label5.Text = "Espera Clínica";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(325, 129);
            label6.Name = "label6";
            label6.Size = new Size(112, 21);
            label6.TabIndex = 9;
            label6.Text = "Espera Peditría";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(620, 129);
            label7.Name = "label7";
            label7.Size = new Size(115, 21);
            label7.TabIndex = 10;
            label7.Text = "Espera Guardia";
            // 
            // lstClinica
            // 
            lstClinica.FormattingEnabled = true;
            lstClinica.ItemHeight = 21;
            lstClinica.Location = new Point(28, 153);
            lstClinica.Name = "lstClinica";
            lstClinica.Size = new Size(275, 319);
            lstClinica.TabIndex = 11;
            // 
            // lstPediatria
            // 
            lstPediatria.FormattingEnabled = true;
            lstPediatria.ItemHeight = 21;
            lstPediatria.Location = new Point(325, 153);
            lstPediatria.Name = "lstPediatria";
            lstPediatria.Size = new Size(275, 319);
            lstPediatria.TabIndex = 12;
            // 
            // lstGuardia
            // 
            lstGuardia.FormattingEnabled = true;
            lstGuardia.ItemHeight = 21;
            lstGuardia.Location = new Point(620, 153);
            lstGuardia.Name = "lstGuardia";
            lstGuardia.Size = new Size(275, 319);
            lstGuardia.TabIndex = 13;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmdLlamar);
            groupBox1.Controls.Add(optGuardia);
            groupBox1.Controls.Add(optPediatria);
            groupBox1.Controls.Add(optClinica);
            groupBox1.Location = new Point(31, 491);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(864, 110);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Llamar a consultorio";
            // 
            // cmdLlamar
            // 
            cmdLlamar.BackColor = Color.FromArgb(128, 255, 128);
            cmdLlamar.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            cmdLlamar.Location = new Point(589, 32);
            cmdLlamar.Name = "cmdLlamar";
            cmdLlamar.Size = new Size(250, 52);
            cmdLlamar.TabIndex = 3;
            cmdLlamar.Text = "L L A M A R";
            cmdLlamar.UseVisualStyleBackColor = false;
            // 
            // optGuardia
            // 
            optGuardia.AutoSize = true;
            optGuardia.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            optGuardia.Location = new Point(366, 42);
            optGuardia.Name = "optGuardia";
            optGuardia.Size = new Size(114, 36);
            optGuardia.TabIndex = 2;
            optGuardia.TabStop = true;
            optGuardia.Text = "Guardia";
            optGuardia.UseVisualStyleBackColor = true;
            // 
            // optPediatria
            // 
            optPediatria.AutoSize = true;
            optPediatria.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            optPediatria.Location = new Point(187, 42);
            optPediatria.Name = "optPediatria";
            optPediatria.Size = new Size(123, 36);
            optPediatria.TabIndex = 1;
            optPediatria.TabStop = true;
            optPediatria.Text = "Pediatría";
            optPediatria.UseVisualStyleBackColor = true;
            // 
            // optClinica
            // 
            optClinica.AutoSize = true;
            optClinica.Checked = true;
            optClinica.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            optClinica.Location = new Point(26, 42);
            optClinica.Name = "optClinica";
            optClinica.Size = new Size(102, 36);
            optClinica.TabIndex = 0;
            optClinica.TabStop = true;
            optClinica.Text = "Clínica";
            optClinica.UseVisualStyleBackColor = true;
            // 
            // cmdInsertar
            // 
            cmdInsertar.BackColor = Color.FromArgb(128, 255, 128);
            cmdInsertar.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            cmdInsertar.Location = new Point(684, 77);
            cmdInsertar.Name = "cmdInsertar";
            cmdInsertar.Size = new Size(211, 37);
            cmdInsertar.TabIndex = 15;
            cmdInsertar.Text = "I N S E R T A R";
            cmdInsertar.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(926, 629);
            Controls.Add(cmdInsertar);
            Controls.Add(groupBox1);
            Controls.Add(lstGuardia);
            Controls.Add(lstPediatria);
            Controls.Add(lstClinica);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(txtDNI);
            Controls.Add(txtNombre);
            Controls.Add(txtApellido);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Carga de Clientes";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private TextBox txtDNI;
        private ComboBox comboBox1;
        private Label label5;
        private Label label6;
        private Label label7;
        private ListBox lstClinica;
        private ListBox lstPediatria;
        private ListBox lstGuardia;
        private GroupBox groupBox1;
        private Button cmdLlamar;
        private RadioButton optGuardia;
        private RadioButton optPediatria;
        private RadioButton optClinica;
        private Button cmdInsertar;
    }
}
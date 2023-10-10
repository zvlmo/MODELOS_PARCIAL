namespace AppLavaderoWF
{
    partial class FormIngresoVehiculos
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
            selecvehiculo = new Label();
            label2 = new Label();
            label3 = new Label();
            txtMarca = new Label();
            txtAsientos = new Label();
            txtCilindrada = new Label();
            txtTara = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            aceptarBtn = new Button();
            SuspendLayout();
            // 
            // selecvehiculo
            // 
            selecvehiculo.AutoSize = true;
            selecvehiculo.Location = new Point(52, 29);
            selecvehiculo.Name = "selecvehiculo";
            selecvehiculo.Size = new Size(111, 15);
            selecvehiculo.TabIndex = 0;
            selecvehiculo.Text = "Seleccione vehiculo\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 133);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 1;
            label2.Text = "Patente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 223);
            label3.Name = "label3";
            label3.Size = new Size(109, 15);
            label3.TabIndex = 2;
            label3.Text = "Cantidad de ruedas";
            // 
            // txtMarca
            // 
            txtMarca.AutoSize = true;
            txtMarca.Location = new Point(52, 328);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(40, 15);
            txtMarca.TabIndex = 3;
            txtMarca.Text = "Marca";
            // 
            // txtAsientos
            // 
            txtAsientos.AutoSize = true;
            txtAsientos.Location = new Point(397, 133);
            txtAsientos.Name = "txtAsientos";
            txtAsientos.Size = new Size(52, 15);
            txtAsientos.TabIndex = 4;
            txtAsientos.Text = "Asientos";
            // 
            // txtCilindrada
            // 
            txtCilindrada.AutoSize = true;
            txtCilindrada.Location = new Point(397, 223);
            txtCilindrada.Name = "txtCilindrada";
            txtCilindrada.Size = new Size(61, 15);
            txtCilindrada.TabIndex = 5;
            txtCilindrada.Text = "Cilindrada";
            // 
            // txtTara
            // 
            txtTara.AutoSize = true;
            txtTara.Location = new Point(397, 328);
            txtTara.Name = "txtTara";
            txtTara.Size = new Size(28, 15);
            txtTara.TabIndex = 6;
            txtTara.Text = "Tara";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Auto", "Moto", "Camion" });
            comboBox1.Location = new Point(52, 68);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(154, 23);
            comboBox1.TabIndex = 7;
            comboBox1.Text = "Seleccione una opcion";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(52, 175);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(397, 175);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(52, 272);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(397, 272);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(52, 363);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 12;
            // 
            // textBox6
            // 
            textBox6.Enabled = false;
            textBox6.Location = new Point(397, 363);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 13;
            // 
            // aceptarBtn
            // 
            aceptarBtn.Location = new Point(217, 375);
            aceptarBtn.Name = "aceptarBtn";
            aceptarBtn.Size = new Size(118, 45);
            aceptarBtn.TabIndex = 14;
            aceptarBtn.Text = "Subir vehiculo";
            aceptarBtn.UseVisualStyleBackColor = true;
            aceptarBtn.Click += aceptarBtn_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(aceptarBtn);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(txtTara);
            Controls.Add(txtCilindrada);
            Controls.Add(txtAsientos);
            Controls.Add(txtMarca);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(selecvehiculo);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label selecvehiculo;
        private Label label2;
        private Label label3;
        private Label txtMarca;
        private Label txtAsientos;
        private Label txtCilindrada;
        private Label txtTara;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button aceptarBtn;
    }
}
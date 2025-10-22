namespace TPVentaOnlineFront
{
    partial class Agregar_Componente
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(200, 88);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 1;
            label1.Text = "Tipo Componente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(200, 183);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 2;
            label2.Text = "Modelo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(200, 139);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 3;
            label3.Text = "Marca";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(200, 225);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 4;
            label4.Text = "Precio";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(335, 180);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(229, 27);
            textBox3.TabIndex = 6;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(335, 218);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(229, 27);
            textBox4.TabIndex = 7;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(335, 263);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(229, 27);
            textBox5.TabIndex = 8;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(200, 270);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 9;
            label5.Text = "Stock";
            // 
            // button1
            // 
            button1.Location = new Point(396, 334);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 10;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(28, 392);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 11;
            button2.Text = "Volver";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Procesador ", "PlacaBase ", "MemoriaRAM", "Almacenamiento ", "TarjetaGrafica", "FuentePoder ", "Gabinete " });
            comboBox1.Location = new Point(335, 88);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(229, 28);
            comboBox1.TabIndex = 12;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(335, 136);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(229, 27);
            textBox2.TabIndex = 13;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // Agregar_Componente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Agregar_Componente";
            Text = "Agregar_Componente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label5;
        private Button button1;
        private Button button2;
        private ComboBox comboBox1;
        private TextBox textBox2;
    }
}
namespace TPVentaOnlineFront.ABM_cliente.Alta_Usuario
{
    partial class CrearCuenta_usu
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
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button2 = new Button();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(370, 38);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 0;
            label1.Text = "Registracion";
            // 
            // button1
            // 
            button1.Location = new Point(361, 284);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(181, 118);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 2;
            label2.Text = "Nombre :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(162, 169);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 3;
            label3.Text = "Contraseña :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(97, 215);
            label4.Name = "label4";
            label4.Size = new Size(155, 20);
            label4.TabIndex = 4;
            label4.Text = "Confirme Contraseña :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(199, 65);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 5;
            label5.Text = "Email :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(309, 65);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(202, 27);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(309, 118);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(202, 27);
            textBox2.TabIndex = 7;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(309, 169);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(202, 27);
            textBox3.TabIndex = 8;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(309, 212);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(202, 27);
            textBox4.TabIndex = 9;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(338, 375);
            button2.Name = "button2";
            button2.Size = new Size(145, 29);
            button2.TabIndex = 10;
            button2.Text = "Iniciar Sesion";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(352, 335);
            label6.Name = "label6";
            label6.Size = new Size(120, 20);
            label6.TabIndex = 11;
            label6.Text = "Ya tenes Cuenta?";
            // 
            // CrearCuenta_usu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "CrearCuenta_usu";
            Text = "CrearCuenta_usu";
            Load += CrearCuenta_usu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button2;
        private Label label6;
    }
}
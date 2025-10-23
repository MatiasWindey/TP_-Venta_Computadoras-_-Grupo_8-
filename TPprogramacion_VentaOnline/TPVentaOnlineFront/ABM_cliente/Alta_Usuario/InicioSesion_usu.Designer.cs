namespace TPVentaOnlineFront.ABM_cliente.Alta_Usuario
{
    partial class InicioSesion_usu
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
            textBox2 = new TextBox();
            button1 = new Button();
            label4 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(367, 24);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 0;
            label1.Text = "Iniciar sesion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(147, 77);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 1;
            label2.Text = "Ingrese Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(147, 124);
            label3.Name = "label3";
            label3.Size = new Size(138, 20);
            label3.TabIndex = 2;
            label3.Text = "Ingrese Contraseña:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(336, 124);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(154, 27);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(367, 175);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Ingresar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(339, 226);
            label4.Name = "label4";
            label4.Size = new Size(156, 20);
            label4.TabIndex = 6;
            label4.Text = "Aun no tienes Cuenta?";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(336, 77);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(154, 27);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(367, 269);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 8;
            button2.Text = "Registrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(21, 409);
            button3.Name = "button3";
            button3.Size = new Size(145, 29);
            button3.TabIndex = 9;
            button3.Text = "Volver inicio";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // InicioSesion_usu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "InicioSesion_usu";
            Text = "Alta_usu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Button button1;
        private Label label4;
        private TextBox textBox1;
        private Button button2;
        private Button button3;
    }
}
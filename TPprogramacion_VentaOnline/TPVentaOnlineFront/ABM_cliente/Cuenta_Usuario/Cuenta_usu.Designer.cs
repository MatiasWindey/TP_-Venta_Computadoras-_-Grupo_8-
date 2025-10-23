namespace TPVentaOnlineFront.ABM_cliente.Modificacion_Usuario
{
    partial class Cuenta_usu
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            button2 = new Button();
            label3 = new Label();
            label5 = new Label();
            button3 = new Button();
            label6 = new Label();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(374, 108);
            button1.Name = "button1";
            button1.Size = new Size(113, 29);
            button1.TabIndex = 0;
            button1.Text = "Modificar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(388, 20);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 1;
            label1.Text = "Perfil";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(237, 112);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 2;
            label2.Text = "Nombre :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(237, 161);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 4;
            label4.Text = "Contraseña :";
            // 
            // button2
            // 
            button2.Location = new Point(374, 157);
            button2.Name = "button2";
            button2.Size = new Size(113, 29);
            button2.TabIndex = 7;
            button2.Text = "Modificar ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(256, 61);
            label3.Name = "label3";
            label3.Size = new Size(259, 20);
            label3.TabIndex = 8;
            label3.Text = "Tu email : TomasPierro12@gmail.com";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(237, 259);
            label5.Name = "label5";
            label5.Size = new Size(114, 20);
            label5.TabIndex = 9;
            label5.Text = "Puntuar Pagina :";
            // 
            // button3
            // 
            button3.Location = new Point(374, 259);
            button3.Name = "button3";
            button3.Size = new Size(113, 29);
            button3.TabIndex = 10;
            button3.Text = "Puntuar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(388, 215);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 11;
            label6.Text = "Puntuanos";
            // 
            // button4
            // 
            button4.Location = new Point(12, 409);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 12;
            button4.Text = "Volver";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Cuenta_usu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(label6);
            Controls.Add(button3);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Cuenta_usu";
            Text = "Cuenta_usu";
            Load += Cuenta_usu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label4;
        private Button button2;
        private Label label3;
        private Label label5;
        private Button button3;
        private Label label6;
        private Button button4;
    }
}
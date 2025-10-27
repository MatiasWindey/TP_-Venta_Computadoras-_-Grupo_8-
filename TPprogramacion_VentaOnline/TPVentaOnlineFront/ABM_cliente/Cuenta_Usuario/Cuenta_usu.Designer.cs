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
            listBox1 = new ListBox();
            button5 = new Button();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(645, 109);
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
            label2.Location = new Point(224, 109);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 2;
            label2.Text = "Nombre :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(224, 158);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 4;
            label4.Text = "Contraseña :";
            // 
            // button2
            // 
            button2.Location = new Point(645, 154);
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
            label3.Location = new Point(224, 61);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 8;
            label3.Text = "Tu email : ";
            label3.Click += label3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(224, 285);
            label5.Name = "label5";
            label5.Size = new Size(114, 20);
            label5.TabIndex = 9;
            label5.Text = "Puntuar Pagina :";
            // 
            // button3
            // 
            button3.Location = new Point(359, 281);
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
            label6.Location = new Point(373, 218);
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
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(320, 61);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(309, 24);
            listBox1.TabIndex = 13;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged_1;
            // 
            // button5
            // 
            button5.Location = new Point(36, 39);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 14;
            button5.Text = "Ver Datos";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(320, 109);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(309, 24);
            listBox2.TabIndex = 15;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.Location = new Point(320, 158);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(309, 24);
            listBox3.TabIndex = 16;
            listBox3.SelectedIndexChanged += listBox3_SelectedIndexChanged;
            // 
            // Cuenta_usu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(button5);
            Controls.Add(listBox1);
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
        private ListBox listBox1;
        private Button button5;
        private ListBox listBox2;
        private ListBox listBox3;
    }
}
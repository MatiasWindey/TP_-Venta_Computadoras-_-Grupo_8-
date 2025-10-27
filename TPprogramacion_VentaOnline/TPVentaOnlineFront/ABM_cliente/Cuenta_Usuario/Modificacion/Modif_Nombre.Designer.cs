namespace TPVentaOnlineFront.ABM_cliente.Modificacion_Usuario
{
    partial class Modif_Nombre
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
            textBox3 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.Location = new Point(400, 206);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(147, 27);
            textBox3.TabIndex = 15;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(182, 209);
            label4.Name = "label4";
            label4.Size = new Size(187, 20);
            label4.TabIndex = 14;
            label4.Text = "Confirmar Nombre Nueva :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(358, 41);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 13;
            label3.Text = "Modificacion";
            // 
            // button1
            // 
            button1.Location = new Point(321, 246);
            button1.Name = "button1";
            button1.Size = new Size(169, 29);
            button1.TabIndex = 12;
            button1.Text = "Aplicar Modificacion";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(400, 157);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(147, 27);
            textBox2.TabIndex = 11;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(400, 99);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(147, 27);
            textBox1.TabIndex = 10;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(183, 160);
            label2.Name = "label2";
            label2.Size = new Size(169, 20);
            label2.TabIndex = 9;
            label2.Text = "Ingrese Nombre Nueva :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(183, 106);
            label1.Name = "label1";
            label1.Size = new Size(169, 20);
            label1.TabIndex = 8;
            label1.Text = "Ingrese Nombre Actual :";
            // 
            // button2
            // 
            button2.Location = new Point(12, 409);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 16;
            button2.Text = "Volver";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Modif_Nombre
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Modif_Nombre";
            Text = "Modif_Nombre";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox3;
        private Label label4;
        private Label label3;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Button button2;
    }
}
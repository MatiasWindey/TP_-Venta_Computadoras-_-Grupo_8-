namespace TPVentaOnlineFront.ABM_cliente.Modificacion_Usuario
{
    partial class Modif_Contraseña
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(169, 95);
            label1.Name = "label1";
            label1.Size = new Size(188, 20);
            label1.TabIndex = 0;
            label1.Text = "Ingrese Contraseña Actual :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(169, 149);
            label2.Name = "label2";
            label2.Size = new Size(188, 20);
            label2.TabIndex = 1;
            label2.Text = "Ingrese Contraseña Nueva :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(386, 88);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(147, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(386, 146);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(147, 27);
            textBox2.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(307, 235);
            button1.Name = "button1";
            button1.Size = new Size(169, 29);
            button1.TabIndex = 4;
            button1.Text = "Aplicar Modificacion";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(344, 30);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 5;
            label3.Text = "Modificacion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(168, 198);
            label4.Name = "label4";
            label4.Size = new Size(206, 20);
            label4.TabIndex = 6;
            label4.Text = "Confirmar Contraseña Nueva :";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(386, 195);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(147, 27);
            textBox3.TabIndex = 7;
            // 
            // Modif_Contraseña
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Modif_Contraseña";
            Text = "Modif_Contraseña";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Label label3;
        private Label label4;
        private TextBox textBox3;
    }
}
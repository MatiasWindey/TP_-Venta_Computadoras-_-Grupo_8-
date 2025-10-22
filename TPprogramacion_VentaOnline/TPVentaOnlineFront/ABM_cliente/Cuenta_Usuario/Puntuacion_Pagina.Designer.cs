namespace TPVentaOnlineFront.ABM_cliente.Modificacion_Usuario
{
    partial class Puntuacion_Pagina
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
            label2 = new Label();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox1 = new CheckBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(318, 241);
            button1.Name = "button1";
            button1.Size = new Size(155, 29);
            button1.TabIndex = 0;
            button1.Text = "Enviar Puntuacion";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(348, 22);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 2;
            label2.Text = "Valoracion";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(363, 92);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(43, 24);
            checkBox2.TabIndex = 4;
            checkBox2.Text = "2 ";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(363, 125);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(43, 24);
            checkBox3.TabIndex = 5;
            checkBox3.Text = "3 ";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(363, 155);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(43, 24);
            checkBox4.TabIndex = 6;
            checkBox4.Text = "4 ";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(363, 185);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(43, 24);
            checkBox5.TabIndex = 7;
            checkBox5.Text = "5 ";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(363, 62);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(43, 24);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "1 ";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(196, 62);
            label3.Name = "label3";
            label3.Size = new Size(159, 20);
            label3.TabIndex = 10;
            label3.Text = "Valorenos en Estrellas :";
            // 
            // Puntuacion_Pagina
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(checkBox1);
            Controls.Add(checkBox5);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(label2);
            Controls.Add(button1);
            Name = "Puntuacion_Pagina";
            Text = "Puntuacion_Pagina";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label2;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox1;
        private Label label3;
    }
}

namespace TPVentaOnlineFront
{
    partial class ABM
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(287, 62);
            button1.Name = "button1";
            button1.Size = new Size(204, 29);
            button1.TabIndex = 0;
            button1.Text = "Agregar Componente";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(287, 128);
            button2.Name = "button2";
            button2.Size = new Size(205, 29);
            button2.TabIndex = 1;
            button2.Text = "Modificar Componente";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(287, 195);
            button3.Name = "button3";
            button3.Size = new Size(205, 29);
            button3.TabIndex = 2;
            button3.Text = "Baja Componente";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(21, 398);
            button4.Name = "button4";
            button4.Size = new Size(101, 29);
            button4.TabIndex = 3;
            button4.Text = "Volver inicio";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(287, 258);
            button5.Name = "button5";
            button5.Size = new Size(205, 29);
            button5.TabIndex = 4;
            button5.Text = "Reporte Puntuacion";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(286, 321);
            button6.Name = "button6";
            button6.Size = new Size(205, 29);
            button6.TabIndex = 5;
            button6.Text = "Reporte Componente";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // ABM
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 450);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "ABM";
            Text = "ABM COMPONENTE";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private EventHandler button1_Click;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}

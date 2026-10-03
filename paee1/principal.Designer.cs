namespace paee1
{
    partial class principal
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
            label1 = new Label();
            button1 = new Button();
            menuStrip2 = new MenuStrip();
            menuArchivo = new ToolStripMenuItem();
            menuSalir = new ToolStripMenuItem();
            menuAyuda = new ToolStripMenuItem();
            menuAcercaDe = new ToolStripMenuItem();
            textBox1 = new TextBox();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btn0 = new Button();
            btnPlus = new Button();
            btnMinus = new Button();
            btnMult = new Button();
            btnDiv = new Button();
            btnEq = new Button();
            btnErase = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            menuStrip2.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(605, 69);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(112, 25);
            label1.TabIndex = 0;
            label1.Text = "Hola Mundo";
            // 
            // button1
            // 
            button1.Location = new Point(739, 58);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(118, 36);
            button1.TabIndex = 1;
            button1.Text = "Click";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { menuArchivo, menuAyuda });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Padding = new Padding(8, 2, 0, 2);
            menuStrip2.Size = new Size(978, 33);
            menuStrip2.TabIndex = 3;
            menuStrip2.Text = "menuPrincipal";
            // 
            // menuArchivo
            // 
            menuArchivo.DropDownItems.AddRange(new ToolStripItem[] { menuSalir });
            menuArchivo.Name = "menuArchivo";
            menuArchivo.Size = new Size(88, 29);
            menuArchivo.Text = "&Archivo";
            // 
            // menuSalir
            // 
            menuSalir.Name = "menuSalir";
            menuSalir.Size = new Size(147, 34);
            menuSalir.Text = "&Salir";
            menuSalir.Click += menuSalir_Click;
            // 
            // menuAyuda
            // 
            menuAyuda.Alignment = ToolStripItemAlignment.Right;
            menuAyuda.DropDownItems.AddRange(new ToolStripItem[] { menuAcercaDe });
            menuAyuda.Name = "menuAyuda";
            menuAyuda.Size = new Size(79, 29);
            menuAyuda.Text = "A&yuda";
            menuAyuda.Click += menuAyuda_Click;
            // 
            // menuAcercaDe
            // 
            menuAcercaDe.Name = "menuAcercaDe";
            menuAcercaDe.Size = new Size(270, 34);
            menuAcercaDe.Text = "AcercaDe";
            menuAcercaDe.Click += menuAcercaDe_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 59);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(443, 31);
            textBox1.TabIndex = 4;
            // 
            // btn1
            // 
            btn1.Location = new Point(15, 100);
            btn1.Margin = new Padding(4);
            btn1.Name = "btn1";
            btn1.Size = new Size(62, 62);
            btn1.TabIndex = 5;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += button2_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(85, 100);
            btn2.Margin = new Padding(4);
            btn2.Name = "btn2";
            btn2.Size = new Size(62, 62);
            btn2.TabIndex = 6;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            btn3.Location = new Point(155, 100);
            btn3.Margin = new Padding(4);
            btn3.Name = "btn3";
            btn3.Size = new Size(62, 62);
            btn3.TabIndex = 7;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            btn6.Location = new Point(155, 170);
            btn6.Margin = new Padding(4);
            btn6.Name = "btn6";
            btn6.Size = new Size(62, 62);
            btn6.TabIndex = 10;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            btn5.Location = new Point(85, 170);
            btn5.Margin = new Padding(4);
            btn5.Name = "btn5";
            btn5.Size = new Size(62, 62);
            btn5.TabIndex = 9;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += button6_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(15, 170);
            btn4.Margin = new Padding(4);
            btn4.Name = "btn4";
            btn4.Size = new Size(62, 62);
            btn4.TabIndex = 8;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            btn9.Location = new Point(155, 240);
            btn9.Margin = new Padding(4);
            btn9.Name = "btn9";
            btn9.Size = new Size(62, 62);
            btn9.TabIndex = 13;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            btn8.Location = new Point(85, 240);
            btn8.Margin = new Padding(4);
            btn8.Name = "btn8";
            btn8.Size = new Size(62, 62);
            btn8.TabIndex = 12;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            btn7.Location = new Point(15, 240);
            btn7.Margin = new Padding(4);
            btn7.Name = "btn7";
            btn7.Size = new Size(62, 62);
            btn7.TabIndex = 11;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            btn0.Location = new Point(85, 310);
            btn0.Margin = new Padding(4);
            btn0.Name = "btn0";
            btn0.Size = new Size(62, 62);
            btn0.TabIndex = 14;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            // 
            // btnPlus
            // 
            btnPlus.Location = new Point(21, 3);
            btnPlus.Margin = new Padding(4);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(62, 62);
            btnPlus.TabIndex = 15;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            // 
            // btnMinus
            // 
            btnMinus.Location = new Point(21, 73);
            btnMinus.Margin = new Padding(4);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(62, 62);
            btnMinus.TabIndex = 16;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += button13_Click;
            // 
            // btnMult
            // 
            btnMult.Location = new Point(21, 143);
            btnMult.Margin = new Padding(4);
            btnMult.Name = "btnMult";
            btnMult.Size = new Size(62, 62);
            btnMult.TabIndex = 17;
            btnMult.Text = "X";
            btnMult.UseVisualStyleBackColor = true;
            btnMult.Click += button14_Click;
            // 
            // btnDiv
            // 
            btnDiv.Location = new Point(21, 213);
            btnDiv.Margin = new Padding(4);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(62, 62);
            btnDiv.TabIndex = 18;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            // 
            // btnEq
            // 
            btnEq.Location = new Point(13, 4);
            btnEq.Margin = new Padding(4);
            btnEq.Name = "btnEq";
            btnEq.Size = new Size(62, 62);
            btnEq.TabIndex = 19;
            btnEq.Text = "=";
            btnEq.UseVisualStyleBackColor = true;
            btnEq.Click += button16_Click;
            // 
            // btnErase
            // 
            btnErase.Location = new Point(13, 73);
            btnErase.Margin = new Padding(4);
            btnErase.Name = "btnErase";
            btnErase.Size = new Size(62, 62);
            btnErase.TabIndex = 20;
            btnErase.Text = "B";
            btnErase.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 97);
            panel1.Name = "panel1";
            panel1.Size = new Size(233, 293);
            panel1.TabIndex = 21;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnDiv);
            panel2.Controls.Add(btnMult);
            panel2.Controls.Add(btnMinus);
            panel2.Controls.Add(btnPlus);
            panel2.Location = new Point(239, 97);
            panel2.Name = "panel2";
            panel2.Size = new Size(105, 293);
            panel2.TabIndex = 22;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnEq);
            panel3.Controls.Add(btnErase);
            panel3.Location = new Point(350, 97);
            panel3.Name = "panel3";
            panel3.Size = new Size(93, 293);
            panel3.TabIndex = 23;
            // 
            // principal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 691);
            Controls.Add(btn0);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(menuStrip2);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "principal";
            Text = "Calculadora";
            Load += principal_Load;
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem menuArchivo;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem menuAyuda;
        private ToolStripMenuItem menuSalir;
        private TextBox textBox1;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btn0;
        private Button btnPlus;
        private Button btnMinus;
        private Button btnMult;
        private Button btnDiv;
        private Button btnEq;
        private Button btnErase;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private ToolStripMenuItem menuAcercaDe;
    }
}

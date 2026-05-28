namespace Ventana
{
    partial class Form1
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
            lblTitulo = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox1 = new GroupBox();
            button3 = new Button();
            txtElementoEliminar = new TextBox();
            label1 = new Label();
            txtLista = new TextBox();
            lblLista = new Label();
            button2 = new Button();
            txtElemento = new TextBox();
            label2 = new Label();
            button1 = new Button();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            button4 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(0, 192, 0);
            lblTitulo.Location = new Point(167, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(238, 50);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Hola mundo";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 62);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(613, 379);
            tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(button1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(605, 351);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Ejemplo de botón";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(txtElementoEliminar);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtLista);
            groupBox1.Controls.Add(lblLista);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(txtElemento);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(6, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(310, 316);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista de compras";
            // 
            // button3
            // 
            button3.Location = new Point(200, 112);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 13;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += clicEliminarElemento;
            // 
            // txtElementoEliminar
            // 
            txtElementoEliminar.Location = new Point(142, 83);
            txtElementoEliminar.Name = "txtElementoEliminar";
            txtElementoEliminar.Size = new Size(133, 23);
            txtElementoEliminar.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 86);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 11;
            label1.Text = "Elemento a eliminar:";
            // 
            // txtLista
            // 
            txtLista.Location = new Point(142, 144);
            txtLista.Multiline = true;
            txtLista.Name = "txtLista";
            txtLista.Size = new Size(133, 155);
            txtLista.TabIndex = 10;
            // 
            // lblLista
            // 
            lblLista.AutoSize = true;
            lblLista.Location = new Point(6, 147);
            lblLista.Name = "lblLista";
            lblLista.Size = new Size(38, 15);
            lblLista.TabIndex = 9;
            lblLista.Text = "label1";
            // 
            // button2
            // 
            button2.Location = new Point(200, 57);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 8;
            button2.Text = "Agregar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += clicAgregarElemento;
            // 
            // txtElemento
            // 
            txtElemento.Location = new Point(142, 28);
            txtElemento.Name = "txtElemento";
            txtElemento.Size = new Size(133, 23);
            txtElemento.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 31);
            label2.Name = "label2";
            label2.Size = new Size(117, 15);
            label2.TabIndex = 6;
            label2.Text = "Elemento a comprar:";
            // 
            // button1
            // 
            button1.Location = new Point(464, 29);
            button1.Name = "button1";
            button1.Size = new Size(116, 36);
            button1.TabIndex = 6;
            button1.Text = "Cambiar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += clicCambiarNombre;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(605, 351);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Ejemplo de pila";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(605, 351);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Location = new Point(19, 25);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(551, 301);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Librería";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button4);
            groupBox3.Controls.Add(textBox2);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(textBox1);
            groupBox3.Controls.Add(label3);
            groupBox3.Location = new Point(20, 22);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 218);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Agregar libro";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 36);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 0;
            label3.Text = "titulo";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(77, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 73);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 2;
            label4.Text = "autor";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(77, 70);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            // 
            // button4
            // 
            button4.Location = new Point(102, 116);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 4;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(637, 453);
            Controls.Add(tabControl1);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button button1;
        private TabPage tabPage3;
        private GroupBox groupBox1;
        private TextBox txtElemento;
        private Label label2;
        private Button button2;
        private TextBox txtLista;
        private Label lblLista;
        private Button button3;
        private TextBox txtElementoEliminar;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button button4;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox1;
        private Label label3;
    }
}

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
            groupBox2 = new GroupBox();
            groupBox4 = new GroupBox();
            button5 = new Button();
            txtAnyoEliminar = new TextBox();
            label8 = new Label();
            txtAutorEliminar = new TextBox();
            label7 = new Label();
            txtTituloeliminar = new TextBox();
            label6 = new Label();
            txtPila = new TextBox();
            groupBox3 = new GroupBox();
            txtAutor = new TextBox();
            txtTitulo = new TextBox();
            txtAnyo = new TextBox();
            label5 = new Label();
            button4 = new Button();
            label4 = new Label();
            label3 = new Label();
            tabPage3 = new TabPage();
            groupBox6 = new GroupBox();
            button7 = new Button();
            txtIdAutor = new TextBox();
            label11 = new Label();
            txtCola = new TextBox();
            groupBox5 = new GroupBox();
            button6 = new Button();
            txtApellidoAutor = new TextBox();
            label10 = new Label();
            txtNombreAutor = new TextBox();
            label9 = new Label();
            tabPage4 = new TabPage();
            button8 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            tabPage3.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            tabPage4.SuspendLayout();
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
            tabControl1.Controls.Add(tabPage4);
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
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Controls.Add(txtPila);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Location = new Point(19, 25);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(580, 301);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Librería";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(button5);
            groupBox4.Controls.Add(txtAnyoEliminar);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(txtAutorEliminar);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(txtTituloeliminar);
            groupBox4.Controls.Add(label6);
            groupBox4.Location = new Point(395, 22);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(179, 218);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Eliminar libro";
            // 
            // button5
            // 
            button5.Location = new Point(85, 154);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 6;
            button5.Text = "Eliminar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // txtAnyoEliminar
            // 
            txtAnyoEliminar.Location = new Point(60, 94);
            txtAnyoEliminar.Name = "txtAnyoEliminar";
            txtAnyoEliminar.Size = new Size(100, 23);
            txtAnyoEliminar.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(7, 97);
            label8.Name = "label8";
            label8.Size = new Size(29, 15);
            label8.TabIndex = 4;
            label8.Text = "Año";
            // 
            // txtAutorEliminar
            // 
            txtAutorEliminar.Location = new Point(60, 59);
            txtAutorEliminar.Name = "txtAutorEliminar";
            txtAutorEliminar.Size = new Size(100, 23);
            txtAutorEliminar.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(7, 62);
            label7.Name = "label7";
            label7.Size = new Size(37, 15);
            label7.TabIndex = 2;
            label7.Text = "Autor";
            // 
            // txtTituloeliminar
            // 
            txtTituloeliminar.Location = new Point(60, 22);
            txtTituloeliminar.Name = "txtTituloeliminar";
            txtTituloeliminar.Size = new Size(100, 23);
            txtTituloeliminar.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 25);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 0;
            label6.Text = "Titulo";
            // 
            // txtPila
            // 
            txtPila.Location = new Point(180, 32);
            txtPila.Multiline = true;
            txtPila.Name = "txtPila";
            txtPila.Size = new Size(209, 208);
            txtPila.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtAutor);
            groupBox3.Controls.Add(txtTitulo);
            groupBox3.Controls.Add(txtAnyo);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(button4);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Location = new Point(6, 22);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(168, 218);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Agregar libro";
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(57, 59);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(100, 23);
            txtAutor.TabIndex = 8;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(57, 22);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(100, 23);
            txtTitulo.TabIndex = 7;
            // 
            // txtAnyo
            // 
            txtAnyo.Location = new Point(57, 94);
            txtAnyo.Name = "txtAnyo";
            txtAnyo.Size = new Size(100, 23);
            txtAnyo.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 97);
            label5.Name = "label5";
            label5.Size = new Size(29, 15);
            label5.TabIndex = 5;
            label5.Text = "Año";
            // 
            // button4
            // 
            button4.Location = new Point(82, 154);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 4;
            button4.Text = "Registrar libro";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 62);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 2;
            label4.Text = "Autor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 25);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 0;
            label3.Text = "Titulo";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(groupBox6);
            tabPage3.Controls.Add(txtCola);
            tabPage3.Controls.Add(groupBox5);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(605, 351);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Ejemplo de colas";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(button7);
            groupBox6.Controls.Add(txtIdAutor);
            groupBox6.Controls.Add(label11);
            groupBox6.Location = new Point(14, 170);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(175, 161);
            groupBox6.TabIndex = 2;
            groupBox6.TabStop = false;
            groupBox6.Text = "Eliminar autor";
            // 
            // button7
            // 
            button7.Location = new Point(94, 73);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 2;
            button7.Text = "Eliminar";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // txtIdAutor
            // 
            txtIdAutor.Location = new Point(69, 31);
            txtIdAutor.Name = "txtIdAutor";
            txtIdAutor.Size = new Size(100, 23);
            txtIdAutor.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(10, 31);
            label11.Name = "label11";
            label11.Size = new Size(21, 15);
            label11.TabIndex = 0;
            label11.Text = "ID:";
            // 
            // txtCola
            // 
            txtCola.Location = new Point(204, 23);
            txtCola.Multiline = true;
            txtCola.Name = "txtCola";
            txtCola.Size = new Size(387, 308);
            txtCola.TabIndex = 1;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(button6);
            groupBox5.Controls.Add(txtApellidoAutor);
            groupBox5.Controls.Add(label10);
            groupBox5.Controls.Add(txtNombreAutor);
            groupBox5.Controls.Add(label9);
            groupBox5.Location = new Point(14, 14);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(175, 112);
            groupBox5.TabIndex = 0;
            groupBox5.TabStop = false;
            groupBox5.Text = "Agregar nuevo autor";
            // 
            // button6
            // 
            button6.Location = new Point(94, 80);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 4;
            button6.Text = "Agregar";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // txtApellidoAutor
            // 
            txtApellidoAutor.Location = new Point(69, 51);
            txtApellidoAutor.Name = "txtApellidoAutor";
            txtApellidoAutor.Size = new Size(100, 23);
            txtApellidoAutor.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(10, 54);
            label10.Name = "label10";
            label10.Size = new Size(54, 15);
            label10.TabIndex = 2;
            label10.Text = "Apellido:";
            // 
            // txtNombreAutor
            // 
            txtNombreAutor.Location = new Point(69, 22);
            txtNombreAutor.Name = "txtNombreAutor";
            txtNombreAutor.Size = new Size(100, 23);
            txtNombreAutor.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(10, 25);
            label9.Name = "label9";
            label9.Size = new Size(54, 15);
            label9.TabIndex = 0;
            label9.Text = "Nombre:";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(button8);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(605, 351);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Ejemplo DDBB";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(16, 15);
            button8.Name = "button8";
            button8.Size = new Size(128, 23);
            button8.TabIndex = 0;
            button8.Text = "Probar conexión";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
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
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            tabPage4.ResumeLayout(false);
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
        private TextBox txtIdAutor;
        private Label label3;
        private TextBox txtAnyo;
        private Label label5;
        private TextBox txtAutor;
        private TextBox txtTitulo;
        private TextBox txtPila;
        private GroupBox groupBox4;
        private Button button5;
        private TextBox txtAnyoEliminar;
        private Label label8;
        private TextBox txtAutorEliminar;
        private Label label7;
        private TextBox txtTituloeliminar;
        private Label label6;
        private GroupBox groupBox5;
        private Button button6;
        private TextBox txtApellidoAutor;
        private Label label10;
        private TextBox txtNombreAutor;
        private Label label9;
        private GroupBox groupBox6;
        private TextBox txtCola;
        private Button button7;
        private Label label11;
        private TabPage tabPage4;
        private Button button8;
    }
}

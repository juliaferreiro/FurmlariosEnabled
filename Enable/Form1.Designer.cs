namespace Enable
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
            txtFamiliar = new TextBox();
            txtDuo = new TextBox();
            txtInfantil = new TextBox();
            txtEltrio = new TextBox();
            txtTotal = new TextBox();
            txtIVA = new TextBox();
            txtSubtotal = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label8 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnAceptar = new Button();
            btnCompra = new Button();
            groupBox3 = new GroupBox();
            chkEltrio = new CheckBox();
            chkInfantil = new CheckBox();
            chkDuo = new CheckBox();
            chkFamiliar = new CheckBox();
            groupBox4 = new GroupBox();
            groupBox5 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // txtFamiliar
            // 
            txtFamiliar.Enabled = false;
            txtFamiliar.Location = new Point(15, 22);
            txtFamiliar.Name = "txtFamiliar";
            txtFamiliar.Size = new Size(65, 23);
            txtFamiliar.TabIndex = 0;
            // 
            // txtDuo
            // 
            txtDuo.Enabled = false;
            txtDuo.Location = new Point(15, 51);
            txtDuo.Name = "txtDuo";
            txtDuo.Size = new Size(65, 23);
            txtDuo.TabIndex = 1;
            // 
            // txtInfantil
            // 
            txtInfantil.Enabled = false;
            txtInfantil.Location = new Point(15, 80);
            txtInfantil.Name = "txtInfantil";
            txtInfantil.Size = new Size(65, 23);
            txtInfantil.TabIndex = 2;
            // 
            // txtEltrio
            // 
            txtEltrio.Enabled = false;
            txtEltrio.Location = new Point(15, 109);
            txtEltrio.Name = "txtEltrio";
            txtEltrio.Size = new Size(65, 23);
            txtEltrio.TabIndex = 3;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(156, 92);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 4;
            // 
            // txtIVA
            // 
            txtIVA.Location = new Point(156, 63);
            txtIVA.Name = "txtIVA";
            txtIVA.Size = new Size(100, 23);
            txtIVA.TabIndex = 5;
            // 
            // txtSubtotal
            // 
            txtSubtotal.Location = new Point(156, 34);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(100, 23);
            txtSubtotal.TabIndex = 6;
            txtSubtotal.TextChanged += txtSubtotal_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtFamiliar);
            groupBox1.Controls.Add(txtDuo);
            groupBox1.Controls.Add(txtInfantil);
            groupBox1.Controls.Add(txtEltrio);
            groupBox1.Location = new Point(58, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(139, 139);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cantidad";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(379, 30);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(139, 147);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Precio";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 117);
            label8.Name = "label8";
            label8.Size = new Size(34, 15);
            label8.TabIndex = 13;
            label8.Text = "$95.5";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 88);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 10;
            label2.Text = "$105";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 80);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 59);
            label4.Name = "label4";
            label4.Size = new Size(25, 15);
            label4.TabIndex = 12;
            label4.Text = "$90";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 30);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 9;
            label1.Text = "$85";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 95);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 14;
            label5.Text = "Total a pagar:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 66);
            label6.Name = "label6";
            label6.Size = new Size(27, 15);
            label6.TabIndex = 15;
            label6.Text = "IVA:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 37);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 13;
            label7.Text = "Sub Total:";
            label7.Click += label7_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(15, 22);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(80, 44);
            btnAceptar.TabIndex = 16;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCompra
            // 
            btnCompra.Location = new Point(15, 80);
            btnCompra.Name = "btnCompra";
            btnCompra.Size = new Size(80, 44);
            btnCompra.TabIndex = 17;
            btnCompra.Text = "Nueva Compra";
            btnCompra.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(chkEltrio);
            groupBox3.Controls.Add(chkInfantil);
            groupBox3.Controls.Add(chkDuo);
            groupBox3.Controls.Add(chkFamiliar);
            groupBox3.Location = new Point(212, 30);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(139, 139);
            groupBox3.TabIndex = 18;
            groupBox3.TabStop = false;
            // 
            // chkEltrio
            // 
            chkEltrio.AutoSize = true;
            chkEltrio.Location = new Point(9, 109);
            chkEltrio.Name = "chkEltrio";
            chkEltrio.Size = new Size(102, 19);
            chkEltrio.TabIndex = 3;
            chkEltrio.Text = "Paquete El trio";
            chkEltrio.UseVisualStyleBackColor = true;
            chkEltrio.CheckedChanged += chkEltrio_CheckedChanged;
            // 
            // chkInfantil
            // 
            chkInfantil.AutoSize = true;
            chkInfantil.Location = new Point(9, 84);
            chkInfantil.Name = "chkInfantil";
            chkInfantil.Size = new Size(109, 19);
            chkInfantil.TabIndex = 2;
            chkInfantil.Text = "Paquete Infantil";
            chkInfantil.UseVisualStyleBackColor = true;
            chkInfantil.CheckedChanged += chkInfantil_CheckedChanged;
            // 
            // chkDuo
            // 
            chkDuo.AutoSize = true;
            chkDuo.Location = new Point(9, 58);
            chkDuo.Name = "chkDuo";
            chkDuo.Size = new Size(94, 19);
            chkDuo.TabIndex = 1;
            chkDuo.Text = "Paquete Duo";
            chkDuo.UseVisualStyleBackColor = true;
            chkDuo.CheckedChanged += chkDuo_CheckedChanged;
            // 
            // chkFamiliar
            // 
            chkFamiliar.AutoSize = true;
            chkFamiliar.Location = new Point(9, 29);
            chkFamiliar.Name = "chkFamiliar";
            chkFamiliar.Size = new Size(114, 19);
            chkFamiliar.TabIndex = 0;
            chkFamiliar.Text = "Paquete Familiar";
            chkFamiliar.UseVisualStyleBackColor = true;
            chkFamiliar.CheckedChanged += chkFamiliar_CheckedChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(txtTotal);
            groupBox4.Controls.Add(txtIVA);
            groupBox4.Controls.Add(txtSubtotal);
            groupBox4.Location = new Point(212, 183);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(271, 139);
            groupBox4.TabIndex = 19;
            groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btnCompra);
            groupBox5.Controls.Add(btnAceptar);
            groupBox5.Location = new Point(58, 183);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(113, 139);
            groupBox5.TabIndex = 20;
            groupBox5.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 378);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Comida";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtFamiliar;
        private TextBox txtDuo;
        private TextBox txtInfantil;
        private TextBox txtEltrio;
        private TextBox txtTotal;
        private TextBox txtIVA;
        private TextBox txtSubtotal;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label1;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnAceptar;
        private Button btnCompra;
        private Label label8;
        private GroupBox groupBox3;
        private CheckBox chkEltrio;
        private CheckBox chkInfantil;
        private CheckBox chkDuo;
        private CheckBox chkFamiliar;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
    }
}

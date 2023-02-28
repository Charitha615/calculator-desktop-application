namespace Calculator_DOT_NET
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnMenu = new System.Windows.Forms.Button();
            this.TxDisplay1 = new System.Windows.Forms.TextBox();
            this.BtnBackspace = new System.Windows.Forms.Button();
            this.BtnCE = new System.Windows.Forms.Button();
            this.BtnC = new System.Windows.Forms.Button();
            this.BtnDivision = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.BtnSubtraction = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.BtnMulti = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnDesimal = new System.Windows.Forms.Button();
            this.Btn0 = new System.Windows.Forms.Button();
            this.BtnEq = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnMenu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 72);
            this.panel2.TabIndex = 3;
            // 
            // BtnMenu
            // 
            this.BtnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnMenu.FlatAppearance.BorderSize = 0;
            this.BtnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMenu.Image = ((System.Drawing.Image)(resources.GetObject("BtnMenu.Image")));
            this.BtnMenu.Location = new System.Drawing.Point(0, 0);
            this.BtnMenu.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(50, 72);
            this.BtnMenu.TabIndex = 2;
            this.BtnMenu.UseVisualStyleBackColor = true;
            // 
            // TxDisplay1
            // 
            this.TxDisplay1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TxDisplay1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxDisplay1.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxDisplay1.Font = new System.Drawing.Font("Gadugi", 40F, System.Drawing.FontStyle.Bold);
            this.TxDisplay1.ForeColor = System.Drawing.Color.White;
            this.TxDisplay1.Location = new System.Drawing.Point(0, 72);
            this.TxDisplay1.Margin = new System.Windows.Forms.Padding(0);
            this.TxDisplay1.Multiline = true;
            this.TxDisplay1.Name = "TxDisplay1";
            this.TxDisplay1.Size = new System.Drawing.Size(350, 103);
            this.TxDisplay1.TabIndex = 5;
            this.TxDisplay1.Text = "0";
            this.TxDisplay1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxDisplay1.TextChanged += new System.EventHandler(this.TxDisplay1_TextChanged);
            // 
            // BtnBackspace
            // 
            this.BtnBackspace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BtnBackspace.FlatAppearance.BorderSize = 0;
            this.BtnBackspace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBackspace.ForeColor = System.Drawing.Color.Silver;
            this.BtnBackspace.Image = ((System.Drawing.Image)(resources.GetObject("BtnBackspace.Image")));
            this.BtnBackspace.Location = new System.Drawing.Point(175, 241);
            this.BtnBackspace.Margin = new System.Windows.Forms.Padding(1);
            this.BtnBackspace.Name = "BtnBackspace";
            this.BtnBackspace.Size = new System.Drawing.Size(85, 50);
            this.BtnBackspace.TabIndex = 7;
            this.BtnBackspace.Text = " ";
            this.BtnBackspace.UseVisualStyleBackColor = false;
            // 
            // BtnCE
            // 
            this.BtnCE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BtnCE.FlatAppearance.BorderSize = 0;
            this.BtnCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCE.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCE.ForeColor = System.Drawing.Color.White;
            this.BtnCE.Location = new System.Drawing.Point(1, 241);
            this.BtnCE.Margin = new System.Windows.Forms.Padding(1);
            this.BtnCE.Name = "BtnCE";
            this.BtnCE.Size = new System.Drawing.Size(85, 50);
            this.BtnCE.TabIndex = 15;
            this.BtnCE.Text = "CE";
            this.BtnCE.UseVisualStyleBackColor = false;
            this.BtnCE.Click += new System.EventHandler(this.BtnCE_Click);
            // 
            // BtnC
            // 
            this.BtnC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BtnC.FlatAppearance.BorderSize = 0;
            this.BtnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnC.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnC.ForeColor = System.Drawing.Color.White;
            this.BtnC.Location = new System.Drawing.Point(88, 241);
            this.BtnC.Margin = new System.Windows.Forms.Padding(1);
            this.BtnC.Name = "BtnC";
            this.BtnC.Size = new System.Drawing.Size(85, 50);
            this.BtnC.TabIndex = 16;
            this.BtnC.Text = "C";
            this.BtnC.UseVisualStyleBackColor = false;
            this.BtnC.Click += new System.EventHandler(this.BtnC_Click);
            // 
            // BtnDivision
            // 
            this.BtnDivision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BtnDivision.FlatAppearance.BorderSize = 0;
            this.BtnDivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDivision.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDivision.ForeColor = System.Drawing.Color.Silver;
            this.BtnDivision.Location = new System.Drawing.Point(262, 241);
            this.BtnDivision.Margin = new System.Windows.Forms.Padding(1);
            this.BtnDivision.Name = "BtnDivision";
            this.BtnDivision.Size = new System.Drawing.Size(85, 50);
            this.BtnDivision.TabIndex = 17;
            this.BtnDivision.Text = "/";
            this.BtnDivision.UseVisualStyleBackColor = false;
            this.BtnDivision.Click += new System.EventHandler(this.operation_);
            // 
            // Btn6
            // 
            this.Btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn6.FlatAppearance.BorderSize = 0;
            this.Btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn6.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn6.ForeColor = System.Drawing.Color.White;
            this.Btn6.Location = new System.Drawing.Point(175, 345);
            this.Btn6.Margin = new System.Windows.Forms.Padding(1);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(85, 50);
            this.Btn6.TabIndex = 28;
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = false;
            this.Btn6.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn5
            // 
            this.Btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn5.FlatAppearance.BorderSize = 0;
            this.Btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn5.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn5.ForeColor = System.Drawing.Color.White;
            this.Btn5.Location = new System.Drawing.Point(88, 345);
            this.Btn5.Margin = new System.Windows.Forms.Padding(1);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(85, 50);
            this.Btn5.TabIndex = 27;
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = false;
            this.Btn5.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn4
            // 
            this.Btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn4.FlatAppearance.BorderSize = 0;
            this.Btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn4.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn4.ForeColor = System.Drawing.Color.White;
            this.Btn4.Location = new System.Drawing.Point(1, 345);
            this.Btn4.Margin = new System.Windows.Forms.Padding(1);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(85, 50);
            this.Btn4.TabIndex = 26;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = false;
            this.Btn4.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // BtnSubtraction
            // 
            this.BtnSubtraction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BtnSubtraction.FlatAppearance.BorderSize = 0;
            this.BtnSubtraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSubtraction.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubtraction.ForeColor = System.Drawing.Color.Silver;
            this.BtnSubtraction.Location = new System.Drawing.Point(262, 345);
            this.BtnSubtraction.Margin = new System.Windows.Forms.Padding(1);
            this.BtnSubtraction.Name = "BtnSubtraction";
            this.BtnSubtraction.Size = new System.Drawing.Size(85, 50);
            this.BtnSubtraction.TabIndex = 25;
            this.BtnSubtraction.Text = "-";
            this.BtnSubtraction.UseVisualStyleBackColor = false;
            this.BtnSubtraction.Click += new System.EventHandler(this.operation_);
            // 
            // Btn9
            // 
            this.Btn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn9.FlatAppearance.BorderSize = 0;
            this.Btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn9.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn9.ForeColor = System.Drawing.Color.White;
            this.Btn9.Location = new System.Drawing.Point(175, 293);
            this.Btn9.Margin = new System.Windows.Forms.Padding(1);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(85, 50);
            this.Btn9.TabIndex = 24;
            this.Btn9.Text = "9";
            this.Btn9.UseVisualStyleBackColor = false;
            this.Btn9.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn8
            // 
            this.Btn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn8.FlatAppearance.BorderSize = 0;
            this.Btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn8.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn8.ForeColor = System.Drawing.Color.White;
            this.Btn8.Location = new System.Drawing.Point(88, 293);
            this.Btn8.Margin = new System.Windows.Forms.Padding(1);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(85, 50);
            this.Btn8.TabIndex = 23;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = false;
            this.Btn8.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn7
            // 
            this.Btn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn7.FlatAppearance.BorderSize = 0;
            this.Btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn7.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn7.ForeColor = System.Drawing.Color.White;
            this.Btn7.Location = new System.Drawing.Point(1, 293);
            this.Btn7.Margin = new System.Windows.Forms.Padding(1);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(85, 50);
            this.Btn7.TabIndex = 22;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = false;
            this.Btn7.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // BtnMulti
            // 
            this.BtnMulti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BtnMulti.FlatAppearance.BorderSize = 0;
            this.BtnMulti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMulti.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMulti.ForeColor = System.Drawing.Color.Silver;
            this.BtnMulti.Location = new System.Drawing.Point(262, 293);
            this.BtnMulti.Margin = new System.Windows.Forms.Padding(1);
            this.BtnMulti.Name = "BtnMulti";
            this.BtnMulti.Size = new System.Drawing.Size(85, 50);
            this.BtnMulti.TabIndex = 21;
            this.BtnMulti.Text = "*";
            this.BtnMulti.UseVisualStyleBackColor = false;
            this.BtnMulti.Click += new System.EventHandler(this.operation_);
            // 
            // Btn3
            // 
            this.Btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn3.FlatAppearance.BorderSize = 0;
            this.Btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn3.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn3.ForeColor = System.Drawing.Color.White;
            this.Btn3.Location = new System.Drawing.Point(175, 397);
            this.Btn3.Margin = new System.Windows.Forms.Padding(1);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(85, 50);
            this.Btn3.TabIndex = 32;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = false;
            this.Btn3.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn2
            // 
            this.Btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn2.FlatAppearance.BorderSize = 0;
            this.Btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn2.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn2.ForeColor = System.Drawing.Color.White;
            this.Btn2.Location = new System.Drawing.Point(88, 397);
            this.Btn2.Margin = new System.Windows.Forms.Padding(1);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(85, 50);
            this.Btn2.TabIndex = 31;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = false;
            this.Btn2.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn1
            // 
            this.Btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn1.FlatAppearance.BorderSize = 0;
            this.Btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1.ForeColor = System.Drawing.Color.White;
            this.Btn1.Location = new System.Drawing.Point(1, 397);
            this.Btn1.Margin = new System.Windows.Forms.Padding(1);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(85, 50);
            this.Btn1.TabIndex = 30;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = false;
            this.Btn1.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BtnAdd.FlatAppearance.BorderSize = 0;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ForeColor = System.Drawing.Color.Silver;
            this.BtnAdd.Location = new System.Drawing.Point(175, 449);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(1);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(85, 50);
            this.BtnAdd.TabIndex = 29;
            this.BtnAdd.Text = "+";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.operation_);
            // 
            // BtnDesimal
            // 
            this.BtnDesimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BtnDesimal.FlatAppearance.BorderSize = 0;
            this.BtnDesimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDesimal.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDesimal.ForeColor = System.Drawing.Color.White;
            this.BtnDesimal.Location = new System.Drawing.Point(88, 449);
            this.BtnDesimal.Margin = new System.Windows.Forms.Padding(1);
            this.BtnDesimal.Name = "BtnDesimal";
            this.BtnDesimal.Size = new System.Drawing.Size(85, 50);
            this.BtnDesimal.TabIndex = 36;
            this.BtnDesimal.Text = ".";
            this.BtnDesimal.UseVisualStyleBackColor = false;
            this.BtnDesimal.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn0
            // 
            this.Btn0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn0.FlatAppearance.BorderSize = 0;
            this.Btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn0.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn0.ForeColor = System.Drawing.Color.White;
            this.Btn0.Location = new System.Drawing.Point(1, 449);
            this.Btn0.Margin = new System.Windows.Forms.Padding(1);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(85, 50);
            this.Btn0.TabIndex = 35;
            this.Btn0.Text = "0";
            this.Btn0.UseVisualStyleBackColor = false;
            this.Btn0.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // BtnEq
            // 
            this.BtnEq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BtnEq.FlatAppearance.BorderSize = 0;
            this.BtnEq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEq.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEq.ForeColor = System.Drawing.Color.Silver;
            this.BtnEq.Location = new System.Drawing.Point(262, 397);
            this.BtnEq.Margin = new System.Windows.Forms.Padding(1);
            this.BtnEq.Name = "BtnEq";
            this.BtnEq.Size = new System.Drawing.Size(85, 103);
            this.BtnEq.TabIndex = 33;
            this.BtnEq.Text = "=";
            this.BtnEq.UseVisualStyleBackColor = false;
            this.BtnEq.Click += new System.EventHandler(this.BtnEq_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(350, 526);
            this.Controls.Add(this.BtnDesimal);
            this.Controls.Add(this.Btn0);
            this.Controls.Add(this.BtnEq);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.Btn6);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.BtnSubtraction);
            this.Controls.Add(this.Btn9);
            this.Controls.Add(this.Btn8);
            this.Controls.Add(this.Btn7);
            this.Controls.Add(this.BtnMulti);
            this.Controls.Add(this.BtnDivision);
            this.Controls.Add(this.BtnC);
            this.Controls.Add(this.BtnCE);
            this.Controls.Add(this.BtnBackspace);
            this.Controls.Add(this.TxDisplay1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.BtnNum_Click);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnMenu;
        private System.Windows.Forms.TextBox TxDisplay1;
        private System.Windows.Forms.Button BtnBackspace;
        private System.Windows.Forms.Button BtnCE;
        private System.Windows.Forms.Button BtnC;
        private System.Windows.Forms.Button BtnDivision;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button BtnSubtraction;
        private System.Windows.Forms.Button Btn9;
        private System.Windows.Forms.Button Btn8;
        private System.Windows.Forms.Button Btn7;
        private System.Windows.Forms.Button BtnMulti;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnDesimal;
        private System.Windows.Forms.Button Btn0;
        private System.Windows.Forms.Button BtnEq;
    }
}


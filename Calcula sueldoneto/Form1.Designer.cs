﻿namespace Calcula_sueldoneto
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtafp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtISR = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSRS = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSN = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sueldo Bruto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSB
            // 
            this.txtSB.Location = new System.Drawing.Point(12, 36);
            this.txtSB.Name = "txtSB";
            this.txtSB.Size = new System.Drawing.Size(100, 23);
            this.txtSB.TabIndex = 1;
            this.txtSB.TextChanged += new System.EventHandler(this.txtSB_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "AFP";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtafp
            // 
            this.txtafp.Location = new System.Drawing.Point(12, 115);
            this.txtafp.Name = "txtafp";
            this.txtafp.Size = new System.Drawing.Size(100, 23);
            this.txtafp.TabIndex = 3;
            this.txtafp.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "ISR";
            // 
            // txtISR
            // 
            this.txtISR.Location = new System.Drawing.Point(147, 115);
            this.txtISR.Name = "txtISR";
            this.txtISR.Size = new System.Drawing.Size(100, 23);
            this.txtISR.TabIndex = 5;
            this.txtISR.TextChanged += new System.EventHandler(this.txtARS_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "SRS";
            // 
            // txtSRS
            // 
            this.txtSRS.Location = new System.Drawing.Point(281, 115);
            this.txtSRS.Name = "txtSRS";
            this.txtSRS.Size = new System.Drawing.Size(100, 23);
            this.txtSRS.TabIndex = 7;
            this.txtSRS.TextChanged += new System.EventHandler(this.txtSRS_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sueldo Neto";
            // 
            // txtSN
            // 
            this.txtSN.Location = new System.Drawing.Point(12, 199);
            this.txtSN.Name = "txtSN";
            this.txtSN.Size = new System.Drawing.Size(100, 23);
            this.txtSN.TabIndex = 9;
            this.txtSN.TextChanged += new System.EventHandler(this.txtSN_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(357, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 246);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSRS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtISR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtafp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSB);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtSB;
        private Label label2;
        private TextBox txtafp;
        private Label label3;
        private TextBox txtISR;
        private Label label4;
        private TextBox txtSRS;
        private Label label5;
        private TextBox txtSN;
        private Button button1;
    }
}
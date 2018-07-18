namespace Matris_Form
{
    partial class matris_islem
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnmatris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reellecarpma = new System.Windows.Forms.Button();
            this.toplama = new System.Windows.Forms.Button();
            this.matrislecarpma = new System.Windows.Forms.Button();
            this.çikarma = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsonuc = new System.Windows.Forms.TextBox();
            this.txtmatris2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnmatris);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.textBox2);
            this.groupBox5.Location = new System.Drawing.Point(160, 39);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(447, 166);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            // 
            // btnmatris
            // 
            this.btnmatris.Location = new System.Drawing.Point(41, 50);
            this.btnmatris.Name = "btnmatris";
            this.btnmatris.Size = new System.Drawing.Size(119, 77);
            this.btnmatris.TabIndex = 1;
            this.btnmatris.Text = "Matrisi Girmek için Tıklayın";
            this.btnmatris.UseVisualStyleBackColor = true;
            this.btnmatris.Click += new System.EventHandler(this.btnmatris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(278, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Girilen Matris";
            // 
            // textBox2
            // 
            this.textBox2.AcceptsReturn = true;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(235, 40);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(164, 106);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtsonuc);
            this.groupBox4.Controls.Add(this.txtmatris2);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(29, 232);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(709, 239);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.reellecarpma);
            this.groupBox1.Controls.Add(this.toplama);
            this.groupBox1.Controls.Add(this.matrislecarpma);
            this.groupBox1.Controls.Add(this.çikarma);
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 213);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlemler";
            // 
            // reellecarpma
            // 
            this.reellecarpma.Location = new System.Drawing.Point(131, 140);
            this.reellecarpma.Name = "reellecarpma";
            this.reellecarpma.Size = new System.Drawing.Size(103, 63);
            this.reellecarpma.TabIndex = 13;
            this.reellecarpma.Text = "Matrisle Skaler Çarpım İşlemi için Tıklayın";
            this.reellecarpma.UseVisualStyleBackColor = true;
            this.reellecarpma.Click += new System.EventHandler(this.reellecarpma_Click);
            // 
            // toplama
            // 
            this.toplama.Location = new System.Drawing.Point(24, 19);
            this.toplama.Name = "toplama";
            this.toplama.Size = new System.Drawing.Size(103, 63);
            this.toplama.TabIndex = 9;
            this.toplama.Text = "Girilen Matrisle Toplama İşlemi Yapmak için Tıklayın";
            this.toplama.UseVisualStyleBackColor = true;
            this.toplama.Click += new System.EventHandler(this.toplama_Click);
            // 
            // matrislecarpma
            // 
            this.matrislecarpma.Location = new System.Drawing.Point(24, 88);
            this.matrislecarpma.Name = "matrislecarpma";
            this.matrislecarpma.Size = new System.Drawing.Size(212, 46);
            this.matrislecarpma.TabIndex = 12;
            this.matrislecarpma.Text = "Girilen Matrisle Çarpma İşlemi Yapmak için Tıklayın";
            this.matrislecarpma.UseVisualStyleBackColor = true;
            this.matrislecarpma.Click += new System.EventHandler(this.matrislecarpma_Click);
            // 
            // çikarma
            // 
            this.çikarma.Location = new System.Drawing.Point(133, 19);
            this.çikarma.Name = "çikarma";
            this.çikarma.Size = new System.Drawing.Size(103, 63);
            this.çikarma.TabIndex = 11;
            this.çikarma.Text = "Girilen Matrisle Çıkarma İşlemi Yapmak için Tıklayın";
            this.çikarma.UseVisualStyleBackColor = true;
            this.çikarma.Click += new System.EventHandler(this.çikarma_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(476, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = ">>";
            // 
            // txtsonuc
            // 
            this.txtsonuc.AcceptsReturn = true;
            this.txtsonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsonuc.Location = new System.Drawing.Point(534, 68);
            this.txtsonuc.Multiline = true;
            this.txtsonuc.Name = "txtsonuc";
            this.txtsonuc.ReadOnly = true;
            this.txtsonuc.Size = new System.Drawing.Size(164, 106);
            this.txtsonuc.TabIndex = 16;
            // 
            // txtmatris2
            // 
            this.txtmatris2.AcceptsReturn = true;
            this.txtmatris2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtmatris2.Location = new System.Drawing.Point(289, 68);
            this.txtmatris2.Multiline = true;
            this.txtmatris2.Name = "txtmatris2";
            this.txtmatris2.ReadOnly = true;
            this.txtmatris2.Size = new System.Drawing.Size(164, 106);
            this.txtmatris2.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(580, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Oluşan Matris";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(311, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "İşleme Girecek 2. Matris";
            // 
            // matris_islem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(782, 506);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Name = "matris_islem";
            this.Text = "matris_islem";
            this.Load += new System.EventHandler(this.matris_islem_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnmatris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button reellecarpma;
        private System.Windows.Forms.Button toplama;
        private System.Windows.Forms.Button matrislecarpma;
        private System.Windows.Forms.Button çikarma;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsonuc;
        private System.Windows.Forms.TextBox txtmatris2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
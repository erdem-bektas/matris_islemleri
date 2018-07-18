namespace Matris_Form
{
    partial class matris_ozellikler
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
            this.btnmatris = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtsonuc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.transpoze = new System.Windows.Forms.Button();
            this.tipbelirle = new System.Windows.Forms.Button();
            this.rank = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnmatris
            // 
            this.btnmatris.Location = new System.Drawing.Point(41, 50);
            this.btnmatris.Name = "btnmatris";
            this.btnmatris.Size = new System.Drawing.Size(119, 77);
            this.btnmatris.TabIndex = 1;
            this.btnmatris.Text = "Matrisi Girmek için Tıklayın";
            this.btnmatris.UseVisualStyleBackColor = true;
            this.btnmatris.Click += new System.EventHandler(this.button1_Click);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(942, 205);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtsonuc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(721, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 168);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // txtsonuc
            // 
            this.txtsonuc.AcceptsReturn = true;
            this.txtsonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsonuc.Location = new System.Drawing.Point(19, 39);
            this.txtsonuc.Multiline = true;
            this.txtsonuc.Name = "txtsonuc";
            this.txtsonuc.ReadOnly = true;
            this.txtsonuc.Size = new System.Drawing.Size(164, 106);
            this.txtsonuc.TabIndex = 16;
            this.txtsonuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Oluşan Matris";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnmatris);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.textBox2);
            this.groupBox5.Location = new System.Drawing.Point(12, 21);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(447, 166);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.transpoze);
            this.groupBox3.Controls.Add(this.tipbelirle);
            this.groupBox3.Controls.Add(this.rank);
            this.groupBox3.Location = new System.Drawing.Point(474, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(241, 168);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Girilen Matrisin";
            // 
            // transpoze
            // 
            this.transpoze.Location = new System.Drawing.Point(124, 91);
            this.transpoze.Name = "transpoze";
            this.transpoze.Size = new System.Drawing.Size(106, 63);
            this.transpoze.TabIndex = 16;
            this.transpoze.Text = "Transpozesini Belirlemek için Tıklayın";
            this.transpoze.UseVisualStyleBackColor = true;
            this.transpoze.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // tipbelirle
            // 
            this.tipbelirle.Location = new System.Drawing.Point(12, 91);
            this.tipbelirle.Name = "tipbelirle";
            this.tipbelirle.Size = new System.Drawing.Size(106, 63);
            this.tipbelirle.TabIndex = 10;
            this.tipbelirle.Text = "Tipini Öğrenmek için Tıklayın";
            this.tipbelirle.UseVisualStyleBackColor = true;
            this.tipbelirle.Click += new System.EventHandler(this.tipbelirle_Click);
            // 
            // rank
            // 
            this.rank.Location = new System.Drawing.Point(12, 22);
            this.rank.Name = "rank";
            this.rank.Size = new System.Drawing.Size(106, 63);
            this.rank.TabIndex = 14;
            this.rank.Text = "Rankını Öğrenmek için Tıklayın";
            this.rank.UseVisualStyleBackColor = true;
            this.rank.Click += new System.EventHandler(this.rank_Click);
            // 
            // matris_ozellikler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(971, 238);
            this.Controls.Add(this.groupBox2);
            this.Name = "matris_ozellikler";
            this.Text = "1. Ünite";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnmatris;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button rank;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button transpoze;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtsonuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button tipbelirle;
    }
}


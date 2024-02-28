namespace mayın_tarlası
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label_skor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.basla_buton = new System.Windows.Forms.Button();
            this.kolay = new System.Windows.Forms.RadioButton();
            this.orta = new System.Windows.Forms.RadioButton();
            this.zor = new System.Windows.Forms.RadioButton();
            this.groupBox_skor = new System.Windows.Forms.GroupBox();
            this.groupBox_zorluk = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_skor.SuspendLayout();
            this.groupBox_zorluk.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(360, 360);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label_skor
            // 
            this.label_skor.AutoSize = true;
            this.label_skor.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_skor.Location = new System.Drawing.Point(102, 61);
            this.label_skor.Name = "label_skor";
            this.label_skor.Size = new System.Drawing.Size(24, 28);
            this.label_skor.TabIndex = 1;
            this.label_skor.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(69, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "SKOR";
            // 
            // basla_buton
            // 
            this.basla_buton.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.basla_buton.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.basla_buton.Location = new System.Drawing.Point(393, 287);
            this.basla_buton.Name = "basla_buton";
            this.basla_buton.Size = new System.Drawing.Size(222, 85);
            this.basla_buton.TabIndex = 0;
            this.basla_buton.Text = "Başla";
            this.basla_buton.UseVisualStyleBackColor = false;
            this.basla_buton.Click += new System.EventHandler(this.button1_Click);
            // 
            // kolay
            // 
            this.kolay.AutoSize = true;
            this.kolay.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kolay.Location = new System.Drawing.Point(122, 22);
            this.kolay.Name = "kolay";
            this.kolay.Size = new System.Drawing.Size(59, 19);
            this.kolay.TabIndex = 2;
            this.kolay.TabStop = true;
            this.kolay.Text = "Kolay";
            this.kolay.UseVisualStyleBackColor = true;
            // 
            // orta
            // 
            this.orta.AutoSize = true;
            this.orta.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.orta.Location = new System.Drawing.Point(122, 47);
            this.orta.Name = "orta";
            this.orta.Size = new System.Drawing.Size(51, 19);
            this.orta.TabIndex = 3;
            this.orta.TabStop = true;
            this.orta.Text = "Orta";
            this.orta.UseVisualStyleBackColor = true;
            // 
            // zor
            // 
            this.zor.AutoSize = true;
            this.zor.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.zor.Location = new System.Drawing.Point(122, 72);
            this.zor.Name = "zor";
            this.zor.Size = new System.Drawing.Size(46, 19);
            this.zor.TabIndex = 4;
            this.zor.TabStop = true;
            this.zor.Text = "Zor";
            this.zor.UseVisualStyleBackColor = true;
            // 
            // groupBox_skor
            // 
            this.groupBox_skor.Controls.Add(this.label_skor);
            this.groupBox_skor.Controls.Add(this.label2);
            this.groupBox_skor.Location = new System.Drawing.Point(393, 12);
            this.groupBox_skor.Name = "groupBox_skor";
            this.groupBox_skor.Size = new System.Drawing.Size(222, 100);
            this.groupBox_skor.TabIndex = 5;
            this.groupBox_skor.TabStop = false;
            // 
            // groupBox_zorluk
            // 
            this.groupBox_zorluk.Controls.Add(this.label1);
            this.groupBox_zorluk.Controls.Add(this.kolay);
            this.groupBox_zorluk.Controls.Add(this.orta);
            this.groupBox_zorluk.Controls.Add(this.zor);
            this.groupBox_zorluk.Location = new System.Drawing.Point(393, 118);
            this.groupBox_zorluk.Name = "groupBox_zorluk";
            this.groupBox_zorluk.Size = new System.Drawing.Size(222, 103);
            this.groupBox_zorluk.TabIndex = 6;
            this.groupBox_zorluk.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Zorluk";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(632, 387);
            this.Controls.Add(this.groupBox_zorluk);
            this.Controls.Add(this.groupBox_skor);
            this.Controls.Add(this.basla_buton);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Mayın Tarlası(Ferit)";
            this.groupBox_skor.ResumeLayout(false);
            this.groupBox_skor.PerformLayout();
            this.groupBox_zorluk.ResumeLayout(false);
            this.groupBox_zorluk.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label_skor;
        private Label label2;
        private Button basla_buton;
        private RadioButton kolay;
        private RadioButton orta;
        private RadioButton zor;
        private GroupBox groupBox_skor;
        private GroupBox groupBox_zorluk;
        private Label label1;
    }
}
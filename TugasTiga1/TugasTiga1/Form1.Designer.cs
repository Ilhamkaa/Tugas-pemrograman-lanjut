namespace TugasTiga1
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
            this.lab1 = new System.Windows.Forms.Label();
            this.tombolentr = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.nim = new System.Windows.Forms.Label();
            this.nama = new System.Windows.Forms.Label();
            this.kelas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab1.Location = new System.Drawing.Point(72, 86);
            this.lab1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(338, 25);
            this.lab1.TabIndex = 0;
            this.lab1.Text = "Aplikasi Melihat Nim, Nama dan kelas";
            // 
            // tombolentr
            // 
            this.tombolentr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolentr.Location = new System.Drawing.Point(68, 226);
            this.tombolentr.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tombolentr.Name = "tombolentr";
            this.tombolentr.Size = new System.Drawing.Size(127, 32);
            this.tombolentr.TabIndex = 1;
            this.tombolentr.Text = "Priksa";
            this.tombolentr.UseVisualStyleBackColor = true;
            this.tombolentr.Click += new System.EventHandler(this.tombolentr_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(259, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nim
            // 
            this.nim.AutoSize = true;
            this.nim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.nim.Location = new System.Drawing.Point(88, 138);
            this.nim.Name = "nim";
            this.nim.Size = new System.Drawing.Size(48, 15);
            this.nim.TabIndex = 3;
            this.nim.Text = "NIM     :";
            // 
            // nama
            // 
            this.nama.AutoSize = true;
            this.nama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.nama.Location = new System.Drawing.Point(88, 169);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(47, 15);
            this.nama.TabIndex = 4;
            this.nama.Text = "Nama :";
            // 
            // kelas
            // 
            this.kelas.AutoSize = true;
            this.kelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.kelas.Location = new System.Drawing.Point(88, 195);
            this.kelas.Name = "kelas";
            this.kelas.Size = new System.Drawing.Size(47, 15);
            this.kelas.TabIndex = 5;
            this.kelas.Text = "Kelas  :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 382);
            this.Controls.Add(this.kelas);
            this.Controls.Add(this.nama);
            this.Controls.Add(this.nim);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tombolentr);
            this.Controls.Add(this.lab1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form1";
            this.Text = "Tugas 3.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.Button tombolentr;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label nim;
        private System.Windows.Forms.Label nama;
        private System.Windows.Forms.Label kelas;
    }
}


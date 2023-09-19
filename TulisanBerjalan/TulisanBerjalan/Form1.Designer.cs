namespace TulisanBerjalan
{
    partial class frmtulisanberjalan
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
            this.components = new System.ComponentModel.Container();
            this.lblanimasi1 = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblanimasi1
            // 
            this.lblanimasi1.AutoSize = true;
            this.lblanimasi1.Location = new System.Drawing.Point(84, 74);
            this.lblanimasi1.Name = "lblanimasi1";
            this.lblanimasi1.Size = new System.Drawing.Size(82, 13);
            this.lblanimasi1.TabIndex = 0;
            this.lblanimasi1.Text = "Tulisan Berjalan";
            this.lblanimasi1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(110, 135);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(98, 30);
            this.button.TabIndex = 1;
            this.button.Text = "Keluar";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.lblanimasi_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmtulisanberjalan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 450);
            this.Controls.Add(this.button);
            this.Controls.Add(this.lblanimasi1);
            this.Name = "frmtulisanberjalan";
            this.Text = "Tulisan Berjalan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblanimasi1;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Timer timer1;
    }
}


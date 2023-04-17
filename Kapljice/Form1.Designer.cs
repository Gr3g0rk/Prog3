namespace Kapljice
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
            this.components = new System.ComponentModel.Container();
            this.platno = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.platno)).BeginInit();
            this.SuspendLayout();
            // 
            // platno
            // 
            this.platno.Location = new System.Drawing.Point(12, 12);
            this.platno.Name = "platno";
            this.platno.Size = new System.Drawing.Size(776, 426);
            this.platno.TabIndex = 0;
            this.platno.TabStop = false;
            this.platno.Paint += new System.Windows.Forms.PaintEventHandler(this.narisi);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.platno);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.nalozi);
            ((System.ComponentModel.ISupportInitialize)(this.platno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox platno;
        private System.Windows.Forms.Timer timer1;
    }
}


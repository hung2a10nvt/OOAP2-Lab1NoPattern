namespace Lab1NoPattern
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxCar = new System.Windows.Forms.PictureBox();
            this.rtbSpec = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCarName = new System.Windows.Forms.Label();
            this.btRussia = new System.Windows.Forms.Button();
            this.btAsia = new System.Windows.Forms.Button();
            this.btEurope = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btEurope);
            this.panel1.Controls.Add(this.btAsia);
            this.panel1.Controls.Add(this.btRussia);
            this.panel1.Controls.Add(this.lblCarName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1079, 100);
            this.panel1.TabIndex = 0;
            // 
            // pictureBoxCar
            // 
            this.pictureBoxCar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxCar.Location = new System.Drawing.Point(0, 100);
            this.pictureBoxCar.Name = "pictureBoxCar";
            this.pictureBoxCar.Size = new System.Drawing.Size(1079, 492);
            this.pictureBoxCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCar.TabIndex = 0;
            this.pictureBoxCar.TabStop = false;
            // 
            // rtbSpec
            // 
            this.rtbSpec.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtbSpec.Location = new System.Drawing.Point(0, 496);
            this.rtbSpec.Name = "rtbSpec";
            this.rtbSpec.Size = new System.Drawing.Size(1079, 96);
            this.rtbSpec.TabIndex = 1;
            this.rtbSpec.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Region";
            // 
            // lblCarName
            // 
            this.lblCarName.AutoSize = true;
            this.lblCarName.Location = new System.Drawing.Point(12, 84);
            this.lblCarName.Name = "lblCarName";
            this.lblCarName.Size = new System.Drawing.Size(35, 13);
            this.lblCarName.TabIndex = 3;
            this.lblCarName.Text = "label2";
            // 
            // btRussia
            // 
            this.btRussia.Location = new System.Drawing.Point(69, 36);
            this.btRussia.Name = "btRussia";
            this.btRussia.Size = new System.Drawing.Size(75, 23);
            this.btRussia.TabIndex = 4;
            this.btRussia.Text = "Russia";
            this.btRussia.UseVisualStyleBackColor = true;
            this.btRussia.Click += new System.EventHandler(this.btRussia_Click);
            // 
            // btAsia
            // 
            this.btAsia.Location = new System.Drawing.Point(167, 36);
            this.btAsia.Name = "btAsia";
            this.btAsia.Size = new System.Drawing.Size(75, 23);
            this.btAsia.TabIndex = 5;
            this.btAsia.Text = "Asia";
            this.btAsia.UseVisualStyleBackColor = true;
            this.btAsia.Click += new System.EventHandler(this.btAsia_Click);
            // 
            // btEurope
            // 
            this.btEurope.Location = new System.Drawing.Point(270, 36);
            this.btEurope.Name = "btEurope";
            this.btEurope.Size = new System.Drawing.Size(75, 23);
            this.btEurope.TabIndex = 6;
            this.btEurope.Text = "Europe";
            this.btEurope.UseVisualStyleBackColor = true;
            this.btEurope.Click += new System.EventHandler(this.btEurope_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 592);
            this.Controls.Add(this.rtbSpec);
            this.Controls.Add(this.pictureBoxCar);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btEurope;
        private System.Windows.Forms.Button btAsia;
        private System.Windows.Forms.Button btRussia;
        private System.Windows.Forms.Label lblCarName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxCar;
        private System.Windows.Forms.RichTextBox rtbSpec;
    }
}


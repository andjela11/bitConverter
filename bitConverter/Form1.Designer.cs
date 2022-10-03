
namespace bitConverter
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
            this.numConvert = new System.Windows.Forms.NumericUpDown();
            this.txtConvert = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.radioBtnOkt = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBtnHex = new System.Windows.Forms.RadioButton();
            this.radioBtnBin = new System.Windows.Forms.RadioButton();
            this.btnConvert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numConvert)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numConvert
            // 
            this.numConvert.Location = new System.Drawing.Point(29, 87);
            this.numConvert.Name = "numConvert";
            this.numConvert.Size = new System.Drawing.Size(120, 22);
            this.numConvert.TabIndex = 0;
            // 
            // txtConvert
            // 
            this.txtConvert.Location = new System.Drawing.Point(29, 323);
            this.txtConvert.Name = "txtConvert";
            this.txtConvert.Size = new System.Drawing.Size(120, 22);
            this.txtConvert.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(617, 278);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 22);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(617, 323);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(120, 22);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(617, 367);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(120, 22);
            this.textBox4.TabIndex = 4;
            // 
            // radioBtnOkt
            // 
            this.radioBtnOkt.AutoSize = true;
            this.radioBtnOkt.Location = new System.Drawing.Point(6, 30);
            this.radioBtnOkt.Name = "radioBtnOkt";
            this.radioBtnOkt.Size = new System.Drawing.Size(58, 21);
            this.radioBtnOkt.TabIndex = 5;
            this.radioBtnOkt.TabStop = true;
            this.radioBtnOkt.Text = "OKT";
            this.radioBtnOkt.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBtnBin);
            this.groupBox1.Controls.Add(this.radioBtnHex);
            this.groupBox1.Controls.Add(this.radioBtnOkt);
            this.groupBox1.Location = new System.Drawing.Point(29, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 116);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Convert to:";
            // 
            // radioBtnHex
            // 
            this.radioBtnHex.AutoSize = true;
            this.radioBtnHex.Location = new System.Drawing.Point(6, 57);
            this.radioBtnHex.Name = "radioBtnHex";
            this.radioBtnHex.Size = new System.Drawing.Size(57, 21);
            this.radioBtnHex.TabIndex = 6;
            this.radioBtnHex.TabStop = true;
            this.radioBtnHex.Text = "HEX";
            this.radioBtnHex.UseVisualStyleBackColor = true;
            // 
            // radioBtnBin
            // 
            this.radioBtnBin.AutoSize = true;
            this.radioBtnBin.Location = new System.Drawing.Point(6, 84);
            this.radioBtnBin.Name = "radioBtnBin";
            this.radioBtnBin.Size = new System.Drawing.Size(51, 21);
            this.radioBtnBin.TabIndex = 7;
            this.radioBtnBin.TabStop = true;
            this.radioBtnBin.Text = "BIN";
            this.radioBtnBin.UseVisualStyleBackColor = true;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(29, 278);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 24);
            this.btnConvert.TabIndex = 7;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(32, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtConvert);
            this.Controls.Add(this.numConvert);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numConvert)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numConvert;
        private System.Windows.Forms.TextBox txtConvert;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.RadioButton radioBtnOkt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioBtnBin;
        private System.Windows.Forms.RadioButton radioBtnHex;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label label1;
    }
}


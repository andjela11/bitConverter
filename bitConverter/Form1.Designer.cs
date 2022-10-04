
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
            this.txtCalcFirst = new System.Windows.Forms.TextBox();
            this.txtCalcSecond = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.radioBtnOkt = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBtnBin = new System.Windows.Forms.RadioButton();
            this.radioBtnHex = new System.Windows.Forms.RadioButton();
            this.btnConvert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numCalc1 = new System.Windows.Forms.NumericUpDown();
            this.numCalc2 = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioBtnXOR = new System.Windows.Forms.RadioButton();
            this.radioBtnOR = new System.Windows.Forms.RadioButton();
            this.radioBtnAND = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numConvert)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCalc1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCalc2)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            // txtCalcFirst
            // 
            this.txtCalcFirst.Location = new System.Drawing.Point(356, 314);
            this.txtCalcFirst.Name = "txtCalcFirst";
            this.txtCalcFirst.Size = new System.Drawing.Size(120, 22);
            this.txtCalcFirst.TabIndex = 2;
            // 
            // txtCalcSecond
            // 
            this.txtCalcSecond.Location = new System.Drawing.Point(356, 359);
            this.txtCalcSecond.Name = "txtCalcSecond";
            this.txtCalcSecond.Size = new System.Drawing.Size(120, 22);
            this.txtCalcSecond.TabIndex = 3;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(356, 403);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(120, 22);
            this.txtResult.TabIndex = 4;
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
            // numCalc1
            // 
            this.numCalc1.Location = new System.Drawing.Point(341, 87);
            this.numCalc1.Name = "numCalc1";
            this.numCalc1.Size = new System.Drawing.Size(79, 22);
            this.numCalc1.TabIndex = 9;
            // 
            // numCalc2
            // 
            this.numCalc2.Location = new System.Drawing.Point(433, 87);
            this.numCalc2.Name = "numCalc2";
            this.numCalc2.Size = new System.Drawing.Size(79, 22);
            this.numCalc2.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioBtnXOR);
            this.groupBox2.Controls.Add(this.radioBtnOR);
            this.groupBox2.Controls.Add(this.radioBtnAND);
            this.groupBox2.Location = new System.Drawing.Point(356, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(156, 116);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bitwise operation:";
            // 
            // radioBtnXOR
            // 
            this.radioBtnXOR.AutoSize = true;
            this.radioBtnXOR.Location = new System.Drawing.Point(6, 84);
            this.radioBtnXOR.Name = "radioBtnXOR";
            this.radioBtnXOR.Size = new System.Drawing.Size(59, 21);
            this.radioBtnXOR.TabIndex = 7;
            this.radioBtnXOR.TabStop = true;
            this.radioBtnXOR.Text = "XOR";
            this.radioBtnXOR.UseVisualStyleBackColor = true;
            // 
            // radioBtnOR
            // 
            this.radioBtnOR.AutoSize = true;
            this.radioBtnOR.Location = new System.Drawing.Point(6, 57);
            this.radioBtnOR.Name = "radioBtnOR";
            this.radioBtnOR.Size = new System.Drawing.Size(50, 21);
            this.radioBtnOR.TabIndex = 6;
            this.radioBtnOR.TabStop = true;
            this.radioBtnOR.Text = "OR";
            this.radioBtnOR.UseVisualStyleBackColor = true;
            // 
            // radioBtnAND
            // 
            this.radioBtnAND.AutoSize = true;
            this.radioBtnAND.Location = new System.Drawing.Point(6, 30);
            this.radioBtnAND.Name = "radioBtnAND";
            this.radioBtnAND.Size = new System.Drawing.Size(58, 21);
            this.radioBtnAND.TabIndex = 5;
            this.radioBtnAND.TabStop = true;
            this.radioBtnAND.Text = "AND";
            this.radioBtnAND.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(353, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 14;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(362, 278);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 24);
            this.btnCalc.TabIndex = 15;
            this.btnCalc.Text = "Calc";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(313, 403);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.numCalc2);
            this.Controls.Add(this.numCalc1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtCalcSecond);
            this.Controls.Add(this.txtCalcFirst);
            this.Controls.Add(this.txtConvert);
            this.Controls.Add(this.numConvert);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numConvert)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCalc1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCalc2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numConvert;
        private System.Windows.Forms.TextBox txtConvert;
        private System.Windows.Forms.TextBox txtCalcFirst;
        private System.Windows.Forms.TextBox txtCalcSecond;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.RadioButton radioBtnOkt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioBtnBin;
        private System.Windows.Forms.RadioButton radioBtnHex;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numCalc1;
        private System.Windows.Forms.NumericUpDown numCalc2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioBtnXOR;
        private System.Windows.Forms.RadioButton radioBtnOR;
        private System.Windows.Forms.RadioButton radioBtnAND;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label label5;
    }
}


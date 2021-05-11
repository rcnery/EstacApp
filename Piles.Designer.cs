
namespace EstacApp
{
    partial class Form_Piles
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
            this.textBox_length = new System.Windows.Forms.TextBox();
            this.textBox_diameter = new System.Windows.Forms.TextBox();
            this.textBox_pileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox_bottleneckFlag = new System.Windows.Forms.CheckBox();
            this.textBox_bottleneckLength = new System.Windows.Forms.TextBox();
            this.label_bottleneckLength = new System.Windows.Forms.Label();
            this.textBox_bottleneckFinalDiameter = new System.Windows.Forms.TextBox();
            this.label_bottleneckFinalDiameter = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_barQuantity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_barDiameter = new System.Windows.Forms.ComboBox();
            this.comboBox_stirrupDiameter = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox_stirrupType = new System.Windows.Forms.ComboBox();
            this.textBox_stirrupSpacing = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_results = new System.Windows.Forms.TextBox();
            this.button_calculateResults = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_length
            // 
            this.textBox_length.Location = new System.Drawing.Point(140, 97);
            this.textBox_length.Name = "textBox_length";
            this.textBox_length.Size = new System.Drawing.Size(62, 23);
            this.textBox_length.TabIndex = 0;
            // 
            // textBox_diameter
            // 
            this.textBox_diameter.Location = new System.Drawing.Point(140, 68);
            this.textBox_diameter.Name = "textBox_diameter";
            this.textBox_diameter.Size = new System.Drawing.Size(62, 23);
            this.textBox_diameter.TabIndex = 1;
            // 
            // textBox_pileName
            // 
            this.textBox_pileName.Location = new System.Drawing.Point(140, 39);
            this.textBox_pileName.Name = "textBox_pileName";
            this.textBox_pileName.Size = new System.Drawing.Size(62, 23);
            this.textBox_pileName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Diâmetro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Comprimento:";
            // 
            // checkBox_bottleneckFlag
            // 
            this.checkBox_bottleneckFlag.AutoSize = true;
            this.checkBox_bottleneckFlag.Location = new System.Drawing.Point(10, 126);
            this.checkBox_bottleneckFlag.Name = "checkBox_bottleneckFlag";
            this.checkBox_bottleneckFlag.Size = new System.Drawing.Size(128, 19);
            this.checkBox_bottleneckFlag.TabIndex = 6;
            this.checkBox_bottleneckFlag.Text = "Tem afunilamento?";
            this.checkBox_bottleneckFlag.UseVisualStyleBackColor = true;
            this.checkBox_bottleneckFlag.Click += new System.EventHandler(this.checkBox1_Click);
            // 
            // textBox_bottleneckLength
            // 
            this.textBox_bottleneckLength.Location = new System.Drawing.Point(140, 151);
            this.textBox_bottleneckLength.Name = "textBox_bottleneckLength";
            this.textBox_bottleneckLength.Size = new System.Drawing.Size(62, 23);
            this.textBox_bottleneckLength.TabIndex = 7;
            this.textBox_bottleneckLength.Visible = false;
            // 
            // label_bottleneckLength
            // 
            this.label_bottleneckLength.AutoSize = true;
            this.label_bottleneckLength.Location = new System.Drawing.Point(10, 154);
            this.label_bottleneckLength.Name = "label_bottleneckLength";
            this.label_bottleneckLength.Size = new System.Drawing.Size(124, 15);
            this.label_bottleneckLength.TabIndex = 8;
            this.label_bottleneckLength.Text = "Compr. afunilamento:";
            this.label_bottleneckLength.Visible = false;
            // 
            // textBox_bottleneckFinalDiameter
            // 
            this.textBox_bottleneckFinalDiameter.Location = new System.Drawing.Point(140, 180);
            this.textBox_bottleneckFinalDiameter.Name = "textBox_bottleneckFinalDiameter";
            this.textBox_bottleneckFinalDiameter.Size = new System.Drawing.Size(62, 23);
            this.textBox_bottleneckFinalDiameter.TabIndex = 9;
            this.textBox_bottleneckFinalDiameter.Visible = false;
            // 
            // label_bottleneckFinalDiameter
            // 
            this.label_bottleneckFinalDiameter.AutoSize = true;
            this.label_bottleneckFinalDiameter.Location = new System.Drawing.Point(10, 183);
            this.label_bottleneckFinalDiameter.Name = "label_bottleneckFinalDiameter";
            this.label_bottleneckFinalDiameter.Size = new System.Drawing.Size(85, 15);
            this.label_bottleneckFinalDiameter.TabIndex = 10;
            this.label_bottleneckFinalDiameter.Text = "Diâmetro final:";
            this.label_bottleneckFinalDiameter.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Dimensões";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(226, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Armação";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(226, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Qtde. de barras longitudinais:";
            // 
            // textBox_barQuantity
            // 
            this.textBox_barQuantity.Location = new System.Drawing.Point(400, 39);
            this.textBox_barQuantity.Name = "textBox_barQuantity";
            this.textBox_barQuantity.Size = new System.Drawing.Size(73, 23);
            this.textBox_barQuantity.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(226, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Bitola das barras longitudinais:";
            // 
            // comboBox_barDiameter
            // 
            this.comboBox_barDiameter.FormattingEnabled = true;
            this.comboBox_barDiameter.Items.AddRange(new object[] {
            "10",
            "12,5",
            "16",
            "20",
            "25",
            "32",
            "40"});
            this.comboBox_barDiameter.Location = new System.Drawing.Point(400, 68);
            this.comboBox_barDiameter.Name = "comboBox_barDiameter";
            this.comboBox_barDiameter.Size = new System.Drawing.Size(73, 23);
            this.comboBox_barDiameter.TabIndex = 17;
            this.comboBox_barDiameter.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox_stirrupDiameter
            // 
            this.comboBox_stirrupDiameter.FormattingEnabled = true;
            this.comboBox_stirrupDiameter.Items.AddRange(new object[] {
            "10",
            "12,5",
            "16",
            "20",
            "25",
            "32",
            "40"});
            this.comboBox_stirrupDiameter.Location = new System.Drawing.Point(400, 126);
            this.comboBox_stirrupDiameter.Name = "comboBox_stirrupDiameter";
            this.comboBox_stirrupDiameter.Size = new System.Drawing.Size(73, 23);
            this.comboBox_stirrupDiameter.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(226, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "Bitola dos estribos:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(226, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 15);
            this.label9.TabIndex = 19;
            this.label9.Text = "Tipo de estribo:";
            // 
            // comboBox_stirrupType
            // 
            this.comboBox_stirrupType.FormattingEnabled = true;
            this.comboBox_stirrupType.Items.AddRange(new object[] {
            "individual",
            "espiral"});
            this.comboBox_stirrupType.Location = new System.Drawing.Point(400, 97);
            this.comboBox_stirrupType.Name = "comboBox_stirrupType";
            this.comboBox_stirrupType.Size = new System.Drawing.Size(73, 23);
            this.comboBox_stirrupType.TabIndex = 22;
            // 
            // textBox_stirrupSpacing
            // 
            this.textBox_stirrupSpacing.Location = new System.Drawing.Point(400, 155);
            this.textBox_stirrupSpacing.Name = "textBox_stirrupSpacing";
            this.textBox_stirrupSpacing.Size = new System.Drawing.Size(73, 23);
            this.textBox_stirrupSpacing.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(226, 159);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 15);
            this.label10.TabIndex = 24;
            this.label10.Text = "Espaçamento:";
            // 
            // textBox_results
            // 
            this.textBox_results.Location = new System.Drawing.Point(493, 68);
            this.textBox_results.Multiline = true;
            this.textBox_results.Name = "textBox_results";
            this.textBox_results.ReadOnly = true;
            this.textBox_results.Size = new System.Drawing.Size(233, 225);
            this.textBox_results.TabIndex = 25;
            // 
            // button_calculateResults
            // 
            this.button_calculateResults.Location = new System.Drawing.Point(493, 39);
            this.button_calculateResults.Name = "button_calculateResults";
            this.button_calculateResults.Size = new System.Drawing.Size(137, 23);
            this.button_calculateResults.TabIndex = 26;
            this.button_calculateResults.Text = "Calcular resultados";
            this.button_calculateResults.UseVisualStyleBackColor = true;
            this.button_calculateResults.Click += new System.EventHandler(this.button_calculateResults_Click);
            // 
            // Form_Piles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 305);
            this.Controls.Add(this.button_calculateResults);
            this.Controls.Add(this.textBox_results);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox_stirrupSpacing);
            this.Controls.Add(this.comboBox_stirrupType);
            this.Controls.Add(this.comboBox_stirrupDiameter);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox_barDiameter);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_barQuantity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_bottleneckFinalDiameter);
            this.Controls.Add(this.label_bottleneckFinalDiameter);
            this.Controls.Add(this.textBox_bottleneckLength);
            this.Controls.Add(this.label_bottleneckLength);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_pileName);
            this.Controls.Add(this.textBox_diameter);
            this.Controls.Add(this.textBox_length);
            this.Controls.Add(this.checkBox_bottleneckFlag);
            this.Controls.Add(this.label3);
            this.Name = "Form_Piles";
            this.Text = "Estacas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_length;
        private System.Windows.Forms.TextBox textBox_diameter;
        private System.Windows.Forms.TextBox textBox_pileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox_bottleneckFlag;
        private System.Windows.Forms.TextBox textBox_bottleneckLength;
        private System.Windows.Forms.Label label_bottleneckLength;
        private System.Windows.Forms.TextBox textBox_bottleneckFinalDiameter;
        private System.Windows.Forms.Label label_bottleneckFinalDiameter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_barQuantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_barDiameter;
        private System.Windows.Forms.ComboBox comboBox_stirrupDiameter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox_stirrupType;
        private System.Windows.Forms.TextBox textBox_stirrupSpacing;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_results;
        private System.Windows.Forms.Button button_calculateResults;
    }
}


namespace CalculatorApplication {
    partial class FrmCalculator {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            groupBox1 = new GroupBox();
            BtnClear = new Button();
            BtnCalculate = new Button();
            lblDisplayTotal = new Label();
            label3 = new Label();
            cbOperator = new ComboBox();
            TxtBoxInput2 = new TextBox();
            TxtBoxInput1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtnClear);
            groupBox1.Controls.Add(BtnCalculate);
            groupBox1.Controls.Add(lblDisplayTotal);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cbOperator);
            groupBox1.Controls.Add(TxtBoxInput2);
            groupBox1.Controls.Add(TxtBoxInput1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(424, 356);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enter the following";
            // 
            // BtnClear
            // 
            BtnClear.Location = new Point(166, 183);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(57, 35);
            BtnClear.TabIndex = 7;
            BtnClear.Text = "C";
            BtnClear.UseVisualStyleBackColor = true;
            BtnClear.Click += BtnClear_Click;
            // 
            // BtnCalculate
            // 
            BtnCalculate.Location = new Point(229, 183);
            BtnCalculate.Name = "BtnCalculate";
            BtnCalculate.Size = new Size(125, 35);
            BtnCalculate.TabIndex = 6;
            BtnCalculate.Text = "Calculate";
            BtnCalculate.UseVisualStyleBackColor = true;
            BtnCalculate.Click += BtnCalculate_Click;
            // 
            // lblDisplayTotal
            // 
            lblDisplayTotal.AutoSize = true;
            lblDisplayTotal.Location = new Point(41, 256);
            lblDisplayTotal.Name = "lblDisplayTotal";
            lblDisplayTotal.Size = new Size(131, 23);
            lblDisplayTotal.TabIndex = 5;
            lblDisplayTotal.Text = "Answer: ---";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 92);
            label3.Name = "label3";
            label3.Size = new Size(109, 23);
            label3.TabIndex = 4;
            label3.Text = "Operator:";
            // 
            // cbOperator
            // 
            cbOperator.FormattingEnabled = true;
            cbOperator.Items.AddRange(new object[] { "+", "-", "*", "/" });
            cbOperator.Location = new Point(229, 89);
            cbOperator.Name = "cbOperator";
            cbOperator.Size = new Size(66, 31);
            cbOperator.TabIndex = 3;
            // 
            // TxtBoxInput2
            // 
            TxtBoxInput2.Location = new Point(229, 130);
            TxtBoxInput2.Name = "TxtBoxInput2";
            TxtBoxInput2.Size = new Size(125, 31);
            TxtBoxInput2.TabIndex = 2;
            TxtBoxInput2.TextAlign = HorizontalAlignment.Center;
            // 
            // TxtBoxInput1
            // 
            TxtBoxInput1.Location = new Point(229, 46);
            TxtBoxInput1.Name = "TxtBoxInput1";
            TxtBoxInput1.Size = new Size(125, 31);
            TxtBoxInput1.TabIndex = 2;
            TxtBoxInput1.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 135);
            label2.Name = "label2";
            label2.Size = new Size(164, 23);
            label2.TabIndex = 1;
            label2.Text = "Second Number:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 49);
            label1.Name = "label1";
            label1.Size = new Size(153, 23);
            label1.TabIndex = 0;
            label1.Text = "First Number:";
            // 
            // FrmCalculator
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 356);
            Controls.Add(groupBox1);
            Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmCalculator";
            Text = "FrmCalculator";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private TextBox TxtBoxInput2;
        private TextBox TxtBoxInput1;
        private Label label3;
        private ComboBox cbOperator;
        private Label lblDisplayTotal;
        private Button BtnCalculate;
        private Button BtnClear;
    }
}
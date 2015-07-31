namespace DateCalculator.UI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ApplicationTabs = new System.Windows.Forms.TabControl();
            this.DifferenceTab = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.SecondDate = new System.Windows.Forms.DateTimePicker();
            this.FirstDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddSubtractDate = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Days = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.Months = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.Years = new System.Windows.Forms.NumericUpDown();
            this.Subtract = new System.Windows.Forms.RadioButton();
            this.Add = new System.Windows.Forms.RadioButton();
            this.Reset2Button = new System.Windows.Forms.Button();
            this.Calculate2Button = new System.Windows.Forms.Button();
            this.FromDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ResultedDate = new System.Windows.Forms.TextBox();
            this.ResultSummary = new DateCalculator.UI.Controls.DateCalculatorSummary();
            this.ApplicationTabs.SuspendLayout();
            this.DifferenceTab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.AddSubtractDate.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Days)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Months)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Years)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ApplicationTabs
            // 
            this.ApplicationTabs.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.ApplicationTabs.Controls.Add(this.DifferenceTab);
            this.ApplicationTabs.Controls.Add(this.AddSubtractDate);
            this.ApplicationTabs.Location = new System.Drawing.Point(6, 12);
            this.ApplicationTabs.Name = "ApplicationTabs";
            this.ApplicationTabs.SelectedIndex = 0;
            this.ApplicationTabs.Size = new System.Drawing.Size(341, 306);
            this.ApplicationTabs.TabIndex = 0;
            // 
            // DifferenceTab
            // 
            this.DifferenceTab.BackColor = System.Drawing.SystemColors.Control;
            this.DifferenceTab.Controls.Add(this.groupBox1);
            this.DifferenceTab.Controls.Add(this.ResultSummary);
            this.DifferenceTab.Location = new System.Drawing.Point(4, 25);
            this.DifferenceTab.Name = "DifferenceTab";
            this.DifferenceTab.Padding = new System.Windows.Forms.Padding(3);
            this.DifferenceTab.Size = new System.Drawing.Size(333, 277);
            this.DifferenceTab.TabIndex = 0;
            this.DifferenceTab.Text = "Calculate Age/Experience";
            this.DifferenceTab.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ResetButton);
            this.groupBox1.Controls.Add(this.CalculateButton);
            this.groupBox1.Controls.Add(this.SecondDate);
            this.groupBox1.Controls.Add(this.FirstDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 125);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Provide your inputs";
            // 
            // ResetButton
            // 
            this.ResetButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.Location = new System.Drawing.Point(130, 95);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 5;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateButton.Location = new System.Drawing.Point(211, 95);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 4;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // SecondDate
            // 
            this.SecondDate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondDate.Location = new System.Drawing.Point(86, 67);
            this.SecondDate.Name = "SecondDate";
            this.SecondDate.Size = new System.Drawing.Size(200, 22);
            this.SecondDate.TabIndex = 3;
            // 
            // FirstDate
            // 
            this.FirstDate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstDate.Location = new System.Drawing.Point(86, 30);
            this.FirstDate.Name = "FirstDate";
            this.FirstDate.Size = new System.Drawing.Size(200, 22);
            this.FirstDate.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Second Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Date:";
            // 
            // AddSubtractDate
            // 
            this.AddSubtractDate.BackColor = System.Drawing.SystemColors.Control;
            this.AddSubtractDate.Controls.Add(this.groupBox3);
            this.AddSubtractDate.Controls.Add(this.groupBox2);
            this.AddSubtractDate.Location = new System.Drawing.Point(4, 25);
            this.AddSubtractDate.Name = "AddSubtractDate";
            this.AddSubtractDate.Padding = new System.Windows.Forms.Padding(3);
            this.AddSubtractDate.Size = new System.Drawing.Size(333, 277);
            this.AddSubtractDate.TabIndex = 1;
            this.AddSubtractDate.Text = "Addition/Subtraction to Date";
            this.AddSubtractDate.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.Days);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.Months);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.Years);
            this.groupBox2.Controls.Add(this.Subtract);
            this.groupBox2.Controls.Add(this.Add);
            this.groupBox2.Controls.Add(this.Reset2Button);
            this.groupBox2.Controls.Add(this.Calculate2Button);
            this.groupBox2.Controls.Add(this.FromDate);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(16, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 189);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Provide your inputs";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Day(s):";
            // 
            // Days
            // 
            this.Days.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Days.Location = new System.Drawing.Point(86, 130);
            this.Days.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.Days.Name = "Days";
            this.Days.Size = new System.Drawing.Size(47, 22);
            this.Days.TabIndex = 12;
            this.Days.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Month(s):";
            // 
            // Months
            // 
            this.Months.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Months.Location = new System.Drawing.Point(86, 95);
            this.Months.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.Months.Name = "Months";
            this.Months.Size = new System.Drawing.Size(47, 22);
            this.Months.TabIndex = 10;
            this.Months.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Year(s):";
            // 
            // Years
            // 
            this.Years.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Years.Location = new System.Drawing.Point(86, 60);
            this.Years.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.Years.Name = "Years";
            this.Years.Size = new System.Drawing.Size(47, 22);
            this.Years.TabIndex = 8;
            this.Years.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Subtract
            // 
            this.Subtract.AutoSize = true;
            this.Subtract.Location = new System.Drawing.Point(218, 60);
            this.Subtract.Name = "Subtract";
            this.Subtract.Size = new System.Drawing.Size(68, 17);
            this.Subtract.TabIndex = 7;
            this.Subtract.Text = "Subtract";
            this.Subtract.UseVisualStyleBackColor = true;
            // 
            // Add
            // 
            this.Add.AutoSize = true;
            this.Add.Checked = true;
            this.Add.Location = new System.Drawing.Point(165, 60);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(47, 17);
            this.Add.TabIndex = 6;
            this.Add.TabStop = true;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            // 
            // Reset2Button
            // 
            this.Reset2Button.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset2Button.Location = new System.Drawing.Point(130, 160);
            this.Reset2Button.Name = "Reset2Button";
            this.Reset2Button.Size = new System.Drawing.Size(75, 23);
            this.Reset2Button.TabIndex = 5;
            this.Reset2Button.Text = "Reset";
            this.Reset2Button.UseVisualStyleBackColor = true;
            this.Reset2Button.Click += new System.EventHandler(this.Reset2Button_Click);
            // 
            // Calculate2Button
            // 
            this.Calculate2Button.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculate2Button.Location = new System.Drawing.Point(211, 160);
            this.Calculate2Button.Name = "Calculate2Button";
            this.Calculate2Button.Size = new System.Drawing.Size(75, 23);
            this.Calculate2Button.TabIndex = 4;
            this.Calculate2Button.Text = "Calculate";
            this.Calculate2Button.UseVisualStyleBackColor = true;
            this.Calculate2Button.Click += new System.EventHandler(this.Calculate2Button_Click);
            // 
            // FromDate
            // 
            this.FromDate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromDate.Location = new System.Drawing.Point(86, 30);
            this.FromDate.Name = "FromDate";
            this.FromDate.Size = new System.Drawing.Size(200, 22);
            this.FromDate.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "From Date:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ResultedDate);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(16, 198);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(307, 73);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Results";
            // 
            // ResultedDate
            // 
            this.ResultedDate.Enabled = false;
            this.ResultedDate.Location = new System.Drawing.Point(15, 29);
            this.ResultedDate.Name = "ResultedDate";
            this.ResultedDate.Size = new System.Drawing.Size(276, 22);
            this.ResultedDate.TabIndex = 0;
            this.ResultedDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ResultSummary
            // 
            this.ResultSummary.AutoSize = true;
            this.ResultSummary.BackColor = System.Drawing.SystemColors.Control;
            this.ResultSummary.Location = new System.Drawing.Point(16, 141);
            this.ResultSummary.Name = "ResultSummary";
            this.ResultSummary.Results = null;
            this.ResultSummary.Size = new System.Drawing.Size(307, 129);
            this.ResultSummary.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 330);
            this.Controls.Add(this.ApplicationTabs);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Date Calculator";
            this.ApplicationTabs.ResumeLayout(false);
            this.DifferenceTab.ResumeLayout(false);
            this.DifferenceTab.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.AddSubtractDate.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Days)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Months)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Years)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ApplicationTabs;
        private System.Windows.Forms.TabPage DifferenceTab;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.DateTimePicker SecondDate;
        private System.Windows.Forms.DateTimePicker FirstDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DateCalculator.UI.Controls.DateCalculatorSummary ResultSummary;
        private System.Windows.Forms.TabPage AddSubtractDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Reset2Button;
        private System.Windows.Forms.Button Calculate2Button;
        private System.Windows.Forms.DateTimePicker FromDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton Subtract;
        private System.Windows.Forms.RadioButton Add;
        private System.Windows.Forms.NumericUpDown Years;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown Days;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown Months;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox ResultedDate;


    }
}
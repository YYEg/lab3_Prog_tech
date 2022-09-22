namespace lab3_Prog_tech
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtSecond = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.cmbOperation = new System.Windows.Forms.ComboBox();
            this.cmbFirstType = new System.Windows.Forms.ComboBox();
            this.cmbSecondType = new System.Windows.Forms.ComboBox();
            this.cmbResultType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(288, 92);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(100, 22);
            this.txtFirst.TabIndex = 0;
            this.txtFirst.TextChanged += new System.EventHandler(this.onValueChanged);
            // 
            // txtSecond
            // 
            this.txtSecond.Location = new System.Drawing.Point(288, 144);
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.Size = new System.Drawing.Size(100, 22);
            this.txtSecond.TabIndex = 1;
            this.txtSecond.TextChanged += new System.EventHandler(this.onValueChanged);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(146, 193);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(207, 22);
            this.txtResult.TabIndex = 2;
            // 
            // cmbOperation
            // 
            this.cmbOperation.FormattingEnabled = true;
            this.cmbOperation.Items.AddRange(new object[] {
            "+",
            "-"});
            this.cmbOperation.Location = new System.Drawing.Point(128, 121);
            this.cmbOperation.Name = "cmbOperation";
            this.cmbOperation.Size = new System.Drawing.Size(121, 24);
            this.cmbOperation.TabIndex = 3;
            this.cmbOperation.Text = "+";
            this.cmbOperation.SelectedIndexChanged += new System.EventHandler(this.cmbOperation_SelectedIndexChanged);
            // 
            // cmbFirstType
            // 
            this.cmbFirstType.FormattingEnabled = true;
            this.cmbFirstType.Location = new System.Drawing.Point(409, 89);
            this.cmbFirstType.Name = "cmbFirstType";
            this.cmbFirstType.Size = new System.Drawing.Size(121, 24);
            this.cmbFirstType.TabIndex = 4;
            this.cmbFirstType.SelectedIndexChanged += new System.EventHandler(this.onValueChanged);
            // 
            // cmbSecondType
            // 
            this.cmbSecondType.FormattingEnabled = true;
            this.cmbSecondType.Location = new System.Drawing.Point(409, 141);
            this.cmbSecondType.Name = "cmbSecondType";
            this.cmbSecondType.Size = new System.Drawing.Size(121, 24);
            this.cmbSecondType.TabIndex = 5;
            this.cmbSecondType.SelectedIndexChanged += new System.EventHandler(this.onValueChanged);
            // 
            // cmbResultType
            // 
            this.cmbResultType.FormattingEnabled = true;
            this.cmbResultType.Location = new System.Drawing.Point(409, 190);
            this.cmbResultType.Name = "cmbResultType";
            this.cmbResultType.Size = new System.Drawing.Size(121, 24);
            this.cmbResultType.TabIndex = 6;
            this.cmbResultType.SelectedIndexChanged += new System.EventHandler(this.onValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbResultType);
            this.Controls.Add(this.cmbSecondType);
            this.Controls.Add(this.cmbFirstType);
            this.Controls.Add(this.cmbOperation);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtSecond);
            this.Controls.Add(this.txtFirst);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtSecond;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.ComboBox cmbOperation;
        private System.Windows.Forms.ComboBox cmbFirstType;
        private System.Windows.Forms.ComboBox cmbSecondType;
        private System.Windows.Forms.ComboBox cmbResultType;
    }
}


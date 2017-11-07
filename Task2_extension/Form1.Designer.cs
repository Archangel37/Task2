namespace Task2_extension
{
    partial class FormExtension
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_Input = new System.Windows.Forms.TextBox();
            this.button_convert = new System.Windows.Forms.Button();
            this.richTextBox_output = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // textBox_Input
            // 
            this.textBox_Input.Location = new System.Drawing.Point(49, 41);
            this.textBox_Input.Name = "textBox_Input";
            this.textBox_Input.Size = new System.Drawing.Size(330, 20);
            this.textBox_Input.TabIndex = 0;
            // 
            // button_convert
            // 
            this.button_convert.Location = new System.Drawing.Point(435, 37);
            this.button_convert.Name = "button_convert";
            this.button_convert.Size = new System.Drawing.Size(75, 23);
            this.button_convert.TabIndex = 1;
            this.button_convert.Text = "Convert";
            this.button_convert.UseVisualStyleBackColor = true;
            this.button_convert.Click += new System.EventHandler(this.button_convert_Click);
            // 
            // richTextBox_output
            // 
            this.richTextBox_output.Location = new System.Drawing.Point(12, 106);
            this.richTextBox_output.Name = "richTextBox_output";
            this.richTextBox_output.Size = new System.Drawing.Size(750, 447);
            this.richTextBox_output.TabIndex = 2;
            this.richTextBox_output.Text = "";
            // 
            // Form_extension
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 565);
            this.Controls.Add(this.richTextBox_output);
            this.Controls.Add(this.button_convert);
            this.Controls.Add(this.textBox_Input);
            this.Name = "FormExtension";
            this.Text = "Convert DateTime to Words";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Input;
        private System.Windows.Forms.Button button_convert;
        private System.Windows.Forms.RichTextBox richTextBox_output;
    }
}


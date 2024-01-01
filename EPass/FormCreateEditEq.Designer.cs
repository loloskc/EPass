namespace EPass
{
    partial class FormCreateEditEq
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
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            label3 = new Label();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(514, 37);
            label2.Name = "label2";
            label2.Size = new Size(71, 21);
            label2.TabIndex = 10;
            label2.Text = "Модель";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(225, 43);
            label1.Name = "label1";
            label1.Size = new Size(85, 21);
            label1.TabIndex = 9;
            label1.Text = "Названия";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(316, 29);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(192, 35);
            textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(12, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(192, 35);
            textBox1.TabIndex = 7;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(771, 159);
            button1.Name = "button1";
            button1.Size = new Size(135, 29);
            button1.TabIndex = 6;
            button1.Text = "Подтвердить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(825, 37);
            label3.Name = "label3";
            label3.Size = new Size(105, 21);
            label3.TabIndex = 12;
            label3.Text = "Инв. Номер";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(627, 29);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(192, 35);
            textBox3.TabIndex = 11;
            // 
            // FormCreateEditEq
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 216);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "FormCreateEditEq";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCreateEditEq";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
        private Label label3;
        private TextBox textBox3;
    }
}
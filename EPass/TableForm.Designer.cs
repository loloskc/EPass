namespace EPass
{
    partial class TableForm
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
            groupBox1 = new GroupBox();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button4 = new Button();
            label1 = new Label();
            comboBox1 = new ComboBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            button3 = new Button();
            button1 = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            label6 = new Label();
            button5 = new Button();
            button6 = new Button();
            button2 = new Button();
            button7 = new Button();
            groupBox1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button10);
            groupBox1.Controls.Add(button9);
            groupBox1.Controls.Add(button8);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Location = new Point(0, -13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(279, 936);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button10
            // 
            button10.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button10.Location = new Point(23, 310);
            button10.Name = "button10";
            button10.Size = new Size(209, 57);
            button10.TabIndex = 5;
            button10.Text = "Запрос по ФИО заведующего";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button9.Location = new Point(23, 224);
            button9.Name = "button9";
            button9.Size = new Size(209, 59);
            button9.TabIndex = 4;
            button9.Text = "Запрос по номер лаборатории";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(23, 149);
            button8.Name = "button8";
            button8.Size = new Size(209, 48);
            button8.TabIndex = 3;
            button8.Text = "Запрос по адресу";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(45, 877);
            button4.Name = "button4";
            button4.Size = new Size(159, 30);
            button4.TabIndex = 2;
            button4.Text = "Применить";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 28);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 1;
            label1.Text = "Таблица";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Паспорта", "Заведующие" });
            comboBox1.Location = new Point(23, 52);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(166, 29);
            comboBox1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Location = new Point(285, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1302, 858);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1284, 70);
            panel1.TabIndex = 0;
            panel1.Visible = false;
            panel1.Click += panel1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1092, 12);
            button3.Name = "button3";
            button3.Size = new Size(111, 43);
            button3.TabIndex = 6;
            button3.Text = "Редактировать";
            button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(1209, 12);
            button1.Name = "button1";
            button1.Size = new Size(60, 43);
            button1.TabIndex = 5;
            button1.Text = "Удалить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(909, 18);
            label5.Name = "label5";
            label5.Size = new Size(155, 30);
            label5.TabIndex = 4;
            label5.Text = "Заведующий лаборатории\r\nФИО\r\n";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(393, 18);
            label4.Name = "label4";
            label4.Size = new Size(116, 30);
            label4.TabIndex = 3;
            label4.Text = "Адрес лаборатории\r\nадрес\r\n";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 18);
            label3.Name = "label3";
            label3.Size = new Size(121, 30);
            label3.TabIndex = 2;
            label3.Text = "Номер лаборатории\r\nномер";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(205, 18);
            label2.Name = "label2";
            label2.Size = new Size(135, 30);
            label2.TabIndex = 1;
            label2.Text = "Название лаборатории\r\nимя\r\n";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label6);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button6);
            panel2.Location = new Point(3, 79);
            panel2.Name = "panel2";
            panel2.Size = new Size(1284, 70);
            panel2.TabIndex = 1;
            panel2.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(20, 9);
            label6.Name = "label6";
            label6.Size = new Size(504, 46);
            label6.TabIndex = 7;
            label6.Text = "Демидов Денис Михайлович";
            // 
            // button5
            // 
            button5.Location = new Point(1092, 12);
            button5.Name = "button5";
            button5.Size = new Size(111, 43);
            button5.TabIndex = 6;
            button5.Text = "Редактировать";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(1209, 12);
            button6.Name = "button6";
            button6.Size = new Size(60, 43);
            button6.TabIndex = 5;
            button6.Text = "Удалить";
            button6.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(128, 255, 128);
            button2.Location = new Point(1363, 876);
            button2.Name = "button2";
            button2.Size = new Size(209, 34);
            button2.TabIndex = 2;
            button2.Text = "Добавить запись";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(128, 255, 128);
            button7.Location = new Point(1198, 876);
            button7.Name = "button7";
            button7.Size = new Size(209, 34);
            button7.TabIndex = 3;
            button7.Text = "Добавить запись";
            button7.UseVisualStyleBackColor = false;
            button7.Visible = false;
            button7.Click += button7_Click;
            // 
            // TableForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1584, 922);
            Controls.Add(button7);
            Controls.Add(button2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TableForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TableForm";
            FormClosing += TableForm_FormClosing;
            Load += TableForm_Load;
            SizeChanged += TableForm_SizeChanged;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private ComboBox comboBox1;
        private Button button4;
        private Panel panel2;
        private Button button5;
        private Button button6;
        private Label label6;
        private Button button7;
        private Button button10;
        private Button button9;
        private Button button8;
    }
}
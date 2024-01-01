namespace EPass
{
    partial class ViewEq
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            button4 = new Button();
            button3 = new Button();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Location = new Point(12, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1081, 380);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1063, 47);
            panel1.TabIndex = 0;
            panel1.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(578, 12);
            label3.Name = "label3";
            label3.Size = new Size(115, 26);
            label3.TabIndex = 5;
            label3.Text = "Ин. Номер";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(267, 11);
            label2.Name = "label2";
            label2.Size = new Size(84, 26);
            label2.TabIndex = 4;
            label2.Text = "Модель";
            // 
            // button2
            // 
            button2.Location = new Point(976, 11);
            button2.Name = "button2";
            button2.Size = new Size(84, 27);
            button2.TabIndex = 3;
            button2.Text = "удалить";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(858, 10);
            button1.Name = "button1";
            button1.Size = new Size(112, 27);
            button1.TabIndex = 2;
            button1.Text = "редактировать";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(13, 11);
            label1.Name = "label1";
            label1.Size = new Size(101, 26);
            label1.TabIndex = 0;
            label1.Text = "Название";
            // 
            // button4
            // 
            button4.Location = new Point(857, 415);
            button4.Name = "button4";
            button4.Size = new Size(108, 23);
            button4.TabIndex = 3;
            button4.Text = "Обновить";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(985, 415);
            button3.Name = "button3";
            button3.Size = new Size(108, 23);
            button3.TabIndex = 4;
            button3.Text = "Добавить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // ViewEq
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1105, 450);
            Controls.Add(button3);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(button4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ViewEq";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewEq";
            Load += ViewEq_Load;
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Button button2;
        private Button button1;
        private Label label1;
        private Label label3;
        private Label label2;
        private Button button4;
        private Button button3;
    }
}
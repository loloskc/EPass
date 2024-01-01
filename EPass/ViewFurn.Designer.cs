namespace EPass
{
    partial class ViewFurn
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
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            button3 = new Button();
            button4 = new Button();
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
            flowLayoutPanel1.Size = new Size(912, 380);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(883, 47);
            panel1.TabIndex = 0;
            panel1.Visible = false;
            // 
            // button2
            // 
            button2.Location = new Point(796, 10);
            button2.Name = "button2";
            button2.Size = new Size(84, 27);
            button2.TabIndex = 3;
            button2.Text = "удалить";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(678, 10);
            button1.Name = "button1";
            button1.Size = new Size(112, 27);
            button1.TabIndex = 2;
            button1.Text = "редактировать";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(517, 10);
            label2.Name = "label2";
            label2.Size = new Size(139, 26);
            label2.TabIndex = 1;
            label2.Text = "Количество: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(13, 11);
            label1.Name = "label1";
            label1.Size = new Size(65, 26);
            label1.TabIndex = 0;
            label1.Text = "Имя: ";
            label1.Click += label1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(804, 415);
            button3.Name = "button3";
            button3.Size = new Size(108, 23);
            button3.TabIndex = 1;
            button3.Text = "Добавить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(674, 415);
            button4.Name = "button4";
            button4.Size = new Size(108, 23);
            button4.TabIndex = 2;
            button4.Text = "Обновить";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // ViewFurn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(flowLayoutPanel1);
            Name = "ViewFurn";
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
        private Label label1;
        private Label label2;
        private Button button2;
        private Button button1;
        private Button button3;
        private Button button4;
    }
}
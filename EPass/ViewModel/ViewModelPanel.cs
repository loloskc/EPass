using EPass.Data;
using EPass.Data.Enum;
using EPass.Models;
using EPass.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPass.ViewModel
{
    public class ViewModelPanel
    {
        public ViewModelPanel(PassLab pass,string res) 
        {
            Pass = pass;
            Responsibly = res;
        }
        private PassLab Pass { get; set; }
        public string Responsibly { get; set; }
        public Panel panel { get; set; }
        
        public Panel CreatePanel()
        {
            Panel panel = new Panel();
            this.panel = panel;
            panel.BorderStyle = BorderStyle.FixedSingle;
            //panel.Controls.Add(labelId());
            panel.Controls.Add(labelName());
            panel.Controls.Add(labelNum());
            panel.Controls.Add(labelAddress());
            panel.Controls.Add(labelResponsibly());
            panel.Controls.Add(DelButton());
            panel.Controls.Add(EditButton());
            panel.Size = new Size(1284, 70);
            panel.Click += Panel_Click;
            return panel;
        }

        private void Panel_Click(object? sender, EventArgs e)
        {
            using(ApplicationDbContext context = new ApplicationDbContext())
            {
                ViewPass form = new ViewPass(Pass,context);
                form.Show();
            }
        }

        public Label labelId()
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Location = new Point(34, 18);
            label.Size = new Size(17, 30);
            label.TabIndex = 0;
            label.Text = "Id\r\n" +Pass.Id;
            label.TextAlign = ContentAlignment.MiddleCenter;
            return label;
        }

        public Label labelName()
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Location = new Point(205, 18);
            label.Size = new Size(135, 30);
            label.TabIndex = 1;
            label.Text = "Название лаборатории\r\n"+Pass.NameLab;
            label.TextAlign = ContentAlignment.MiddleCenter;
            return label;
        }

        public Label labelNum()
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Location = new Point(32, 18);
            label.Size = new Size(121, 30);
            label.TabIndex = 2;
            label.Text = "Номер лаборатории\r\n"+Pass.NumLab.ToString();
            label.TextAlign = ContentAlignment.MiddleCenter;
            return label;
        }

        public Label labelAddress()
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Location = new Point(393, 18);
            label.Size = new Size(116, 30);
            label.TabIndex = 3;
            label.Text = "Адрес лаборатории\r\n"+Pass.AddressLab.ToString();
            label.TextAlign = ContentAlignment.MiddleCenter;
            return label;
        }

        public Label labelResponsibly()
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Location = new Point(909, 18);
            label.Size = new Size(155, 30);
            label.TabIndex = 4;
            label.Text = "Заведующий лаборатории\r\n"+Responsibly.ToString();
            label.TextAlign = ContentAlignment.MiddleCenter;
            return label;
        }

        public Button DelButton()
        {
            Button button = new Button();
            button.Size = new Size(60, 43);
            button.Text = "Удалить";
            button.UseVisualStyleBackColor = true;
            button.Location = new Point(1209, 12);
            button.Click += button1_Click;
            return button;
        }

        public Button EditButton()
        {
            Button button = new Button();
            button.Size = new Size(111, 43);
            button.Text = "Редактировать";
            button.UseVisualStyleBackColor= true;
            button.Location = new Point(1092, 12);
            button.Click += button2_Click;
            return button;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using(ApplicationDbContext db = new ApplicationDbContext())
            {
                PassRepository passRepository = new PassRepository(db);
                passRepository.Delete(Pass);
                this.panel.Dispose();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using(ApplicationDbContext db = new ApplicationDbContext())
            {
                PassRepository pass = new PassRepository(db);
                FormCreateEditPass form = new FormCreateEditPass(db,pass.GetById(Pass.Id));
                form.ShowDialog();

            }
            
        }

    }
}

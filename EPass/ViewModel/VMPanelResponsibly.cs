using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPass.Data;
using EPass.Models;
using EPass.Repository;

namespace EPass.ViewModel
{
    public class VMPanelResponsibly
    {
        private Responsible Responsible { get; set; }
        private Panel panel {  get; set; }
        private readonly ResponsiblyRepository resRepository;

        public VMPanelResponsibly(Responsible res, ResponsiblyRepository resRepos)
        {
            Responsible = res;
            panel = new Panel();
            resRepository = resRepos;
        }

        public Panel CreatePanel()
        {
            Panel panel = new Panel();
            this.panel = panel;
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Controls.Add(Responsibly());
            panel.Controls.Add(DelButton());
            panel.Controls.Add(EditButton());
            panel.Size = new Size(1284, 70);
            return panel;
        }

        public Label Responsibly()
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Font = new Font("Times New Roman", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label.Location = new Point(20, 9);
            label.Size = new Size(504, 46);
            label.Text = Responsible.FIO;
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
            button.UseVisualStyleBackColor = true;
            button.Location = new Point(1092, 12);
            button.Click += button2_Click;
            return button;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resRepository.Delete(Responsible);
            this.panel.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                FormCreateEditRepository form = new FormCreateEditRepository(db, resRepository.GetById(Responsible.Id));
                form.ShowDialog();

            }
        }

    }
}

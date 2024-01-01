using EPass.Data;
using EPass.Models;
using EPass.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPass.ViewModel
{
    
    public class ViewModelEq
    {
        private readonly Equipment eq;
        private readonly ApplicationDbContext context;
        private Panel panel;

        public ViewModelEq(Equipment eq, ApplicationDbContext context)
        {
            this.eq = eq;
            this.context = context;
        }

        public Panel CreatePanel()
        {
            Panel panel = new Panel();
            this.panel = panel;
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Controls.Add(labelInventory());
            panel.Controls.Add(labelName());
            panel.Controls.Add(labelModel());
            panel.Controls.Add(DelButton());
            panel.Controls.Add(EditButton());
            panel.Size = new Size(1063, 47);
            return panel;
        }

        public Label labelName()
        {
            Label label = new Label();
            label.Text = "Название: " + eq.Name;
            label.AutoSize = true;
            label.Font = new Font("Times New Roman", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
            label.Location = new Point(13, 11);
            return label;
        }

        public Label labelModel()
        {
            Label label = new Label();
            label.Font = new Font("Times New Roman", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
            label.Text = "Модель " + eq.Model;
            label.AutoSize = true;
            label.Location = new Point(267,11);
            return label;
        }

        public Label labelInventory()
        {
            Label label = new Label();
            label.Font = new Font("Times New Roman", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
            label.AutoSize= true;
            label.Text = "Ин. Номер" + eq.InventoryNum.ToString();
            label.Location = new Point(578, 11);
            return label;
        }

        public Button DelButton()
        {
            Button button = new Button();
            button.Location = new Point(976, 11);
            button.Text = "Удалить";
            button.UseVisualStyleBackColor = true;
            button.Size = new Size(84, 27);
            button.Click += Button_Click;
            return button;
        }

        private void Button_Click(object? sender, EventArgs e)
        {
            using (ApplicationDbContext db = new ApplicationDbContext()) 
            {
                this.panel.Dispose();
                EqRepository eqRepository = new EqRepository(db);
                eqRepository.Delete(eq);
            }
        }

        public Button EditButton()
        {
            Button button = new Button();
            button.Location = new Point(858, 10);
            button.Size = new Size(112, 27);
            button.Text = "Редактировать";
            button.UseVisualStyleBackColor = true;
            button.Click += Button2_Click;
            return button;
        }

        private void Button2_Click(object? sender, EventArgs e)
        {
            using(ApplicationDbContext db = new ApplicationDbContext())
            {
                PassRepository passRepository = new PassRepository(db);
                var pass = passRepository.GetById(eq.passLabId);
                FormCreateEditEq form = new FormCreateEditEq(pass, db, eq);
                form.ShowDialog();
            }
        }
    }
}

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
    public class ViewModeFurn
    {
        private readonly Furniture furniture;
        private readonly ApplicationDbContext context;
        private Panel panel;
        public ViewModeFurn(Furniture furniture,ApplicationDbContext context) 
        {
            this.context = context;
            this.furniture = furniture;
        }

        public Panel CreatPanel()
        {
            Panel panel = new Panel();
            this.panel = panel;
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Controls.Add(labelCount());
            panel.Controls.Add(labelName());
            panel.Controls.Add(DelButton());
            panel.Controls.Add(EditButton());
            panel.Size = new Size(883, 47);
            return panel;
        } 

        public Label labelName()
        {
            Label label = new Label();
            label.Text = "Имя: "+ furniture.Name;
            label.AutoSize = true;
            label.Font = new Font("Times New Roman", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
            label.Location = new Point(13, 11);
            label.Size = new Size(65, 26);
            return label;
        }

        public Label labelCount()
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Font = new Font("Times New Roman", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
            label.Location = new Point(489, 11);
            label.Size = new Size(139, 26);
            label.Text = "Количество: "+furniture.Quantity;
            return label;
        }

        public Button DelButton()
        {
            Button button = new Button();
            button.Size = new Size(84, 27);
            button.Location = new Point(796, 10);
            button.Text = "Удалить";
            button.UseVisualStyleBackColor = true;
            button.Click += Button_Click;
            return button;
        }

        private void Button_Click(object? sender, EventArgs e)
        {
            
           using(var db =new ApplicationDbContext())
            {
                this.panel.Dispose();
                FurnRepository furnRepository = new FurnRepository(db);
                furnRepository.Delete(furniture);
            }

        }

        public Button EditButton()
        {
            Button button = new Button();
            button.Size = new Size(112, 27);
            button.Location = new Point(678, 10);
            button.Text = "Редактировать";
            button.UseVisualStyleBackColor = true;
            button.Click += Button2_Click;
            return button;
        }

        private void Button2_Click(object? sender, EventArgs e)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                PassRepository passRepository = new PassRepository(db);
                var pass = passRepository.GetById(furniture.passLabId);
                FormCreateEditFurn form = new FormCreateEditFurn(pass, db, furniture);
                form.ShowDialog();
            }
        }
    }
}

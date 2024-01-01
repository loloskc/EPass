using EPass.Data;
using EPass.Models;
using EPass.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EPass
{
    public partial class ViewEq : Form
    {
        private readonly ApplicationDbContext context;
        private readonly PassLab pass;
        private VMRepository vmPanel;
        public ViewEq(ApplicationDbContext context, PassLab pass)
        {
            InitializeComponent();
            this.context = context;
            this.pass = pass;
            vmPanel = new VMRepository(flowLayoutPanel1);
        }

        private void ViewEq_Load(object sender, EventArgs e)
        {
            vmPanel.LoadFielEq(pass);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            vmPanel.LoadFielEq(pass);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using(ApplicationDbContext db = new ApplicationDbContext())
            {
                FormCreateEditEq formCreate = new FormCreateEditEq(pass, db);
                formCreate.ShowDialog();
                if (formCreate.GetEquipment() != null)
                {
                    ViewModelEq vmModel = new ViewModelEq(formCreate.GetEquipment(), db);
                    flowLayoutPanel1.Controls.Add(vmModel.CreatePanel());
                }
            }
           
        }
    }
}

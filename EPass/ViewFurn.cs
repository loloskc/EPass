using EPass.Data;
using EPass.Models;
using EPass.Repository;
using EPass.ViewModel;
using Microsoft.EntityFrameworkCore;
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
    public partial class ViewFurn : Form
    {
        private readonly ApplicationDbContext context;
        private readonly PassLab pass;
        private VMRepository vmPanel;
        public ViewFurn(ApplicationDbContext context, PassLab pass)
        {
            InitializeComponent();
            this.context = context;
            this.pass = pass;
            vmPanel = new VMRepository(flowLayoutPanel1);
        }

        private void ViewEq_Load(object sender, EventArgs e)
        {
            vmPanel.LoadFieldFurn(pass);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            using (var context = new ApplicationDbContext())
            {
                FormCreateEditFurn formCreate = new FormCreateEditFurn(pass, context);
                formCreate.ShowDialog();
                if (formCreate.GetFurniture() != null)
                {
                    ViewModeFurn vmModel = new ViewModeFurn(formCreate.GetFurniture(), context);
                    flowLayoutPanel1.Controls.Add(vmModel.CreatPanel());
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            vmPanel.LoadFieldFurn(pass);
        }
    }
}

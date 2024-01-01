using EPass.Data;
using EPass.Models;
using EPass.Repository;
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
    public partial class FormCreateEditRepository : Form
    {
        private readonly ResponsiblyRepository resRepository;
        private readonly ApplicationDbContext context;
        private readonly Responsible responsible;
        private readonly bool stateEdit = false;
        public FormCreateEditRepository(ApplicationDbContext context)
        {
            InitializeComponent();
            resRepository = new ResponsiblyRepository(context);
            this.context = context;
            responsible = new Responsible();
        }

        public FormCreateEditRepository(ApplicationDbContext context, Responsible responsible)
        {
            InitializeComponent();
            resRepository = new ResponsiblyRepository(context);
            this.context = context;
            this.responsible = responsible;
            textBox1.Text = responsible.FIO;
            stateEdit = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            responsible.FIO = textBox1.Text;
            if (!stateEdit) resRepository.Add(responsible);
            else resRepository.Update(responsible);
            this.Close();
        }
    }
}

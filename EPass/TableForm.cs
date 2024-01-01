using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EPass.Data;
using EPass.Models;
using EPass.Repository;
using EPass.ViewModel;

namespace EPass
{
    public partial class TableForm : Form
    {
        private readonly PassRepository passRepository;
        private readonly ResponsiblyRepository resRepository;
        private readonly ApplicationDbContext context;
        private readonly Form MainForm;
        private readonly VMRepository vmRepository;

        public TableForm(ApplicationDbContext context, Form form)
        {
            InitializeComponent();
            passRepository = new PassRepository(context);
            resRepository = new ResponsiblyRepository(context);
            this.context = context;
            MainForm = form;
            vmRepository = new VMRepository(flowLayoutPanel1, passRepository, resRepository);
        }

        public async void TableForm_Load(object sender, EventArgs e)
        {
            vmRepository.LoadFieldPass();
            comboBox1.SelectedIndex = 0;
        }



        private void TableForm_SizeChanged(object sender, EventArgs e)
        {
            groupBox1.Height = this.Height;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormCreateEditPass form = new FormCreateEditPass(context);
            form.ShowDialog();
            vmRepository.LoadFieldPass();
        }

        private void TableForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            MainForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                vmRepository.LoadFieldPass();
                button2.Visible = true;
                button7.Visible = false;

            }
            if (comboBox1.SelectedIndex == 1)
            {
                vmRepository.LoadFieldResponsibly();
                button2.Visible = false;
                button7.Visible = true;
            }
            if (comboBox1.SelectedIndex != 0 && comboBox1.SelectedIndex != 1)
            {
                Label errorLabel = new Label()
                {
                    Text = "Ошибка неверная таблица"
                };
                MyMessageBox errorForm = new MyMessageBox(errorLabel);
                errorForm.ShowDialog();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormCreateEditRepository formCreateEditRepository = new FormCreateEditRepository(context);
            formCreateEditRepository.ShowDialog();
            vmRepository.LoadFieldResponsibly();
        }


        private void panel1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            ChoiceAddress form = new ChoiceAddress();
            form.ShowDialog();
            try
            {
                int choice = form.GetAddress();
                vmRepository.LoadFieldPassByAddres(choice);
            }
            catch { }


        }

        private void button9_Click(object sender, EventArgs e)
        {
            ChoiceNum form = new ChoiceNum();
            form.ShowDialog();
            try
            {
                int choice = form.GetNum();
                vmRepository.LoadFieldPassByNum(choice);
            }
            catch { }
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ChoiceRespon form = new ChoiceRespon(context);
            form.ShowDialog();
            try
            {
                int choice = form.GetResponsible();
                vmRepository.LoadFieldPassByFIO(choice);
            }
            catch { }
            
        }
    }
}

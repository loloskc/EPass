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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EPass
{
    public partial class ChoiceRespon : Form
    {
        private readonly ApplicationDbContext context;
        private readonly ResponsiblyRepository responsiblyRepository;
        public ChoiceRespon(ApplicationDbContext context)
        {
            InitializeComponent();
            this.context = context;
            responsiblyRepository = new ResponsiblyRepository(context);
        }

        private void ChoiceRespon_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(responsiblyRepository.GetAllFio().ToArray());
        }
        public int GetResponsible()
        {
            try
            {
                return responsiblyRepository.GetIdByFio(comboBox1.Text);
            }
            catch { return 0; }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                Label label = new Label();
                label.Text = "Выберите ФИО";
                MyMessageBox form = new MyMessageBox(label);
                form.ShowDialog();
            }
            else
            {
                this.Close();
            }
        }
    }
}

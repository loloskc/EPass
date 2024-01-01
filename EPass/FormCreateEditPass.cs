using EPass.Data;
using EPass.Data.Enum;
using EPass.Models;
using EPass.Repository;
using System;
using System.Collections;
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
    public partial class FormCreateEditPass : Form
    {
        private readonly PassRepository passRepository;
        private readonly ResponsiblyRepository resRepository;
        private readonly ApplicationDbContext context;
        private readonly PassLab passLab;
        private readonly bool stateEdit = false;
        public FormCreateEditPass(ApplicationDbContext context)
        {
            InitializeComponent();
            passRepository = new PassRepository(context);
            resRepository = new ResponsiblyRepository(context);
            this.context = context;
            passLab = new PassLab();
        }

        public FormCreateEditPass(ApplicationDbContext context, PassLab pass)
        {
            InitializeComponent();
            passRepository = new PassRepository(context);
            resRepository = new ResponsiblyRepository(context);
            this.context = context;
            textBox1.Text = pass.NumLab.ToString();
            textBox2.Text = pass.NameLab.ToString();
            comboBox1.Text = pass.AddressLab.ToString();
            comboBox2.Text = resRepository.GetFioResponsiblyById(pass.ResponsibleId);
            stateEdit = true;
            passLab = pass;
        }

        private async void FormCreateEditPass_Load(object sender, EventArgs e)
        {
            string[] adressStr = { Address.Lenina.ToString(), Address.Construction.ToString() };
            comboBox1.Items.AddRange(adressStr);
            comboBox2.Items.AddRange(resRepository.GetAllFio().ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            passLab.NameLab = textBox2.Text;
            int.TryParse(textBox1.Text, out int val);
            passLab.NumLab = val;
            passLab.ResponsibleId = resRepository.GetIdByFio(comboBox2.Text);

            if (comboBox1.Text == "Lenina") passLab.AddressLab = Address.Lenina;
            else passLab.AddressLab = Address.Construction;

            if (!stateEdit) passRepository.Add(passLab);
            else passRepository.Update(passLab);


            this.Close();


        }
    }
}

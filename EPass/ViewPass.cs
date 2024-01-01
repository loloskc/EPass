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
    public partial class ViewPass : Form
    {
        private readonly ApplicationDbContext context;
        private readonly PassRepository passRepository;
        private readonly ResponsiblyRepository responsiblyRepository;
        private readonly PassLab pass;

        public ViewPass(PassLab pass, ApplicationDbContext context)
        {
            InitializeComponent();
            this.context = context;
            passRepository = new PassRepository(context);
            responsiblyRepository = new ResponsiblyRepository(context);
            label2.Text += pass.NameLab;
            label3.Text += pass.NumLab;
            label4.Text += responsiblyRepository.GetFioResponsiblyById(pass.ResponsibleId);
            label5.Text += pass.AddressLab.ToString();
            this.pass = pass;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewEq form = new ViewEq(context, pass);
            form.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewFurn form = new ViewFurn(context, pass);
            form.ShowDialog();
        }
    }
}

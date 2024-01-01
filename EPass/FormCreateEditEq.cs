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
    public partial class FormCreateEditEq : Form
    {
        private readonly ApplicationDbContext _context;
        private bool _isEditing = false;
        private readonly Equipment _equipment;
        private PassLab pass;
        public FormCreateEditEq(PassLab pass, ApplicationDbContext context)
        {
            InitializeComponent();
            this.pass = pass;
            _context = context;
            _equipment = new Equipment();
        }
        public FormCreateEditEq(PassLab pass, ApplicationDbContext context, Equipment equipment)
        {
            InitializeComponent();
            this.pass = pass;
            _context = context;
            _equipment = equipment;
            _isEditing = true;
            textBox1.Text = _equipment.Name;
            textBox2.Text = _equipment.Model;
            textBox3.Text = _equipment.InventoryNum.ToString();
        }

        public Equipment GetEquipment() => _equipment;

        private void button1_Click(object sender, EventArgs e)
        {
            _equipment.passLabId = pass.Id;
            int.TryParse(textBox3.Text, out int val);
            _equipment.Name = textBox1.Text;
            _equipment.Model = textBox2.Text;
            _equipment.InventoryNum = val;
            EqRepository eqRepository = new EqRepository(_context);
            if (!_isEditing) eqRepository.Add(_equipment);
            else eqRepository.Update(_equipment);
            this.Close();
        }
    }
}

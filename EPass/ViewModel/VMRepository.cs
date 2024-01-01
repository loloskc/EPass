using EPass.Data;
using EPass.Models;
using EPass.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EPass.ViewModel
{
    public class VMRepository
    {
        private readonly FlowLayoutPanel field;
        private readonly PassRepository? passRepository;
        private readonly ResponsiblyRepository? resRepository;

        public VMRepository(FlowLayoutPanel field, PassRepository pass, ResponsiblyRepository res)
        {
            this.field = field;
            this.passRepository = pass;
            this.resRepository = res;
        }

        public VMRepository(FlowLayoutPanel field)
        {
            this.field = field;
        }


        public void ClearField()
        {
            field.Controls.Clear();
        }

        public async void LoadFieldPass()
        {
            ClearField();
            IEnumerable<PassLab> passLabs = await passRepository.GetAll();
            foreach (PassLab passLab in passLabs)
            {
                ViewModelPanel panelVM = new ViewModelPanel(passLab, resRepository.GetFioResponsiblyById(passLab.ResponsibleId));
                field.Controls.Add(panelVM.CreatePanel());
            }
        }
        public void LoadFieldPassByAddres(int address)
        {
            ClearField();
            IEnumerable<PassLab> passLabs = passRepository.GetPassLabsByAddress(address);
            foreach(PassLab passLab in passLabs)
            {
                ViewModelPanel panelVM = new ViewModelPanel(passLab, resRepository.GetFioResponsiblyById(passLab.ResponsibleId));
                field.Controls.Add(panelVM.CreatePanel());
            }
        }

        public void LoadFieldPassByNum(int num) 
        {
            ClearField();
            IEnumerable<PassLab> passLabs = passRepository.GetPassLabsByNum(num);
            foreach (PassLab passLab in passLabs)
            {
                ViewModelPanel panelVM = new ViewModelPanel(passLab, resRepository.GetFioResponsiblyById(passLab.ResponsibleId));
                field.Controls.Add(panelVM.CreatePanel());
            }

        }
        
        public void LoadFieldPassByFIO(int id)
        {
            ClearField();
            IEnumerable<PassLab> passLabs = passRepository.GetPassByFIO(id);
            foreach (PassLab passLab in passLabs)
            {
                ViewModelPanel panelVM = new ViewModelPanel(passLab, resRepository.GetFioResponsiblyById(passLab.ResponsibleId));
                field.Controls.Add(panelVM.CreatePanel());
            }
        }

        public async void LoadFieldResponsibly()
        {
            ClearField();
            IEnumerable<Responsible> responsibles = await resRepository.GetAllAsync();
            foreach(Responsible responsible in responsibles)
            {
                VMPanelResponsibly panelVM = new VMPanelResponsibly(responsible, resRepository);
                field.Controls.Add(panelVM.CreatePanel());
            }
        }

        public void LoadFieldFurn(PassLab pass)
        {
            ClearField();
            using(var db= new ApplicationDbContext())
            {
                FurnRepository furnRepository = new FurnRepository(db);
                var array = furnRepository.GetAllById(pass.Id);
                for (int i = 0; i < array.Length; i++)
                {
                    ViewModeFurn vmmodel = new ViewModeFurn(array[i], db);
                    field.Controls.Add(vmmodel.CreatPanel());
                }
            }
        }

        public void LoadFielEq(PassLab pass)
        {
            ClearField();
            using (var db = new ApplicationDbContext())
            {
                EqRepository eqRepository = new EqRepository(db);
                FurnRepository furnRepository = new FurnRepository(db);
                var array = eqRepository.GetAllEquipmentById(pass.Id);
                //var array = furnRepository.GetAllById(pass.Id);
                for (int i = 0; i < array.Length; i++)
                {
                    ViewModelEq vmmodel = new ViewModelEq(array[i], db);
                    //ViewModeFurn vmmodel = new ViewModeFurn(array[i], db);
                    field.Controls.Add(vmmodel.CreatePanel());
                }
            }
        }
    }
}

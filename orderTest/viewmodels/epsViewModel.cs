using orderTest.commands;
using orderTest.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace orderTest.viewmodels
{
    internal class epsViewModel
    {
        string mark = "";
        int thikness;
        double amount;
        int pack;

        public ICommand AddEPS { get; set; }
        public BindingList<epsModel> Eps { get; }
        public string Mark { get => mark; set => mark = value; }
        public int Thikness { get => thikness; set => thikness = value; }
        public double Amount { get => amount; set => amount = value; }
        public int Pack { get => pack; set => pack = value; }
        //public List<epsModel> EPSList { get; }
        public epsViewModel()
        {
            Eps = new BindingList<epsModel>()
            {
                new epsModel{Mark = "eps 30", Thikness = 2, Amount = 12.2, Pack = 45}
            };
            AddEPS = new MainCommand(_ =>
            {
                Eps.Add(new epsModel { Mark = this.Mark, Thikness = this.Thikness, Amount = this.Amount, Pack = this.Pack });
                Mark = ""; Thikness = 0; Amount=0.0; Pack = 0;
            });
        }

        //public event PropertyChangedEventHandler PropertyChanged;
        //public void OnPropertyChanged()
    }
}

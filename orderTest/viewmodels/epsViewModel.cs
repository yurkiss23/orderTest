using orderTest.commands;
using orderTest.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace orderTest.viewmodels
{
    internal class epsViewModel:INotifyPropertyChanged
    {
        string mark = "";
        int thikness;
        double amount;
        int pack;

        public ICommand AddEPS { get; set; }
        public BindingList<epsModel> Eps { get; }
        public string Mark { get => mark; set { if (mark != value) { mark = value; OnPropertyChanged(); } } }
        public int Thikness { get => thikness; set { if (thikness != value) { thikness = value; OnPropertyChanged(); } } }
        public double Amount { get => amount; set { if (amount != value) { amount = value; OnPropertyChanged(); } } }
        public int Pack { get => pack; set { if (pack != value) { pack = value; OnPropertyChanged(); } } }
        //public List<epsModel> EPSList { get; }
        public epsViewModel()
        {
            Eps = new()
            {
                new epsModel{Mark = "test", Thikness = 0, Amount = 0.0, Pack = 0}
            };
            AddEPS = new MainCommand(_ =>
            {
                Eps.Add(new epsModel { Mark = this.Mark, Thikness = this.Thikness, Amount = this.Amount, Pack = this.Pack });
                Mark = ""; Thikness = 0; Amount=0.0; Pack = 0;
            });
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}

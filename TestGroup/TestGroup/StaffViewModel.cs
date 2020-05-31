using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGroup
{
   public  class StaffViewModel :INotifyPropertyChanged
    {

        private Staff selectedStaff;

        private ObservableCollection<Staff> staffs;
        public StaffViewModel()
        {
            this.staffs = new ObservableCollection<Staff>();
            this.staffs.Add(new Staff() {ID=1,FirstName="Steve",LastName="Steveson",Role="IT" });
            this.staffs.Add(new Staff() {ID =2, FirstName = "Mark", LastName = "Steveson", Role = "Parker" });
            this.staffs.Add(new Staff() {ID =3, FirstName = "Peter", LastName = "Steveson", Role = "IT" });
        }

        public ObservableCollection<Staff> Staffs
        {
            get => staffs;
        }

        public  Staff SelectedStaff
        {
            get => this.selectedStaff;
            set => this.selectedStaff = value;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChangeEvent(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

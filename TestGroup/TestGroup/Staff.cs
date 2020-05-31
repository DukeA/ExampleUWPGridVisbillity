using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGroup
{
    public class Staff : INotifyPropertyChanged
    {
        public int ID
        {
            get;
            set;
        }
        public string FirstName
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }

        public string Role
        {
            get;
            set;
        }


        public bool showDetails;


        public string getInfo
        {
            get
            {
                return $" {ID} \n {FirstName} {LastName}";
            }
            
        }
        public string getAllINFO
        {
            get => $"{ID} \n {FirstName} {LastName} \n {Role}";
            
        }


        public  bool ShowDetails
        {
            get
            {
                return showDetails;
            }
            set
            {
                showDetails = value;
                RaisePropertyChangeEvent(nameof(showDetails));
            }

        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChangeEvent(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}


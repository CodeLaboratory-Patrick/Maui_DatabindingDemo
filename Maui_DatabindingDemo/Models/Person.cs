using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Maui_DatabindingDemo.Models
{
    public class Person : INotifyPropertyChanged
    {
        private string name;
        private string phone;
        private string address;

        public string Name
        {
            get => name; set
            {
                name = value;
                ObPropertyChanged();
            }
        }
        public string Phone
        {
            get => phone; set
            {
                phone = value;
                ObPropertyChanged();
            }
        }
        public string Address
        {
            get => address; set
            {
                address = value;
                ObPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void ObPropertyChanged([CallerMemberName]string propName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}

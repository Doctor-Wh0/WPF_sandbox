using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace OrderManager.ViewModels
{
    public class AddOrderViewModel : IViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}

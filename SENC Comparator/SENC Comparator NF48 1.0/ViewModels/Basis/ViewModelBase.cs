using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SENC_Comparator_NF48_1._0.ViewModels.Basis
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnChanged([CallerMemberName] string name = null) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
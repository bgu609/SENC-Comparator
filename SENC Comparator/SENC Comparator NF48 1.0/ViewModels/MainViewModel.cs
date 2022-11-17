using SENC_Comparator_NF48_1._0.ViewModels.Basis;
using SENC_Comparator_NF48_1._0.Views;

namespace SENC_Comparator_NF48_1._0.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private object reference_readviewer;
        public object Reference_ReadViewer
        {
            get => reference_readviewer;
            set { reference_readviewer = value; OnChanged(); }
        }

        private object check_readviewer;
        public object Check_ReadViewer
        {
            get => check_readviewer;
            set { check_readviewer = value; OnChanged(); }
        }

        ReadViewModel Reference_Reader;
        ReadViewModel Check_Reader;



        public MainViewModel()
        {
            Reference_Reader = new ReadViewModel();
            Check_Reader = new ReadViewModel();

            Reference_ReadViewer = new ReadView() { DataContext = Reference_Reader };
            Check_ReadViewer = new ReadView() { DataContext = Check_Reader };
        }
    }
}
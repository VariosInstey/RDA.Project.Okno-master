using RDA.Project.Okno.Extensions;
using RDA.Project.Okno.Messages;
using RDA.Project.Okno.Services;
using RDA.Project.Okno.Utility;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RDA.Project.Okno.ViewModel
{
    public class OknoOverviewViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private IOknoDataService _oknoDataService;
        private IDialogService _dialogService;
        private ObservableCollection<Okno> _oknos;
        public ObservableCollection<Okno> Oknos
        {
            get => _oknos;
            set
            {
                _oknos = value;
                RaisePropertyChanged();
            }
        }
        private Okno _selectedOkno;
        public Okno SelectedOkno
        {
            get => _selectedOkno; set
            {
                _selectedOkno = value;
                RaisePropertyChanged();
            }
        }
        public ICommand EditCommand { get; set; }
        private void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public OknoOverviewViewModel(IOknoDataService oknoDataService, IDialogService dialogService)
        {
            _oknoDataService = oknoDataService;
            _dialogService = dialogService;
            LoadData();
            LoadCommands();
            Messenger.Default.Register<UpdateListMessage>(this, OnUpdateListMessageReceived);
        }
        private void LoadCommands()
        {
            EditCommand = new CustomCommand(EditOkno, CanEditOkno);
        }
        private void OnUpdateListMessageReceived(UpdateListMessage obj)
        {
            LoadData();
            _dialogService.CloseDetailDialog();
        }
        private void EditOkno(object obj)
        {
            Messenger.Default.Send<Okno>(_selectedOkno);
            _dialogService.ShowDetailDialog();
        }
        private bool CanEditOkno(object obj)
        {
            if (SelectedOkno != null)
                return true;
            return false;
        }
        private void LoadData()
        {
            Oknos = _oknoDataService.GetAllOknos().ToObservableCollection();
        }
    }
}

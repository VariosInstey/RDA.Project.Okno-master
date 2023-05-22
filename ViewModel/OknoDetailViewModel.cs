using RDA.Project.Okno.Messages;
using RDA.Project.Okno.Services;
using RDA.Project.Okno.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RDA.Project.Okno.ViewModel
{
    public class OknoDetailViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private IOknoDataService _oknoDataService;
        private IDialogService _dialogService;
        private void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public ICommand SaveCommand { get; set; }
        public ICommand DeleteCommand { get; set;}
        private Okno selectedOkno;
        public Okno SelectedOkno
        {
            get => selectedOkno;
            set
            {
                selectedOkno = value;
                RaisePropertyChanged();
            }
        }
        public OknoDetailViewModel(IOknoDataService oknoDataService, IDialogService dialogService)
        {
            _oknoDataService = oknoDataService;
            _dialogService = dialogService;
            Messenger.Default.Register<Okno>(this, OnOknoReceived);
            SaveCommand = new CustomCommand(SaveOkno, CanSaveOkno);
            DeleteCommand = new CustomCommand(DeleteOkno, CanDeleteOkno);
        }
        public void OnOknoReceived(Okno okno)
        {
            SelectedOkno = okno;
        }
        private bool CanDeleteOkno(object obj)
        {
            return true;
        }
        private void DeleteOkno(object okno)
        {
            _oknoDataService.DeleteOkno(selectedOkno);
            Messenger.Default.Send<UpdateListMessage>(new UpdateListMessage());
        }
        private bool CanSaveOkno(object obj)
        {
            return true;
        }
        private void SaveOkno(object okno) 
        {
            _oknoDataService.UpdateOkno(selectedOkno);
            Messenger.Default.Send<UpdateListMessage>(new UpdateListMessage());
        }

    }
}

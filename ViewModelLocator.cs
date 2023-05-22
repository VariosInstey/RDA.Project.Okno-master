using RDA.Project.Okno.DAL;
using RDA.Project.Okno.Services;
using RDA.Project.Okno.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDA.Project.Okno
{
    public class ViewModelLocator
    {
        private static IDialogService _dialogService = new DialogService();
        private static IOknoDataService _OknoDataService = new OknoDataService(new OknoRepository());

        private static OknoOverviewViewModel _OknoOverviewModel = new OknoOverviewViewModel(_OknoDataService, _dialogService);
        private static OknoDetailViewModel _OknoDetailViewModel = new OknoDetailViewModel(_OknoDataService, _dialogService);
        public static OknoDetailViewModel OknoDetailViewModel
        {
            get => _OknoDetailViewModel;
        }
        public static OknoOverviewViewModel OknoOverviewViewModel
        {
            get => _OknoOverviewModel;
        }
    }
}

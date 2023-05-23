using RDA.Project.Okno.View.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RDA.Project.Okno.Services
{
    public class DialogService : IDialogService
    {
        Window oknoDetailView = null;

        public DialogService() { }
        public void ShowDetailDialog()
        {
            oknoDetailView = new OknoWindow();
            oknoDetailView.ShowDialog();    
        }
        public void CloseDetailDialog()
        {
            if (oknoDetailView != null)
                oknoDetailView.Close();
        }
    }
}

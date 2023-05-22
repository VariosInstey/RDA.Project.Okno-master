using RDA.Project.Okno.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RDA.Project.Okno
{
    public class Okno : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
        #region Private Fields
        private int _OknaId;
        private string _OknaName;
        private int _prise;
        #endregion
        #region Public Property
        public int OknaId
        {
            get => _OknaId;
            set
            {
                _OknaId = value; RaisePropertyChanged();
            }
        }
        public string OknaName
        {
            get => _OknaName;
            set
            {
                _OknaName = value; RaisePropertyChanged();
            }
        }
        public int Price
        {
            get => _prise; set
            {
                _prise = value;
                RaisePropertyChanged();
            }
        }
        public string Description { get;set; }
        public Country OriginCountry { get; set; }
        public bool InStock { get; set; }
        public int AmountInStock { get; set; }
        public DateTime FirstAddedToStockDate { get; set; }
        public int ImageId { get; set; }

        #endregion
    }
}

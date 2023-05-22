using RDA.Project.Okno.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDA.Project.Okno.DAL
{
    public class OknoRepository : IOknoRepository
    {
        public static List<Okno> oknos;
        public OknoRepository()
        {
        }
        public Okno GetAOkno()
        {
            if (oknos == null)
                LoadOknos();
            return oknos.FirstOrDefault();
        }
        public List<Okno> GetOknos() 
        {
            if (oknos != null)
                LoadOknos();
            return oknos;
        }
        public Okno GetOknoById (int id)
        {
            if (oknos == null)
                LoadOknos();
            return oknos.Where(c => c.OknaId == id).FirstOrDefault();
        }
        public void DeleteOkno(Okno okno)
        {
            oknos.Remove(okno);
        }
        public void UpdateOkno(Okno okno)
        {
            Okno oknoToUpdate = oknos.Where(c => c.OknaId == okno.OknaId).FirstOrDefault();
            oknoToUpdate = okno;
        }

        private void LoadOknos()
        {
            oknos = new List<Okno>();
            new Okno()
            {
                OknaId = 1,
                OknaName = "Пластиковое",
                Description = "Обычное окно",
                ImageId = 1,
                AmountInStock = 10,
                InStock = true,
                FirstAddedToStockDate = new DateTime(19,05,2023),
                OriginCountry = Country.Россия,
                Price = 5000
            };
        }
    }

}

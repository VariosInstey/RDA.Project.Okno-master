using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDA.Project.Okno.Services
{
    public interface IOknoDataService
    {
        void DeleteOkno(Okno okno);
        List<Okno> GetAllOknos();
        Okno GetOknoDetail(int oknoId);
        void UpdateOkno(Okno okno);
    }
}

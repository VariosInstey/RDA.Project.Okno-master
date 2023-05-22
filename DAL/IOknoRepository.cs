using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDA.Project.Okno.DAL
{
     public interface IOknoRepository
    {
        void DeleteOkno(Okno okno);
        Okno GetAOkno();
        Okno GetOknoById(int id);
        List<Okno> GetOknos();
        void UpdateOkno(Okno okno);
    }
}

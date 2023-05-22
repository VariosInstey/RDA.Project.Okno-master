using RDA.Project.Okno.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDA.Project.Okno.Services
{
    public class OknoDataService : IOknoDataService
    {
        IOknoRepository _repository;
        public OknoDataService(IOknoRepository repository)
        {
            _repository = repository;
        }
        public Okno GetOknoDetail(int OknoId)
        {
            return _repository.GetOknoById(OknoId);
        }
        public List<Okno> GetAllOknos()
        {
            return _repository.GetOknos();
        }
        public void UpdateOkno(Okno okno)
        {
            _repository.UpdateOkno(okno);
        }
        public void DeleteOkno(Okno okno)
        {
            _repository.DeleteOkno(okno);
        }
    }
}

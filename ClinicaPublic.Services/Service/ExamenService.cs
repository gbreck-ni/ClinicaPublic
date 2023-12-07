using ClinicaPublic.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaPublic.Services.Service
{
    public class ExamenService : IExamenService
    {
        private IExamenRepository _repositoryExamen;

        public ExamenService(IExamenRepository repositoryExamen)
        {
            _repositoryExamen = repositoryExamen;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Examen> GetAll()
        {
            return _repositoryExamen.GetAll();
        }

        public Examen GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Examen GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Examen entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(Examen entity)
        {
            throw new NotImplementedException();
        }
    }
}

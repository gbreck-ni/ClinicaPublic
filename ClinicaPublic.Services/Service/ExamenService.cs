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
            return _repositoryExamen.Delete(id);
        }

        public List<Examen> GetAll()
        {
            return _repositoryExamen.GetAll();
        }

        public Examen GetById(int id)
        {
            return _repositoryExamen.GetById(id);
        }

        public Examen GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Examen entity)
        {
            entity.FechaRegistro = DateTime.Now;
            return _repositoryExamen.Insert(entity);
        }

        public bool Update(Examen entity)
        {
            entity.FechaRegistro = DateTime.Now;
            return _repositoryExamen.Update(entity);
        }
    }
}

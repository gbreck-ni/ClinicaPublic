using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaPublic.Repositories
{
    public interface IExamenRepository
    {
        bool Insert(Examen entity);
        bool Update(Examen entity);
        bool Delete(int id);
        Examen GetById(int id);
        IQueryable<Examen> GetAll();
    }
}

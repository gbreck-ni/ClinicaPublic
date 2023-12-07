using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaPublic.Services.Service
{
    public interface IExamenService
    {
        bool Insert(Examen entity);
        bool Update(Examen entity);
        bool Delete(int id);
        Examen GetById(int id);
        List<Examen> GetAll();
        Examen GetByName(string name);
    }
}

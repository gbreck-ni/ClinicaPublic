using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaPublic.Repositories
{
    public class ExamenRepository : IExamenRepository
    {
        private readonly ClinicaContext _context;

        public ExamenRepository(ClinicaContext context)
        {
            _context = context;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Examen> GetAll()
        {
            //Lista = _context.Examen.ToList();
            //return Lista;
            Console.WriteLine("Exito");
            IQueryable<Examen> sqlExamen = _context.Examen;
            return sqlExamen;
            //return null;
        }

        public Examen GetById(int id)
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

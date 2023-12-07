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
            Examen model = _context.Examen.First(m => m.Id == id);
            if (model == null) return false;

            _context.Examen.Remove(model);
            _context.SaveChanges();
            return true;
        }

        public List<Examen> GetAll()
        {
            IQueryable<Examen> sqlExamen = _context.Examen;
            return sqlExamen.ToList();
        }

        public Examen GetById(int id)
        {
            Examen model = _context.Examen.First(m => m.Id == id);
            return model;
        }

        public bool Insert(Examen entity)
        {
            _context.Examen.Add(entity);
            _context.SaveChanges();
            return true;
        }

        public bool Update(Examen entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
            return true;
        }
    }
}

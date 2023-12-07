using ClinicaPublic.Services.Service;

namespace ClinicaPublic
{
    public partial class FormExamen : Form
    {
        private readonly IExamenService _examenService;
        private Examen _examen;
        public FormExamen(IExamenService examenService)
        {
            InitializeComponent();
            _examenService = examenService;
            _examen = new Examen();
        }

    }
}
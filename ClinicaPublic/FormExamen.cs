using ClinicaPublic.Services.Service;

namespace ClinicaPublic
{
    public partial class FormExamen : Form
    {
        private readonly IExamenService _examenService;
        public FormExamen(IExamenService examenService)
        {
            InitializeComponent();
            _examenService = examenService;

            _examenService.GetAll();
        }
    }
}
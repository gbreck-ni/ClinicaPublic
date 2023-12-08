using ClinicaPublic.App;
using ClinicaPublic.Services.Service;
using System.ComponentModel;

namespace ClinicaPublic
{
    public partial class FormExamen : Form
    {
        private readonly IExamenService _examenService;
        private Examen _examen;
        public FormExamen(IExamenService examenService)
        {
            InitializeComponent();
            CenterToScreen();
            _examenService = examenService;
            _examen = new Examen();
        }
        /*
         * BEGIN METHODS
         */

        private void ClearInput()
        {
            _examen = new Examen();
            txtNombre.Text = string.Empty;
            txtPrecio.Text = string.Empty;
        }
        private bool InputControlValidator(object sender)
        {
            var textInput = sender as TextBox;
            if (string.IsNullOrEmpty(textInput.Text.Trim()))
            {
                MessageBox.Show(Labels.ValidaEntradaUsuario, Labels.Examen, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textInput.Focus();
                return false;
            }
            return true;
        }

        private bool InputValidatorExisteExamenEnGrid()
        {
            int rowIndex = -1;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["colNombre"].Value.ToString().Equals(txtNombre.Text))
                {
                    rowIndex = row.Index;
                    break;
                }
            }

            if (rowIndex >= 0)
            {
                MessageBox.Show(Labels.ValorIngresadoYaExiste, Labels.GestionarExamenes, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dataGridView1.Rows[rowIndex].Selected = true;
                dataGridView1.Rows[rowIndex].Cells[0].Selected = true;
                dataGridView1.Focus();
                return true;
            }
            return false;
        }

        #region CRUD

        private void Create()
        {
            _examen.Nombre = txtNombre.Text.ToUpper();
            _examen.Precio = Convert.ToDecimal(txtPrecio.Text);

            _examenService.Insert(_examen);
        }
        private void Read()
        {
            BindingList<Examen> bindingList = new BindingList<Examen>(_examenService.GetAll());
            BindingSource bindingSourceExamen = new BindingSource(bindingList, null);
            dataGridView1.DataSource = bindingSourceExamen;
        }
        private bool Update()
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            DataGridViewRow focusedRow = dataGridView1.Rows[index];

            _examen = focusedRow.DataBoundItem as Examen;
            _examen.Nombre = _examen.Nombre.ToUpper();

            bool respuesta = _examenService.Update(_examen);
            return respuesta;
        }
        private bool Delete()
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            DataGridViewRow focusedRow = dataGridView1.Rows[index];

            _examen = focusedRow.DataBoundItem as Examen;

            bool result = _examenService.Delete(_examen.Id);
            return result;
        }

        #endregion

        /*
         * END METHODS
         */
        private void FormExamen_Load(object sender, EventArgs e)
        {
            this.Text = Labels.GestionarExamenes;
            groupBoxExamen.Text = Labels.Examen;
            lblNombre.Text = Labels.Nombre;
            lblPrecio.Text = Labels.Precio;

            groupBoxOpciones.Text = Labels.Opciones;
            btnAgregar.Text = Labels.Agregar;
            btnCerrar.Text = Labels.Cerrar;

            Read();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //
            // Create
            //
            if (!InputControlValidator(txtNombre)) { return; }
            if (!InputControlValidator(txtPrecio)) { return; }

            if (InputValidatorExisteExamenEnGrid()) { return; }

            try
            {
                Create();

                ClearInput();
                Read();

                dataGridView1.ClearSelection();
                int nRowIndex = dataGridView1.Rows.Count - 1;

                dataGridView1.Rows[nRowIndex].Selected = true;
                dataGridView1.Rows[nRowIndex].Cells[0].Selected = true;

                txtNombre.Focus();
            }
            catch (InvalidOperationException exeption)
            {
                MessageBox.Show(exeption.Message);
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //
            // Update
            //

            if (dataGridView1.Rows.Count == 0) return;

            int index = dataGridView1.CurrentCell.RowIndex;
            DataGridViewRow focusedRow = dataGridView1.Rows[index];

            if (focusedRow == null)
            {
                MessageBox.Show($"{Labels.NingunCambioRealizado}", Labels.GestionarExamenes, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"{Labels.DeseaActualizar} {focusedRow.Cells["colNombre"].Value.ToString().ToUpper()}", Labels.GestionarExamenes, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Update();

                ClearInput();
                Read();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //
            // Delete
            //

            if (e.ColumnIndex == dataGridView1.Columns["colDelete"].Index)
            {
                if (dataGridView1.Rows.Count == 0) return;

                int index = dataGridView1.CurrentCell.RowIndex;
                DataGridViewRow focusedRow = dataGridView1.Rows[index];

                if (focusedRow == null)
                {
                    MessageBox.Show($"{Labels.NingunCambioRealizado}", Labels.GestionarExamenes, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show($"{Labels.DeseaEliminar} {focusedRow.Cells["colNombre"].Value.ToString().ToUpper()}", Labels.GestionarExamenes, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (Delete())
                        MessageBox.Show($"{Labels.OperacionSatisfactoria}", Labels.GestionarExamenes, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearInput();
                    Read();
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
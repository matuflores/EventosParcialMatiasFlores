using EventoParcial.Ioc;
using EventoParcial.Servicios.DTOs.Evento;
using EventoParcial.Servicios.Interfaces;
using EventoParcial.Windows.Helpers;

namespace EventoParcial.Windows
{
    public partial class frmEventos : Form
    {
        private readonly IServicioEventos _servicioEventos;
        private readonly IServicioSalones _servicioSalones;
        private List<EventoListDto>? eventosDto;
        private int cantidadDeRegistros;
        public frmEventos(IServicioEventos servicioEventos, IServicioSalones servicioSalones)
        {
            InitializeComponent();
            _servicioEventos = servicioEventos;
            _servicioSalones = servicioSalones;
        }


        private void frmEventos_Load(object sender, EventArgs e)
        {
            RecargarGrilla();
        }

        private void RecargarGrilla()
        {
            try
            {
                eventosDto = _servicioEventos.ObtenerLista();
                cantidadDeRegistros = _servicioEventos.ObtenerCantidad();
                GridHelper.MostrarDatosEnGrilla<EventoListDto>(eventosDto, dgvDatos);
                MostrarCantidad();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void MostrarCantidad()
        {
            txtCantidad.Text = cantidadDeRegistros.ToString();
        }

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsbActualizar_Click(object sender, EventArgs e)
        {
            RecargarGrilla();
        }

        private void tsbDetalles_Click(object sender, EventArgs e)
        {
            using (var frm = new frmDetalleEvento() { Text = "Mostrar detalles del Evento" })
            {
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel) return;
            }
        }


        private void cboSalonFiltro_Click(object sender, EventArgs e)
        {

        }
    }
}

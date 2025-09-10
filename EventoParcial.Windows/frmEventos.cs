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
                GridHelper.MostrarDatosEnGrilla<EventoListDto>(eventosDto, dgvDatos);//NUEVO DE POO METODO GENERICO
                MostrarCantidad();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void MostrarCantidad()
        {
            throw new NotImplementedException();
        }

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

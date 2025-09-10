using EventoParcial.Servicios.DTOS.Evento;
using EventoParcial.Servicios.Interfaces;
using EventoParcial.Servicios.Mapeadores;
using EventoParcial.Windows.Helpers;

namespace EventoParcial.Windows
{
    public partial class frmEventos : Form
    {
        public frmEventos()
        {
            InitializeComponent();
        }


        private void frmEventos_Shown(object sender, EventArgs e)
        {
            //try
            //{
            //    CombosHelper.CargarComboSalones(cboSalonFiltro, _servicioSalones);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error");
            //}
        }
    }
}

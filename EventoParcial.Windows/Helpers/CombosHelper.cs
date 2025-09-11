﻿//using EventoParcial.Servicios.DTOs.Salon;
//using EventoParcial.Servicios.DTOs.TipoEvento;
using EventoParcial.Servicios.DTOs.Salon;
using EventoParcial.Servicios.Interfaces;

namespace EventoParcial.Windows.Helpers
{
    public static class CombosHelper
    {
        public static void CargarComboSalones(ref ComboBox cbo, IServicioSalones _servicioSalones)
        {
            var salones = _servicioSalones.ObtenerLista();
            var defaulSalon = new SalonListDto
            {
                SalonId = 0,
                NombreSalon = "Seleccione un genero"
            };
            //salones.Insert(0,defaulSalon);
            cbo.DataSource = salones;//dataSource es decir que se lo damos como fuente de datos
            cbo.DisplayMember = "NombreGenero";//es lo que voy a mostrar
            cbo.ValueMember = "GeneroId";//que valor voy a guardar cuando me selecxcionan
            cbo.SelectedIndex = 0;
        }

        
        //public static void CargarComboSalones(ToolStripComboBox cbo, IServicioSalones servicio)
        //{
        //    if (cbo?.ComboBox == null)
        //        throw new InvalidOperationException("El ToolStripComboBox no está inicializado.");

        //    cbo.ComboBox.Items.Clear();

        //    cbo.ComboBox.Items.Add(new SalonComboDto
        //    {
        //        SalonId = 0,
        //        NombreSalon = "Seleccione Salón"
        //    });

        //    var lista = servicio.ObtenerListaCombo() ?? new List<SalonComboDto>();

        //    foreach (var salon in lista)
        //    {
        //        cbo.ComboBox.Items.Add(salon);
        //    }

        //    if (cbo.ComboBox.Items.Count > 0)
        //    {
        //        cbo.ComboBox.SelectedIndex = 0;
        //    }
        //}
    }
}


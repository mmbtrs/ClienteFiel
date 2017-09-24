using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClienteFiel.WS_ServiciosDepartamento;
using ClienteFiel.WS_ServiciosMunicipio;
using UtilidadesServiciosWeb;

namespace ClienteFiel.utilidades
{
    public partial class ctrMunicipio : UserControl
    {
        ServiciosDepartamento serviciosDepartamento;
        ServiciosMunicipio serviciosMunicipio;

        public ctrMunicipio()
        {
            InitializeComponent();
            inicializarServicios();
            getDepartamentos();
            getMunicipios();
        }

        private void getMunicipios()
        {
            try
            {
                cmbMunicipio.Items.Clear();
                cmbMunicipio.DisplayMember = "NOM_MUNICIPIO";
                if (cmbDpto.Items != null && cmbDpto.Items.Count > 0 && cmbDpto.SelectedItem != null)
                {
                    Departamento tmpDpto = (Departamento)cmbDpto.SelectedItem;
                    if (tmpDpto != null && tmpDpto.ID_DEPARTAMENTO > 0)
                    {
                        Municipio tmpMunicipio = new Municipio();
                        tmpMunicipio.ID_DEPARTAMENTO = tmpDpto.ID_DEPARTAMENTO;
                        Municipio[] lstMunicipios = serviciosMunicipio.buscarMunicipio(tmpMunicipio);
                        if (lstMunicipios != null && lstMunicipios.Length > 0)
                        {
                            foreach (Municipio item in lstMunicipios)
                            {
                                cmbMunicipio.Items.Add(item);
                            }
                            cmbMunicipio.SelectedIndex = 0;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Mensajes.mensajeError(e.Message);
            }
        }

        private void getDepartamentos()
        {
            try
            {
                cmbDpto.Items.Clear();
                cmbDpto.DisplayMember = "NOM_DEPARTAMENTO";
                Departamento[] lstDptos = serviciosDepartamento.listarDepartamento();
                if (lstDptos != null && lstDptos.Length > 0)
                {
                    foreach (Departamento item in lstDptos)
                    {
                        cmbDpto.Items.Add(item);
                    }
                    cmbDpto.SelectedIndex = 0;
                }
            }
            catch (Exception e)
            {
                Mensajes.mensajeError(e.Message);
            }
        }

        private void inicializarServicios()
        {
            try
            {
                serviciosDepartamento = (ServiciosDepartamento)Configurador.ConfigurarServicio(typeof(ServiciosDepartamento));
                serviciosDepartamento.AutenticacionValue = new WS_ServiciosDepartamento.Autenticacion() { usuario = "U", contrasena = "1" };
                serviciosMunicipio = (ServiciosMunicipio)Configurador.ConfigurarServicio(typeof(ServiciosMunicipio));
                serviciosMunicipio.AutenticacionValue = new WS_ServiciosMunicipio.Autenticacion() { usuario = "U", contrasena = "1" };
            }
            catch (Exception e)
            {
                Mensajes.mensajeError(e.Message);
            }
        }

        private void cmbDpto_SelectedIndexChanged(object sender, EventArgs e)
        {
            getMunicipios();
        }

        public Municipio getMunicipio()
        {
            try
            {
                if (cmbMunicipio.Items != null && cmbMunicipio.Items.Count > 0 && cmbMunicipio.SelectedItem != null)
                    return (Municipio)cmbMunicipio.SelectedItem;
                else
                    return null;
            }
            catch (Exception e)
            {
                Mensajes.mensajeError(e.Message);
                return null;
            }
        }
    }
}

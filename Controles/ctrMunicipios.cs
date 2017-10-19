using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Controles.WS_ServiciosDepartamento;
using Controles.WS_ServiciosMunicipio;
using UtilidadesServiciosWeb;

namespace Controles
{
    public partial class ctrMunicipios : UserControl
    {
        ServiciosDepartamento serviciosDepartamento;
        ServiciosMunicipio serviciosMunicipio;
        DataTable dtDatosD;
        DataTable dtDatosM;
        int indice_inicial_Depto;
        int indice_inicial_Mpio;

        public ctrMunicipios()
        {
            InitializeComponent();
            indice_inicial_Depto = 0;
            indice_inicial_Mpio = 0;
        }

        public void iniciar()
        {
            inicializarServicios();
            getDepartamentos();
            ctrBuscarDepto.setConfig(new String[] { "DEPARTAMENTO" }, grdDepartamentos, dtDatosD);
            ctrBuscarMunicipio.setConfig(new String[] { "MUNICIPIO" }, grdMunicipios, dtDatosM);
        }

        private void getMunicipios(long idDepto)
        {
            try
            {
                grdMunicipios.Rows.Clear();
                Municipio tmpMunicipio = new WS_ServiciosMunicipio.Municipio();
                tmpMunicipio.ID_DEPARTAMENTO = idDepto;
                Municipio[] lstMunicipio = serviciosMunicipio.buscarMunicipio(tmpMunicipio);//listarMunicipio();

                dtDatosM = new DataTable();
                dtDatosM.Columns.Add("No.", typeof(int));
                dtDatosM.Columns.Add("ID_MUNICIPIO", typeof(String));
                dtDatosM.Columns.Add("ID_DEPARTAMENTO_M", typeof(String));
                dtDatosM.Columns.Add("MUNICIPIO", typeof(String));

                if (lstMunicipio != null && lstMunicipio.Length > 0)
                {
                    int i = 0;
                    foreach (Municipio item in lstMunicipio)
                    {
                        DataRow dr = dtDatosM.NewRow();
                        dr[0] = i + 1;
                        dr[1] = item.ID_MUNICIPIO.ToString();
                        dr[2] = item.ID_DEPARTAMENTO;
                        dr[3] = item.NOM_MUNICIPIO;
                        dtDatosM.Rows.Add(dr);
                        i++;
                    }
                    ctrBuscarMunicipio.setDatos(dtDatosM);
                    for (int j = 0; j < dtDatosM.Rows.Count; j++)
                    {
                        try
                        {
                            grdMunicipios.Rows.Add(new object[] { dtDatosM.Rows[j][0], dtDatosM.Rows[j][1], dtDatosM.Rows[j][2], dtDatosM.Rows[j][3] });
                        }
                        catch (Exception exp)
                        {
                        }
                    }
                    Controles.utilidades.setFormatGrid(grdMunicipios);                    
                }
            }
            catch (Exception exp)
            {
                Controles.mensajes.mensajeError(exp.Message);
            }
        }

        private void getDepartamentos()
        {
            try
            {
                grdDepartamentos.Rows.Clear();
                Departamento[] lstDeptos = serviciosDepartamento.listarDepartamento();

                dtDatosD = new DataTable();
                dtDatosD.Columns.Add("No.", typeof(int));
                dtDatosD.Columns.Add("ID_DEPARTAMENTO", typeof(String));
                dtDatosD.Columns.Add("DEPARTAMENTO", typeof(String));

                if (lstDeptos != null && lstDeptos.Length > 0)
                {
                    int i = 0;
                    foreach (Departamento item in lstDeptos)
                    {
                        DataRow dr = dtDatosD.NewRow();
                        dr[0] = i + 1;
                        dr[1] = item.ID_DEPARTAMENTO.ToString();
                        dr[2] = item.NOM_DEPARTAMENTO;
                        dtDatosD.Rows.Add(dr);
                        i++;
                    }
                    //grdTiposActividad.DataSource = dtDatos;
                    ctrBuscarDepto.setDatos(dtDatosD);
                    for (int j = 0; j < dtDatosD.Rows.Count; j++)
                    {
                        try
                        {
                            grdDepartamentos.Rows.Add(new object[] { dtDatosD.Rows[j][0], dtDatosD.Rows[j][1], dtDatosD.Rows[j][2] });
                        }
                        catch (Exception)
                        {
                        }
                    }
                    Controles.utilidades.setFormatGrid(grdDepartamentos);
                }
            }
            catch (Exception exp)
            {
                Controles.mensajes.mensajeError(exp.Message);
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
            catch (Exception exp)
            {
                Controles.mensajes.mensajeError(exp.Message);
            }
        }

        private void grdDepartamentos_SelectionChanged(object sender, EventArgs e)
        {
            if (grdDepartamentos.RowCount > 0 && grdDepartamentos.SelectedRows != null && grdDepartamentos.SelectedRows.Count > 0)
            {
                Departamento tmpDepto = new Departamento();
                tmpDepto.ID_DEPARTAMENTO = long.Parse(grdDepartamentos.SelectedRows[0].Cells["ID_DEPARTAMENTO"].Value.ToString());
                getMunicipios(tmpDepto.ID_DEPARTAMENTO);
            }
        }

        public Municipio getMunicipioSeleccionado()
        {
            try
            {
                if (grdMunicipios.RowCount > 0 && grdMunicipios.SelectedRows != null && grdMunicipios.SelectedRows.Count > 0)
                {
                    Municipio municipio = new Municipio();
                    municipio.ID_DEPARTAMENTO = long.Parse(grdMunicipios.SelectedRows[0].Cells["ID_DEPARTAMENTO_M"].Value.ToString());
                    municipio.ID_MUNICIPIO = long.Parse(grdMunicipios.SelectedRows[0].Cells["ID_MUNICIPIO"].Value.ToString());
                    municipio.NOM_MUNICIPIO = grdMunicipios.SelectedRows[0].Cells["MUNICIPIO"].Value.ToString();
                    return municipio;
                }
                else
                    return null;
            }
            catch (Exception exp)
            {
                Controles.mensajes.mensajeError(exp.Message);
                return null;
            }
        }

        private void grdDepartamentos_SelectionChanged_1(object sender, EventArgs e)
        {
            if (grdDepartamentos.RowCount > 0 && grdDepartamentos.SelectedRows != null && grdDepartamentos.SelectedRows.Count > 0)
            {
                Departamento tmpDepto = new Departamento();
                tmpDepto.ID_DEPARTAMENTO = long.Parse(grdDepartamentos.SelectedRows[0].Cells["ID_DEPARTAMENTO"].Value.ToString());
                getMunicipios(tmpDepto.ID_DEPARTAMENTO);
            }
        }

        public void setMunicipio(long idMunicipio)
        {
            try
            {
                Boolean encontrado = false;
                Municipio tmpMunicipio = new Municipio();
                tmpMunicipio.ID_MUNICIPIO = idMunicipio;
                tmpMunicipio = serviciosMunicipio.buscarPrimeroMunicipio(tmpMunicipio);
                getDepartamentos();
                for (int i = 0; i < grdDepartamentos.RowCount; i++)
                {
                    if (grdDepartamentos.Rows[i].Cells["ID_DEPARTAMENTO"].Value.ToString().Equals(tmpMunicipio.ID_DEPARTAMENTO.ToString()))
                    {
                        grdDepartamentos.Rows[i].Selected = true;
                        indice_inicial_Depto = i;
                        grdDepartamentos.FirstDisplayedScrollingRowIndex = i;
                        encontrado = true;
                        break;
                    }
                }
                if (encontrado)
                {
                    for (int i = 0; i < grdMunicipios.RowCount; i++)
                    {
                        if (grdMunicipios.Rows[i].Cells["ID_MUNICIPIO"].Value.ToString().Equals(tmpMunicipio.ID_MUNICIPIO.ToString()))
                        {
                            grdMunicipios.Rows[i].Selected = true;
                            indice_inicial_Mpio = i;
                            grdMunicipios.FirstDisplayedScrollingRowIndex = i;
                            break;
                        }
                    }
                }
            }
            catch (Exception exp)
            {
                Controles.mensajes.mensajeError(exp.Message);
            }
        }

        private void grdMunicipios_SelectionChanged(object sender, EventArgs e)
        {
        }
    }
}


using ClienteFiel.modelo.accesorias;
using ClienteFiel.modelo.forms_base;
using ClienteFiel.WS_ServiciosDepartamento;
using ClienteFiel.WS_ServiciosMunicipio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UtilidadesServiciosWeb;

namespace ClienteFiel.modelo.accesorias
{
    public partial class gestionMunicipios : frmBase
    {
        ServiciosDepartamento serviciosDepartamento;
        ServiciosMunicipio serviciosMunicipio;
        DataTable dtDatosD;
        DataTable dtDatosM;

        public gestionMunicipios()
        {
            InitializeComponent();
            inicializarServicios();
            getDepartamentos();
            ctrBuscarDepto.setConfig(new String[] { "DEPARTAMENTO" }, grdDepartamentos, dtDatosD);
            ctrBuscarMunicipio.setConfig(new String[] { "MUNICIPIO" }, grdMunicipios, dtDatosM);
            Controles.utilidades.fijarSize(this);
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
                    Controles.utilidades.setFormatGrid(grdMunicipios );
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

        private void btnInsertarD_Click(object sender, EventArgs e)
        {
            setDepartamento setDpto = new setDepartamento(Controles.utilidades.tipoOperacion.Insertar, null);
            setDpto.ShowDialog(this);
            getDepartamentos();
        }

        private void editarDepartamento()
        {
            if (grdDepartamentos.Rows != null && grdDepartamentos.Rows.Count > 0 &&
                grdDepartamentos.SelectedRows != null && grdDepartamentos.SelectedRows.Count > 0)
            {
                try
                {
                    Departamento tmpDpto = new Departamento();
                    tmpDpto.ID_DEPARTAMENTO = long.Parse(grdDepartamentos.SelectedRows[0].Cells["ID_DEPARTAMENTO"].Value.ToString());
                    tmpDpto.NOM_DEPARTAMENTO = grdDepartamentos.SelectedRows[0].Cells["DEPARTAMENTO"].Value.ToString();

                    setDepartamento setDpto = new setDepartamento(Controles.utilidades.tipoOperacion.Editar, tmpDpto);
                    setDpto.ShowDialog(this);
                    getDepartamentos();
                }
                catch (Exception exp)
                {
                    Controles.mensajes.mensajeError(exp.Message);
                }
            }
            else
                Controles.mensajes.mensajeError("Debe seleccionar un Departamento de la lista");
        }

        private void editarMunicipio()
        {
            if (grdMunicipios.Rows != null && grdMunicipios.Rows.Count > 0 &&
                grdMunicipios.SelectedRows != null && grdMunicipios.SelectedRows.Count > 0)
            {
                if (grdDepartamentos.Rows != null && grdDepartamentos.Rows.Count > 0 &&
                    grdDepartamentos.SelectedRows != null && grdDepartamentos.SelectedRows.Count > 0)
                {
                    try
                    {
                        Departamento tmpDpto = new Departamento();
                        tmpDpto.ID_DEPARTAMENTO = long.Parse(grdDepartamentos.SelectedRows[0].Cells["ID_DEPARTAMENTO"].Value.ToString());
                        tmpDpto.NOM_DEPARTAMENTO = grdDepartamentos.SelectedRows[0].Cells["DEPARTAMENTO"].Value.ToString();
                        Municipio tmpMpio = new Municipio();
                        tmpMpio.ID_MUNICIPIO = long.Parse(grdMunicipios.SelectedRows[0].Cells["ID_MUNICIPIO"].Value.ToString());
                        tmpMpio.ID_DEPARTAMENTO = long.Parse(grdMunicipios.SelectedRows[0].Cells["ID_DEPARTAMENTO_M"].Value.ToString());
                        tmpMpio.NOM_MUNICIPIO = grdMunicipios.SelectedRows[0].Cells["MUNICIPIO"].Value.ToString();

                        setMunicipios setMpio = new setMunicipios(Controles.utilidades.tipoOperacion.Editar, tmpMpio, tmpDpto);
                        setMpio.ShowDialog(this);
                        getMunicipios(tmpMpio.ID_DEPARTAMENTO);
                        //buscarMunicipio();
                    }
                    catch (Exception exp)
                    {
                        Controles.mensajes.mensajeError(exp.Message);
                    }
                }
                else
                    Controles.mensajes.mensajeError("Debe seleccionar un Departamento de la lista");
            }
            else
                Controles.mensajes.mensajeError("Debe seleccionar un Municipio de la lista");
        }

        private void btnEditarD_Click(object sender, EventArgs e)
        {
            editarDepartamento();
        }

        private void eliminarDepartamento()
        {
            if (grdDepartamentos.Rows != null && grdDepartamentos.Rows.Count > 0 &&
                grdDepartamentos.SelectedRows != null && grdDepartamentos.SelectedRows.Count > 0)
            {
                try
                {
                    if (MessageBox.Show("¿Esta seguro(a) que desea eliminar el Departamento " + grdDepartamentos.SelectedRows[0].Cells["DEPARTAMENTO"].Value.ToString() + "?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        long tmpLong = 0;
                        Departamento tmpDpto = new Departamento();
                        tmpLong = 0;
                        long.TryParse(grdDepartamentos.SelectedRows[0].Cells["ID_DEPARTAMENTO"].Value.ToString(), out tmpLong);
                        tmpDpto.ID_DEPARTAMENTO = tmpLong;
                        if (tmpDpto.ID_DEPARTAMENTO > 0)
                        {
                            DepartamentoResponse objResponse = serviciosDepartamento.eliminarDepartamento(tmpDpto);
                            if (objResponse != null && objResponse.correcto)
                            {
                                Controles.mensajes.mensajeCorrecto("Departamento eliminado correctamente");
                            }
                            else
                                Controles.mensajes.errorWebServices(objResponse.error);
                            getDepartamentos();
                        }
                    }
                }
                catch (Exception exp)
                {
                    Controles.mensajes.mensajeError(exp.Message);
                }
            }
            else
                Controles.mensajes.mensajeError("Debe seleccionar un Departamento de la lista");
        }

        private void eliminarMunicipio()
        {
            if (grdMunicipios.Rows != null && grdMunicipios.Rows.Count > 0 &&
                grdMunicipios.SelectedRows != null && grdMunicipios.SelectedRows.Count > 0)
            {
                try
                {
                    if (MessageBox.Show("¿Esta seguro(a) que desea eliminar el Municipio " + grdMunicipios.SelectedRows[0].Cells["MUNICIPIO"].Value.ToString() + "?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        long tmpLong = 0;
                        Municipio tmpMunicipio = new Municipio();
                        tmpLong = 0;
                        long.TryParse(grdMunicipios.SelectedRows[0].Cells["ID_MUNICIPIO"].Value.ToString(), out tmpLong);
                        tmpMunicipio.ID_MUNICIPIO = tmpLong;
                        if (tmpMunicipio.ID_MUNICIPIO > 0)
                        {
                            MunicipioResponse objResponse = serviciosMunicipio.eliminarMunicipio(tmpMunicipio);
                            if (objResponse != null && objResponse.correcto)
                            {
                                Controles.mensajes.mensajeCorrecto("Municipio eliminado correctamente");
                            }
                            else
                                Controles.mensajes.errorWebServices(objResponse.error);
                            tmpLong = 0;
                            long.TryParse(grdMunicipios.SelectedRows[0].Cells["ID_DEPARTAMENTO_M"].Value.ToString(), out tmpLong);
                            getMunicipios(tmpLong);
                            //buscarMunicipio();
                        }
                    }
                }
                catch (Exception exp)
                {
                    Controles.mensajes.mensajeError(exp.Message);
                }
            }
            else
                Controles.mensajes.mensajeError("Debe seleccionar un Municipio de la lista");
        }

        private void btnEliminarD_Click(object sender, EventArgs e)
        {
            eliminarDepartamento();
        }

        private void btnInsertarM_Click(object sender, EventArgs e)
        {
            if (grdDepartamentos.Rows != null && grdDepartamentos.Rows.Count > 0 &&
               grdDepartamentos.SelectedRows != null && grdDepartamentos.SelectedRows.Count > 0)
            {
                Departamento tmpDpto = new Departamento();
                tmpDpto.ID_DEPARTAMENTO = long.Parse(grdDepartamentos.SelectedRows[0].Cells["ID_DEPARTAMENTO"].Value.ToString());
                tmpDpto.NOM_DEPARTAMENTO = grdDepartamentos.SelectedRows[0].Cells["DEPARTAMENTO"].Value.ToString();
                setMunicipios setMpio = new setMunicipios(Controles.utilidades.tipoOperacion.Insertar, null, tmpDpto);
                setMpio.ShowDialog(this);
                getMunicipios(tmpDpto.ID_DEPARTAMENTO);
                //buscarMunicipio();
            }
            else
                Controles.mensajes.mensajeError("Debe seleccionar un Departamento de la lista");
        }

        private void btnEliminarM_Click(object sender, EventArgs e)
        {
            eliminarMunicipio();
        }

        private void btnEditarM_Click(object sender, EventArgs e)
        {
            editarMunicipio();
        }
    }
}

using ClienteFiel.utilidades;
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

namespace ClienteFiel.modulos.accesorias
{
    public partial class GestionMunicipio : Form
    {
        ServiciosDepartamento serviciosDepartamento;
        ServiciosMunicipio serviciosMunicipio;
        DataTable dtDatosD;
        DataTable dtDatosM;

        public GestionMunicipio()
        {
            InitializeComponent();
            inicializarServicios();
            cmbColumnaDepto.SelectedIndex = 0;
            cmbColumnaMunicipio.SelectedIndex = 0;
            getMunicipios();
            getDepartamentos();
            Controles.utilidades.fijarSize(this);       
        }

        private void getMunicipios()
        {
            try
            {
                        Municipio[] lstMunicipio = serviciosMunicipio.listarMunicipio();

                        dtDatosM = new DataTable();
                        dtDatosM.Columns.Add("No.", typeof(int));
                        dtDatosM.Columns.Add("ID_MUNICIPIO", typeof(String));
                        dtDatosM.Columns.Add("ID_DEPARTAMENTO_M", typeof(String));
                        dtDatosM.Columns.Add("NOM_MUNICIPIO", typeof(String));

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
                        } 
            }
            catch (Exception exp)
            {
                utilidades.Mensajes.mensajeError(exp.Message);
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
                dtDatosD.Columns.Add("NOM_DEPARTAMENTO", typeof(String));

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
                utilidades.Mensajes.mensajeError(exp.Message);
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
                utilidades.Mensajes.mensajeError(exp.Message);
            }
        }

        private void grdDepartamentos_SelectionChanged(object sender, EventArgs e)
        {
            buscarMunicipio();
        }

        private void buscarDepartamento()
        {
            int i = 1;
            DataView view = dtDatosD.AsDataView();
            view.RowFilter = "NOM_DEPARTAMENTO like '%" + txtFiltroDpto.Text + "%' ";
            grdDepartamentos.Rows.Clear();
            foreach (DataRowView item in view)
            {
                grdDepartamentos.Rows.Add(new object[] { i, item[1], item[2] });
                i++;
            }
        }

        private void eliminarDepartamento()
        {
            if (grdDepartamentos.Rows != null && grdDepartamentos.Rows.Count > 0 &&
                grdDepartamentos.SelectedRows != null && grdDepartamentos.SelectedRows.Count > 0)
            {
                try
                {
                    if (MessageBox.Show("¿Esta seguro(a) que desea eliminar el Departamento " + grdDepartamentos.SelectedRows[0].Cells["NOM_DEPARTAMENTO"].Value.ToString() + "?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
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
                                utilidades.Mensajes.mensajeCorrecto("Departamento eliminado correctamente");
                            }
                            else
                                utilidades.Mensajes.errorWebServices(objResponse.error);
                            getDepartamentos();
                        }
                    }
                }
                catch (Exception exp)
                {
                    utilidades.Mensajes.mensajeError(exp.Message);
                }
            }
            else
                utilidades.Mensajes.mensajeError("Debe seleccionar un Departamento de la lista");
        }

        private void eliminarMunicipio()
        {
            if (grdMunicipios.Rows != null && grdMunicipios.Rows.Count > 0 &&
                grdMunicipios.SelectedRows != null && grdMunicipios.SelectedRows.Count > 0)
            {
                try
                {
                    if (MessageBox.Show("¿Esta seguro(a) que desea eliminar el Municipio " + grdMunicipios.SelectedRows[0].Cells["NOM_MUNICIPIO"].Value.ToString() + "?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
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
                                utilidades.Mensajes.mensajeCorrecto("Municipio eliminado correctamente");
                            }
                            else
                                utilidades.Mensajes.errorWebServices(objResponse.error);
                            getMunicipios();
                            buscarMunicipio();
                        }
                    }
                }
                catch (Exception exp)
                {
                    utilidades.Mensajes.mensajeError(exp.Message);
                }
            }
            else
                utilidades.Mensajes.mensajeError("Debe seleccionar un Municipio de la lista");
        }

        private void btnEliminarD_Click(object sender, EventArgs e)
        {
            eliminarDepartamento();
        }

        private void txtFiltroDpto_TextChanged(object sender, EventArgs e)
        {
            buscarDepartamento();
        }

        private void buscarMunicipio()
        {
            int i = 1;
            if (grdDepartamentos.Rows != null && grdDepartamentos.Rows.Count > 0 &&
                grdDepartamentos.SelectedRows != null && grdDepartamentos.SelectedRows.Count > 0)
            {
                DataView view = dtDatosM.AsDataView();
                try
                {
                    String idDpto = grdDepartamentos.SelectedRows[0].Cells["ID_DEPARTAMENTO"].Value.ToString().Trim();
                    view.RowFilter = "ID_DEPARTAMENTO_M = " + idDpto  + " and NOM_MUNICIPIO like '%" + txtFiltroMunicipio.Text + "%' ";
                    grdMunicipios.Rows.Clear();
                    foreach (DataRowView item in view)
                    {
                        grdMunicipios.Rows.Add(new object[] { i, item[1], item[2], item[3] });
                        i++;
                    }
                    Controles.utilidades.setFormatGrid(grdMunicipios);
                }
                catch (Exception exp)
                {
                    utilidades.Mensajes.mensajeError(exp.Message);
                }
            }
        }

        private void txtFiltroMunicipio_TextChanged(object sender, EventArgs e)
        {
            buscarMunicipio();
        }

        private void btnEliminarM_Click(object sender, EventArgs e)
        {
            eliminarMunicipio();
        }

        private void btnInsertarD_Click(object sender, EventArgs e)
        {
            setDepartamento setDpto = new setDepartamento(Controles.utilidades.tipoOperacion.Insertar, null);
            setDpto.ShowDialog(this);
            getDepartamentos();
        }

        private void btnInsertarM_Click(object sender, EventArgs e)
        {
            if (grdDepartamentos.Rows != null && grdDepartamentos.Rows.Count > 0 &&
                grdDepartamentos.SelectedRows != null && grdDepartamentos.SelectedRows.Count > 0)
            {
                Departamento tmpDpto = new Departamento();
                tmpDpto.ID_DEPARTAMENTO = long.Parse(grdDepartamentos.SelectedRows[0].Cells["ID_DEPARTAMENTO"].Value.ToString());
                tmpDpto.NOM_DEPARTAMENTO = grdDepartamentos.SelectedRows[0].Cells["NOM_DEPARTAMENTO"].Value.ToString();
                setMunicipio setMpio = new setMunicipio(Controles.utilidades.tipoOperacion.Insertar, null, tmpDpto);
                setMpio.ShowDialog(this);
                getMunicipios();
                buscarMunicipio();
            }
            else
                utilidades.Mensajes.mensajeError("Debe seleccionar un Departamento de la lista");
        }

        private void btnEditarD_Click(object sender, EventArgs e)
        {
            editarDepartamento();   
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
                    tmpDpto.NOM_DEPARTAMENTO = grdDepartamentos.SelectedRows[0].Cells["NOM_DEPARTAMENTO"].Value.ToString();

                    setDepartamento setDpto = new setDepartamento(Controles.utilidades.tipoOperacion.Editar, tmpDpto);
                    setDpto.ShowDialog(this);
                    getDepartamentos();
                }
                catch (Exception exp)
                {
                    utilidades.Mensajes.mensajeError(exp.Message);
                }
            }
            else
                utilidades.Mensajes.mensajeError("Debe seleccionar un Departamento de la lista");
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
                        tmpDpto.NOM_DEPARTAMENTO = grdDepartamentos.SelectedRows[0].Cells["NOM_DEPARTAMENTO"].Value.ToString();
                        Municipio tmpMpio = new Municipio();
                        tmpMpio.ID_MUNICIPIO = long.Parse(grdMunicipios.SelectedRows[0].Cells["ID_MUNICIPIO"].Value.ToString());
                        tmpMpio.ID_DEPARTAMENTO = long.Parse(grdMunicipios.SelectedRows[0].Cells["ID_DEPARTAMENTO_M"].Value.ToString());
                        tmpMpio.NOM_MUNICIPIO = grdMunicipios.SelectedRows[0].Cells["NOM_MUNICIPIO"].Value.ToString();

                        setMunicipio setMpio = new setMunicipio(Controles.utilidades.tipoOperacion.Editar, tmpMpio, tmpDpto);
                        setMpio.ShowDialog(this);
                        getMunicipios();
                        buscarMunicipio();
                    }
                    catch (Exception exp)
                    {
                        utilidades.Mensajes.mensajeError(exp.Message);
                    }
                }
                else
                    utilidades.Mensajes.mensajeError("Debe seleccionar un Departamento de la lista");
            }
            else
                utilidades.Mensajes.mensajeError("Debe seleccionar un Municipio de la lista");
        }

        private void btnEditarM_Click(object sender, EventArgs e)
        {
            editarMunicipio();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

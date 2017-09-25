using ClienteFiel.utilidades;
using ClienteFiel.WS_ServiciosTipoidentificacion;
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
    public partial class GestionTipoIdentificacion : BaseAccesorias
    {
        ServiciosTipoidentificacion serviciosTipoidentificacion;
        DataTable dtDatos;

        public GestionTipoIdentificacion()
        {
            InitializeComponent();
            inicializarServicios();
            cmbColumna.SelectedIndex = 0;
            getTipoIdentificacion();
            Controles.utilidades.fijarSize(this);
        }

        private void getTipoIdentificacion()
        {
            try
            {
                grdTipoIdentificacion.Rows.Clear();
                Tipoidentificacion[] lstTiposIdentificaciones = serviciosTipoidentificacion.listarTipoidentificacion();

                dtDatos = new DataTable();
                dtDatos.Columns.Add("No.", typeof(int));
                dtDatos.Columns.Add("ID_TIPO_IDENTIFICACION", typeof(String));
                dtDatos.Columns.Add("NOM_TIPO_IDENTIFICACION", typeof(String));

                if (lstTiposIdentificaciones != null && lstTiposIdentificaciones.Length > 0)
                {
                    int i = 0;
                    foreach (Tipoidentificacion item in lstTiposIdentificaciones)
                    {
                        DataRow dr = dtDatos.NewRow();
                        dr[0] = i + 1;
                        dr[1] = item.ID_TIPO_IDENTIFICACION.ToString();
                        dr[2] = item.NOM_TIPO_IDENTIFICACION;
                        dtDatos.Rows.Add(dr);
                        i++;
                    }
                    //grdTipoIdentificacion.DataSource = dtDatos;
                    for (int j = 0; j < dtDatos.Rows.Count; j++)
                    {
                        try
                        {
                            grdTipoIdentificacion.Rows.Add(new object[] { dtDatos.Rows[j][0], dtDatos.Rows[j][1], dtDatos.Rows[j][2] });
                        }
                        catch (Exception)
                        {
                        }
                    }
                    Controles.utilidades.setFormatGrid(grdTipoIdentificacion);
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
                serviciosTipoidentificacion = (ServiciosTipoidentificacion)Configurador.ConfigurarServicio(typeof(ServiciosTipoidentificacion));
                serviciosTipoidentificacion.AutenticacionValue = new WS_ServiciosTipoidentificacion.Autenticacion() { usuario = "U", contrasena = "1" };
            }
            catch (Exception exp)
            {
                utilidades.Mensajes.mensajeError(exp.Message);
            }
        }

        private void buscar()
        {
            int i = 1;
            DataView view = dtDatos.AsDataView();
            view.RowFilter = "NOM_TIPO_IDENTIFICACION like '%" + txtFiltro.Text + "%' ";
            grdTipoIdentificacion.Rows.Clear();
            foreach (DataRowView item in view)
            {
                grdTipoIdentificacion.Rows.Add(new object[] { i, item[1], item[2] });
                i++;
            }
        }

        private void eliminarTipoIdentificacion()
        {
            if (grdTipoIdentificacion.Rows != null && grdTipoIdentificacion.Rows.Count > 0 &&
                grdTipoIdentificacion.SelectedRows != null && grdTipoIdentificacion.SelectedRows.Count > 0)
            {
                try
                {
                    if (MessageBox.Show("¿Esta seguro(a) que desea eliminar el Tipo de Identificación " + grdTipoIdentificacion.SelectedRows[0].Cells["NOM_TIPO_IDENTIFICACION"].Value.ToString() + "?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        long tmpLong = 0;
                        Tipoidentificacion tmpTipoIdentificacion = new Tipoidentificacion();
                        tmpLong = 0;
                        long.TryParse(grdTipoIdentificacion.SelectedRows[0].Cells["ID_TIPO_IDENTIFICACION"].Value.ToString(), out tmpLong);
                        tmpTipoIdentificacion.ID_TIPO_IDENTIFICACION = tmpLong;
                        if (tmpTipoIdentificacion.ID_TIPO_IDENTIFICACION > 0)
                        {
                            TipoidentificacionResponse objResponseTipoidentificacion = serviciosTipoidentificacion.eliminarTipoidentificacion(tmpTipoIdentificacion);
                            if (objResponseTipoidentificacion != null && objResponseTipoidentificacion.correcto)
                            {
                                utilidades.Mensajes.mensajeCorrecto("Tipo de Identificación eliminada correctamente");
                            }
                            else
                                utilidades.Mensajes.errorWebServices(objResponseTipoidentificacion.error);
                            getTipoIdentificacion();
                        }
                    }
                }
                catch (Exception exp)
                {
                    utilidades.Mensajes.mensajeError(exp.Message);
                }
            }
            else
                utilidades.Mensajes.mensajeError("Debe seleccionar un Tipo de Identificación  de la lista");
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            SetTipoIdentificacion setTipoIdentificacion = new SetTipoIdentificacion(Controles.utilidades.tipoOperacion.Insertar, null);
            setTipoIdentificacion.ShowDialog(this);
            getTipoIdentificacion();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (grdTipoIdentificacion.Rows != null && grdTipoIdentificacion.Rows.Count > 0 &&
                grdTipoIdentificacion.SelectedRows != null && grdTipoIdentificacion.SelectedRows.Count > 0)
            {
                try
                {
                    Tipoidentificacion tmpTipo = new Tipoidentificacion();
                    tmpTipo.ID_TIPO_IDENTIFICACION = long.Parse(grdTipoIdentificacion.SelectedRows[0].Cells["ID_TIPO_IDENTIFICACION"].Value.ToString());
                    tmpTipo.NOM_TIPO_IDENTIFICACION = grdTipoIdentificacion.SelectedRows[0].Cells["NOM_TIPO_IDENTIFICACION"].Value.ToString();

                    SetTipoIdentificacion setTipoIdentificacion = new SetTipoIdentificacion(Controles.utilidades.tipoOperacion.Editar, tmpTipo);
                    setTipoIdentificacion.ShowDialog(this);
                    getTipoIdentificacion();
                }
                catch (Exception exp)
                {
                    utilidades.Mensajes.mensajeError(exp.Message);
                }
            }
            else
                utilidades.Mensajes.mensajeError("Debe seleccionar un Tipo de Identificación de la lista");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarTipoIdentificacion();
        }

        private void txtFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            buscar();
        }
    }
}

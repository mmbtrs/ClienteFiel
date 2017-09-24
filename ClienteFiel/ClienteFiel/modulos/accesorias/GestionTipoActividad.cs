using ClienteFiel.utilidades;
using ClienteFiel.WS_ServiciosTipoactividad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static ClienteFiel.utilidades.utilidades;

namespace ClienteFiel.modulos.accesorias
{
    public partial class GestionTipoActividad : BaseAccesorias
    {
        ServiciosTipoactividad serviciosTipoactividad;
        DataTable dtDatos;

        public GestionTipoActividad()
        {
            InitializeComponent();
            inicializarServicios();
            cmbColumna.SelectedIndex = 0;
            getTipoActividad();
            fijarSize(this);
        }

        private void inicializarServicios()
        {
            try
            {
                serviciosTipoactividad = new ServiciosTipoactividad();
                serviciosTipoactividad.AutenticacionValue = new Autenticacion() { usuario = "U", contrasena = "1" };
            }
            catch (Exception e)
            {
                utilidades.Mensajes.mensajeError(e.Message);
            }
        }

        private void getTipoActividad()
        {
            try
            {
                grdTiposActividad.Rows.Clear();
                Tipoactividad[] lstTiposAtividades = serviciosTipoactividad.listarTipoactividad();

                dtDatos = new DataTable();
                dtDatos.Columns.Add("No.", typeof(int));
                dtDatos.Columns.Add("ID_TIPO_ACTIVIDAD", typeof(String));
                dtDatos.Columns.Add("NOM_TIPO_ACTIVIDAD", typeof(String));

                if (lstTiposAtividades != null && lstTiposAtividades.Length > 0)
                {
                    int i = 0;
                    foreach (Tipoactividad item in lstTiposAtividades)
                    {
                        DataRow dr = dtDatos.NewRow();
                        dr[0] = i + 1;
                        dr[1] = item.ID_TIPO_ACTIVIDAD.ToString();
                        dr[2] = item.NOM_TIPO_ACTIVIDAD;
                        dtDatos.Rows.Add(dr);
                        i++;
                    }
                    //grdTiposActividad.DataSource = dtDatos;
                    for (int j = 0; j < dtDatos.Rows.Count; j++)
                    {
                        try
                        {
                            grdTiposActividad.Rows.Add(new object[] { dtDatos.Rows[j][0], dtDatos.Rows[j][1], dtDatos.Rows[j][2] });
                        }
                        catch (Exception)
                        {
                        }
                    }
                    utilidades.utilidades.setFormatGrid(grdTiposActividad);
                }
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
            view.RowFilter = "NOM_TIPO_ACTIVIDAD like '%" + txtFiltro.Text + "%' ";
            grdTiposActividad.Rows.Clear();
            foreach (DataRowView item in view)
            {
                grdTiposActividad.Rows.Add(new object[] { i, item[1], item[2] });
                i++;
            }
        }

        private void eliminarTipoActividad()
        {
            if (grdTiposActividad.Rows != null && grdTiposActividad.Rows.Count > 0 &&
                grdTiposActividad.SelectedRows != null && grdTiposActividad.SelectedRows.Count > 0)
            {
                try
                {
                    if (MessageBox.Show("¿Esta seguro(a) que desea eliminar el Tipo de Actividad " + grdTiposActividad.SelectedRows[0].Cells["NOM_TIPO_ACTIVIDAD"].Value.ToString() + "?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        long tmpLong = 0;
                        Tipoactividad tmpTipoactividad = new Tipoactividad();
                        tmpLong = 0;
                        long.TryParse(grdTiposActividad.SelectedRows[0].Cells["ID_TIPO_ACTIVIDAD"].Value.ToString(), out tmpLong);
                        tmpTipoactividad.ID_TIPO_ACTIVIDAD = tmpLong;
                        if (tmpTipoactividad.ID_TIPO_ACTIVIDAD > 0)
                        {
                            TipoactividadResponse objResponseTipoactividad = serviciosTipoactividad.eliminarTipoactividad(tmpTipoactividad);
                            if (objResponseTipoactividad != null && objResponseTipoactividad.correcto)
                            {
                                utilidades.Mensajes.mensajeCorrecto("Tipo de Actividad eliminada correctamente");
                            }
                            else
                                utilidades.Mensajes.errorWebServices(objResponseTipoactividad.error);
                            getTipoActividad();
                        }
                    }
                }
                catch (Exception exp)
                {
                    utilidades.Mensajes.mensajeError(exp.Message);
                }
            }
            else
                utilidades.Mensajes.mensajeError("Debe seleccionar un Tipo de Actividad de la lista");
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            SetTipoActividad setTipoActividad = new SetTipoActividad(tipoOperacion.Insertar, null);
            setTipoActividad.ShowDialog(this);
            getTipoActividad();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (grdTiposActividad.Rows != null && grdTiposActividad.Rows.Count > 0 &&
                grdTiposActividad.SelectedRows != null && grdTiposActividad.SelectedRows.Count > 0)
            {
                try
                {
                    Tipoactividad tmpTipo = new Tipoactividad();
                    tmpTipo.ID_TIPO_ACTIVIDAD = long.Parse(grdTiposActividad.SelectedRows[0].Cells["ID_TIPO_ACTIVIDAD"].Value.ToString());
                    tmpTipo.NOM_TIPO_ACTIVIDAD = grdTiposActividad.SelectedRows[0].Cells["NOM_TIPO_ACTIVIDAD"].Value.ToString();

                    SetTipoActividad setTipoactividad = new SetTipoActividad(tipoOperacion.Editar, tmpTipo);
                    setTipoactividad.ShowDialog(this);
                    getTipoActividad();
                }
                catch (Exception exp)
                {
                    utilidades.Mensajes.mensajeError(exp.Message);
                }
            }
            else
                utilidades.Mensajes.mensajeError("Debe seleccionar un Tipo de Actividad de la lista");
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            buscar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarTipoActividad();
        }
    }
}

using ClienteFiel.modelo.forms_base;
using ClienteFiel.WS_ServiciosTipoactividad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClienteFiel.modelo.accesorias
{
    public partial class gestionTipoActividad : frmBase
    {
        ServiciosTipoactividad serviciosTipoactividad;
        DataTable dtDatos;

        public gestionTipoActividad()
        {
            InitializeComponent();
            inicializarServicios();
            getTipoActividad();
            ctrBuscar1.setConfig(new String[] { "TIPO DE ACTIVIDAD" }, grdTiposActividad, dtDatos);
           // Controles.utilidades.fijarSize(this);
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
                Controles.mensajes.mensajeError(e.Message);
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
                dtDatos.Columns.Add("TIPO_DE_ACTIVIDAD", typeof(String));

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
                    ctrBuscar1.setDatos(dtDatos);
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
                    Controles.utilidades.setFormatGrid(grdTiposActividad);
                }
            }
            catch (Exception exp)
            {
                Controles.mensajes.mensajeError(exp.Message);
            }
        }

        private void eliminarTipoActividad()
        {
            if (grdTiposActividad.Rows != null && grdTiposActividad.Rows.Count > 0 &&
                grdTiposActividad.SelectedRows != null && grdTiposActividad.SelectedRows.Count > 0)
            {
                try
                {
                    if (MessageBox.Show("¿Esta seguro(a) que desea eliminar el Tipo de Actividad " + grdTiposActividad.SelectedRows[0].Cells["TIPO_DE_ACTIVIDAD"].Value.ToString() + "?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
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
                                Controles.mensajes.mensajeCorrecto("Tipo de Actividad eliminada correctamente");
                            }
                            else
                                Controles.mensajes.errorWebServices(objResponseTipoactividad.error);
                            getTipoActividad();
                        }
                    }
                }
                catch (Exception exp)
                {
                    Controles.mensajes.mensajeError(exp.Message);
                }
            }
            else
                Controles.mensajes.mensajeError("Debe seleccionar un Tipo de Actividad de la lista");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarTipoActividad();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            setTipoActividad setTipoActividad = new setTipoActividad(Controles.utilidades.tipoOperacion.Insertar, null);
            setTipoActividad.ShowDialog(this);
            getTipoActividad();
        }

        private void editar()
        {
            if (grdTiposActividad.Rows != null && grdTiposActividad.Rows.Count > 0 &&
                grdTiposActividad.SelectedRows != null && grdTiposActividad.SelectedRows.Count > 0)
            {
                try
                {
                    Tipoactividad tmpTipo = new Tipoactividad();
                    tmpTipo.ID_TIPO_ACTIVIDAD = long.Parse(grdTiposActividad.SelectedRows[0].Cells["ID_TIPO_ACTIVIDAD"].Value.ToString());
                    tmpTipo.NOM_TIPO_ACTIVIDAD = grdTiposActividad.SelectedRows[0].Cells["TIPO_DE_ACTIVIDAD"].Value.ToString();

                    setTipoActividad setTipoactividad = new setTipoActividad(Controles.utilidades.tipoOperacion.Editar, tmpTipo);
                    setTipoactividad.ShowDialog(this);
                    getTipoActividad();
                }
                catch (Exception exp)
                {
                    Controles.mensajes.mensajeError(exp.Message);
                }
            }
            else
                Controles.mensajes.mensajeError("Debe seleccionar un Tipo de Actividad de la lista");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            editar();
        }
    }
}

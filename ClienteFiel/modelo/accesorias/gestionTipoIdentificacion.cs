using ClienteFiel.modelo.forms_base;
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

namespace ClienteFiel.modelo.accesorias
{
    public partial class gestionTipoIdentificacion : frmBase
    {
        ServiciosTipoidentificacion serviciosTipoidentificacion;
        DataTable dtDatos;

        public gestionTipoIdentificacion()
        {
            InitializeComponent();
            inicializarServicios();
            getTipoIdentificacion();
            ctrBuscar1.setConfig(new String[] { "TIPO DE IDENTIFICACION" }, grdTipoIdentificacion, dtDatos);
            //Controles.utilidades.fijarSize(this);
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
                Controles.mensajes.mensajeError(exp.Message);
            }
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
                dtDatos.Columns.Add("TIPO_DE_IDENTIFICACION", typeof(String));

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
                    ctrBuscar1.setDatos(dtDatos);
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
                Controles.mensajes.mensajeError(exp.Message);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            setTipoIdentificacion setTipoIdentificacion = new setTipoIdentificacion(Controles.utilidades.tipoOperacion.Insertar, null);
            setTipoIdentificacion.ShowDialog(this);
            getTipoIdentificacion();
        }

        private void editar()
        {
            if (grdTipoIdentificacion.Rows != null && grdTipoIdentificacion.Rows.Count > 0 &&
                grdTipoIdentificacion.SelectedRows != null && grdTipoIdentificacion.SelectedRows.Count > 0)
            {
                try
                {
                    Tipoidentificacion tmpTipo = new Tipoidentificacion();
                    tmpTipo.ID_TIPO_IDENTIFICACION = long.Parse(grdTipoIdentificacion.SelectedRows[0].Cells["ID_TIPO_IDENTIFICACION"].Value.ToString());
                    tmpTipo.NOM_TIPO_IDENTIFICACION = grdTipoIdentificacion.SelectedRows[0].Cells["TIPO_DE_IDENTIFICACION"].Value.ToString();

                    setTipoIdentificacion setTipoIdentificacion = new setTipoIdentificacion(Controles.utilidades.tipoOperacion.Editar, tmpTipo);
                    setTipoIdentificacion.ShowDialog(this);
                    getTipoIdentificacion();
                }
                catch (Exception exp)
                {
                    Controles.mensajes.mensajeError(exp.Message);
                }
            }
            else
                Controles.mensajes.mensajeError("Debe seleccionar un Tipo de Identificación de la lista");
        }

        private void eliminarTipoIdentificacion()
        {
            if (grdTipoIdentificacion.Rows != null && grdTipoIdentificacion.Rows.Count > 0 &&
                grdTipoIdentificacion.SelectedRows != null && grdTipoIdentificacion.SelectedRows.Count > 0)
            {
                try
                {
                    if (MessageBox.Show("¿Esta seguro(a) que desea eliminar el Tipo de Identificación " + grdTipoIdentificacion.SelectedRows[0].Cells["TIPO_DE_IDENTIFICACION"].Value.ToString() + "?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
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
                                Controles.mensajes.mensajeCorrecto("Tipo de Identificación eliminada correctamente");
                            }
                            else
                                Controles.mensajes.errorWebServices(objResponseTipoidentificacion.error);
                            getTipoIdentificacion();
                        }
                    }
                }
                catch (Exception exp)
                {
                    Controles.mensajes.mensajeError(exp.Message);
                }
            }
            else
                Controles.mensajes.mensajeError("Debe seleccionar un Tipo de Identificación  de la lista");
        }
        
        private void btnEditar_Click(object sender, EventArgs e)
        {
            editar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarTipoIdentificacion();
        }
    }

}

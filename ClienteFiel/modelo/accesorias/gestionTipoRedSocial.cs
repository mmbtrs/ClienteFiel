using ClienteFiel.modelo.accesorias;
using ClienteFiel.modelo.forms_base;
using ClienteFiel.WS_ServiciosImagen;
using ClienteFiel.WS_ServiciosTiporedsocial;
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
    public partial class gestionTipoRedSocial : frmBase
    {
        ServiciosTiporedsocial serviciosTiporedsocial;
        ServiciosImagen serviciosImagen;
        DataTable dtDatos;
        public gestionTipoRedSocial()
        {
            InitializeComponent();
            inicializarServicios();
            getTiposRedesSociales();
            ctrBuscar1.setConfig(new string[] { "RED SOCIAL" }, grdTiposRedesSociales, dtDatos);            
            //Controles.utilidades.fijarSize(this);
            //ctrBotonesBasicos1.btnSalir.Click += new EventHandler( ( this.Handle);
        }

        private void inicializarServicios()
        {
            try
            {
                serviciosTiporedsocial = (ServiciosTiporedsocial)Configurador.ConfigurarServicio(typeof(ServiciosTiporedsocial));
                serviciosTiporedsocial.AutenticacionValue = new WS_ServiciosTiporedsocial.Autenticacion() { usuario = "U", contrasena = "1" };
                serviciosImagen = (ServiciosImagen)Configurador.ConfigurarServicio(typeof(ServiciosImagen));
                serviciosImagen.AutenticacionValue = new WS_ServiciosImagen.Autenticacion() { usuario = "U", contrasena = "1" };
            }
            catch (Exception exp)
            {
                Controles.mensajes.mensajeError(exp.Message);
            }
        }

        private void getTiposRedesSociales()
        {
            try
            {
                grdTiposRedesSociales.Rows.Clear();
                Tiporedsocial[] lstTiposRedesSociales = serviciosTiporedsocial.listarTiporedsocial();

                dtDatos = new DataTable();
                dtDatos.Columns.Add("No.", typeof(int));
                dtDatos.Columns.Add("ID_TIPO_RED_SOCIAL", typeof(String));
                dtDatos.Columns.Add("RED_SOCIAL", typeof(String));
                dtDatos.Columns.Add("ID_IMAGEN", typeof(String));
                dtDatos.Columns.Add("IMAGEN", typeof(Image));

                if (lstTiposRedesSociales != null && lstTiposRedesSociales.Length > 0)
                {
                    int i = 0;
                    foreach (Tiporedsocial item in lstTiposRedesSociales)
                    {
                        DataRow dr = dtDatos.NewRow();
                        dr[0] = i + 1;
                        dr[1] = item.ID_TIPO_RED_SOCIAL.ToString();
                        dr[2] = item.NOM_TIPO_RED_SOCIAL;

                        Imagen tmpImagen = new Imagen();
                        tmpImagen.ID_IMAGEN = item.ID_IMAGEN;
                        tmpImagen = serviciosImagen.buscarPrimeroImagen(tmpImagen);
                        if (tmpImagen != null && tmpImagen.ID_IMAGEN > 0)
                        {
                            dr[3] = tmpImagen.ID_IMAGEN.ToString();
                            dr[4] = Controles.utilidades.byteToImagen(tmpImagen.IMAGEN);
                        }
                        else
                        {
                            dr[3] = "";
                            dr[4] = null;
                        }
                        dtDatos.Rows.Add(dr);
                        i++;
                    }
                    ctrBuscar1.setDatos(dtDatos);
                    //grdTiposRedesSociales.DataSource = dtDatos;
                    for (int j = 0; j < dtDatos.Rows.Count; j++)
                    {
                        try
                        {
                            grdTiposRedesSociales.Rows.Add(new object[] { dtDatos.Rows[j][0], dtDatos.Rows[j][1], dtDatos.Rows[j][2], dtDatos.Rows[j][3], dtDatos.Rows[j][4] });
                        }
                        catch (Exception)
                        {
                            grdTiposRedesSociales.Rows.Add(new object[] { dtDatos.Rows[j][0], dtDatos.Rows[j][1], dtDatos.Rows[j][2], dtDatos.Rows[j][3], null });
                        }
                    }
                    Controles.utilidades.setFormatGrid(grdTiposRedesSociales);
                }
            }
            catch (Exception exp)
            {
                Controles.mensajes.mensajeError(exp.Message);
            }
        }

        private void ctrBotonesBasicos1_Load(object sender, EventArgs e)
        {
        }

        private void ctrBotonesBasicos1_Click(object sender, EventArgs e)
        {
                    }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            setTipoRedSocial setTipoRedSocial = new setTipoRedSocial(Controles.utilidades.tipoOperacion.Insertar, null, null);
            setTipoRedSocial.ShowDialog(this);
            getTiposRedesSociales();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            editar();
        }

        private void editar()
        {
            if (grdTiposRedesSociales.Rows != null && grdTiposRedesSociales.Rows.Count > 0 &&
                grdTiposRedesSociales.SelectedRows != null && grdTiposRedesSociales.SelectedRows.Count > 0)
            {
                try
                {
                    Tiporedsocial tmpTipo = new Tiporedsocial();
                    Imagen tmpImagen = new Imagen();
                    tmpTipo.ID_TIPO_RED_SOCIAL = long.Parse(grdTiposRedesSociales.SelectedRows[0].Cells["ID_TIPO_RED_SOCIAL"].Value.ToString());
                    tmpTipo.NOM_TIPO_RED_SOCIAL = grdTiposRedesSociales.SelectedRows[0].Cells["RED_SOCIAL"].Value.ToString();
                    if (grdTiposRedesSociales.SelectedRows[0].Cells["ID_IMAGEN"].Value != null && grdTiposRedesSociales.SelectedRows[0].Cells["IMAGEN"].Value != null)
                    {
                        long tmpLong = 0;
                        long.TryParse(grdTiposRedesSociales.SelectedRows[0].Cells["ID_IMAGEN"].Value.ToString(), out tmpLong);
                        tmpTipo.ID_IMAGEN = tmpLong;
                        tmpImagen.ID_IMAGEN = tmpTipo.ID_IMAGEN;
                        if (tmpLong > 0)
                            tmpImagen.IMAGEN = Controles.utilidades.ImageToByte((Image)grdTiposRedesSociales.SelectedRows[0].Cells["IMAGEN"].Value);
                        else
                            tmpImagen.IMAGEN = null;
                    }
                    else
                    {
                        tmpTipo.ID_IMAGEN = 0;
                        tmpImagen.ID_IMAGEN = 0;
                        tmpImagen.IMAGEN = null;
                    }
                    setTipoRedSocial setTipoRedSocial = new setTipoRedSocial(Controles.utilidades.tipoOperacion.Editar, tmpTipo, tmpImagen);
                    setTipoRedSocial.ShowDialog(this);
                    getTiposRedesSociales();
                }
                catch (Exception exp)
                {
                    Controles.mensajes.mensajeError(exp.Message);
                }
            }
            else
                Controles.mensajes.mensajeError("Debe seleccionar una Red Social de la lista");
        }

        private void eliminarTiporedsocial()
        {
            if (grdTiposRedesSociales.Rows != null && grdTiposRedesSociales.Rows.Count > 0 &&
                grdTiposRedesSociales.SelectedRows != null && grdTiposRedesSociales.SelectedRows.Count > 0)
            {
                try
                {
                    if (MessageBox.Show("¿Esta seguro(a) que desea eliminar la Red Social " + grdTiposRedesSociales.SelectedRows[0].Cells["RED_SOCIAL"].Value.ToString() + "?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        Imagen tmpImagen = new Imagen();
                        long tmpLong = 0;
                        long.TryParse(grdTiposRedesSociales.SelectedRows[0].Cells["ID_IMAGEN"].Value.ToString(), out tmpLong);
                        tmpImagen.ID_IMAGEN = tmpLong;
                        Tiporedsocial tmpTipoRed = new Tiporedsocial();
                        tmpLong = 0;
                        long.TryParse(grdTiposRedesSociales.SelectedRows[0].Cells["ID_TIPO_RED_SOCIAL"].Value.ToString(), out tmpLong);
                        tmpTipoRed.ID_TIPO_RED_SOCIAL = tmpLong;
                        if (tmpTipoRed.ID_TIPO_RED_SOCIAL > 0)
                        {
                            TiporedsocialResponse objResponseTipored = serviciosTiporedsocial.eliminarTiporedsocial(tmpTipoRed);
                            if (objResponseTipored != null && objResponseTipored.correcto)
                            {
                                if (tmpImagen.ID_IMAGEN > 0)
                                {
                                    ImagenResponse objResponseImagen = serviciosImagen.eliminarImagen(tmpImagen);
                                    if (objResponseImagen != null && !objResponseImagen.correcto)
                                        Controles.mensajes.errorWebServices(objResponseImagen.error);
                                }
                                Controles.mensajes.mensajeCorrecto("Red Social eliminada correctamente");
                            }
                            else
                                Controles.mensajes.errorWebServices(objResponseTipored.error);
                            getTiposRedesSociales();
                        }
                    }
                }
                catch (Exception exp)
                {
                    Controles.mensajes.mensajeError(exp.Message);
                }
            }
            else
                Controles.mensajes.mensajeError("Debe seleccionar un Tipo de Red Social  de la lista");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarTiporedsocial();
        }
    }
}

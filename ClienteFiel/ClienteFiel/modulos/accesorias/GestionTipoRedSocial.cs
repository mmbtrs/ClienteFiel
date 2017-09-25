using ClienteFiel.utilidades;
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

namespace ClienteFiel.modulos.accesorias
{
    public partial class GestionTipoRedSocial : BaseAccesorias
    {
        ServiciosTiporedsocial serviciosTiporedsocial;
        ServiciosImagen serviciosImagen;

        DataTable dtDatos;

        public GestionTipoRedSocial()
        {
            InitializeComponent();
            inicializarServicios();
            cmbColumna.SelectedIndex = 0;
            getTiposRedesSociales();
            Controles.utilidades.fijarSize(this);
        }

        private void getTiposRedesSociales()
        {
            try
            {
                grdTiposRedesSociales.Rows.Clear();
                Tiporedsocial[] lstTiposRedesSociales = serviciosTiporedsocial.listarTiporedsocial();

                dtDatos = new DataTable();
                dtDatos.Columns.Add("No.", typeof(int));
                dtDatos.Columns.Add("ID_TIPO_RED_SOCIAL",typeof(String));
                dtDatos.Columns.Add("NOM_TIPO_RED_SOCIAL", typeof(String));
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
                utilidades.Mensajes.mensajeError(exp.Message);
            }
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
                utilidades.Mensajes.mensajeError(exp.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void grdDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            buscar();
        }

        private void buscar()
        {
            int i = 1;
            DataView view = dtDatos.AsDataView();
            view.RowFilter = "NOM_TIPO_RED_SOCIAL like '%" + txtFiltro.Text + "%' ";
            grdTiposRedesSociales.Rows.Clear();
            foreach (DataRowView item in view)
            {
                grdTiposRedesSociales.Rows.Add(new object[] { i, item[1], item[2], item[3], item[4]});
                i++;
            }
        }

        private void grdTiposRedesSociales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4 && grdTiposRedesSociales.Rows[e.RowIndex].Cells["IMAGEN"] != null)
            {
                try
                {
                    VentanaImagen ventanaImagen = new VentanaImagen((Image)grdTiposRedesSociales.Rows[e.RowIndex].Cells["IMAGEN"].Value);
                    ventanaImagen.ShowDialog(this);
                }
                catch (Exception)
                {
                }

            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void eliminarTiporedsocial()
        {
            if (grdTiposRedesSociales.Rows != null && grdTiposRedesSociales.Rows.Count > 0 &&
                grdTiposRedesSociales.SelectedRows != null && grdTiposRedesSociales.SelectedRows.Count > 0)
            {
                try
                {
                    if (MessageBox.Show("¿Esta seguro(a) que desea eliminar la Red Social " + grdTiposRedesSociales.SelectedRows[0].Cells["NOM_TIPO_RED_SOCIAL"].Value.ToString() + "?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
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
                                        utilidades.Mensajes.errorWebServices(objResponseImagen.error);
                                }
                                utilidades.Mensajes.mensajeCorrecto("Red Social eliminada correctamente");
                            }
                            else
                                utilidades.Mensajes.errorWebServices(objResponseTipored.error);
                            getTiposRedesSociales();
                        }
                    }
                }
                catch (Exception exp)
                {
                    utilidades.Mensajes.mensajeError(exp.Message);
                }
            }
            else
                utilidades.Mensajes.mensajeError("Debe seleccionar un Tipo de Red Social  de la lista");
        }

        private void btnInsertar_Click_1(object sender, EventArgs e)
        {
            SetTipoRedSocial setTipoRedSocial = new SetTipoRedSocial(Controles.utilidades.tipoOperacion.Insertar, null, null);
            setTipoRedSocial.ShowDialog(this);
            getTiposRedesSociales();
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (grdTiposRedesSociales.Rows != null && grdTiposRedesSociales.Rows.Count > 0 &&
                grdTiposRedesSociales.SelectedRows != null && grdTiposRedesSociales.SelectedRows.Count > 0)
            {
                try
                {
                    Tiporedsocial tmpTipo = new Tiporedsocial();
                    Imagen tmpImagen = new Imagen();
                    tmpTipo.ID_TIPO_RED_SOCIAL = long.Parse(grdTiposRedesSociales.SelectedRows[0].Cells["ID_TIPO_RED_SOCIAL"].Value.ToString());
                    tmpTipo.NOM_TIPO_RED_SOCIAL = grdTiposRedesSociales.SelectedRows[0].Cells["NOM_TIPO_RED_SOCIAL"].Value.ToString();
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
                    SetTipoRedSocial setTipoRedSocial = new SetTipoRedSocial(Controles.utilidades.tipoOperacion.Editar, tmpTipo, tmpImagen);
                    setTipoRedSocial.ShowDialog(this);
                    getTiposRedesSociales();
                }
                catch (Exception exp)
                {
                    utilidades.Mensajes.mensajeError(exp.Message);
                }
            }
            else
                utilidades.Mensajes.mensajeError("Debe seleccionar una Red Social de la lista");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarTiporedsocial();
        }
    }
}

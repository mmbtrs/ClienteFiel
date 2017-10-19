using ClienteFiel.modelo.forms_base;
using ClienteFiel.WS_ServiciosEmpresa;
using ClienteFiel.WS_ServiciosImagen;
using ClienteFiel.WS_ServiciosViewempresa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UtilidadesServiciosWeb;

namespace ClienteFiel.modelo.empresa
{
    public partial class gestionEmpresa : frmBase
    {
        ServiciosViewempresa serviciosViewempresa;
        ServiciosEmpresa serviciosEmpresa;
        ServiciosImagen serviciosImagen;
        DataTable dtDatos;

        public gestionEmpresa()
        {
            InitializeComponent();
            inicializarServicios();
            getEmpresas();
            ctrBuscar1.setConfig(new String[] { "NIT", "RAZON SOCIAL", "DIRECCION", "TELEFONO", "SLOGAN", "SUCURSAL", "MUNICIPIO" }, grdDatos, dtDatos);
        }

        private void getEmpresas()
        {
            try
            {
                grdDatos.Rows.Clear();
                Viewempresa[] lstEmpresas = serviciosViewempresa.listarViewempresa();

                dtDatos = new DataTable();
                dtDatos.Columns.Add("No.", typeof(int));
                dtDatos.Columns.Add("ID_EMPRESA", typeof(int));
                dtDatos.Columns.Add("ID_MUNICIPIO", typeof(int));
                dtDatos.Columns.Add("ID_IMAGEN", typeof(int));
                dtDatos.Columns.Add("NIT", typeof(String));
                dtDatos.Columns.Add("RAZON_SOCIAL", typeof(String));
                dtDatos.Columns.Add("DIRECCION", typeof(String));
                dtDatos.Columns.Add("TELEFONO", typeof(String));
                dtDatos.Columns.Add("SLOGAN", typeof(String));
                dtDatos.Columns.Add("LATITUD", typeof(String));
                dtDatos.Columns.Add("LONGITUD", typeof(String));
                dtDatos.Columns.Add("SUCURSAL", typeof(String));
                dtDatos.Columns.Add("MUNICIPIO", typeof(String));
                dtDatos.Columns.Add("IMAGEN", typeof(Image));

                if (lstEmpresas != null && lstEmpresas.Length > 0)
                {
                    int i = 0;
                    foreach (Viewempresa item in lstEmpresas)
                    {
                        DataRow dr = dtDatos.NewRow();
                        dr[0] = i + 1;
                        dr[1] = item.ID_EMPRESA;
                        dr[2] = item.ID_MUNICIPIO;
                        dr[3] = item.ID_IMAGEN;
                        dr[4] = item.NIT;
                        dr[5] = item.RAZON_SOCIAL;
                        dr[6] = item.DIRECCION_CLIENTE;
                        dr[7] = item.TELEFONO;
                        dr[8] = item.SLOGAN;
                        dr[9] = item.LATITUD;
                        dr[10] = item.LONGITUD;
                        dr[11] = item.SUCURSAL;
                        dr[12] = item.NOM_MUNICIPIO;
                        dr[13] = Controles.utilidades.byteToImagen(item.IMAGEN);
                        dtDatos.Rows.Add(dr);
                        i++;
                    }
                    //grdTiposActividad.DataSource = dtDatos;
                    ctrBuscar1.setDatos(dtDatos);
                    for (int j = 0; j < dtDatos.Rows.Count; j++)
                    {
                        try
                        {
                            grdDatos.Rows.Add(new object[] { dtDatos.Rows[j][0], dtDatos.Rows[j][1], dtDatos.Rows[j][2],
                                                             dtDatos.Rows[j][3], dtDatos.Rows[j][4], dtDatos.Rows[j][5],
                                                             dtDatos.Rows[j][6], dtDatos.Rows[j][7], dtDatos.Rows[j][8],
                                                             dtDatos.Rows[j][9], dtDatos.Rows[j][10], dtDatos.Rows[j][11],
                                                             dtDatos.Rows[j][12], dtDatos.Rows[j][13]});
                        }
                        catch (Exception)
                        {
                        }
                    }
                    Controles.utilidades.setFormatGrid(grdDatos);
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
                serviciosViewempresa = (ServiciosViewempresa)Configurador.ConfigurarServicio(typeof(ServiciosViewempresa));
                serviciosViewempresa.AutenticacionValue = new WS_ServiciosViewempresa.Autenticacion() { usuario = "U", contrasena = "1" };
                serviciosEmpresa = (ServiciosEmpresa)Configurador.ConfigurarServicio(typeof(ServiciosEmpresa));
                serviciosEmpresa.AutenticacionValue = new WS_ServiciosEmpresa.Autenticacion() { usuario = "U", contrasena = "1" };
                serviciosImagen = (ServiciosImagen)Configurador.ConfigurarServicio(typeof(ServiciosImagen));
                serviciosImagen.AutenticacionValue = new WS_ServiciosImagen.Autenticacion() { usuario = "U", contrasena = "1" };
            }
            catch (Exception exp)
            {
                Controles.mensajes.mensajeError(exp.Message);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            setEmpresa frmSetEmpresa = new setEmpresa(Controles.utilidades.tipoOperacion.Insertar,null,0);
            frmSetEmpresa.ShowDialog(this);
            getEmpresas();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            editar();
            getEmpresas();
        }

        private void editar()
        {
            try
            {
                if (grdDatos.RowCount > 0 && grdDatos.SelectedRows != null && grdDatos.SelectedRows.Count > 0)
                {
                    Viewempresa tmpViewEmpresa = new Viewempresa();
                    tmpViewEmpresa.ID_EMPRESA = long.Parse(grdDatos.SelectedRows[0].Cells["ID_EMPRESA"].Value.ToString());
                    tmpViewEmpresa = serviciosViewempresa.buscarPrimeroViewempresa(tmpViewEmpresa);
                    setEmpresa frmSetEmpresa = new setEmpresa(Controles.utilidades.tipoOperacion.Editar, tmpViewEmpresa, tmpViewEmpresa.ID_MUNICIPIO);
                    frmSetEmpresa.ShowDialog(this);
                }
                else
                    Controles.mensajes.mensajeError("Debe seleccionar una empresa de la lista");
            }
            catch (Exception exp)
            {
                Controles.mensajes.mensajeError(exp.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarEmpresa();
        }

        private void eliminarEmpresa()
        {
            try
            {
                if (grdDatos.RowCount > 0 && grdDatos.SelectedRows != null && grdDatos.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("¿Esta seguro(a) que desea eliminar la empresa " + grdDatos.SelectedRows[0].Cells["RAZON_SOCIAL"].Value.ToString() + ", SUCURSAL " + grdDatos.SelectedRows[0].Cells["SUCURSAL"].Value.ToString() + "?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        long tmpLong = 0;
                        WS_ServiciosEmpresa.Empresa tmpEmpresa = new WS_ServiciosEmpresa.Empresa();
                        tmpLong = 0;
                        long.TryParse(grdDatos.SelectedRows[0].Cells["ID_EMPRESA"].Value.ToString(), out tmpLong);
                        tmpEmpresa.ID_EMPRESA = tmpLong;
                        tmpLong = 0;
                        Imagen tmpImagen = new Imagen();
                        long.TryParse(grdDatos.SelectedRows[0].Cells["ID_IMAGEN"].Value.ToString(), out tmpLong);
                        tmpImagen.ID_IMAGEN = tmpLong;
                        if (tmpEmpresa.ID_EMPRESA > 0)
                        {
                            WS_ServiciosEmpresa.EmpresaResponse objResponseEmpresa = serviciosEmpresa.eliminarEmpresa(tmpEmpresa);
                            if (objResponseEmpresa != null && objResponseEmpresa.correcto)
                            {
                                Controles.mensajes.mensajeCorrecto("Empresa eliminada correctamente");
                                if (tmpImagen != null && tmpImagen.ID_IMAGEN > 0)
                                {
                                    ImagenResponse objResponseImagen = serviciosImagen.eliminarImagen(tmpImagen);
                                    if (objResponseImagen != null && objResponseImagen.correcto)
                                        Controles.mensajes.mensajeCorrecto("El logo de la empresa se eliminó correctamente");
                                    else
                                        Controles.mensajes.errorWebServices(objResponseImagen.error);
                                }
                            }
                            else
                                Controles.mensajes.errorWebServices(objResponseEmpresa.error);
                            getEmpresas();
                        }
                    }
                }
                else
                    Controles.mensajes.mensajeError("Debe seleccionar una empresa de la lista");
            }
            catch (Exception exp)
            {
                Controles.mensajes.mensajeError(exp.Message);
            }
        }
    }
}

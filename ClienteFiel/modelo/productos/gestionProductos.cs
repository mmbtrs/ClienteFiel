using ClienteFiel.modelo.forms_base;
using ClienteFiel.WS_ServiciosImagen;
using ClienteFiel.WS_ServiciosProducto;
using ClienteFiel.WS_ServiciosViewproducto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UtilidadesServiciosWeb;

namespace ClienteFiel.modelo.productos
{
    public partial class gestionProductos : frmBase
    {
        ServiciosViewproducto serviciosViewproducto;
        ServiciosProducto serviciosProducto;
        ServiciosImagen serviciosImagen;
        DataTable dtDatos;

        public gestionProductos()
        {
            InitializeComponent();
            inicializarServicios();
            getProductos();
            ctrBuscar1.setConfig(new string[] { "PRODUCTO", "PRECIO", "TIPO PRODUCTO", "NIT", "RAZON SOCIAL", "SUCURSAL" }, grdDatos, dtDatos);
            //Controles.utilidades.fijarSize(this);
        }

        private void getProductos()
        {
            try
            {
                grdDatos.Rows.Clear();
                Viewproducto[] lstProductos = serviciosViewproducto.listarViewproducto();
                dtDatos = new DataTable();
                dtDatos.Columns.Add("No", typeof(int));
                dtDatos.Columns.Add("ID_PRODUCTO", typeof(String));
                dtDatos.Columns.Add("ID_IMAGEN", typeof(String));
                dtDatos.Columns.Add("ID_TIPO_PRODUCTO", typeof(String));
                dtDatos.Columns.Add("ID_EMPRESA", typeof(String));
                dtDatos.Columns.Add("PRODUCTO", typeof(String));
                dtDatos.Columns.Add("PRECIO", typeof(String));
                dtDatos.Columns.Add("DESCRIPCION", typeof(String));
                dtDatos.Columns.Add("IMAGEN", typeof(Image));
                dtDatos.Columns.Add("TIPO_PRODUCTO", typeof(String));
                dtDatos.Columns.Add("NIT", typeof(String));
                dtDatos.Columns.Add("RAZON_SOCIAL", typeof(String));
                dtDatos.Columns.Add("SUCURSAL", typeof(String));
                if (lstProductos != null && lstProductos.Length > 0)
                {
                    int i = 0;
                    foreach (Viewproducto item in lstProductos)
                    {
                        DataRow dr = dtDatos.NewRow();
                        dr[0] = i + 1;
                        dr[1] = item.ID_PRODUCTO.ToString();
                        dr[2] = item.ID_IMAGEN.ToString();
                        dr[3] = item.ID_TIPO_PRODUCTO.ToString();
                        dr[4] = item.ID_EMPRESA.ToString();
                        dr[5] = item.NOM_PRODUCTO.ToString();
                        dr[6] = item.PRECIO.ToString();
                        dr[7] = item.DESCRIPCION.ToString();

                        Imagen tmpImagen = new Imagen();
                        tmpImagen.ID_IMAGEN = item.ID_IMAGEN;
                        tmpImagen = serviciosImagen.buscarPrimeroImagen(tmpImagen);
                        if (tmpImagen != null && tmpImagen.ID_IMAGEN > 0)
                            dr[8] = Controles.utilidades.byteToImagen(item.IMAGEN);
                        else
                            dr[8] = null;

                        dr[9] = item.NOM_TIPO_PRODUCTO.ToString();
                        dr[10] = item.NIT.ToString();
                        dr[11] = item.RAZON_SOCIAL.ToString();
                        dr[12] = item.SUCURSAL.ToString();
                        dtDatos.Rows.Add(dr);
                        i++;
                    }
                    ctrBuscar1.setDatos(dtDatos);
                    for (int j = 0; j < dtDatos.Rows.Count; j++)
                    {
                        try
                        {
                            grdDatos.Rows.Add(new object[] { dtDatos.Rows[j][0], dtDatos.Rows[j][1], dtDatos.Rows[j][2], dtDatos.Rows[j][3], dtDatos.Rows[j][4], dtDatos.Rows[j][5], dtDatos.Rows[j][6],
                                                             dtDatos.Rows[j][7], dtDatos.Rows[j][8], dtDatos.Rows[j][9], dtDatos.Rows[j][10], dtDatos.Rows[j][11], dtDatos.Rows[j][12]});
                        }
                        catch (Exception exp)
                        {
                            grdDatos.Rows.Add(new object[] { dtDatos.Rows[j][0], dtDatos.Rows[j][1], dtDatos.Rows[j][2], dtDatos.Rows[j][3], dtDatos.Rows[j][4], dtDatos.Rows[j][5], dtDatos.Rows[j][6],
                                                             dtDatos.Rows[j][7], null, dtDatos.Rows[j][9], dtDatos.Rows[j][10], dtDatos.Rows[j][11], dtDatos.Rows[j][12]});
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
                serviciosViewproducto = (ServiciosViewproducto)Configurador.ConfigurarServicio(typeof(ServiciosViewproducto));
                serviciosViewproducto.AutenticacionValue = new WS_ServiciosViewproducto.Autenticacion() { usuario = "U", contrasena = "1" };
                serviciosProducto = (ServiciosProducto)Configurador.ConfigurarServicio(typeof(ServiciosProducto));
                serviciosProducto.AutenticacionValue = new WS_ServiciosProducto.Autenticacion() { usuario = "U", contrasena = "1" };
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
            setProductos frmSetProductos = new setProductos(Controles.utilidades.tipoOperacion.Insertar, 0);
            frmSetProductos.ShowDialog(this);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            editar();
            getProductos();
        }

        private void editar()
        {
            try
            {
                if (grdDatos.RowCount > 0 && grdDatos.SelectedRows != null && grdDatos.SelectedRows.Count > 0)
                {
                    long tmpLong = 0;
                    long.TryParse(grdDatos.SelectedRows[0].Cells["ID_PRODUCTO"].Value.ToString(), out tmpLong);
                    setProductos frmSetProductos = new setProductos(Controles.utilidades.tipoOperacion.Editar, tmpLong);
                    frmSetProductos.ShowDialog(this);
                }
            }
            catch (Exception exp)
            {
                Controles.mensajes.mensajeError(exp.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarProducto();
            getProductos();
        }

        private void eliminarProducto()
        {
            try
            {
                if (grdDatos.RowCount > 0 && grdDatos.SelectedRows != null && grdDatos.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("¿Está seguro(a) que desea eliminar el producto " + grdDatos.SelectedRows[0].Cells["PRODUCTO"].Value.ToString() + ", de la empresa " + grdDatos.SelectedRows[0].Cells["RAZON_SOCIAL"].Value.ToString() + ", sucursal " + grdDatos.SelectedRows[0].Cells["SUCURSAL"].Value.ToString() + "?", "Confirmar eliminación",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        long tmpLong = 0;
                        Producto tmpProducto = new Producto();
                        long.TryParse(grdDatos.SelectedRows[0].Cells["ID_PRODUCTO"].Value.ToString(), out tmpLong);
                        tmpProducto.ID_PRODUCTO = tmpLong;
                        tmpLong = 0;
                        Imagen tmpImagen = new Imagen();
                        long.TryParse(grdDatos.SelectedRows[0].Cells["ID_IMAGEN"].Value.ToString(), out tmpLong);
                        tmpImagen.ID_IMAGEN = tmpLong;
                        ProductoResponse objResponseProducto = serviciosProducto.eliminarProducto(tmpProducto);
                        if (objResponseProducto != null && objResponseProducto.correcto)
                        {
                            Controles.mensajes.mensajeCorrecto("El producto fue eliminado correctamente");
                            ImagenResponse objResponseImagen = serviciosImagen.eliminarImagen(tmpImagen);
                            if (objResponseImagen != null && objResponseImagen.correcto)
                                Controles.mensajes.mensajeCorrecto("La iamgen, del producto eliminado, tambien se eliminó correctamente");
                            else
                                Controles.mensajes.errorWebServices(objResponseImagen.error);
                        }
                        else
                            Controles.mensajes.errorWebServices(objResponseProducto.error);
                    }
                }
                else
                    Controles.mensajes.mensajeError("Debe seleccionar un producto de la lista");
            }
            catch (Exception exp)
            {
                Controles.mensajes.mensajeError(exp.Message);
            }
        }
    }
}

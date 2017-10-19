using ClienteFiel.modelo.forms_base;
using ClienteFiel.WS_ServiciosTipoproducto;
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
    public partial class gestionTipoProducto : frmBase
    {
        ServiciosTipoproducto serviciosTipoproducto;
        DataTable dtDatos;

        public gestionTipoProducto()
        {
            InitializeComponent();
            inicializarServicios();
            getTipoProducto();
            ctrBuscar1.setConfig(new String[] { "TIPO DE PRODUCTO" }, grdTipoProducto, dtDatos);
            //Controles.utilidades.fijarSize(this);
        }

        private void getTipoProducto()
        {
            try
            {
                grdTipoProducto.Rows.Clear();
                Tipoproducto[] lstTiposProductos = serviciosTipoproducto.listarTipoproducto();

                dtDatos = new DataTable();
                dtDatos.Columns.Add("No.", typeof(int));
                dtDatos.Columns.Add("ID_TIPO_PRODUCTO", typeof(String));
                dtDatos.Columns.Add("TIPO_DE_PRODUCTO", typeof(String));

                if (lstTiposProductos != null && lstTiposProductos.Length > 0)
                {
                    int i = 0;
                    foreach (Tipoproducto item in lstTiposProductos)
                    {
                        DataRow dr = dtDatos.NewRow();
                        dr[0] = i + 1;
                        dr[1] = item.ID_TIPO_PRODUCTO.ToString();
                        dr[2] = item.NOM_TIPO_PRODUCTO;
                        dtDatos.Rows.Add(dr);
                        i++;
                    }
                    grdTipoProducto.Rows.Clear();
                    ctrBuscar1.setDatos(dtDatos);
                    for (int j = 0; j < dtDatos.Rows.Count; j++)
                    {
                        try
                        {
                            grdTipoProducto.Rows.Add(new object[] { dtDatos.Rows[j][0], dtDatos.Rows[j][1], dtDatos.Rows[j][2] });
                        }
                        catch (Exception)
                        {
                        }
                    }
                    Controles.utilidades.setFormatGrid(grdTipoProducto);
                }
            }
            catch (Exception exp)
            {
                Controles.mensajes.mensajeError(exp.Message);
            }
        }

        private void inicializarServicios()
        {
            serviciosTipoproducto = (ServiciosTipoproducto)Configurador.ConfigurarServicio(typeof(ServiciosTipoproducto));
            serviciosTipoproducto.AutenticacionValue = new Autenticacion() { usuario = "U", contrasena = "1" };
        }

        private void eliminarTipoProducto()
        {
            if (grdTipoProducto.Rows != null && grdTipoProducto.Rows.Count > 0 &&
                grdTipoProducto.SelectedRows != null && grdTipoProducto.SelectedRows.Count > 0)
            {
                try
                {
                    if (MessageBox.Show("¿Esta seguro(a) que desea eliminar el Tipo de Producto " + grdTipoProducto.SelectedRows[0].Cells["TIPO_DE_PRODUCTO"].Value.ToString() + "?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        long tmpLong = 0;
                        Tipoproducto tmpTipoproducto = new Tipoproducto();
                        tmpLong = 0;
                        long.TryParse(grdTipoProducto.SelectedRows[0].Cells["ID_TIPO_PRODUCTO"].Value.ToString(), out tmpLong);
                        tmpTipoproducto.ID_TIPO_PRODUCTO = tmpLong;
                        if (tmpTipoproducto.ID_TIPO_PRODUCTO > 0)
                        {
                            TipoProductoResponse objResponseTipoproducto = serviciosTipoproducto.eliminarTipoproducto(tmpTipoproducto);
                            if (objResponseTipoproducto != null && objResponseTipoproducto.correcto)
                            {
                                Controles.mensajes.mensajeCorrecto("Tipo de Producto eliminado correctamente");
                            }
                            else
                                Controles.mensajes.errorWebServices(objResponseTipoproducto.error);
                            getTipoProducto();
                        }
                    }
                }
                catch (Exception exp)
                {
                    Controles.mensajes.mensajeError(exp.Message);
                }
            }
            else
                Controles.mensajes.mensajeError("Debe seleccionar un Tipo de Producto de la lista");
        }

        private void editarTipoProducto()
        {
            if (grdTipoProducto.Rows != null && grdTipoProducto.Rows.Count > 0 &&
                grdTipoProducto.SelectedRows != null && grdTipoProducto.SelectedRows.Count > 0)
            {
                try
                {
                    Tipoproducto tmpTipo = new Tipoproducto();
                    tmpTipo.ID_TIPO_PRODUCTO = long.Parse(grdTipoProducto.SelectedRows[0].Cells["ID_TIPO_PRODUCTO"].Value.ToString());
                    tmpTipo.NOM_TIPO_PRODUCTO = grdTipoProducto.SelectedRows[0].Cells["TIPO_DE_PRODUCTO"].Value.ToString();

                    setTipoProducto setTipoProducto = new setTipoProducto(Controles.utilidades.tipoOperacion.Editar, tmpTipo);
                    setTipoProducto.ShowDialog(this);
                    getTipoProducto();
                }
                catch (Exception exp)
                {
                    Controles.mensajes.mensajeError(exp.Message);
                }
            }
            else
                Controles.mensajes.mensajeError("Debe seleccionar un Tipo de Producto de la lista");
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            setTipoProducto setTipoProducto = new setTipoProducto(Controles.utilidades.tipoOperacion.Insertar, null);
            setTipoProducto.ShowDialog(this);
            getTipoProducto();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            editarTipoProducto();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarTipoProducto();
        }
    }
}

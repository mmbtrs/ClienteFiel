using ClienteFiel.utilidades;
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

namespace ClienteFiel.modulos.accesorias
{
    public partial class GestionTipoProducto : BaseAccesorias
    {
        ServiciosTipoproducto serviciosTipoproducto;
        DataTable dtDatos;

        public GestionTipoProducto()
        {
            InitializeComponent();
            inicializarServicios();
            cmbColumna.SelectedIndex = 0;
            getTipoProducto();
            Controles.utilidades.fijarSize(this);
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
                dtDatos.Columns.Add("NOM_TIPO_PRODUCTO", typeof(String));

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
                utilidades.Mensajes.mensajeError(exp.Message);
            }
        }

        private void inicializarServicios()
        {
            serviciosTipoproducto = (ServiciosTipoproducto)Configurador.ConfigurarServicio(typeof(ServiciosTipoproducto));
            serviciosTipoproducto.AutenticacionValue = new Autenticacion() { usuario = "U", contrasena = "1" };
        }

        private void buscar()
        {
            int i = 1;
            DataView view = dtDatos.AsDataView();
            view.RowFilter = "NOM_TIPO_PRODUCTO like '%" + txtFiltro.Text + "%' ";
            grdTipoProducto.Rows.Clear();
            foreach (DataRowView item in view)
            {
                grdTipoProducto.Rows.Add(new object[] { i, item[1], item[2] });
                i++;
            }
        }

        private void eliminarTipoProducto()
        {
            if (grdTipoProducto.Rows != null && grdTipoProducto.Rows.Count > 0 &&
                grdTipoProducto.SelectedRows != null && grdTipoProducto.SelectedRows.Count > 0)
            {
                try
                {
                    if (MessageBox.Show("¿Esta seguro(a) que desea eliminar el Tipo de Producto " + grdTipoProducto.SelectedRows[0].Cells["NOM_TIPO_PRODUCTO"].Value.ToString() + "?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
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
                                utilidades.Mensajes.mensajeCorrecto("Tipo de Producto eliminado correctamente");
                            }
                            else
                                utilidades.Mensajes.errorWebServices(objResponseTipoproducto.error);
                            getTipoProducto();
                        }
                    }
                }
                catch (Exception exp)
                {
                    utilidades.Mensajes.mensajeError(exp.Message);
                }
            }
            else
                utilidades.Mensajes.mensajeError("Debe seleccionar un Tipo de Producto de la lista");
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            SetTipoProducto setTipoProducto = new SetTipoProducto(Controles.utilidades.tipoOperacion.Insertar, null);
            setTipoProducto.ShowDialog(this);
            getTipoProducto();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            editarTipoProducto();
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
                    tmpTipo.NOM_TIPO_PRODUCTO = grdTipoProducto.SelectedRows[0].Cells["NOM_TIPO_PRODUCTO"].Value.ToString();

                    SetTipoProducto setTipoProducto = new SetTipoProducto(Controles.utilidades.tipoOperacion.Editar, tmpTipo);
                    setTipoProducto.ShowDialog(this);
                    getTipoProducto();
                }
                catch (Exception exp)
                {
                    utilidades.Mensajes.mensajeError(exp.Message);
                }
            }
            else
                utilidades.Mensajes.mensajeError("Debe seleccionar un Tipo de Producto de la lista");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarTipoProducto();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            buscar();
        }
    }
}

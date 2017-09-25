using ClienteFiel.utilidades;
using ClienteFiel.WS_ServiciosError;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UtilidadesServiciosWeb;

namespace ClienteFiel.modulos.errores
{
    public partial class GestionErrores : BaseAccesorias
    {
        ServiciosError serviciosError;
        DataTable dt;

        public GestionErrores()
        {
            InitializeComponent();
            cmbColumna.SelectedIndex = 0;
            inicializarServicios();
            getErrores();
        }

        private void getErrores()
        {
            try
            {
                Error[] lstErrores = serviciosError.listarError();
                dt = new DataTable();
                dt.Columns.Add("No", typeof(int));
                dt.Columns.Add("ID_ERROR", typeof(int));
                dt.Columns.Add("ERROR", typeof(String));
                dt.Columns.Add("MENSAJE", typeof(String));
                dt.Columns.Add("SOLUCION", typeof(String));

                if (lstErrores != null && lstErrores.Length > 0)
                {
                    int i = 1;
                    foreach (Error item in lstErrores)
                    {
                        DataRow dr = dt.NewRow();
                        dr["No"] = i;
                        dr["ID_ERROR"] = item.ID_ERROR;
                        dr["ERROR"] = item.ERROR;
                        dr["MENSAJE"] = item.MENSAJE_PARA_USUARIO;
                        dr["SOLUCION"] = item.POSIBLE_SOLUCION;
                        dt.Rows.Add(dr);
                        i++;
                    }

                    grdErrores.Rows.Clear();
                    for (int j = 0; j < dt.Rows.Count; j++)
                    {
                        grdErrores.Rows.Add(new object[] {dt.Rows[j][0], dt.Rows[j][1], dt.Rows[j][2], dt.Rows[j][3], dt.Rows[j][4] });
                    }

                    Controles.utilidades.setFormatGrid(grdErrores);
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
                serviciosError = (ServiciosError)Configurador.ConfigurarServicio(typeof(ServiciosError));
                serviciosError.AutenticacionValue = new Autenticacion() { usuario = "U", contrasena = "1" };
            }
            catch (Exception exp)
            {
                utilidades.Mensajes.mensajeError(exp.Message);
            }
        }

        private void buscar()
        {
            int i = 1;
            DataView view = dt.AsDataView();
            view.RowFilter = cmbColumna.Text +" like '%" + txtFiltro.Text + "%' ";
            grdErrores.Rows.Clear();
            foreach (DataRowView item in view)
            {
                grdErrores.Rows.Add(new object[] { i, item[1], item[2], item[3], item[4] });
                i++;
            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            buscar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarError();
        }

        private void eliminarError()
        {
            if (grdErrores.Rows != null && grdErrores.Rows.Count > 0 &&
                grdErrores.SelectedRows != null && grdErrores.SelectedRows.Count > 0)
            {
                try
                {
                    if (MessageBox.Show("¿Esta seguro(a) que desea eliminar el Tipo de Error seleccionado?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        long tmpLong = 0;
                        Error tmpError = new Error();
                        tmpLong = 0;
                        long.TryParse(grdErrores.SelectedRows[0].Cells["ID_ERROR"].Value.ToString(), out tmpLong);
                        tmpError.ID_ERROR = tmpLong;
                        if (tmpError.ID_ERROR > 0)
                        {
                            ErrorResponse objResponse = serviciosError.eliminarError(tmpError);
                            if (objResponse != null && objResponse.correcto)
                            {
                                utilidades.Mensajes.mensajeCorrecto("Tipo de Identificación eliminada correctamente");
                            }
                            else
                                utilidades.Mensajes.errorWebServices(objResponse.error);
                            getErrores();
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            editarError();
        }

        private void editarError()
        {
            if (grdErrores.Rows != null && grdErrores.Rows.Count > 0 &&
                grdErrores.SelectedRows != null && grdErrores.SelectedRows.Count > 0)
            {
                try
                {
                    Error tmpError = new WS_ServiciosError.Error();
                    tmpError.ID_ERROR = long.Parse(grdErrores.SelectedRows[0].Cells["ID_ERROR"].Value.ToString());
                    tmpError.ERROR = grdErrores.SelectedRows[0].Cells["ERROR"].Value.ToString();
                    tmpError.MENSAJE_PARA_USUARIO = grdErrores.SelectedRows[0].Cells["MENSAJE"].Value.ToString();
                    tmpError.POSIBLE_SOLUCION = grdErrores.SelectedRows[0].Cells["SOLUCION"].Value.ToString();

                    setErrores setE = new setErrores(Controles.utilidades.tipoOperacion.Editar, tmpError);
                    setE.ShowDialog(this);
                    getErrores();
                }
                catch (Exception exp)
                {
                    utilidades.Mensajes.mensajeError(exp.Message);
                }
            }
            else
                utilidades.Mensajes.mensajeError("Debe seleccionar un Tipo de Error de la lista");
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
        }
    }
}

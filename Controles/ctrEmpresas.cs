using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Controles.WS_ServiciosViewempresa;
using UtilidadesServiciosWeb;
using System.Collections;

namespace Controles
{
    public partial class ctrEmpresas : UserControl
    {
        ServiciosViewempresa serviciosViewempresa;
        DataTable dtDatos;

        public ctrEmpresas()
        {
            InitializeComponent();
        }

        public void iniciar()
        {
            inicializarServicios();
            getEmpresas();
            cmbColumna.SelectedIndex = 0;
        }

        private void inicializarServicios()
        {
            try
            {
                serviciosViewempresa = (ServiciosViewempresa)Configurador.ConfigurarServicio(typeof(ServiciosViewempresa));
                serviciosViewempresa.AutenticacionValue = new Autenticacion() { usuario = "U", contrasena = "1" };
            }
            catch (Exception exp)
            {
                //MessageBox.Show("Se presentó el siguiente error: " + exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void getEmpresas()
        {
            try
            {
                grdDatos.Rows.Clear();
                Viewempresa[] lstEmpresas = serviciosViewempresa.listarViewempresa();

                dtDatos = new DataTable();
                dtDatos.Columns.Add("idEmpresa", typeof(int));
                dtDatos.Columns.Add("seleccionado", typeof(CheckBox));
                dtDatos.Columns.Add("nit", typeof(String));
                dtDatos.Columns.Add("razon_social", typeof(String));
                dtDatos.Columns.Add("sucursal", typeof(String));
                dtDatos.Columns.Add("municipio", typeof(String));
                dtDatos.Columns.Add("logo", typeof(Image));

                if (lstEmpresas != null && lstEmpresas.Length > 0)
                {
                    foreach (Viewempresa item in lstEmpresas)
                    {
                        DataRow dr = dtDatos.NewRow();
                        dr[0] = item.ID_EMPRESA;
                        dr[2] = item.NIT;
                        dr[3] = item.RAZON_SOCIAL;
                        dr[4] = item.SUCURSAL;
                        dr[5] = item.NOM_MUNICIPIO;
                        dr[6] = utilidades.byteToImagen(item.IMAGEN);
                        dtDatos.Rows.Add(dr);
                    }
                    //grdTiposActividad.DataSource = dtDatos;
                    for (int j = 0; j < dtDatos.Rows.Count; j++)
                    {
                        try
                        {
                            grdDatos.Rows.Add(new object[] { dtDatos.Rows[j][0], dtDatos.Rows[j][1], dtDatos.Rows[j][2],
                                                             dtDatos.Rows[j][3], dtDatos.Rows[j][4], dtDatos.Rows[j][5],
                                                             dtDatos.Rows[j][6]});
                        }
                        catch (Exception)
                        {
                        }
                    }
                    utilidades.setFormatGrid(grdDatos);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Se presentó el siguiente error: " + exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grdDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                if (grdDatos.Rows[e.RowIndex].Cells["seleccionado"].Value.Equals(true))
                    grdDatos.Rows[e.RowIndex].Cells["seleccionado"].Value = false;
                else
                    grdDatos.Rows[e.RowIndex].Cells["seleccionado"].Value = true;
            }
        }

        public ArrayList getEmpresasSeleccionadas()
        {
            ArrayList lstEmpresas = new ArrayList();
            for (int i = 0; i < grdDatos.Rows.Count; i++)
            {
                if (grdDatos.Rows[i].Cells["seleccionado"].Value.Equals(true))
                    lstEmpresas.Add(int.Parse(grdDatos.Rows[i].Cells["idEmpresa"].Value.ToString()));
            }
            if (lstEmpresas != null && lstEmpresas.Count > 0)
                return lstEmpresas;
            return null;
        }

        public void setEmpresasSeleccionadas(String[] idsEmpresas)
        {
            if (idsEmpresas != null && idsEmpresas.Length > 0)
            {
                foreach (String item in idsEmpresas)
                {
                    for (int i = 0; i < grdDatos.RowCount; i++)
                    {
                        if (item.Equals(grdDatos.Rows[i].Cells["idEmpresa"].Value.ToString()))
                        {
                            grdDatos.Rows[i].Cells["seleccionado"].Value = true;
                            break;
                        }
                    }
                }
            }
        }

        private void buscar()
        {
            DataView view = dtDatos.AsDataView();
            String filtro = cmbColumna.Text.Replace(' ', '_');
            view.RowFilter = filtro + " like '%" + txtFiltro.Text + "%' ";
            grdDatos.Rows.Clear();
            foreach (DataRowView item in view)
            {
                grdDatos.Rows.Add(new object[] { item[0], item[1], item[2],
                                                 item[3], item[4], item[5],
                                                 item[6]});
            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            buscar();
        }
    }
}

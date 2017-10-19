using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Controles
{
    public partial class ctrBuscar : UserControl
    {
        DataTable dtDatos;
        DataGridView grdDatos;
        int numItems;

        public ctrBuscar()
        {
            InitializeComponent();
        }


        public void setConfig(String[] listaCombo, DataGridView grdTabla, DataTable datos)
        {
            setComboColumna(listaCombo);
            grdDatos = grdTabla;
            numItems = grdTabla.ColumnCount - 1;
            dtDatos = datos;
        }

        public void setDatos(DataTable datos)
        {
            dtDatos = datos;
        }

        private void setComboColumna(String[] lista)
        {
            if (lista != null && lista.Length > 0)
            {
                cmbColumna.Items.Clear();
                foreach (String item in lista)
                {
                    cmbColumna.Items.Add(item);
                }
                cmbColumna.SelectedIndex = 0;
            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            buscar();
        }

        private void buscar()
        {
            int i = 1;
            DataView view = dtDatos.AsDataView();
            String columna = "";
            if (cmbColumna.Text.Contains(' '))
                columna = cmbColumna.Text.Replace(' ', '_');
            else
                columna = cmbColumna.Text;
            view.RowFilter = columna.Trim() + " like '%" + txtFiltro.Text + "%' ";//"NOM_TIPO_RED_SOCIAL like '%" + txtFiltro.Text + "%' "; ;
            grdDatos.Rows.Clear();
            foreach (DataRowView item in view)
            {
                switch (numItems)
                {
                    case 1:
                        grdDatos.Rows.Add(new object[] { i, item[1] });
                        break;
                    case 2:
                        grdDatos.Rows.Add(new object[] { i, item[1], item[2] });
                        break;
                    case 3:
                        grdDatos.Rows.Add(new object[] { i, item[1], item[2], item[3] });
                        break;
                    case 4:
                        grdDatos.Rows.Add(new object[] { i, item[1], item[2], item[3], item[4] });
                        break;
                    case 5:
                        grdDatos.Rows.Add(new object[] { i, item[1], item[2], item[3], item[4], item[5] });
                        break;
                    case 6:
                        grdDatos.Rows.Add(new object[] { i, item[1], item[2], item[3], item[4], item[5], item[6] });
                        break;
                    case 7:
                        grdDatos.Rows.Add(new object[] { i, item[1], item[2], item[3], item[4], item[5], item[6], item[7] });
                        break;
                    case 8:
                        grdDatos.Rows.Add(new object[] { i, item[1], item[2], item[3], item[4], item[5], item[6], item[7], item[8] });
                        break;
                    case 9:
                        grdDatos.Rows.Add(new object[] { i, item[1], item[2], item[3], item[4], item[5], item[6], item[7], item[8], item[9] });
                        break;
                    case 10:
                        grdDatos.Rows.Add(new object[] { i, item[1], item[2], item[3], item[4], item[5], item[6], item[7], item[8], item[9], item[10] });
                        break;
                    case 11:
                        grdDatos.Rows.Add(new object[] { i, item[1], item[2], item[3], item[4], item[5], item[6], item[7], item[8], item[9], item[10],
                                                            item[11]});
                        break;
                    case 12:
                        grdDatos.Rows.Add(new object[] { i, item[1], item[2], item[3], item[4], item[5], item[6], item[7], item[8], item[9], item[10],
                                                            item[11], item[12]});
                        break;
                    case 13:
                        grdDatos.Rows.Add(new object[] { i, item[1], item[2], item[3], item[4], item[5], item[6], item[7], item[8], item[9], item[10],
                                                            item[11], item[12], item[13]});
                        break;
                    case 14:
                        grdDatos.Rows.Add(new object[] { i, item[1], item[2], item[3], item[4], item[5], item[6], item[7], item[8], item[9], item[10],
                                                            item[11], item[12], item[13], item[14]});
                        break;
                    case 15:
                        grdDatos.Rows.Add(new object[] { i, item[1], item[2], item[3], item[4], item[5], item[6], item[7], item[8], item[9], item[10],
                                                            item[11], item[12], item[13], item[14], item[15]});
                        break;
                    default:
                        grdDatos.Rows.Add(new object[] { i });
                        break;
                }
                i++;
            }
        }
    }
}

using ClienteFiel.utilidades;
using ClienteFiel.WS_ServiciosDepartamento;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UtilidadesServiciosWeb;
using static ClienteFiel.utilidades.utilidades;

namespace ClienteFiel.modulos.accesorias
{
    public partial class GestionDepartamento : BaseAccesorias
    {
        ServiciosDepartamento serviciosDepartamento;
        DataTable dtDatos;

        public GestionDepartamento()
        {
            InitializeComponent();
            inicializarServicios();
            cmbColumna.SelectedIndex = 0;
            getDepartamentos();
            fijarSize(this);
        }

        private void getDepartamentos()
        {
            try
            {
                grdDepartamentos.Rows.Clear();
                Departamento[] lstDeptos = serviciosDepartamento.listarDepartamento();

                dtDatos = new DataTable();
                dtDatos.Columns.Add("No.", typeof(int));
                dtDatos.Columns.Add("ID_DEPARTAMENTO", typeof(String));
                dtDatos.Columns.Add("NOM_DEPARTAMENTO", typeof(String));

                if (lstDeptos != null && lstDeptos.Length > 0)
                {
                    int i = 0;
                    foreach (Departamento item in lstDeptos)
                    {
                        DataRow dr = dtDatos.NewRow();
                        dr[0] = i + 1;
                        dr[1] = item.ID_DEPARTAMENTO.ToString();
                        dr[2] = item.NOM_DEPARTAMENTO;
                        dtDatos.Rows.Add(dr);
                        i++;
                    }
                    //grdTiposActividad.DataSource = dtDatos;
                    for (int j = 0; j < dtDatos.Rows.Count; j++)
                    {
                        try
                        {
                            grdDepartamentos.Rows.Add(new object[] { dtDatos.Rows[j][0], dtDatos.Rows[j][1], dtDatos.Rows[j][2] });
                        }
                        catch (Exception)
                        {
                        }
                    }
                    utilidades.utilidades.setFormatGrid(grdDepartamentos);
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
                serviciosDepartamento = (ServiciosDepartamento)Configurador.ConfigurarServicio(typeof(ServiciosDepartamento));
                serviciosDepartamento.AutenticacionValue = new Autenticacion() { usuario = "U", contrasena = "1" };
            }
            catch (Exception e)
            {
                utilidades.Mensajes.mensajeError(e.Message);
            }
        }

        private void buscar()
        {
            int i = 1;
            DataView view = dtDatos.AsDataView();
            view.RowFilter = "NOM_DEPARTAMENTO like '%" + txtFiltro.Text + "%' ";
            grdDepartamentos.Rows.Clear();
            foreach (DataRowView item in view)
            {
                grdDepartamentos.Rows.Add(new object[] { i, item[1], item[2] });
                i++;
            }
        }

        private void eliminarDepartamento()
        {
            if (grdDepartamentos.Rows != null && grdDepartamentos.Rows.Count > 0 &&
                grdDepartamentos.SelectedRows != null && grdDepartamentos.SelectedRows.Count > 0)
            {
                try
                {
                    if (MessageBox.Show("¿Esta seguro(a) que desea eliminar el Departamento " + grdDepartamentos.SelectedRows[0].Cells["NOM_DEPARTAMENTO"].Value.ToString() + "?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        long tmpLong = 0;
                        Departamento tmpDpto = new Departamento();
                        tmpLong = 0;
                        long.TryParse(grdDepartamentos.SelectedRows[0].Cells["ID_DEPARTAMENTO"].Value.ToString(), out tmpLong);
                        tmpDpto.ID_DEPARTAMENTO = tmpLong;
                        if (tmpDpto.ID_DEPARTAMENTO > 0)
                        {
                            DepartamentoResponse objResponse = serviciosDepartamento.eliminarDepartamento(tmpDpto);
                            if (objResponse != null && objResponse.correcto)
                            {
                                utilidades.Mensajes.mensajeCorrecto("Departamento eliminado correctamente");
                            }
                            else
                                utilidades.Mensajes.errorWebServices(objResponse.error);
                            getDepartamentos();
                        }
                    }
                }
                catch (Exception exp)
                {
                    utilidades.Mensajes.mensajeError(exp.Message);
                }
            }
            else
                utilidades.Mensajes.mensajeError("Debe seleccionar un Departamento de la lista");
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            buscar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarDepartamento();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            setDepartamento setDpto = new setDepartamento(tipoOperacion.Insertar, null);
            setDpto.ShowDialog(this);
            getDepartamentos();
        }

        private void editarDepartamento()
        {
            if (grdDepartamentos.Rows != null && grdDepartamentos.Rows.Count > 0 &&
                grdDepartamentos.SelectedRows != null && grdDepartamentos.SelectedRows.Count > 0)
            {
                try
                {
                    Departamento tmpDpto = new Departamento();
                    tmpDpto.ID_DEPARTAMENTO = long.Parse(grdDepartamentos.SelectedRows[0].Cells["ID_DEPARTAMENTO"].Value.ToString());
                    tmpDpto.NOM_DEPARTAMENTO = grdDepartamentos.SelectedRows[0].Cells["NOM_DEPARTAMENTO"].Value.ToString();

                    setDepartamento setDpto = new setDepartamento(tipoOperacion.Editar, tmpDpto);
                    setDpto.ShowDialog(this);
                    getDepartamentos();
                }
                catch (Exception exp)
                {
                    utilidades.Mensajes.mensajeError(exp.Message);
                }
            }
            else
                utilidades.Mensajes.mensajeError("Debe seleccionar un Departamento de la lista");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            editarDepartamento();
        }
    }
}

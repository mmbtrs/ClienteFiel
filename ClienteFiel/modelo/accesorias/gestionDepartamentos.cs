using ClienteFiel.modelo.forms_base;
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

namespace ClienteFiel.modelo.accesorias
{
    public partial class gestionDepartamentos : frmBase
    {
        ServiciosDepartamento serviciosDepartamento;
        DataTable dtDatos;

        public gestionDepartamentos()
        {
            InitializeComponent();
            inicializarServicios();
            getDepartamentos();
            ctrBuscar1.setConfig(new String[] { "DEPARTAMENTO" }, grdDepartamentos, dtDatos);
            //Controles.utilidades.fijarSize(this);
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
                dtDatos.Columns.Add("DEPARTAMENTO", typeof(String));

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
                    ctrBuscar1.setDatos(dtDatos);
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
                    Controles.utilidades.setFormatGrid(grdDepartamentos);
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
                serviciosDepartamento = (ServiciosDepartamento)Configurador.ConfigurarServicio(typeof(ServiciosDepartamento));
                serviciosDepartamento.AutenticacionValue = new Autenticacion() { usuario = "U", contrasena = "1" };
            }
            catch (Exception e)
            {
                Controles.mensajes.mensajeError(e.Message);
            }
        }

        private void eliminarDepartamento()
        {
            if (grdDepartamentos.Rows != null && grdDepartamentos.Rows.Count > 0 &&
                grdDepartamentos.SelectedRows != null && grdDepartamentos.SelectedRows.Count > 0)
            {
                try
                {
                    if (MessageBox.Show("¿Esta seguro(a) que desea eliminar el Departamento " + grdDepartamentos.SelectedRows[0].Cells["DEPARTAMENTO"].Value.ToString() + "?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
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
                                Controles.mensajes.mensajeCorrecto("Departamento eliminado correctamente");
                            }
                            else
                                Controles.mensajes.errorWebServices(objResponse.error);
                            getDepartamentos();
                        }
                    }
                }
                catch (Exception exp)
                {
                    Controles.mensajes.mensajeError(exp.Message);
                }
            }
            else
                Controles.mensajes.mensajeError("Debe seleccionar un Departamento de la lista");
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
                    tmpDpto.NOM_DEPARTAMENTO = grdDepartamentos.SelectedRows[0].Cells["DEPARTAMENTO"].Value.ToString();

                    setDepartamento setDpto = new setDepartamento(Controles.utilidades.tipoOperacion.Editar, tmpDpto);
                    setDpto.ShowDialog(this);
                    getDepartamentos();
                }
                catch (Exception exp)
                {
                    Controles.mensajes.mensajeError(exp.Message);
                }
            }
            else
                Controles.mensajes.mensajeError("Debe seleccionar un Departamento de la lista");
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            setDepartamento setDpto = new setDepartamento(Controles.utilidades.tipoOperacion.Insertar, null);
            setDpto.ShowDialog(this);
            getDepartamentos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            editarDepartamento();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarDepartamento();
        }
    }
}

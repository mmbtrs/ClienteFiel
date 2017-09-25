using ClienteFiel.utilidades;
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

namespace ClienteFiel.modulos.empresa
{
    public partial class GestionEmpresa : BaseAccesorias
    {
        ServiciosViewempresa serviciosViewempresa;
        DataTable dtDatos;

        public GestionEmpresa()
        {
            InitializeComponent();
            inicializarServicios();
            cmbColumna.SelectedIndex = 0;
            getEmpresas();
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
                utilidades.Mensajes.mensajeError(exp.Message);
            }
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
                utilidades.Mensajes.mensajeError(exp.Message);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            SetEmpresa setEmpresa = new SetEmpresa(Controles.utilidades.tipoOperacion.Insertar, null);
            setEmpresa.ShowDialog(this);
        }
    }
}

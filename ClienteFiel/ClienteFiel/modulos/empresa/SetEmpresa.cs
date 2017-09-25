using ClienteFiel.WS_ServiciosEmpresa;
using ClienteFiel.WS_ServiciosImagen;
using ClienteFiel.WS_ServiciosTiporedsocial;
using ServiciosWebClienteFiel.Servicios;
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
    public partial class SetEmpresa : Form
    {
        Controles.utilidades.tipoOperacion operacion;
        WS_ServiciosEmpresa.Empresa empresa;
        WS_ServiciosEmpresa.ServiciosEmpresa serviciosEmpresa;
        WS_ServiciosDepartamento.ServiciosDepartamento serviciosDepartamento;
        WS_ServiciosMunicipio.ServiciosMunicipio serviciosMunicipio;
        WS_ServiciosImagen.ServiciosImagen serviciosImagen;
        WS_ServiciosTiporedsocial.ServiciosTiporedsocial serviciosTiporedsocial;

        DataTable dtDatos;

        public SetEmpresa(Controles.utilidades.tipoOperacion tmpOperacion, WS_ServiciosEmpresa.Empresa tmpEmpresa)
        {
            InitializeComponent();
            inicializarServicios();
            operacion = tmpOperacion;
            empresa = tmpEmpresa;
            configuracionInicial();
            getDepartamentos();
            getMunicipios();
            getTiposRedesSociales();
            Controles.utilidades.fijarSize(this);
        }

        private void inicializarServicios()
        {
            try
            {
                serviciosEmpresa = (WS_ServiciosEmpresa.ServiciosEmpresa)Configurador.ConfigurarServicio(typeof(WS_ServiciosEmpresa.ServiciosEmpresa));
                serviciosEmpresa.AutenticacionValue = new WS_ServiciosEmpresa.Autenticacion() { usuario = "U", contrasena = "1" };
                serviciosDepartamento = (WS_ServiciosDepartamento.ServiciosDepartamento)Configurador.ConfigurarServicio(typeof(WS_ServiciosDepartamento.ServiciosDepartamento));
                serviciosDepartamento.AutenticacionValue = new WS_ServiciosDepartamento.Autenticacion() { usuario = "U", contrasena = "1" };
                serviciosMunicipio = (WS_ServiciosMunicipio.ServiciosMunicipio)Configurador.ConfigurarServicio(typeof(WS_ServiciosMunicipio.ServiciosMunicipio));
                serviciosMunicipio.AutenticacionValue = new WS_ServiciosMunicipio.Autenticacion() { usuario = "U", contrasena = "1" };
                serviciosImagen = (WS_ServiciosImagen.ServiciosImagen)Configurador.ConfigurarServicio(typeof(WS_ServiciosImagen.ServiciosImagen));
                serviciosImagen.AutenticacionValue = new WS_ServiciosImagen.Autenticacion() { usuario = "U", contrasena = "1" };
                serviciosTiporedsocial = (WS_ServiciosTiporedsocial.ServiciosTiporedsocial)Configurador.ConfigurarServicio(typeof(WS_ServiciosTiporedsocial.ServiciosTiporedsocial));
                serviciosTiporedsocial.AutenticacionValue = new WS_ServiciosTiporedsocial.Autenticacion() { usuario = "U", contrasena = "1" };
            }
            catch (Exception exp)
            {
                utilidades.Mensajes.mensajeError(exp.Message);
            }
        }

        private void configuracionInicial()
        {
            try
            {
                if (operacion == Controles.utilidades.tipoOperacion.Insertar)
                {
                    this.Text = "Crear Nueva Empresa";
                    lblTituloVentana.Text = "Nueva Empresa";
                }
                else
                {
                    this.Text = "Editar Empresa";
                    lblTituloVentana.Text = "Editar Empresa";
                    //txtNombreTipoActividad.Text = tipoactividad.NOM_TIPO_ACTIVIDAD;
                }
            }
            catch (Exception exp)
            {
                utilidades.Mensajes.mensajeError(exp.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void getMunicipios()
        {
            try
            {
                cmbMunicipio.Items.Clear();
                cmbMunicipio.DisplayMember = "NOM_MUNICIPIO";
                if (cmbDpto.Items != null && cmbDpto.Items.Count > 0 && cmbDpto.SelectedItem != null)
                {
                    WS_ServiciosDepartamento.Departamento tmpDpto = (WS_ServiciosDepartamento.Departamento)cmbDpto.SelectedItem;
                    if (tmpDpto != null && tmpDpto.ID_DEPARTAMENTO > 0)
                    {
                        WS_ServiciosMunicipio.Municipio tmpMunicipio = new WS_ServiciosMunicipio.Municipio();
                        tmpMunicipio.ID_DEPARTAMENTO = tmpDpto.ID_DEPARTAMENTO;
                        WS_ServiciosMunicipio.Municipio[] lstMunicipios = serviciosMunicipio.buscarMunicipio(tmpMunicipio);
                        if (lstMunicipios != null && lstMunicipios.Length > 0)
                        {
                            foreach (WS_ServiciosMunicipio.Municipio item in lstMunicipios)
                            {
                                cmbMunicipio.Items.Add(item);
                            }
                            cmbMunicipio.SelectedIndex = 0;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                utilidades.Mensajes.mensajeError(e.Message);
            }
        }

        private void getDepartamentos()
        {
            try
            {
                cmbDpto.Items.Clear();
                cmbDpto.DisplayMember = "NOM_DEPARTAMENTO";
                WS_ServiciosDepartamento.Departamento[] lstDptos = serviciosDepartamento.listarDepartamento();
                if (lstDptos != null && lstDptos.Length > 0)
                {
                    foreach (WS_ServiciosDepartamento.Departamento item in lstDptos)
                    {
                        cmbDpto.Items.Add(item);
                    }
                    cmbDpto.SelectedIndex = 0;
                }
            }
            catch (Exception e)
            {
                utilidades.Mensajes.mensajeError(e.Message);
            }
        }

        private void cmbDpto_SelectedIndexChanged(object sender, EventArgs e)
        {
            getMunicipios();
        }

        public WS_ServiciosMunicipio.Municipio getMunicipio()
        {
            try
            {
                if (cmbMunicipio.Items != null && cmbMunicipio.Items.Count > 0 && cmbMunicipio.SelectedItem != null)
                    return (WS_ServiciosMunicipio.Municipio)cmbMunicipio.SelectedItem;
                else
                    return null;
            }
            catch (Exception e)
            {
                utilidades.Mensajes.mensajeError(e.Message);
                return null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void radOtra_CheckedChanged(object sender, EventArgs e)
        {
            if (radOtra.Checked)
            {
                txtSucursal.Enabled = true;
                txtSucursal.Focus();
            }
            else
                txtSucursal.Enabled = false;
        }

        private void txtNit_KeyPress(object sender, KeyPressEventArgs e)
        {
            Controles.utilidades.esNumero(e);
            Controles.utilidades.lanzarTapConEnter(e);
        }

        private void txtRazonSocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            Controles.utilidades.lanzarTapConEnter(e);
        }

        private void cmbDpto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Controles.utilidades.lanzarTapConEnter(e);
        }

        private void cmbMunicipio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Controles.utilidades.lanzarTapConEnter(e);
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Controles.utilidades.lanzarTapConEnter(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Controles.utilidades.lanzarTapConEnter(e);
        }

        private void txtSlogan_KeyPress(object sender, KeyPressEventArgs e)
        {
            Controles.utilidades.lanzarTapConEnter(e);
        }

        private void radPrincipal_KeyPress(object sender, KeyPressEventArgs e)
        {
            Controles.utilidades.lanzarTapConEnter(e);
        }

        private void radOtra_KeyPress(object sender, KeyPressEventArgs e)
        {
            Controles.utilidades.lanzarTapConEnter(e);
        }

        private void txtSucursal_KeyPress(object sender, KeyPressEventArgs e)
        {
            Controles.utilidades.lanzarTapConEnter(e);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (operacion == Controles.utilidades.tipoOperacion.Insertar)
            {
                guardar();
            }
            else
            {
                editar();
            }
        }

        private void guardar()
        {
            try
            {
                if (ctrLogo.getImage() != null)
                {
                    ImagenResponse responseImagen = guardarImagen();
                    if (responseImagen.correcto)
                    {
                        WS_ServiciosEmpresa.Empresa tmpEmpresa = new WS_ServiciosEmpresa.Empresa();
                        tmpEmpresa.DIRECCION_CLIENTE = txtDireccion.Text.Trim();
                        tmpEmpresa.ID_IMAGEN = responseImagen.objeto.ID_IMAGEN;
                        if (cmbMunicipio.SelectedItem != null)
                            tmpEmpresa.ID_MUNICIPIO = ((WS_ServiciosMunicipio.Municipio)cmbMunicipio.SelectedItem).ID_MUNICIPIO;
                        tmpEmpresa.NIT = txtNit.Text.Trim();
                        tmpEmpresa.RAZON_SOCIAL = txtRazonSocial.Text.Trim();
                        tmpEmpresa.SLOGAN = txtSlogan.Text.Trim();
                        if (radPrincipal.Checked)
                            tmpEmpresa.SUCURSAL = "PRINCIPAL";
                        else
                            tmpEmpresa.SUCURSAL = txtSucursal.Text.Trim();
                        tmpEmpresa.TELEFONO = txtTelefono.Text.Trim();
                        EmpresaResponse responseEmpresa = serviciosEmpresa.crearEmpresa(tmpEmpresa);
                        if (responseEmpresa != null && responseEmpresa.correcto)
                        {
                            utilidades.Mensajes.mensajeCorrecto("Los datos de la empresa fueron guardados correctamente");
                        }
                        else
                        {
                            serviciosImagen.eliminarImagen(responseImagen.objeto);
                            utilidades.Mensajes.errorWebServices(responseEmpresa.error);
                        }
                    }
                    else
                        utilidades.Mensajes.errorWebServices(responseImagen.error);
                }
                else
                {

                }
            }
            catch (Exception e)
            {
                utilidades.Mensajes.mensajeError(e.Message);
            }
        }

        private void editar()
        {
            throw new NotImplementedException();
        }

        private ImagenResponse guardarImagen()
        {
            ImagenResponse objResponse;
            try
            {
                Imagen objImagen = new Imagen();
                objImagen.IMAGEN = Controles.utilidades.ImageToByte(ctrLogo.getImage());
                objResponse = serviciosImagen.crearImagen(objImagen);
                return objResponse;
            }
            catch (Exception exp)
            {
                utilidades.Mensajes.mensajeError(exp.Message);
                objResponse = new ImagenResponse();
                objResponse.correcto = false;
                objResponse.error = exp.Message;
                return objResponse;
            }
        }

        private void getTiposRedesSociales()
        {
            try
            {
                grdTiposRedesSociales.Rows.Clear();
                Tiporedsocial[] lstTiposRedesSociales = serviciosTiporedsocial.listarTiporedsocial();

                dtDatos = new DataTable();
                dtDatos.Columns.Add("No.", typeof(int));
                dtDatos.Columns.Add("ID_TIPO_RED_SOCIAL", typeof(String));
                dtDatos.Columns.Add("NOM_TIPO_RED_SOCIAL", typeof(String));
                dtDatos.Columns.Add("ID_IMAGEN", typeof(String));
                dtDatos.Columns.Add("IMAGEN", typeof(Image));

                if (lstTiposRedesSociales != null && lstTiposRedesSociales.Length > 0)
                {
                    int i = 0;
                    foreach (Tiporedsocial item in lstTiposRedesSociales)
                    {
                        DataRow dr = dtDatos.NewRow();
                        dr[0] = i + 1;
                        dr[1] = item.ID_TIPO_RED_SOCIAL.ToString();
                        dr[2] = item.NOM_TIPO_RED_SOCIAL;

                        Imagen tmpImagen = new Imagen();
                        tmpImagen.ID_IMAGEN = item.ID_IMAGEN;
                        tmpImagen = serviciosImagen.buscarPrimeroImagen(tmpImagen);
                        if (tmpImagen != null && tmpImagen.ID_IMAGEN > 0)
                        {
                            dr[3] = tmpImagen.ID_IMAGEN.ToString();
                            dr[4] = Controles.utilidades.byteToImagen(tmpImagen.IMAGEN);
                        }
                        else
                        {
                            dr[3] = "";
                            dr[4] = null;
                        }
                        dtDatos.Rows.Add(dr);
                        i++;
                    }
                    //grdTiposRedesSociales.DataSource = dtDatos;
                    for (int j = 0; j < dtDatos.Rows.Count; j++)
                    {
                        try
                        {
                            grdTiposRedesSociales.Rows.Add(new object[] { dtDatos.Rows[j][0], dtDatos.Rows[j][1], dtDatos.Rows[j][2], dtDatos.Rows[j][3], dtDatos.Rows[j][4] });
                        }
                        catch (Exception)
                        {
                            grdTiposRedesSociales.Rows.Add(new object[] { dtDatos.Rows[j][0], dtDatos.Rows[j][1], dtDatos.Rows[j][2], dtDatos.Rows[j][3], null });
                        }
                    }
                    Controles.utilidades.setFormatGrid(grdTiposRedesSociales);
                }
            }
            catch (Exception exp)
            {
                utilidades.Mensajes.mensajeError(exp.Message);
            }
        }

        private void buscar()
        {
            int i = 1;
            DataView view = dtDatos.AsDataView();
            view.RowFilter = "NOM_TIPO_RED_SOCIAL like '%" + txtFiltroRed.Text + "%' ";
            grdTiposRedesSociales.Rows.Clear();
            foreach (DataRowView item in view)
            {
                grdTiposRedesSociales.Rows.Add(new object[] { i, item[1], item[2], item[3], item[4] });
                i++;
            }
        }

        private void txtFiltroRed_TextChanged(object sender, EventArgs e)
        {
            buscar();
        }
    }
}

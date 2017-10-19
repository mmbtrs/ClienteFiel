using ClienteFiel.modelo.forms_base;
using ClienteFiel.WS_ServiciosEmpresa;
using ClienteFiel.WS_ServiciosImagen;
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

namespace ClienteFiel.modelo.empresa
{
    public partial class setEmpresa : frmBase
    {
        ServiciosEmpresa serviciosEmpresa;
        ServiciosImagen serviciosImagen;

        Controles.utilidades.tipoOperacion operacion;
        Viewempresa viewEmpresa;
        long id_municipio;
        Image logo;

        public setEmpresa(Controles.utilidades.tipoOperacion tmpOperacion, Viewempresa tmpViewEmpresa, long idMunicipio)
        {
            InitializeComponent();
            InicializarServicios();
            operacion = tmpOperacion;
            viewEmpresa = tmpViewEmpresa;
            id_municipio = idMunicipio;
            configuracionInicial();
            Controles.utilidades.fijarSize(this);
        }

        private void configuracionInicial()
        {
            try
            {
                ctrMunicipio.iniciar();
                
                if (operacion == Controles.utilidades.tipoOperacion.Insertar)
                {
                    lblTituloVentana.Text = "Crear Nueva Empresa";
                    logo = null;
                }
                else
                {
                    lblTituloVentana.Text = "Editar Empresa";
                    txtNit.Text = viewEmpresa.NIT;
                    txtRazonSocial.Text = viewEmpresa.RAZON_SOCIAL;
                    ctrLogo.setImage(Controles.utilidades.byteToImagen(viewEmpresa.IMAGEN));
                    txtDireccion.Text = viewEmpresa.DIRECCION_CLIENTE;
                    txtTelefono.Text = viewEmpresa.TELEFONO;
                    txtSlogan.Text = viewEmpresa.SLOGAN;
                    if (viewEmpresa.SUCURSAL.Equals("PRINCIPAL"))
                    {
                        radPrincipal.Checked = true;
                        radOtra.Checked = false;
                        txtSucursal.Text = "";
                    }
                    else
                    {
                        radPrincipal.Checked = !true;
                        radOtra.Checked = !false;
                        txtSucursal.Text = viewEmpresa.SUCURSAL;
                    }

                    if (viewEmpresa != null && viewEmpresa.ID_IMAGEN > 0)
                    {
                        Imagen tmpImagen = new Imagen();
                        tmpImagen.ID_IMAGEN = viewEmpresa.ID_IMAGEN;
                        tmpImagen = serviciosImagen.buscarPrimeroImagen(tmpImagen);
                        if (tmpImagen != null && tmpImagen.IMAGEN != null && tmpImagen.IMAGEN.Length > 0)
                            logo = Controles.utilidades.byteToImagen(tmpImagen.IMAGEN);
                        else
                            logo = null;
                    }
                    else
                        logo = null;
                }
            }
            catch (Exception exp)
            {
                Controles.mensajes.mensajeError(exp.Message);
            }
        }

        private void InicializarServicios()
        {
            serviciosEmpresa = (ServiciosEmpresa)Configurador.ConfigurarServicio(typeof(ServiciosEmpresa));
            serviciosEmpresa.AutenticacionValue = new WS_ServiciosEmpresa.Autenticacion() { usuario = "U", contrasena = "1" };
            serviciosImagen = (ServiciosImagen)Configurador.ConfigurarServicio(typeof(ServiciosImagen));
            serviciosImagen.AutenticacionValue = new WS_ServiciosImagen.Autenticacion() { usuario = "U", contrasena = "1" };
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

        private void setEmpresa_Load(object sender, EventArgs e)
        {
            if (operacion == Controles.utilidades.tipoOperacion.Editar && id_municipio > 0)
                ctrMunicipio.setMunicipio(id_municipio);
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
                        if (ctrMunicipio.getMunicipioSeleccionado() != null)
                            tmpEmpresa.ID_MUNICIPIO = (ctrMunicipio.getMunicipioSeleccionado()).ID_MUNICIPIO;
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
                            Controles.mensajes.mensajeCorrecto("Los datos de la empresa fueron guardados correctamente");
                        }
                        else
                        {
                            serviciosImagen.eliminarImagen(responseImagen.objeto);
                            Controles.mensajes.errorWebServices(responseEmpresa.error);
                        }
                    }
                    else
                        Controles.mensajes.errorWebServices(responseImagen.error);
                }
                else
                {
                    WS_ServiciosEmpresa.Empresa tmpEmpresa = new WS_ServiciosEmpresa.Empresa();
                    tmpEmpresa.DIRECCION_CLIENTE = txtDireccion.Text.Trim();
                    if (ctrMunicipio.getMunicipioSeleccionado() != null)
                        tmpEmpresa.ID_MUNICIPIO = (ctrMunicipio.getMunicipioSeleccionado()).ID_MUNICIPIO;
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
                        Controles.mensajes.mensajeCorrecto("Los datos de la empresa fueron guardados correctamente");
                    }
                    else
                    {
                        Controles.mensajes.errorWebServices(responseEmpresa.error);
                    }
                }
            }
            catch (Exception e)
            {
                Controles.mensajes.mensajeError(e.Message);
            }
        }

        private void editar()
        {
            try
            {
                if (ctrLogo.getImage() != null)
                {
                    ImagenResponse tmpImagenResponse = editarImagen();
                    if (tmpImagenResponse.correcto)
                    {
                        Empresa tmpEmpresa = new Empresa();
                        tmpEmpresa.DIRECCION_CLIENTE = txtDireccion.Text.Trim();
                        tmpEmpresa.ID_EMPRESA = viewEmpresa.ID_EMPRESA;
                        tmpEmpresa.ID_IMAGEN = ((Imagen)tmpImagenResponse.objeto).ID_IMAGEN;
                        tmpEmpresa.ID_MUNICIPIO = (ctrMunicipio.getMunicipioSeleccionado()).ID_MUNICIPIO;
                        tmpEmpresa.NIT = txtNit.Text.Trim();
                        tmpEmpresa.RAZON_SOCIAL = txtRazonSocial.Text.Trim();
                        tmpEmpresa.SLOGAN = txtSlogan.Text.Trim();
                        if (radPrincipal.Checked)
                            tmpEmpresa.SUCURSAL = "PRINCIPAL";
                        else
                            tmpEmpresa.SUCURSAL = txtSucursal.Text.Trim();
                        tmpEmpresa.TELEFONO = txtTelefono.Text.Trim();
                        EmpresaResponse tmpEmpresaResponse = serviciosEmpresa.editarEmpresa(tmpEmpresa);

                        if (tmpEmpresaResponse.correcto)
                        {
                            Controles.mensajes.mensajeCorrecto("La Empresa fue modificada correctamente");
                            this.Close();
                        }
                        else
                        {
                            Controles.mensajes.errorWebServices(tmpEmpresaResponse.error);
                            serviciosImagen.eliminarImagen(tmpImagenResponse.objeto);
                        }
                    }
                    else
                        Controles.mensajes.errorWebServices(tmpImagenResponse.error);
                }
                else
                {
                    Empresa tmpEmpresa = new Empresa();
                    tmpEmpresa.DIRECCION_CLIENTE = txtDireccion.Text.Trim();
                    tmpEmpresa.ID_EMPRESA = viewEmpresa.ID_EMPRESA;
                    tmpEmpresa.ID_MUNICIPIO = (ctrMunicipio.getMunicipioSeleccionado()).ID_MUNICIPIO;
                    tmpEmpresa.NIT = txtNit.Text.Trim();
                    tmpEmpresa.RAZON_SOCIAL = txtRazonSocial.Text.Trim();
                    tmpEmpresa.SLOGAN = txtSlogan.Text.Trim();
                    if (radPrincipal.Checked)
                        tmpEmpresa.SUCURSAL = "PRINCIPAL";
                    else
                        tmpEmpresa.SUCURSAL = txtSucursal.Text.Trim();
                    tmpEmpresa.TELEFONO = txtTelefono.Text.Trim();
                    EmpresaResponse tmpEmpresaResponse = serviciosEmpresa.editarEmpresa(tmpEmpresa);

                    if (tmpEmpresaResponse.correcto)
                    {
                        Controles.mensajes.mensajeCorrecto("La Empresa fue modificada correctamente");
                        if (viewEmpresa.ID_IMAGEN > 0)
                        {
                            Imagen tmpImg = new Imagen();
                            tmpImg.ID_IMAGEN = viewEmpresa.ID_IMAGEN;
                            ImagenResponse imgResponse = serviciosImagen.eliminarImagen(tmpImg);
                            if (imgResponse != null && !imgResponse.correcto)
                                Controles.mensajes.errorWebServices(imgResponse.error);
                        }
                        this.Close();
                    }
                    else
                    {
                        Controles.mensajes.errorWebServices(tmpEmpresaResponse.error);
                    }
                }
            }
            catch (Exception exp)
            {
                Controles.mensajes.mensajeError(exp.Message);
            }
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
                Controles.mensajes.mensajeError(exp.Message);
                objResponse = new ImagenResponse();
                objResponse.correcto = false;
                objResponse.error = exp.Message;
                return objResponse;
            }
        }

        private ImagenResponse editarImagen()
        {
            ImagenResponse objResponse;
            try
            {
                Imagen objImagen = new Imagen();
                objImagen.IMAGEN = Controles.utilidades.ImageToByte(ctrLogo.getImage());
                if (logo != null && viewEmpresa.ID_IMAGEN > 0)
                {
                    objImagen.ID_IMAGEN = viewEmpresa.ID_IMAGEN;
                    objResponse = serviciosImagen.editarImagen(objImagen);
                    objResponse.objeto = objImagen;
                }
                else
                {
                    objResponse = serviciosImagen.crearImagen(objImagen);
                    if (objResponse.correcto && objResponse.objeto != null && objResponse.objeto.ID_IMAGEN > 0)
                        logo = Controles.utilidades.byteToImagen(objResponse.objeto.IMAGEN);
                }
                return objResponse;
            }
            catch (Exception exp)
            {
                Controles.mensajes.mensajeError(exp.Message);
                objResponse = new ImagenResponse();
                objResponse.correcto = false;
                objResponse.error = exp.Message;
                return objResponse;
            }
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
    }
}

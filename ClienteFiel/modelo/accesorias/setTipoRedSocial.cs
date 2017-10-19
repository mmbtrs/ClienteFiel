using ClienteFiel.modelo.forms_base;
using ClienteFiel.WS_ServiciosImagen;
using ClienteFiel.WS_ServiciosTiporedsocial;
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
    public partial class setTipoRedSocial : frmBase
    {
        ServiciosTiporedsocial serviciosTiporedsocial;
        ServiciosImagen serviciosImagen;

        Controles.utilidades.tipoOperacion operacion;
        Tiporedsocial tipoRed;
        Imagen imagen;

        public setTipoRedSocial(Controles.utilidades.tipoOperacion tmpOperacion, Tiporedsocial tmpTipo, Imagen tmpImagen)
        {
            InitializeComponent();
            operacion = tmpOperacion;
            tipoRed = tmpTipo;
            imagen = tmpImagen;
            configuracionInicial();
            inicializarServicios();
            Controles.utilidades.fijarSize(this);
        }

        private void inicializarServicios()
        {
            try
            {
                serviciosTiporedsocial = (ServiciosTiporedsocial)Configurador.ConfigurarServicio(typeof(ServiciosTiporedsocial));
                serviciosTiporedsocial.AutenticacionValue = new WS_ServiciosTiporedsocial.Autenticacion() { usuario = "U", contrasena = "1" };
                serviciosImagen = (ServiciosImagen)Configurador.ConfigurarServicio(typeof(ServiciosImagen));
                serviciosImagen.AutenticacionValue = new WS_ServiciosImagen.Autenticacion() { usuario = "U", contrasena = "1" };
            }
            catch (Exception exp)
            {
                Controles.mensajes.mensajeError(exp.Message);
            }
        }

        private void configuracionInicial()
        {
            try
            {
                if (operacion == Controles.utilidades.tipoOperacion.Insertar)
                {
                    this.Text = "Crear Nueva Red Social";
                    lblTituloVentana.Text = "Nueva Red Social";
                }
                else
                {
                    this.Text = "Editar Red Social";
                    lblTituloVentana.Text = "Edición Red Social";
                    txtNombreTipoRed.Text = tipoRed.NOM_TIPO_RED_SOCIAL;
                    if (imagen.IMAGEN != null && imagen.IMAGEN.Length > 0)
                        ctrLogo.setImage(Controles.utilidades.byteToImagen(imagen.IMAGEN));
                    else
                        ctrLogo.setImage(null);
                }
            }
            catch (Exception exp)
            {
                Controles.mensajes.mensajeError(exp.Message);
            }
        }

        private void editar()
        {
            if (ctrLogo.getImage() != null)
            {
                ImagenResponse tmpImagenResponse = editarImagen();
                if (tmpImagenResponse.correcto)
                {
                    TiporedsocialResponse tmpTipoRedResponse = editarTipoRed(tmpImagenResponse.objeto);
                    if (tmpTipoRedResponse.correcto)
                    {
                        Controles.mensajes.mensajeCorrecto("La Red Social fue modificada correctamente");
                        this.Close();
                    }
                    else
                    {
                        Controles.mensajes.errorWebServices(tmpTipoRedResponse.error);
                        serviciosImagen.eliminarImagen(tmpImagenResponse.objeto);
                    }
                }
                else
                    Controles.mensajes.errorWebServices(tmpImagenResponse.error);
            }
            else
            {
                TiporedsocialResponse tmpTipoRedResponse = editarTipoRed(null);
                if (tmpTipoRedResponse.correcto)
                {
                    Controles.mensajes.mensajeCorrecto("La Red Social fue modificada correctamente");
                    if (imagen != null && imagen.ID_IMAGEN > 0)
                        serviciosImagen.eliminarImagen(imagen);
                    this.Close();
                }
                else
                {
                    Controles.mensajes.errorWebServices(tmpTipoRedResponse.error);
                    //serviciosImagen.eliminarImagen(tmpImagenResponse.objeto);
                }
            }
        }

        private ImagenResponse editarImagen()
        {
            ImagenResponse objResponse;
            try
            {
                Imagen objImagen = new Imagen();
                objImagen.IMAGEN = Controles.utilidades.ImageToByte(ctrLogo.getImage());
                if (imagen != null && imagen.ID_IMAGEN > 0)
                {
                    objImagen.ID_IMAGEN = imagen.ID_IMAGEN;
                    objResponse = serviciosImagen.editarImagen(objImagen);
                    objResponse.objeto = objImagen;
                }
                else
                {
                    objResponse = serviciosImagen.crearImagen(objImagen);
                    if (objResponse.correcto && objResponse.objeto != null && objResponse.objeto.ID_IMAGEN > 0)
                        imagen = objResponse.objeto;
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

        private void guardar()
        {
            if (ctrLogo.getImage() != null)
            {
                ImagenResponse tmpImagenResponse = guardarImagen();
                if (tmpImagenResponse.correcto)
                {
                    TiporedsocialResponse tmpTipoRedResponse = crearTipoRed(tmpImagenResponse.objeto);
                    if (tmpTipoRedResponse.correcto)
                    {
                        Controles.mensajes.mensajeCorrecto("La nueva Red Social fue creada correctamente");
                        txtNombreTipoRed.Text = "";
                        ctrLogo.setImage(null);
                    }
                    else
                    {
                        Controles.mensajes.errorWebServices(tmpTipoRedResponse.error);
                        serviciosImagen.eliminarImagen(tmpImagenResponse.objeto);
                    }
                }
                else
                    Controles.mensajes.errorWebServices(tmpImagenResponse.error);
            }
            else
            {
                TiporedsocialResponse tmpTipoRedResponse = crearTipoRed(null);
                if (tmpTipoRedResponse.correcto)
                {
                    Controles.mensajes.mensajeCorrecto("La nueva Red Social fue creada correctamente");
                    txtNombreTipoRed.Text = "";
                    ctrLogo.setImage(null);
                }
                else
                {
                    Controles.mensajes.errorWebServices(tmpTipoRedResponse.error);
                }
            }
        }

        private TiporedsocialResponse editarTipoRed(Imagen objeto)
        {
            TiporedsocialResponse objResponse;
            try
            {
                Tiporedsocial objTpoRed;
                objTpoRed = new Tiporedsocial();
                if (objeto != null)
                    objTpoRed.ID_IMAGEN = objeto.ID_IMAGEN;
                if (!String.IsNullOrEmpty(txtNombreTipoRed.Text) && !String.IsNullOrWhiteSpace(txtNombreTipoRed.Text))
                    objTpoRed.NOM_TIPO_RED_SOCIAL = txtNombreTipoRed.Text.Trim();
                objTpoRed.ID_TIPO_RED_SOCIAL = tipoRed.ID_TIPO_RED_SOCIAL;
                objResponse = serviciosTiporedsocial.editarTiporedsocial(objTpoRed);
                return objResponse;
            }
            catch (Exception exp)
            {
                Controles.mensajes.mensajeError(exp.Message);
                objResponse = new TiporedsocialResponse();
                objResponse.correcto = false;
                objResponse.error = exp.Message;
                return objResponse;
            }
        }

        private TiporedsocialResponse crearTipoRed(Imagen objeto)
        {
            TiporedsocialResponse objResponse;
            try
            {
                Tiporedsocial objTpoRed;
                objTpoRed = new Tiporedsocial();
                if (objeto != null)
                    objTpoRed.ID_IMAGEN = objeto.ID_IMAGEN;
                if (!String.IsNullOrEmpty(txtNombreTipoRed.Text) && !String.IsNullOrWhiteSpace(txtNombreTipoRed.Text))
                    objTpoRed.NOM_TIPO_RED_SOCIAL = txtNombreTipoRed.Text.Trim();
                objResponse = serviciosTiporedsocial.crearTiporedsocial(objTpoRed);
                return objResponse;
            }
            catch (Exception exp)
            {
                Controles.mensajes.mensajeError(exp.Message);
                objResponse = new TiporedsocialResponse();
                objResponse.correcto = false;
                objResponse.error = exp.Message;
                return objResponse;
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (operacion == Controles.utilidades.tipoOperacion.Insertar)
                guardar();
            else
                editar();
        }
    }
}

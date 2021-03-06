﻿using ClienteFiel.modelo.forms_base;
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
    public partial class setDepartamento : frmBase
    {
        ServiciosDepartamento serviciosDepartamento;
        Controles.utilidades.tipoOperacion operacion;
        Departamento departamento;

        public setDepartamento(Controles.utilidades.tipoOperacion tmpOperacion, Departamento tmpDpto)
        {
            InitializeComponent();
            inicializarServicios();
            operacion = tmpOperacion;
            departamento = tmpDpto;
            configuracionInicial();
            Controles.utilidades.fijarSize(this);
        }

        private void configuracionInicial()
        {
            try
            {
                if (operacion == Controles.utilidades.tipoOperacion.Insertar)
                {
                    this.Text = "Crear Nuevo Departamento";
                    lblTituloVentana.Text = "Nuevo Departamento";
                }
                else
                {
                    this.Text = "Editar Departamento";
                    lblTituloVentana.Text = "Edición Departamento";
                    txtDepartamento.Text = departamento.NOM_DEPARTAMENTO;
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
            catch (Exception exp)
            {
                Controles.mensajes.mensajeError(exp.Message);
            }
        }

        private void editar()
        {
            DepartamentoResponse objResponse;
            try
            {
                Departamento obj;
                obj = new Departamento();

                if (!String.IsNullOrEmpty(txtDepartamento.Text) && !String.IsNullOrWhiteSpace(txtDepartamento.Text))
                    obj.NOM_DEPARTAMENTO = txtDepartamento.Text.Trim();
                obj.ID_DEPARTAMENTO = departamento.ID_DEPARTAMENTO;
                objResponse = serviciosDepartamento.editarDepartamento(obj);
                if (objResponse != null && objResponse.correcto)
                {
                    Controles.mensajes.mensajeCorrecto("La información del Departamento se modificó correctamente");
                    this.Close();
                }
                else
                {
                    if (objResponse != null)
                    {
                        Controles.mensajes.errorWebServices(objResponse.error);
                    }
                }
            }
            catch (Exception exp)
            {
                Controles.mensajes.mensajeError(exp.Message);
            }
        }

        private void guardar()
        {
            try
            {
                DepartamentoResponse objResponse;
                Departamento obj = new Departamento();
                if (!String.IsNullOrEmpty(txtDepartamento.Text) && !String.IsNullOrWhiteSpace(txtDepartamento.Text))
                    obj.NOM_DEPARTAMENTO = txtDepartamento.Text.Trim();
                objResponse = serviciosDepartamento.crearDepartamento(obj);
                if (objResponse != null && objResponse.correcto)
                {
                    Controles.mensajes.mensajeCorrecto("Se creo correctamente el Departamento " + obj.NOM_DEPARTAMENTO);
                    txtDepartamento.Clear();
                }
                else
                {
                    if (objResponse != null)
                    {
                        Controles.mensajes.errorWebServices(objResponse.error);
                    }
                }
            }
            catch (Exception exp)
            {
                Controles.mensajes.mensajeError(exp.Message);
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

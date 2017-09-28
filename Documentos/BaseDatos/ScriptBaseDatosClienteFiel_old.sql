/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2008                    */
/* Created on:     30/07/2017 6:40:59                           */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ACTIVIDAD') and o.name = 'FK_ACTIVIDA_ACTIVIDAD_TIPO_ACT')
alter table ACTIVIDAD
   drop constraint FK_ACTIVIDA_ACTIVIDAD_TIPO_ACT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ACTIVIDAD') and o.name = 'FK_ACTIVIDA_EMPRESA_A_EMPRESA')
alter table ACTIVIDAD
   drop constraint FK_ACTIVIDA_EMPRESA_A_EMPRESA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ACTIVIDAD_IMAGEN') and o.name = 'FK_ACTIVIDA_ACTIVIDAD_ACTIVIDA')
alter table ACTIVIDAD_IMAGEN
   drop constraint FK_ACTIVIDA_ACTIVIDAD_ACTIVIDA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ACTIVIDAD_IMAGEN') and o.name = 'FK_ACTIVIDA_ACTIVIDAD_IMAGEN')
alter table ACTIVIDAD_IMAGEN
   drop constraint FK_ACTIVIDA_ACTIVIDAD_IMAGEN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CLIENTE') and o.name = 'FK_CLIENTE_CLIENTE_C_CODIGO_Q')
alter table CLIENTE
   drop constraint FK_CLIENTE_CLIENTE_C_CODIGO_Q
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CLIENTE') and o.name = 'FK_CLIENTE_CLIENTE_I_IMAGEN')
alter table CLIENTE
   drop constraint FK_CLIENTE_CLIENTE_I_IMAGEN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CLIENTE') and o.name = 'FK_CLIENTE_CLIENTE_T_TIPO_IDE')
alter table CLIENTE
   drop constraint FK_CLIENTE_CLIENTE_T_TIPO_IDE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CLIENTE') and o.name = 'FK_CLIENTE_EMPRESA_C_EMPRESA')
alter table CLIENTE
   drop constraint FK_CLIENTE_EMPRESA_C_EMPRESA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DESCUENTO') and o.name = 'FK_DESCUENT_EMPRESA_D_EMPRESA')
alter table DESCUENTO
   drop constraint FK_DESCUENT_EMPRESA_D_EMPRESA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DETALLE_DOMICILIO') and o.name = 'FK_DETALLE__DOMICILIO_DOMICILI')
alter table DETALLE_DOMICILIO
   drop constraint FK_DETALLE__DOMICILIO_DOMICILI
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DETALLE_DOMICILIO') and o.name = 'FK_DETALLE__PRODUCTO__PRODUCTO')
alter table DETALLE_DOMICILIO
   drop constraint FK_DETALLE__PRODUCTO__PRODUCTO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DOMICILIO') and o.name = 'FK_DOMICILI_CLIENTE_D_CLIENTE')
alter table DOMICILIO
   drop constraint FK_DOMICILI_CLIENTE_D_CLIENTE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DOMICILIO') and o.name = 'FK_DOMICILI_USUARIO_D_USUARIO')
alter table DOMICILIO
   drop constraint FK_DOMICILI_USUARIO_D_USUARIO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('EMPRESA') and o.name = 'FK_EMPRESA_EMPRESA_L_IMAGEN')
alter table EMPRESA
   drop constraint FK_EMPRESA_EMPRESA_L_IMAGEN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('EMPRESA') and o.name = 'FK_EMPRESA_EMPRESA_M_MUNICIPI')
alter table EMPRESA
   drop constraint FK_EMPRESA_EMPRESA_M_MUNICIPI
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('HISTORIAL') and o.name = 'FK_HISTORIA_CLIENTE_H_CLIENTE')
alter table HISTORIAL
   drop constraint FK_HISTORIA_CLIENTE_H_CLIENTE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('HISTORIAL') and o.name = 'FK_HISTORIA_HISTORIAL_HISTORIA')
alter table HISTORIAL
   drop constraint FK_HISTORIA_HISTORIAL_HISTORIA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('HISTORIAL') and o.name = 'FK_HISTORIA_HISTORIAL_IMAGEN')
alter table HISTORIAL
   drop constraint FK_HISTORIA_HISTORIAL_IMAGEN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('HISTORIAL') and o.name = 'FK_HISTORIA_USUARIO_H_USUARIO')
alter table HISTORIAL
   drop constraint FK_HISTORIA_USUARIO_H_USUARIO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('HISTORIAL_DESCUENTO') and o.name = 'FK_HISTORIA_DESCUENTO_DESCUENT')
alter table HISTORIAL_DESCUENTO
   drop constraint FK_HISTORIA_DESCUENTO_DESCUENT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('HISTORIAL_DESCUENTO') and o.name = 'FK_HISTORIA_HISTORIAL_USUARIO')
alter table HISTORIAL_DESCUENTO
   drop constraint FK_HISTORIA_HISTORIAL_USUARIO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('HISTORIAL_DESCUENTO') and o.name = 'FK_HISTORIA_IMAGEN_HI_IMAGEN')
alter table HISTORIAL_DESCUENTO
   drop constraint FK_HISTORIA_IMAGEN_HI_IMAGEN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('MUNICIPIO') and o.name = 'FK_MUNICIPI_MUNICIPIO_DEPARTAM')
alter table MUNICIPIO
   drop constraint FK_MUNICIPI_MUNICIPIO_DEPARTAM
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PRODUCTO') and o.name = 'FK_PRODUCTO_EMPRESA_P_EMPRESA')
alter table PRODUCTO
   drop constraint FK_PRODUCTO_EMPRESA_P_EMPRESA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PRODUCTO') and o.name = 'FK_PRODUCTO_PRODUCTO__IMAGEN')
alter table PRODUCTO
   drop constraint FK_PRODUCTO_PRODUCTO__IMAGEN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PRODUCTO') and o.name = 'FK_PRODUCTO_PRODUCTO__TIPO_PRO')
alter table PRODUCTO
   drop constraint FK_PRODUCTO_PRODUCTO__TIPO_PRO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('REDES_SOCIALES') and o.name = 'FK_REDES_SO_EMPRESA_R_EMPRESA')
alter table REDES_SOCIALES
   drop constraint FK_REDES_SO_EMPRESA_R_EMPRESA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('REDES_SOCIALES') and o.name = 'FK_REDES_SO_RED_SOCIA_TIPO_RED')
alter table REDES_SOCIALES
   drop constraint FK_REDES_SO_RED_SOCIA_TIPO_RED
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ROL_OPCION') and o.name = 'FK_ROL_OPCI_ROL_ROL_O_ROL')
alter table ROL_OPCION
   drop constraint FK_ROL_OPCI_ROL_ROL_O_ROL
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TIPO_RED_SOCIAL') and o.name = 'FK_TIPO_RED_TIPO_RED__IMAGEN')
alter table TIPO_RED_SOCIAL
   drop constraint FK_TIPO_RED_TIPO_RED__IMAGEN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('"TOP"') and o.name = 'FK_TOP_EMPRESA_T_EMPRESA')
alter table "TOP"
   drop constraint FK_TOP_EMPRESA_T_EMPRESA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('"TOP"') and o.name = 'FK_TOP_TOP_IMAGE_IMAGEN')
alter table "TOP"
   drop constraint FK_TOP_TOP_IMAGE_IMAGEN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('USUARIO') and o.name = 'FK_USUARIO_EMPRESA_U_EMPRESA')
alter table USUARIO
   drop constraint FK_USUARIO_EMPRESA_U_EMPRESA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('USUARIO') and o.name = 'FK_USUARIO_USUARIO_I_IMAGEN')
alter table USUARIO
   drop constraint FK_USUARIO_USUARIO_I_IMAGEN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('USUARIO') and o.name = 'FK_USUARIO_USUARIO_R_ROL')
alter table USUARIO
   drop constraint FK_USUARIO_USUARIO_R_ROL
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('USUARIO') and o.name = 'FK_USUARIO_USUARIO_T_TIPO_IDE')
alter table USUARIO
   drop constraint FK_USUARIO_USUARIO_T_TIPO_IDE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('VIEW_EMPRESA')
            and   type = 'V')
   drop view VIEW_EMPRESA
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ACTIVIDAD')
            and   name  = 'ACTIVIDAD_TIPO_FK'
            and   indid > 0
            and   indid < 255)
   drop index ACTIVIDAD.ACTIVIDAD_TIPO_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ACTIVIDAD')
            and   name  = 'EMPRESA_ACTIVIDAD_FK'
            and   indid > 0
            and   indid < 255)
   drop index ACTIVIDAD.EMPRESA_ACTIVIDAD_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ACTIVIDAD')
            and   type = 'U')
   drop table ACTIVIDAD
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ACTIVIDAD_IMAGEN')
            and   name  = 'ACTIVIDAD_IMAGEN_FK'
            and   indid > 0
            and   indid < 255)
   drop index ACTIVIDAD_IMAGEN.ACTIVIDAD_IMAGEN_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ACTIVIDAD_IMAGEN')
            and   name  = 'ACTIVIDAD_IMAGEN2_FK'
            and   indid > 0
            and   indid < 255)
   drop index ACTIVIDAD_IMAGEN.ACTIVIDAD_IMAGEN2_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ACTIVIDAD_IMAGEN')
            and   type = 'U')
   drop table ACTIVIDAD_IMAGEN
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CLIENTE')
            and   name  = 'CLIENTE_CODIGO_QR_FK'
            and   indid > 0
            and   indid < 255)
   drop index CLIENTE.CLIENTE_CODIGO_QR_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CLIENTE')
            and   name  = 'CLIENTE_TIPO_IDENTIFICACION_FK'
            and   indid > 0
            and   indid < 255)
   drop index CLIENTE.CLIENTE_TIPO_IDENTIFICACION_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CLIENTE')
            and   name  = 'CLIENTE_IMAGEN_FK'
            and   indid > 0
            and   indid < 255)
   drop index CLIENTE.CLIENTE_IMAGEN_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CLIENTE')
            and   name  = 'EMPRESA_CLIENTE_FK'
            and   indid > 0
            and   indid < 255)
   drop index CLIENTE.EMPRESA_CLIENTE_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CLIENTE')
            and   type = 'U')
   drop table CLIENTE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CODIGO_QR')
            and   type = 'U')
   drop table CODIGO_QR
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DEPARTAMENTO')
            and   type = 'U')
   drop table DEPARTAMENTO
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('DESCUENTO')
            and   name  = 'EMPRESA_DESCUENTO_FK'
            and   indid > 0
            and   indid < 255)
   drop index DESCUENTO.EMPRESA_DESCUENTO_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DESCUENTO')
            and   type = 'U')
   drop table DESCUENTO
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('DETALLE_DOMICILIO')
            and   name  = 'PRODUCTO_DETALLE_DOMICILIO_FK'
            and   indid > 0
            and   indid < 255)
   drop index DETALLE_DOMICILIO.PRODUCTO_DETALLE_DOMICILIO_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('DETALLE_DOMICILIO')
            and   name  = 'DOMICILIO_DETALLE_DOMICILIO_FK'
            and   indid > 0
            and   indid < 255)
   drop index DETALLE_DOMICILIO.DOMICILIO_DETALLE_DOMICILIO_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DETALLE_DOMICILIO')
            and   type = 'U')
   drop table DETALLE_DOMICILIO
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('DOMICILIO')
            and   name  = 'USUARIO_DOMICILIO_FK'
            and   indid > 0
            and   indid < 255)
   drop index DOMICILIO.USUARIO_DOMICILIO_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('DOMICILIO')
            and   name  = 'CLIENTE_DOMICILIO_FK'
            and   indid > 0
            and   indid < 255)
   drop index DOMICILIO.CLIENTE_DOMICILIO_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DOMICILIO')
            and   type = 'U')
   drop table DOMICILIO
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('EMPRESA')
            and   name  = 'EMPRESA_RED_SOCIAL_FK'
            and   indid > 0
            and   indid < 255)
   drop index EMPRESA.EMPRESA_RED_SOCIAL_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('EMPRESA')
            and   name  = 'EMPRESA_LOGO_FK'
            and   indid > 0
            and   indid < 255)
   drop index EMPRESA.EMPRESA_LOGO_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('EMPRESA')
            and   name  = 'EMPRESA_MUNICIPIO_FK'
            and   indid > 0
            and   indid < 255)
   drop index EMPRESA.EMPRESA_MUNICIPIO_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('EMPRESA')
            and   type = 'U')
   drop table EMPRESA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ERROR')
            and   type = 'U')
   drop table ERROR
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('HISTORIAL')
            and   name  = 'USUARIO_HISTORIAL_FK'
            and   indid > 0
            and   indid < 255)
   drop index HISTORIAL.USUARIO_HISTORIAL_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('HISTORIAL')
            and   name  = 'HISTORIAL_HISTORIAL_DESCUENTO_FK'
            and   indid > 0
            and   indid < 255)
   drop index HISTORIAL.HISTORIAL_HISTORIAL_DESCUENTO_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('HISTORIAL')
            and   name  = 'HISTORIAL_IMAGEN_FK'
            and   indid > 0
            and   indid < 255)
   drop index HISTORIAL.HISTORIAL_IMAGEN_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('HISTORIAL')
            and   name  = 'CLIENTE_HISTORIAL_FK'
            and   indid > 0
            and   indid < 255)
   drop index HISTORIAL.CLIENTE_HISTORIAL_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('HISTORIAL')
            and   type = 'U')
   drop table HISTORIAL
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('HISTORIAL_DESCUENTO')
            and   name  = 'USUARIO_HISTORIAL_DESCUENTO_FK'
            and   indid > 0
            and   indid < 255)
   drop index HISTORIAL_DESCUENTO.USUARIO_HISTORIAL_DESCUENTO_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('HISTORIAL_DESCUENTO')
            and   name  = 'DESCUENTO_HISTORIAL_DESCUENTO_FK'
            and   indid > 0
            and   indid < 255)
   drop index HISTORIAL_DESCUENTO.DESCUENTO_HISTORIAL_DESCUENTO_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('HISTORIAL_DESCUENTO')
            and   name  = 'IMAGEN_HISTORIAL_DESCUENTO_FK'
            and   indid > 0
            and   indid < 255)
   drop index HISTORIAL_DESCUENTO.IMAGEN_HISTORIAL_DESCUENTO_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('HISTORIAL_DESCUENTO')
            and   type = 'U')
   drop table HISTORIAL_DESCUENTO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('IMAGEN')
            and   type = 'U')
   drop table IMAGEN
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('MUNICIPIO')
            and   name  = 'MUNICIPIO_DEPARTAMENTO_FK'
            and   indid > 0
            and   indid < 255)
   drop index MUNICIPIO.MUNICIPIO_DEPARTAMENTO_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('MUNICIPIO')
            and   type = 'U')
   drop table MUNICIPIO
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PRODUCTO')
            and   name  = 'EMPRESA_PRODUCTO_FK'
            and   indid > 0
            and   indid < 255)
   drop index PRODUCTO.EMPRESA_PRODUCTO_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PRODUCTO')
            and   name  = 'PRODUCTO_TIPO_FK'
            and   indid > 0
            and   indid < 255)
   drop index PRODUCTO.PRODUCTO_TIPO_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PRODUCTO')
            and   name  = 'PRODUCTO_IMAGEN_FK'
            and   indid > 0
            and   indid < 255)
   drop index PRODUCTO.PRODUCTO_IMAGEN_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PRODUCTO')
            and   type = 'U')
   drop table PRODUCTO
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('REDES_SOCIALES')
            and   name  = 'RED_SOCIAL_TIPO_FK'
            and   indid > 0
            and   indid < 255)
   drop index REDES_SOCIALES.RED_SOCIAL_TIPO_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('REDES_SOCIALES')
            and   type = 'U')
   drop table REDES_SOCIALES
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ROL')
            and   type = 'U')
   drop table ROL
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ROL_OPCION')
            and   name  = 'ROL_ROL_OPCION_FK'
            and   indid > 0
            and   indid < 255)
   drop index ROL_OPCION.ROL_ROL_OPCION_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ROL_OPCION')
            and   type = 'U')
   drop table ROL_OPCION
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TIPO_ACTIVIDAD')
            and   type = 'U')
   drop table TIPO_ACTIVIDAD
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TIPO_IDENTIFICACION')
            and   type = 'U')
   drop table TIPO_IDENTIFICACION
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TIPO_PRODUCTO')
            and   type = 'U')
   drop table TIPO_PRODUCTO
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TIPO_RED_SOCIAL')
            and   name  = 'TIPO_RED_SOCIAL_IMAGEN_FK'
            and   indid > 0
            and   indid < 255)
   drop index TIPO_RED_SOCIAL.TIPO_RED_SOCIAL_IMAGEN_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TIPO_RED_SOCIAL')
            and   type = 'U')
   drop table TIPO_RED_SOCIAL
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('"TOP"')
            and   name  = 'TOP_IMAGEN_FK'
            and   indid > 0
            and   indid < 255)
   drop index "TOP".TOP_IMAGEN_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('"TOP"')
            and   name  = 'EMPRESA_TOP_FK'
            and   indid > 0
            and   indid < 255)
   drop index "TOP".EMPRESA_TOP_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('"TOP"')
            and   type = 'U')
   drop table "TOP"
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('USUARIO')
            and   name  = 'USUARIO_ROL_FK'
            and   indid > 0
            and   indid < 255)
   drop index USUARIO.USUARIO_ROL_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('USUARIO')
            and   name  = 'USUARIO_IMAGEN_FK'
            and   indid > 0
            and   indid < 255)
   drop index USUARIO.USUARIO_IMAGEN_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('USUARIO')
            and   name  = 'EMPRESA_USUARIO_FK'
            and   indid > 0
            and   indid < 255)
   drop index USUARIO.EMPRESA_USUARIO_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('USUARIO')
            and   name  = 'USUARIO_TIPO_IDENTIFICACION_FK'
            and   indid > 0
            and   indid < 255)
   drop index USUARIO.USUARIO_TIPO_IDENTIFICACION_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('USUARIO')
            and   type = 'U')
   drop table USUARIO
go

if exists(select 1 from systypes where name='DOMAIN_ESTADO')
   execute sp_unbindrule DOMAIN_ESTADO
go

if exists(select 1 from systypes where name='DOMAIN_ESTADO')
   drop type DOMAIN_ESTADO
go

if exists(select 1 from systypes where name='DOMAIN_ESTADO_DOMICILIO')
   execute sp_unbindrule DOMAIN_ESTADO_DOMICILIO
go

if exists(select 1 from systypes where name='DOMAIN_ESTADO_DOMICILIO')
   drop type DOMAIN_ESTADO_DOMICILIO
go

if exists(select 1 from systypes where name='DOMAIN_ORIGEN')
   execute sp_unbindrule DOMAIN_ORIGEN
go

if exists(select 1 from systypes where name='DOMAIN_ORIGEN')
   drop type DOMAIN_ORIGEN
go

if exists(select 1 from systypes where name='DOMAIN_PUBLICADO')
   execute sp_unbindrule DOMAIN_PUBLICADO
go

if exists(select 1 from systypes where name='DOMAIN_PUBLICADO')
   drop type DOMAIN_PUBLICADO
go

if exists(select 1 from systypes where name='DOMAIN_SEXO')
   execute sp_unbindrule DOMAIN_SEXO
go

if exists(select 1 from systypes where name='DOMAIN_SEXO')
   drop type DOMAIN_SEXO
go

if exists(select 1 from systypes where name='DOMAIN_VALOR')
   execute sp_unbindrule DOMAIN_VALOR
go

if exists(select 1 from systypes where name='DOMAIN_VALOR')
   drop type DOMAIN_VALOR
go

if exists (select 1 from sysobjects where id=object_id('R_DOMAIN_ESTADO') and type='R')
   drop rule  R_DOMAIN_ESTADO
go

if exists (select 1 from sysobjects where id=object_id('R_DOMAIN_ESTADO_DOMICILIO') and type='R')
   drop rule  R_DOMAIN_ESTADO_DOMICILIO
go

if exists (select 1 from sysobjects where id=object_id('R_DOMAIN_ORIGEN') and type='R')
   drop rule  R_DOMAIN_ORIGEN
go

if exists (select 1 from sysobjects where id=object_id('R_DOMAIN_PUBLICADO') and type='R')
   drop rule  R_DOMAIN_PUBLICADO
go

if exists (select 1 from sysobjects where id=object_id('R_DOMAIN_SEXO') and type='R')
   drop rule  R_DOMAIN_SEXO
go

if exists (select 1 from sysobjects where id=object_id('R_DOMAIN_VALOR') and type='R')
   drop rule  R_DOMAIN_VALOR
go

create rule R_DOMAIN_ESTADO as
      @column in ('A','I')
go

create rule R_DOMAIN_ESTADO_DOMICILIO as
      @column in ('P','V','D','C')
go

create rule R_DOMAIN_ORIGEN as
      @column in ('A','E')
go

create rule R_DOMAIN_PUBLICADO as
      @column in ('S','N')
go

create rule R_DOMAIN_SEXO as
      @column in ('M','F')
go

create rule R_DOMAIN_VALOR as
      @column >= 0
go

/*==============================================================*/
/* Domain: DOMAIN_ESTADO                                        */
/*==============================================================*/
create type DOMAIN_ESTADO
   from varchar(1)
go

execute sp_bindrule R_DOMAIN_ESTADO, DOMAIN_ESTADO
go

/*==============================================================*/
/* Domain: DOMAIN_ESTADO_DOMICILIO                              */
/*==============================================================*/
create type DOMAIN_ESTADO_DOMICILIO
   from varchar(1)
go

execute sp_bindrule R_DOMAIN_ESTADO_DOMICILIO, DOMAIN_ESTADO_DOMICILIO
go

/*==============================================================*/
/* Domain: DOMAIN_ORIGEN                                        */
/*==============================================================*/
create type DOMAIN_ORIGEN
   from varchar(1)
go

execute sp_bindrule R_DOMAIN_ORIGEN, DOMAIN_ORIGEN
go

/*==============================================================*/
/* Domain: DOMAIN_PUBLICADO                                     */
/*==============================================================*/
create type DOMAIN_PUBLICADO
   from varchar(1)
go

execute sp_bindrule R_DOMAIN_PUBLICADO, DOMAIN_PUBLICADO
go

/*==============================================================*/
/* Domain: DOMAIN_SEXO                                          */
/*==============================================================*/
create type DOMAIN_SEXO
   from varchar(1)
go

execute sp_bindrule R_DOMAIN_SEXO, DOMAIN_SEXO
go

/*==============================================================*/
/* Domain: DOMAIN_VALOR                                         */
/*==============================================================*/
create type DOMAIN_VALOR
   from numeric
go

execute sp_bindrule R_DOMAIN_VALOR, DOMAIN_VALOR
go

/*==============================================================*/
/* Table: ACTIVIDAD                                             */
/*==============================================================*/
create table ACTIVIDAD (
   ID_ACTIVIDAD         numeric              identity(1,1),
   ID_EMPRESA           numeric              not null,
   ID_TIPO_ACTIVIDAD    numeric              not null,
   NOM_ACTIVIDAD        varchar(100)         not null,
   DESCRIPCION          varchar(8000)        null,
   FECHA_DESDE          datetime             not null,
   FECHA_HASTA          datetime             not null,
   PUBLICADO            DOMAIN_PUBLICADO     not null,
   constraint PK_ACTIVIDAD primary key nonclustered (ID_ACTIVIDAD),
   constraint AK_NOM_ACTIVIDAD_ACTIVIDA unique (NOM_ACTIVIDAD)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('ACTIVIDAD') and minor_id = 0)
begin 
   declare @CurrentUser sysname 
select @CurrentUser = user_name() 
execute sp_dropextendedproperty 'MS_Description',  
   'user', @CurrentUser, 'table', 'ACTIVIDAD' 
 
end 


select @CurrentUser = user_name() 
execute sp_addextendedproperty 'MS_Description',  
   'ACTIVIDAD', 
   'user', @CurrentUser, 'table', 'ACTIVIDAD'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('ACTIVIDAD')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'ID_ACTIVIDAD')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'ACTIVIDAD', 'column', 'ID_ACTIVIDAD'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_ACTIVIDAD',
   'user', @CurrentUser, 'table', 'ACTIVIDAD', 'column', 'ID_ACTIVIDAD'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('ACTIVIDAD')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'ID_EMPRESA')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'ACTIVIDAD', 'column', 'ID_EMPRESA'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_EMPRESA',
   'user', @CurrentUser, 'table', 'ACTIVIDAD', 'column', 'ID_EMPRESA'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('ACTIVIDAD')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'ID_TIPO_ACTIVIDAD')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'ACTIVIDAD', 'column', 'ID_TIPO_ACTIVIDAD'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_TIPO_ACTIVIDAD',
   'user', @CurrentUser, 'table', 'ACTIVIDAD', 'column', 'ID_TIPO_ACTIVIDAD'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('ACTIVIDAD')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'NOM_ACTIVIDAD')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'ACTIVIDAD', 'column', 'NOM_ACTIVIDAD'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'NOM_ACTIVIDAD',
   'user', @CurrentUser, 'table', 'ACTIVIDAD', 'column', 'NOM_ACTIVIDAD'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('ACTIVIDAD')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'DESCRIPCION')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'ACTIVIDAD', 'column', 'DESCRIPCION'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'DESCRIPCION',
   'user', @CurrentUser, 'table', 'ACTIVIDAD', 'column', 'DESCRIPCION'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('ACTIVIDAD')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'FECHA_DESDE')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'ACTIVIDAD', 'column', 'FECHA_DESDE'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'FECHA_DESDE',
   'user', @CurrentUser, 'table', 'ACTIVIDAD', 'column', 'FECHA_DESDE'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('ACTIVIDAD')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'FECHA_HASTA')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'ACTIVIDAD', 'column', 'FECHA_HASTA'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'FECHA_HASTA',
   'user', @CurrentUser, 'table', 'ACTIVIDAD', 'column', 'FECHA_HASTA'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('ACTIVIDAD')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'PUBLICADO')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'ACTIVIDAD', 'column', 'PUBLICADO'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'PUBLICADO',
   'user', @CurrentUser, 'table', 'ACTIVIDAD', 'column', 'PUBLICADO'
go

/*==============================================================*/
/* Index: EMPRESA_ACTIVIDAD_FK                                  */
/*==============================================================*/
create index EMPRESA_ACTIVIDAD_FK on ACTIVIDAD (
ID_EMPRESA ASC
)
go

/*==============================================================*/
/* Index: ACTIVIDAD_TIPO_FK                                     */
/*==============================================================*/
create index ACTIVIDAD_TIPO_FK on ACTIVIDAD (
ID_TIPO_ACTIVIDAD ASC
)
go

/*==============================================================*/
/* Table: ACTIVIDAD_IMAGEN                                      */
/*==============================================================*/
create table ACTIVIDAD_IMAGEN (
   ID_ACTIVIDAD         numeric              not null,
   ID_IMAGEN            numeric              not null,
   constraint PK_ACTIVIDAD_IMAGEN primary key nonclustered (ID_ACTIVIDAD, ID_IMAGEN),
   constraint AK_ACTIVIDAD_IMAGEN_ACTIVIDA unique (ID_ACTIVIDAD, ID_IMAGEN)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('ACTIVIDAD_IMAGEN') and minor_id = 0)
begin 
   declare @CurrentUser sysname 
select @CurrentUser = user_name() 
execute sp_dropextendedproperty 'MS_Description',  
   'user', @CurrentUser, 'table', 'ACTIVIDAD_IMAGEN' 
 
end 


select @CurrentUser = user_name() 
execute sp_addextendedproperty 'MS_Description',  
   'ACTIVIDAD_IMAGEN', 
   'user', @CurrentUser, 'table', 'ACTIVIDAD_IMAGEN'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('ACTIVIDAD_IMAGEN')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'ID_ACTIVIDAD')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'ACTIVIDAD_IMAGEN', 'column', 'ID_ACTIVIDAD'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_ACTIVIDAD',
   'user', @CurrentUser, 'table', 'ACTIVIDAD_IMAGEN', 'column', 'ID_ACTIVIDAD'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('ACTIVIDAD_IMAGEN')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'ID_IMAGEN')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'ACTIVIDAD_IMAGEN', 'column', 'ID_IMAGEN'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_IMAGEN',
   'user', @CurrentUser, 'table', 'ACTIVIDAD_IMAGEN', 'column', 'ID_IMAGEN'
go

/*==============================================================*/
/* Index: ACTIVIDAD_IMAGEN2_FK                                  */
/*==============================================================*/
create index ACTIVIDAD_IMAGEN2_FK on ACTIVIDAD_IMAGEN (
ID_IMAGEN ASC
)
go

/*==============================================================*/
/* Index: ACTIVIDAD_IMAGEN_FK                                   */
/*==============================================================*/
create index ACTIVIDAD_IMAGEN_FK on ACTIVIDAD_IMAGEN (
ID_ACTIVIDAD ASC
)
go

/*==============================================================*/
/* Table: CLIENTE                                               */
/*==============================================================*/
create table CLIENTE (
   ID_CLIENTE           numeric              identity(1,1),
   ID_EMPRESA           numeric              not null,
   ID_IMAGEN            numeric              null,
   ID_TIPO_IDENTIFICACION numeric              not null,
   ID_CODIGO_QR         numeric              not null,
   IDENTIFICACION       varchar(50)          not null,
   NOMBRES              varchar(50)          not null,
   APELLIDOS            varchar(50)          not null,
   CORREO               varchar(100)         not null,
   DIRECCION_CLIENTE    varchar(300)         null,
   TELEFONO             varchar(100)         null,
   FECHA_NACIMIENTO     datetime             null,
   SEXO                 DOMAIN_SEXO          null,
   constraint PK_CLIENTE primary key nonclustered (ID_CLIENTE),
   constraint AK_ID_CODIGO_QR_CLIENTE unique (ID_CODIGO_QR),
   constraint AK_IDENTIFICACION_CLIENTE unique (ID_TIPO_IDENTIFICACION, IDENTIFICACION),
   constraint AK_CORREO_CLIENTE unique (CORREO)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('CLIENTE') and minor_id = 0)
begin 
   declare @CurrentUser sysname 
select @CurrentUser = user_name() 
execute sp_dropextendedproperty 'MS_Description',  
   'user', @CurrentUser, 'table', 'CLIENTE' 
 
end 


select @CurrentUser = user_name() 
execute sp_addextendedproperty 'MS_Description',  
   'CLIENTE', 
   'user', @CurrentUser, 'table', 'CLIENTE'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('CLIENTE')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'ID_CLIENTE')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'CLIENTE', 'column', 'ID_CLIENTE'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_CLIENTE',
   'user', @CurrentUser, 'table', 'CLIENTE', 'column', 'ID_CLIENTE'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('CLIENTE')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'ID_EMPRESA')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'CLIENTE', 'column', 'ID_EMPRESA'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_EMPRESA',
   'user', @CurrentUser, 'table', 'CLIENTE', 'column', 'ID_EMPRESA'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('CLIENTE')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'ID_IMAGEN')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'CLIENTE', 'column', 'ID_IMAGEN'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_IMAGEN',
   'user', @CurrentUser, 'table', 'CLIENTE', 'column', 'ID_IMAGEN'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('CLIENTE')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'ID_TIPO_IDENTIFICACION')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'CLIENTE', 'column', 'ID_TIPO_IDENTIFICACION'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_TIPO_IDENTIFICACION',
   'user', @CurrentUser, 'table', 'CLIENTE', 'column', 'ID_TIPO_IDENTIFICACION'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('CLIENTE')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'ID_CODIGO_QR')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'CLIENTE', 'column', 'ID_CODIGO_QR'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_CODIGO_QR',
   'user', @CurrentUser, 'table', 'CLIENTE', 'column', 'ID_CODIGO_QR'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('CLIENTE')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'IDENTIFICACION')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'CLIENTE', 'column', 'IDENTIFICACION'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'IDENTIFICACION',
   'user', @CurrentUser, 'table', 'CLIENTE', 'column', 'IDENTIFICACION'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('CLIENTE')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'NOMBRES')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'CLIENTE', 'column', 'NOMBRES'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'NOMBRES',
   'user', @CurrentUser, 'table', 'CLIENTE', 'column', 'NOMBRES'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('CLIENTE')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'APELLIDOS')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'CLIENTE', 'column', 'APELLIDOS'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'APELLIDOS',
   'user', @CurrentUser, 'table', 'CLIENTE', 'column', 'APELLIDOS'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('CLIENTE')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'CORREO')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'CLIENTE', 'column', 'CORREO'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'CORREO',
   'user', @CurrentUser, 'table', 'CLIENTE', 'column', 'CORREO'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('CLIENTE')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'DIRECCION_CLIENTE')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'CLIENTE', 'column', 'DIRECCION_CLIENTE'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'DIRECCION',
   'user', @CurrentUser, 'table', 'CLIENTE', 'column', 'DIRECCION_CLIENTE'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('CLIENTE')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'TELEFONO')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'CLIENTE', 'column', 'TELEFONO'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'TELEFONO',
   'user', @CurrentUser, 'table', 'CLIENTE', 'column', 'TELEFONO'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('CLIENTE')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'FECHA_NACIMIENTO')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'CLIENTE', 'column', 'FECHA_NACIMIENTO'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'FECHA_NACIMIENTO',
   'user', @CurrentUser, 'table', 'CLIENTE', 'column', 'FECHA_NACIMIENTO'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('CLIENTE')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'SEXO')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'CLIENTE', 'column', 'SEXO'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'SEXO',
   'user', @CurrentUser, 'table', 'CLIENTE', 'column', 'SEXO'
go

/*==============================================================*/
/* Index: EMPRESA_CLIENTE_FK                                    */
/*==============================================================*/
create index EMPRESA_CLIENTE_FK on CLIENTE (
ID_EMPRESA ASC
)
go

/*==============================================================*/
/* Index: CLIENTE_IMAGEN_FK                                     */
/*==============================================================*/
create index CLIENTE_IMAGEN_FK on CLIENTE (
ID_IMAGEN ASC
)
go

/*==============================================================*/
/* Index: CLIENTE_TIPO_IDENTIFICACION_FK                        */
/*==============================================================*/
create index CLIENTE_TIPO_IDENTIFICACION_FK on CLIENTE (
ID_TIPO_IDENTIFICACION ASC
)
go

/*==============================================================*/
/* Index: CLIENTE_CODIGO_QR_FK                                  */
/*==============================================================*/
create index CLIENTE_CODIGO_QR_FK on CLIENTE (
ID_CODIGO_QR ASC
)
go

/*==============================================================*/
/* Table: CODIGO_QR                                             */
/*==============================================================*/
create table CODIGO_QR (
   ID_CODIGO_QR         numeric              identity(1,1),
   QR                   image                not null,
   constraint PK_CODIGO_QR primary key nonclustered (ID_CODIGO_QR)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('CODIGO_QR') and minor_id = 0)
begin 
   declare @CurrentUser sysname 
select @CurrentUser = user_name() 
execute sp_dropextendedproperty 'MS_Description',  
   'user', @CurrentUser, 'table', 'CODIGO_QR' 
 
end 


select @CurrentUser = user_name() 
execute sp_addextendedproperty 'MS_Description',  
   'CODIGO_QR', 
   'user', @CurrentUser, 'table', 'CODIGO_QR'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('CODIGO_QR')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'ID_CODIGO_QR')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'CODIGO_QR', 'column', 'ID_CODIGO_QR'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_CODIGO_QR',
   'user', @CurrentUser, 'table', 'CODIGO_QR', 'column', 'ID_CODIGO_QR'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('CODIGO_QR')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'QR')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'CODIGO_QR', 'column', 'QR'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'QR',
   'user', @CurrentUser, 'table', 'CODIGO_QR', 'column', 'QR'
go

/*==============================================================*/
/* Table: DEPARTAMENTO                                          */
/*==============================================================*/
create table DEPARTAMENTO (
   ID_DEPARTAMENTO      numeric              identity(1,1),
   NOM_DEPARTAMENTO     varchar(50)          not null,
   constraint PK_DEPARTAMENTO primary key nonclustered (ID_DEPARTAMENTO),
   constraint AK_NOM_DEPARTAMENTO_DEPARTAM unique (NOM_DEPARTAMENTO)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('DEPARTAMENTO') and minor_id = 0)
begin 
   declare @CurrentUser sysname 
select @CurrentUser = user_name() 
execute sp_dropextendedproperty 'MS_Description',  
   'user', @CurrentUser, 'table', 'DEPARTAMENTO' 
 
end 


select @CurrentUser = user_name() 
execute sp_addextendedproperty 'MS_Description',  
   'DEPARTAMENTO', 
   'user', @CurrentUser, 'table', 'DEPARTAMENTO'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('DEPARTAMENTO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'ID_DEPARTAMENTO')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'DEPARTAMENTO', 'column', 'ID_DEPARTAMENTO'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_DEPARTAMENTO',
   'user', @CurrentUser, 'table', 'DEPARTAMENTO', 'column', 'ID_DEPARTAMENTO'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('DEPARTAMENTO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'NOM_DEPARTAMENTO')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'DEPARTAMENTO', 'column', 'NOM_DEPARTAMENTO'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'NOM_DEPARTAMENTO',
   'user', @CurrentUser, 'table', 'DEPARTAMENTO', 'column', 'NOM_DEPARTAMENTO'
go

/*==============================================================*/
/* Table: DESCUENTO                                             */
/*==============================================================*/
create table DESCUENTO (
   ID_DESCUENTO         numeric              identity(1,1),
   ID_EMPRESA           numeric              not null,
   NOM_DESCUENTO        varchar(100)         not null,
   DESCRIPCION          varchar(8000)        null,
   FECHA_DESDE          datetime             not null,
   FECHA_FIN            datetime             not null,
   FORMULA              varchar(8000)        not null,
   PUBLICADO            DOMAIN_PUBLICADO     not null,
   constraint PK_DESCUENTO primary key nonclustered (ID_DESCUENTO),
   constraint AK_NOM_DESCUENTO_DESCUENT unique (NOM_DESCUENTO)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('DESCUENTO') and minor_id = 0)
begin 
   declare @CurrentUser sysname 
select @CurrentUser = user_name() 
execute sp_dropextendedproperty 'MS_Description',  
   'user', @CurrentUser, 'table', 'DESCUENTO' 
 
end 


select @CurrentUser = user_name() 
execute sp_addextendedproperty 'MS_Description',  
   'DESCUENTO', 
   'user', @CurrentUser, 'table', 'DESCUENTO'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('DESCUENTO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'ID_DESCUENTO')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'DESCUENTO', 'column', 'ID_DESCUENTO'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_DESCUENTO',
   'user', @CurrentUser, 'table', 'DESCUENTO', 'column', 'ID_DESCUENTO'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('DESCUENTO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'ID_EMPRESA')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'DESCUENTO', 'column', 'ID_EMPRESA'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_EMPRESA',
   'user', @CurrentUser, 'table', 'DESCUENTO', 'column', 'ID_EMPRESA'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('DESCUENTO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'NOM_DESCUENTO')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'DESCUENTO', 'column', 'NOM_DESCUENTO'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'NOM_DESCUENTO',
   'user', @CurrentUser, 'table', 'DESCUENTO', 'column', 'NOM_DESCUENTO'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('DESCUENTO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'DESCRIPCION')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'DESCUENTO', 'column', 'DESCRIPCION'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'DESCRIPCION',
   'user', @CurrentUser, 'table', 'DESCUENTO', 'column', 'DESCRIPCION'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('DESCUENTO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'FECHA_DESDE')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'DESCUENTO', 'column', 'FECHA_DESDE'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'FECHA_DESDE',
   'user', @CurrentUser, 'table', 'DESCUENTO', 'column', 'FECHA_DESDE'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('DESCUENTO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'FECHA_FIN')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'DESCUENTO', 'column', 'FECHA_FIN'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'FECHA_FIN',
   'user', @CurrentUser, 'table', 'DESCUENTO', 'column', 'FECHA_FIN'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('DESCUENTO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'FORMULA')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'DESCUENTO', 'column', 'FORMULA'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'FORMULA',
   'user', @CurrentUser, 'table', 'DESCUENTO', 'column', 'FORMULA'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('DESCUENTO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'PUBLICADO')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'DESCUENTO', 'column', 'PUBLICADO'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'PUBLICADO',
   'user', @CurrentUser, 'table', 'DESCUENTO', 'column', 'PUBLICADO'
go

/*==============================================================*/
/* Index: EMPRESA_DESCUENTO_FK                                  */
/*==============================================================*/
create index EMPRESA_DESCUENTO_FK on DESCUENTO (
ID_EMPRESA ASC
)
go

/*==============================================================*/
/* Table: DETALLE_DOMICILIO                                     */
/*==============================================================*/
create table DETALLE_DOMICILIO (
   ID_DETALLE_DOMICILIO numeric              identity(1,1),
   ID_DOMICILIO         numeric              not null,
   ID_PRODUCTO          numeric              not null,
   OBSERVACION          varchar(8000)        null,
   CANTIDAD             DOMAIN_VALOR         not null,
   SUBTOTAL             numeric              not null,
   constraint PK_DETALLE_DOMICILIO primary key nonclustered (ID_DETALLE_DOMICILIO)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('DETALLE_DOMICILIO') and minor_id = 0)
begin 
   declare @CurrentUser sysname 
select @CurrentUser = user_name() 
execute sp_dropextendedproperty 'MS_Description',  
   'user', @CurrentUser, 'table', 'DETALLE_DOMICILIO' 
 
end 


select @CurrentUser = user_name() 
execute sp_addextendedproperty 'MS_Description',  
   'DETALLE_DOMICILIO', 
   'user', @CurrentUser, 'table', 'DETALLE_DOMICILIO'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('DETALLE_DOMICILIO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'ID_DETALLE_DOMICILIO')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'DETALLE_DOMICILIO', 'column', 'ID_DETALLE_DOMICILIO'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_DETALLE_DOMICILIO',
   'user', @CurrentUser, 'table', 'DETALLE_DOMICILIO', 'column', 'ID_DETALLE_DOMICILIO'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('DETALLE_DOMICILIO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'ID_DOMICILIO')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'DETALLE_DOMICILIO', 'column', 'ID_DOMICILIO'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_DOMICILIO',
   'user', @CurrentUser, 'table', 'DETALLE_DOMICILIO', 'column', 'ID_DOMICILIO'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('DETALLE_DOMICILIO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'ID_PRODUCTO')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'DETALLE_DOMICILIO', 'column', 'ID_PRODUCTO'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_PRODUCTO',
   'user', @CurrentUser, 'table', 'DETALLE_DOMICILIO', 'column', 'ID_PRODUCTO'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('DETALLE_DOMICILIO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'OBSERVACION')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'DETALLE_DOMICILIO', 'column', 'OBSERVACION'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'OBSERVACION',
   'user', @CurrentUser, 'table', 'DETALLE_DOMICILIO', 'column', 'OBSERVACION'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('DETALLE_DOMICILIO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'CANTIDAD')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'DETALLE_DOMICILIO', 'column', 'CANTIDAD'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'CANTIDAD',
   'user', @CurrentUser, 'table', 'DETALLE_DOMICILIO', 'column', 'CANTIDAD'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('DETALLE_DOMICILIO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'SUBTOTAL')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'DETALLE_DOMICILIO', 'column', 'SUBTOTAL'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'SUBTOTAL',
   'user', @CurrentUser, 'table', 'DETALLE_DOMICILIO', 'column', 'SUBTOTAL'
go

/*==============================================================*/
/* Index: DOMICILIO_DETALLE_DOMICILIO_FK                        */
/*==============================================================*/
create index DOMICILIO_DETALLE_DOMICILIO_FK on DETALLE_DOMICILIO (
ID_DOMICILIO ASC
)
go

/*==============================================================*/
/* Index: PRODUCTO_DETALLE_DOMICILIO_FK                         */
/*==============================================================*/
create index PRODUCTO_DETALLE_DOMICILIO_FK on DETALLE_DOMICILIO (
ID_PRODUCTO ASC
)
go

/*==============================================================*/
/* Table: DOMICILIO                                             */
/*==============================================================*/
create table DOMICILIO (
   ID_DOMICILIO         numeric              identity(1,1),
   ID_CLIENTE           numeric              not null,
   ID_USUARIO           numeric              null,
   FECHA_DOMICILIO      datetime             not null,
   HORA_DOMICILIO       datetime             not null,
   FECHA_VERIFICACION   datetime             null,
   HORA_VERIFICACION    datetime             null,
   DIRECCION            varchar(300)         not null,
   TELEFONO             varchar(100)         not null,
   BARRIO               varchar(300)         not null,
   ESTADO               DOMAIN_ESTADO_DOMICILIO not null,
   OBSERVACIONES        varchar(8000)        null,
   TOTAL                DOMAIN_VALOR         not null,
   constraint PK_DOMICILIO primary key nonclustered (ID_DOMICILIO)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('DOMICILIO') and minor_id = 0)
begin 
   declare @CurrentUser sysname 
select @CurrentUser = user_name() 
execute sp_dropextendedproperty 'MS_Description',  
   'user', @CurrentUser, 'table', 'DOMICILIO' 
 
end 


select @CurrentUser = user_name() 
execute sp_addextendedproperty 'MS_Description',  
   'DOMICILIO', 
   'user', @CurrentUser, 'table', 'DOMICILIO'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('DOMICILIO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'ID_DOMICILIO')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'DOMICILIO', 'column', 'ID_DOMICILIO'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_DOMICILIO',
   'user', @CurrentUser, 'table', 'DOMICILIO', 'column', 'ID_DOMICILIO'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('DOMICILIO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'ID_CLIENTE')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'DOMICILIO', 'column', 'ID_CLIENTE'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_CLIENTE',
   'user', @CurrentUser, 'table', 'DOMICILIO', 'column', 'ID_CLIENTE'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('DOMICILIO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'ID_USUARIO')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'DOMICILIO', 'column', 'ID_USUARIO'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_USUARIO',
   'user', @CurrentUser, 'table', 'DOMICILIO', 'column', 'ID_USUARIO'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('DOMICILIO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'FECHA_DOMICILIO')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'DOMICILIO', 'column', 'FECHA_DOMICILIO'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'FECHA_DOMICILIO',
   'user', @CurrentUser, 'table', 'DOMICILIO', 'column', 'FECHA_DOMICILIO'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('DOMICILIO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'HORA_DOMICILIO')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'DOMICILIO', 'column', 'HORA_DOMICILIO'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'HORA_DOMICILIO',
   'user', @CurrentUser, 'table', 'DOMICILIO', 'column', 'HORA_DOMICILIO'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('DOMICILIO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'FECHA_VERIFICACION')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'DOMICILIO', 'column', 'FECHA_VERIFICACION'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'FECHA_VERIFICACION',
   'user', @CurrentUser, 'table', 'DOMICILIO', 'column', 'FECHA_VERIFICACION'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('DOMICILIO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'HORA_VERIFICACION')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'DOMICILIO', 'column', 'HORA_VERIFICACION'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'HORA_VERIFICACION',
   'user', @CurrentUser, 'table', 'DOMICILIO', 'column', 'HORA_VERIFICACION'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('DOMICILIO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'DIRECCION')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'DOMICILIO', 'column', 'DIRECCION'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'DIRECCION',
   'user', @CurrentUser, 'table', 'DOMICILIO', 'column', 'DIRECCION'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('DOMICILIO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'TELEFONO')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'DOMICILIO', 'column', 'TELEFONO'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'TELEFONO',
   'user', @CurrentUser, 'table', 'DOMICILIO', 'column', 'TELEFONO'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('DOMICILIO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'BARRIO')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'DOMICILIO', 'column', 'BARRIO'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'BARRIO',
   'user', @CurrentUser, 'table', 'DOMICILIO', 'column', 'BARRIO'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('DOMICILIO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'ESTADO')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'DOMICILIO', 'column', 'ESTADO'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ESTADO',
   'user', @CurrentUser, 'table', 'DOMICILIO', 'column', 'ESTADO'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('DOMICILIO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'OBSERVACIONES')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'DOMICILIO', 'column', 'OBSERVACIONES'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'OBSERVACIONES',
   'user', @CurrentUser, 'table', 'DOMICILIO', 'column', 'OBSERVACIONES'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('DOMICILIO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'TOTAL')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'DOMICILIO', 'column', 'TOTAL'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'TOTAL',
   'user', @CurrentUser, 'table', 'DOMICILIO', 'column', 'TOTAL'
go

/*==============================================================*/
/* Index: CLIENTE_DOMICILIO_FK                                  */
/*==============================================================*/
create index CLIENTE_DOMICILIO_FK on DOMICILIO (
ID_CLIENTE ASC
)
go

/*==============================================================*/
/* Index: USUARIO_DOMICILIO_FK                                  */
/*==============================================================*/
create index USUARIO_DOMICILIO_FK on DOMICILIO (
ID_USUARIO ASC
)
go

/*==============================================================*/
/* Table: EMPRESA                                               */
/*==============================================================*/
create table EMPRESA (
   ID_EMPRESA           numeric              identity(1,1),
   ID_MUNICIPIO         numeric              null,
   ID_IMAGEN            numeric              null,
   NIT                  varchar(20)          not null,
   RAZON_SOCIAL         varchar(500)         not null,
   DIRECCION_CLIENTE    varchar(300)         not null,
   TELEFONO             varchar(100)         not null,
   SLOGAN               varchar(500)         null,
   LATITUD              varchar(20)          null,
   LONGITUD             varchar(20)          null,
   SUCURSAL             varchar(100)         null,
   constraint PK_EMPRESA primary key nonclustered (ID_EMPRESA),
   constraint AK_SUCURSAL_EMPRESA unique (NIT, SUCURSAL)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('EMPRESA') and minor_id = 0)
begin 
   declare @CurrentUser sysname 
select @CurrentUser = user_name() 
execute sp_dropextendedproperty 'MS_Description',  
   'user', @CurrentUser, 'table', 'EMPRESA' 
 
end 


select @CurrentUser = user_name() 
execute sp_addextendedproperty 'MS_Description',  
   'EMPRESA', 
   'user', @CurrentUser, 'table', 'EMPRESA'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('EMPRESA')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'ID_EMPRESA')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'EMPRESA', 'column', 'ID_EMPRESA'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_EMPRESA',
   'user', @CurrentUser, 'table', 'EMPRESA', 'column', 'ID_EMPRESA'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('EMPRESA')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'ID_MUNICIPIO')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'EMPRESA', 'column', 'ID_MUNICIPIO'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_MUNICIPIO',
   'user', @CurrentUser, 'table', 'EMPRESA', 'column', 'ID_MUNICIPIO'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('EMPRESA')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'ID_IMAGEN')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'EMPRESA', 'column', 'ID_IMAGEN'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_IMAGEN',
   'user', @CurrentUser, 'table', 'EMPRESA', 'column', 'ID_IMAGEN'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('EMPRESA')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'NIT')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'EMPRESA', 'column', 'NIT'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'NIT',
   'user', @CurrentUser, 'table', 'EMPRESA', 'column', 'NIT'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('EMPRESA')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'RAZON_SOCIAL')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'EMPRESA', 'column', 'RAZON_SOCIAL'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'RAZON_SOCIAL',
   'user', @CurrentUser, 'table', 'EMPRESA', 'column', 'RAZON_SOCIAL'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('EMPRESA')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'DIRECCION_CLIENTE')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'EMPRESA', 'column', 'DIRECCION_CLIENTE'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'DIRECCION',
   'user', @CurrentUser, 'table', 'EMPRESA', 'column', 'DIRECCION_CLIENTE'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('EMPRESA')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'TELEFONO')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'EMPRESA', 'column', 'TELEFONO'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'TELEFONO',
   'user', @CurrentUser, 'table', 'EMPRESA', 'column', 'TELEFONO'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('EMPRESA')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'SLOGAN')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'EMPRESA', 'column', 'SLOGAN'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'SLOGAN',
   'user', @CurrentUser, 'table', 'EMPRESA', 'column', 'SLOGAN'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('EMPRESA')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'LATITUD')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'EMPRESA', 'column', 'LATITUD'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'LATITUD',
   'user', @CurrentUser, 'table', 'EMPRESA', 'column', 'LATITUD'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('EMPRESA')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'LONGITUD')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'EMPRESA', 'column', 'LONGITUD'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'LONGITUD',
   'user', @CurrentUser, 'table', 'EMPRESA', 'column', 'LONGITUD'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('EMPRESA')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'SUCURSAL')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'EMPRESA', 'column', 'SUCURSAL'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'SUCURSAL',
   'user', @CurrentUser, 'table', 'EMPRESA', 'column', 'SUCURSAL'
go

/*==============================================================*/
/* Index: EMPRESA_MUNICIPIO_FK                                  */
/*==============================================================*/
create index EMPRESA_MUNICIPIO_FK on EMPRESA (
ID_MUNICIPIO ASC
)
go

/*==============================================================*/
/* Index: EMPRESA_LOGO_FK                                       */
/*==============================================================*/
create index EMPRESA_LOGO_FK on EMPRESA (
ID_IMAGEN ASC
)
go

/*==============================================================*/
/* Index: EMPRESA_RED_SOCIAL_FK                                 */
/*==============================================================*/
create index EMPRESA_RED_SOCIAL_FK on EMPRESA (
ID_EMPRESA ASC
)
go

/*==============================================================*/
/* Table: ERROR                                                 */
/*==============================================================*/
create table ERROR (
   ID_ERROR             numeric              identity(1,1),
   ERROR                varchar(500)         not null,
   MENSAJE_PARA_USUARIO varchar(500)         not null,
   POSIBLE_SOLUCION     varchar(500)         null,
   CAMPO_DE_BUSQUEDA    varchar(150)         not null,
   constraint PK_ERROR primary key (ID_ERROR),
   constraint AK_CAMPO_DE_BUSQUEDA_ERROR unique (CAMPO_DE_BUSQUEDA)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('ERROR') and minor_id = 0)
begin 
   declare @CurrentUser sysname 
select @CurrentUser = user_name() 
execute sp_dropextendedproperty 'MS_Description',  
   'user', @CurrentUser, 'table', 'ERROR' 
 
end 


select @CurrentUser = user_name() 
execute sp_addextendedproperty 'MS_Description',  
   'ERROR', 
   'user', @CurrentUser, 'table', 'ERROR'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('ERROR')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'ID_ERROR')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'ERROR', 'column', 'ID_ERROR'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_ERROR',
   'user', @CurrentUser, 'table', 'ERROR', 'column', 'ID_ERROR'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('ERROR')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'ERROR')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'ERROR', 'column', 'ERROR'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ERROR',
   'user', @CurrentUser, 'table', 'ERROR', 'column', 'ERROR'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('ERROR')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'MENSAJE_PARA_USUARIO')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'ERROR', 'column', 'MENSAJE_PARA_USUARIO'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'MENSAJE_PARA_USUARIO',
   'user', @CurrentUser, 'table', 'ERROR', 'column', 'MENSAJE_PARA_USUARIO'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('ERROR')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'POSIBLE_SOLUCION')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'ERROR', 'column', 'POSIBLE_SOLUCION'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'POSIBLE_SOLUCION',
   'user', @CurrentUser, 'table', 'ERROR', 'column', 'POSIBLE_SOLUCION'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('ERROR')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'CAMPO_DE_BUSQUEDA')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'ERROR', 'column', 'CAMPO_DE_BUSQUEDA'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'CAMPO_DE_BUSQUEDA',
   'user', @CurrentUser, 'table', 'ERROR', 'column', 'CAMPO_DE_BUSQUEDA'
go

/*==============================================================*/
/* Table: HISTORIAL                                             */
/*==============================================================*/
create table HISTORIAL (
   ID_HISTORIAL         numeric              identity(1,1),
   ID_CLIENTE           numeric              not null,
   ID_IMAGEN            numeric              null,
   ID_HISTORIAL_DESCUENTO numeric              null,
   ID_USUARIO           numeric              not null,
   FECHA                datetime             not null,
   HORA                 datetime             not null,
   NUM_FACTURA_VISITA   varchar(100)         not null,
   VALOR_FACTURA        DOMAIN_VALOR         null,
   ORIGEN               DOMAIN_ORIGEN        not null,
   ESTADO               DOMAIN_ESTADO_DOMICILIO not null,
   constraint PK_HISTORIAL primary key nonclustered (ID_HISTORIAL),
   constraint AK_NUM_FACTURA_VISITA_HISTORIA unique (FECHA, HORA, NUM_FACTURA_VISITA)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('HISTORIAL') and minor_id = 0)
begin 
   declare @CurrentUser sysname 
select @CurrentUser = user_name() 
execute sp_dropextendedproperty 'MS_Description',  
   'user', @CurrentUser, 'table', 'HISTORIAL' 
 
end 


select @CurrentUser = user_name() 
execute sp_addextendedproperty 'MS_Description',  
   'HISTORIAL', 
   'user', @CurrentUser, 'table', 'HISTORIAL'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('HISTORIAL')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'ID_HISTORIAL')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'HISTORIAL', 'column', 'ID_HISTORIAL'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_HISTORIAL',
   'user', @CurrentUser, 'table', 'HISTORIAL', 'column', 'ID_HISTORIAL'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('HISTORIAL')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'ID_CLIENTE')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'HISTORIAL', 'column', 'ID_CLIENTE'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_CLIENTE',
   'user', @CurrentUser, 'table', 'HISTORIAL', 'column', 'ID_CLIENTE'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('HISTORIAL')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'ID_IMAGEN')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'HISTORIAL', 'column', 'ID_IMAGEN'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_IMAGEN',
   'user', @CurrentUser, 'table', 'HISTORIAL', 'column', 'ID_IMAGEN'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('HISTORIAL')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'ID_HISTORIAL_DESCUENTO')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'HISTORIAL', 'column', 'ID_HISTORIAL_DESCUENTO'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_HISTORIAL_DESCUENTO',
   'user', @CurrentUser, 'table', 'HISTORIAL', 'column', 'ID_HISTORIAL_DESCUENTO'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('HISTORIAL')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'ID_USUARIO')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'HISTORIAL', 'column', 'ID_USUARIO'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_USUARIO',
   'user', @CurrentUser, 'table', 'HISTORIAL', 'column', 'ID_USUARIO'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('HISTORIAL')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'FECHA')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'HISTORIAL', 'column', 'FECHA'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'FECHA',
   'user', @CurrentUser, 'table', 'HISTORIAL', 'column', 'FECHA'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('HISTORIAL')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'HORA')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'HISTORIAL', 'column', 'HORA'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'HORA',
   'user', @CurrentUser, 'table', 'HISTORIAL', 'column', 'HORA'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('HISTORIAL')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'NUM_FACTURA_VISITA')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'HISTORIAL', 'column', 'NUM_FACTURA_VISITA'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'NUM_FACTURA_VISITA',
   'user', @CurrentUser, 'table', 'HISTORIAL', 'column', 'NUM_FACTURA_VISITA'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('HISTORIAL')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'VALOR_FACTURA')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'HISTORIAL', 'column', 'VALOR_FACTURA'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'VALOR_FACTURA',
   'user', @CurrentUser, 'table', 'HISTORIAL', 'column', 'VALOR_FACTURA'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('HISTORIAL')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'ORIGEN')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'HISTORIAL', 'column', 'ORIGEN'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ORIGEN',
   'user', @CurrentUser, 'table', 'HISTORIAL', 'column', 'ORIGEN'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('HISTORIAL')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'ESTADO')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'HISTORIAL', 'column', 'ESTADO'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ESTADO',
   'user', @CurrentUser, 'table', 'HISTORIAL', 'column', 'ESTADO'
go

/*==============================================================*/
/* Index: CLIENTE_HISTORIAL_FK                                  */
/*==============================================================*/
create index CLIENTE_HISTORIAL_FK on HISTORIAL (
ID_CLIENTE ASC
)
go

/*==============================================================*/
/* Index: HISTORIAL_IMAGEN_FK                                   */
/*==============================================================*/
create index HISTORIAL_IMAGEN_FK on HISTORIAL (
ID_IMAGEN ASC
)
go

/*==============================================================*/
/* Index: HISTORIAL_HISTORIAL_DESCUENTO_FK                      */
/*==============================================================*/
create index HISTORIAL_HISTORIAL_DESCUENTO_FK on HISTORIAL (
ID_HISTORIAL_DESCUENTO ASC
)
go

/*==============================================================*/
/* Index: USUARIO_HISTORIAL_FK                                  */
/*==============================================================*/
create index USUARIO_HISTORIAL_FK on HISTORIAL (
ID_USUARIO ASC
)
go

/*==============================================================*/
/* Table: HISTORIAL_DESCUENTO                                   */
/*==============================================================*/
create table HISTORIAL_DESCUENTO (
   ID_HISTORIAL_DESCUENTO numeric              identity(1,1),
   ID_IMAGEN            numeric              null,
   ID_DESCUENTO         numeric              not null,
   ID_USUARIO           numeric              not null,
   FECHA                datetime             not null,
   HORA                 datetime             not null,
   NUM_FACTURA          varchar(100)         not null,
   constraint PK_HISTORIAL_DESCUENTO primary key nonclustered (ID_HISTORIAL_DESCUENTO),
   constraint AK_NUM_FACTURA_HISTORIA unique (NUM_FACTURA)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('HISTORIAL_DESCUENTO') and minor_id = 0)
begin 
   declare @CurrentUser sysname 
select @CurrentUser = user_name() 
execute sp_dropextendedproperty 'MS_Description',  
   'user', @CurrentUser, 'table', 'HISTORIAL_DESCUENTO' 
 
end 


select @CurrentUser = user_name() 
execute sp_addextendedproperty 'MS_Description',  
   'HISTORIAL_DESCUENTO', 
   'user', @CurrentUser, 'table', 'HISTORIAL_DESCUENTO'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('HISTORIAL_DESCUENTO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'ID_HISTORIAL_DESCUENTO')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'HISTORIAL_DESCUENTO', 'column', 'ID_HISTORIAL_DESCUENTO'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_HISTORIAL_DESCUENTO',
   'user', @CurrentUser, 'table', 'HISTORIAL_DESCUENTO', 'column', 'ID_HISTORIAL_DESCUENTO'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('HISTORIAL_DESCUENTO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'ID_IMAGEN')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'HISTORIAL_DESCUENTO', 'column', 'ID_IMAGEN'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_IMAGEN',
   'user', @CurrentUser, 'table', 'HISTORIAL_DESCUENTO', 'column', 'ID_IMAGEN'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('HISTORIAL_DESCUENTO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'ID_DESCUENTO')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'HISTORIAL_DESCUENTO', 'column', 'ID_DESCUENTO'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_DESCUENTO',
   'user', @CurrentUser, 'table', 'HISTORIAL_DESCUENTO', 'column', 'ID_DESCUENTO'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('HISTORIAL_DESCUENTO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'ID_USUARIO')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'HISTORIAL_DESCUENTO', 'column', 'ID_USUARIO'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_USUARIO',
   'user', @CurrentUser, 'table', 'HISTORIAL_DESCUENTO', 'column', 'ID_USUARIO'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('HISTORIAL_DESCUENTO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'FECHA')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'HISTORIAL_DESCUENTO', 'column', 'FECHA'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'FECHA',
   'user', @CurrentUser, 'table', 'HISTORIAL_DESCUENTO', 'column', 'FECHA'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('HISTORIAL_DESCUENTO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'HORA')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'HISTORIAL_DESCUENTO', 'column', 'HORA'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'HORA',
   'user', @CurrentUser, 'table', 'HISTORIAL_DESCUENTO', 'column', 'HORA'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('HISTORIAL_DESCUENTO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'NUM_FACTURA')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'HISTORIAL_DESCUENTO', 'column', 'NUM_FACTURA'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'NUM_FACTURA',
   'user', @CurrentUser, 'table', 'HISTORIAL_DESCUENTO', 'column', 'NUM_FACTURA'
go

/*==============================================================*/
/* Index: IMAGEN_HISTORIAL_DESCUENTO_FK                         */
/*==============================================================*/
create index IMAGEN_HISTORIAL_DESCUENTO_FK on HISTORIAL_DESCUENTO (
ID_IMAGEN ASC
)
go

/*==============================================================*/
/* Index: DESCUENTO_HISTORIAL_DESCUENTO_FK                      */
/*==============================================================*/
create index DESCUENTO_HISTORIAL_DESCUENTO_FK on HISTORIAL_DESCUENTO (
ID_DESCUENTO ASC
)
go

/*==============================================================*/
/* Index: USUARIO_HISTORIAL_DESCUENTO_FK                        */
/*==============================================================*/
create index USUARIO_HISTORIAL_DESCUENTO_FK on HISTORIAL_DESCUENTO (
ID_USUARIO ASC
)
go

/*==============================================================*/
/* Table: IMAGEN                                                */
/*==============================================================*/
create table IMAGEN (
   ID_IMAGEN            numeric              identity(1,1),
   RUTA                 varchar(1000)        null,
   IMAGEN               image                null,
   constraint PK_IMAGEN primary key nonclustered (ID_IMAGEN)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('IMAGEN') and minor_id = 0)
begin 
   declare @CurrentUser sysname 
select @CurrentUser = user_name() 
execute sp_dropextendedproperty 'MS_Description',  
   'user', @CurrentUser, 'table', 'IMAGEN' 
 
end 


select @CurrentUser = user_name() 
execute sp_addextendedproperty 'MS_Description',  
   'IMAGEN', 
   'user', @CurrentUser, 'table', 'IMAGEN'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('IMAGEN')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'ID_IMAGEN')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'IMAGEN', 'column', 'ID_IMAGEN'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_IMAGEN',
   'user', @CurrentUser, 'table', 'IMAGEN', 'column', 'ID_IMAGEN'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('IMAGEN')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'RUTA')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'IMAGEN', 'column', 'RUTA'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'RUTA',
   'user', @CurrentUser, 'table', 'IMAGEN', 'column', 'RUTA'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('IMAGEN')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'IMAGEN')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'IMAGEN', 'column', 'IMAGEN'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'IMAGEN',
   'user', @CurrentUser, 'table', 'IMAGEN', 'column', 'IMAGEN'
go

/*==============================================================*/
/* Table: MUNICIPIO                                             */
/*==============================================================*/
create table MUNICIPIO (
   ID_MUNICIPIO         numeric              identity(1,1),
   ID_DEPARTAMENTO      numeric              null,
   NOM_MUNICIPIO        varchar(50)          not null,
   constraint PK_MUNICIPIO primary key nonclustered (ID_MUNICIPIO),
   constraint AK_NOM_MUNICIPIO_MUNICIPI unique (ID_DEPARTAMENTO, NOM_MUNICIPIO)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('MUNICIPIO') and minor_id = 0)
begin 
   declare @CurrentUser sysname 
select @CurrentUser = user_name() 
execute sp_dropextendedproperty 'MS_Description',  
   'user', @CurrentUser, 'table', 'MUNICIPIO' 
 
end 


select @CurrentUser = user_name() 
execute sp_addextendedproperty 'MS_Description',  
   'MUNICIPIO', 
   'user', @CurrentUser, 'table', 'MUNICIPIO'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('MUNICIPIO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'ID_MUNICIPIO')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'MUNICIPIO', 'column', 'ID_MUNICIPIO'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_MUNICIPIO',
   'user', @CurrentUser, 'table', 'MUNICIPIO', 'column', 'ID_MUNICIPIO'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('MUNICIPIO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'ID_DEPARTAMENTO')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'MUNICIPIO', 'column', 'ID_DEPARTAMENTO'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_DEPARTAMENTO',
   'user', @CurrentUser, 'table', 'MUNICIPIO', 'column', 'ID_DEPARTAMENTO'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('MUNICIPIO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'NOM_MUNICIPIO')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'MUNICIPIO', 'column', 'NOM_MUNICIPIO'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'NOM_MUNICIPIO',
   'user', @CurrentUser, 'table', 'MUNICIPIO', 'column', 'NOM_MUNICIPIO'
go

/*==============================================================*/
/* Index: MUNICIPIO_DEPARTAMENTO_FK                             */
/*==============================================================*/
create index MUNICIPIO_DEPARTAMENTO_FK on MUNICIPIO (
ID_DEPARTAMENTO ASC
)
go

/*==============================================================*/
/* Table: PRODUCTO                                              */
/*==============================================================*/
create table PRODUCTO (
   ID_PRODUCTO          numeric              identity(1,1),
   ID_IMAGEN            numeric              null,
   ID_TIPO_PRODUCTO     numeric              null,
   ID_EMPRESA           numeric              not null,
   NOM_PRODUCTO         varchar(100)         not null,
   PRECIO               DOMAIN_VALOR         not null,
   DESCRIPCION          varchar(8000)        null,
   constraint PK_PRODUCTO primary key nonclustered (ID_PRODUCTO),
   constraint AK_NOM_PRODUCTO_PRODUCTO unique (NOM_PRODUCTO)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('PRODUCTO') and minor_id = 0)
begin 
   declare @CurrentUser sysname 
select @CurrentUser = user_name() 
execute sp_dropextendedproperty 'MS_Description',  
   'user', @CurrentUser, 'table', 'PRODUCTO' 
 
end 


select @CurrentUser = user_name() 
execute sp_addextendedproperty 'MS_Description',  
   'PRODUCTO', 
   'user', @CurrentUser, 'table', 'PRODUCTO'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('PRODUCTO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'ID_PRODUCTO')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'PRODUCTO', 'column', 'ID_PRODUCTO'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_PRODUCTO',
   'user', @CurrentUser, 'table', 'PRODUCTO', 'column', 'ID_PRODUCTO'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('PRODUCTO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'ID_IMAGEN')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'PRODUCTO', 'column', 'ID_IMAGEN'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_IMAGEN',
   'user', @CurrentUser, 'table', 'PRODUCTO', 'column', 'ID_IMAGEN'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('PRODUCTO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'ID_TIPO_PRODUCTO')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'PRODUCTO', 'column', 'ID_TIPO_PRODUCTO'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_TIPO_PRODUCTO',
   'user', @CurrentUser, 'table', 'PRODUCTO', 'column', 'ID_TIPO_PRODUCTO'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('PRODUCTO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'ID_EMPRESA')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'PRODUCTO', 'column', 'ID_EMPRESA'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_EMPRESA',
   'user', @CurrentUser, 'table', 'PRODUCTO', 'column', 'ID_EMPRESA'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('PRODUCTO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'NOM_PRODUCTO')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'PRODUCTO', 'column', 'NOM_PRODUCTO'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'NOM_PRODUCTO',
   'user', @CurrentUser, 'table', 'PRODUCTO', 'column', 'NOM_PRODUCTO'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('PRODUCTO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'PRECIO')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'PRODUCTO', 'column', 'PRECIO'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'PRECIO',
   'user', @CurrentUser, 'table', 'PRODUCTO', 'column', 'PRECIO'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('PRODUCTO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'DESCRIPCION')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'PRODUCTO', 'column', 'DESCRIPCION'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'DESCRIPCION',
   'user', @CurrentUser, 'table', 'PRODUCTO', 'column', 'DESCRIPCION'
go

/*==============================================================*/
/* Index: PRODUCTO_IMAGEN_FK                                    */
/*==============================================================*/
create index PRODUCTO_IMAGEN_FK on PRODUCTO (
ID_IMAGEN ASC
)
go

/*==============================================================*/
/* Index: PRODUCTO_TIPO_FK                                      */
/*==============================================================*/
create index PRODUCTO_TIPO_FK on PRODUCTO (
ID_TIPO_PRODUCTO ASC
)
go

/*==============================================================*/
/* Index: EMPRESA_PRODUCTO_FK                                   */
/*==============================================================*/
create index EMPRESA_PRODUCTO_FK on PRODUCTO (
ID_EMPRESA ASC
)
go

/*==============================================================*/
/* Table: REDES_SOCIALES                                        */
/*==============================================================*/
create table REDES_SOCIALES (
   ID_REDES_SOCIALES    numeric              identity(1,1),
   ID_TIPO_RED_SOCIAL   numeric              not null,
   ID_EMPRESA           numeric              null,
   URL                  varchar(500)         not null,
   constraint PK_REDES_SOCIALES primary key nonclustered (ID_REDES_SOCIALES)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('REDES_SOCIALES') and minor_id = 0)
begin 
   declare @CurrentUser sysname 
select @CurrentUser = user_name() 
execute sp_dropextendedproperty 'MS_Description',  
   'user', @CurrentUser, 'table', 'REDES_SOCIALES' 
 
end 


select @CurrentUser = user_name() 
execute sp_addextendedproperty 'MS_Description',  
   'REDES_SOCIALES', 
   'user', @CurrentUser, 'table', 'REDES_SOCIALES'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('REDES_SOCIALES')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'ID_REDES_SOCIALES')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'REDES_SOCIALES', 'column', 'ID_REDES_SOCIALES'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_REDES_SOCIALES',
   'user', @CurrentUser, 'table', 'REDES_SOCIALES', 'column', 'ID_REDES_SOCIALES'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('REDES_SOCIALES')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'ID_TIPO_RED_SOCIAL')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'REDES_SOCIALES', 'column', 'ID_TIPO_RED_SOCIAL'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_TIPO_RED_SOCIAL',
   'user', @CurrentUser, 'table', 'REDES_SOCIALES', 'column', 'ID_TIPO_RED_SOCIAL'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('REDES_SOCIALES')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'ID_EMPRESA')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'REDES_SOCIALES', 'column', 'ID_EMPRESA'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_EMPRESA',
   'user', @CurrentUser, 'table', 'REDES_SOCIALES', 'column', 'ID_EMPRESA'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('REDES_SOCIALES')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'URL')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'REDES_SOCIALES', 'column', 'URL'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'URL',
   'user', @CurrentUser, 'table', 'REDES_SOCIALES', 'column', 'URL'
go

/*==============================================================*/
/* Index: RED_SOCIAL_TIPO_FK                                    */
/*==============================================================*/
create index RED_SOCIAL_TIPO_FK on REDES_SOCIALES (
ID_TIPO_RED_SOCIAL ASC
)
go

/*==============================================================*/
/* Table: ROL                                                   */
/*==============================================================*/
create table ROL (
   ID_ROL               numeric              identity(1,1),
   NOM_ROL              varchar(50)          not null,
   constraint PK_ROL primary key nonclustered (ID_ROL),
   constraint AK_NOM_ROL_ROL unique (NOM_ROL)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('ROL') and minor_id = 0)
begin 
   declare @CurrentUser sysname 
select @CurrentUser = user_name() 
execute sp_dropextendedproperty 'MS_Description',  
   'user', @CurrentUser, 'table', 'ROL' 
 
end 


select @CurrentUser = user_name() 
execute sp_addextendedproperty 'MS_Description',  
   'ROL', 
   'user', @CurrentUser, 'table', 'ROL'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('ROL')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'ID_ROL')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'ROL', 'column', 'ID_ROL'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_ROL',
   'user', @CurrentUser, 'table', 'ROL', 'column', 'ID_ROL'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('ROL')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'NOM_ROL')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'ROL', 'column', 'NOM_ROL'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'NOM_ROL',
   'user', @CurrentUser, 'table', 'ROL', 'column', 'NOM_ROL'
go

/*==============================================================*/
/* Table: ROL_OPCION                                            */
/*==============================================================*/
create table ROL_OPCION (
   ID_ROL_OPCION        numeric              identity(1,1),
   ID_ROL               numeric              not null,
   OPCION               varchar(50)          not null,
   constraint PK_ROL_OPCION primary key nonclustered (ID_ROL_OPCION),
   constraint AK_OPCION_ROL_OPCI unique (ID_ROL, OPCION)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('ROL_OPCION') and minor_id = 0)
begin 
   declare @CurrentUser sysname 
select @CurrentUser = user_name() 
execute sp_dropextendedproperty 'MS_Description',  
   'user', @CurrentUser, 'table', 'ROL_OPCION' 
 
end 


select @CurrentUser = user_name() 
execute sp_addextendedproperty 'MS_Description',  
   'ROL_OPCION', 
   'user', @CurrentUser, 'table', 'ROL_OPCION'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('ROL_OPCION')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'ID_ROL_OPCION')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'ROL_OPCION', 'column', 'ID_ROL_OPCION'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_ROL_OPCION',
   'user', @CurrentUser, 'table', 'ROL_OPCION', 'column', 'ID_ROL_OPCION'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('ROL_OPCION')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'ID_ROL')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'ROL_OPCION', 'column', 'ID_ROL'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_ROL',
   'user', @CurrentUser, 'table', 'ROL_OPCION', 'column', 'ID_ROL'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('ROL_OPCION')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'OPCION')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'ROL_OPCION', 'column', 'OPCION'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'OPCION',
   'user', @CurrentUser, 'table', 'ROL_OPCION', 'column', 'OPCION'
go

/*==============================================================*/
/* Index: ROL_ROL_OPCION_FK                                     */
/*==============================================================*/
create index ROL_ROL_OPCION_FK on ROL_OPCION (
ID_ROL ASC
)
go

/*==============================================================*/
/* Table: TIPO_ACTIVIDAD                                        */
/*==============================================================*/
create table TIPO_ACTIVIDAD (
   ID_TIPO_ACTIVIDAD    numeric              identity(1,1),
   NOM_TIPO_ACTIVIDAD   varchar(100)         not null,
   constraint PK_TIPO_ACTIVIDAD primary key nonclustered (ID_TIPO_ACTIVIDAD),
   constraint AK_NOM_TIPO_ACTIVIDAD_TIPO_ACT unique (NOM_TIPO_ACTIVIDAD)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('TIPO_ACTIVIDAD') and minor_id = 0)
begin 
   declare @CurrentUser sysname 
select @CurrentUser = user_name() 
execute sp_dropextendedproperty 'MS_Description',  
   'user', @CurrentUser, 'table', 'TIPO_ACTIVIDAD' 
 
end 


select @CurrentUser = user_name() 
execute sp_addextendedproperty 'MS_Description',  
   'TIPO_ACTIVIDAD', 
   'user', @CurrentUser, 'table', 'TIPO_ACTIVIDAD'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('TIPO_ACTIVIDAD')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'ID_TIPO_ACTIVIDAD')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'TIPO_ACTIVIDAD', 'column', 'ID_TIPO_ACTIVIDAD'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_TIPO_ACTIVIDAD',
   'user', @CurrentUser, 'table', 'TIPO_ACTIVIDAD', 'column', 'ID_TIPO_ACTIVIDAD'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('TIPO_ACTIVIDAD')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'NOM_TIPO_ACTIVIDAD')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'TIPO_ACTIVIDAD', 'column', 'NOM_TIPO_ACTIVIDAD'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'NOM_TIPO_ACTIVIDAD',
   'user', @CurrentUser, 'table', 'TIPO_ACTIVIDAD', 'column', 'NOM_TIPO_ACTIVIDAD'
go

/*==============================================================*/
/* Table: TIPO_IDENTIFICACION                                   */
/*==============================================================*/
create table TIPO_IDENTIFICACION (
   ID_TIPO_IDENTIFICACION numeric              identity(1,1),
   NOM_TIPO_IDENTIFICACION varchar(50)          not null,
   constraint PK_TIPO_IDENTIFICACION primary key nonclustered (ID_TIPO_IDENTIFICACION),
   constraint AK_NOM_TIPO_IDENTIFIC_TIPO_IDE unique (NOM_TIPO_IDENTIFICACION)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('TIPO_IDENTIFICACION') and minor_id = 0)
begin 
   declare @CurrentUser sysname 
select @CurrentUser = user_name() 
execute sp_dropextendedproperty 'MS_Description',  
   'user', @CurrentUser, 'table', 'TIPO_IDENTIFICACION' 
 
end 


select @CurrentUser = user_name() 
execute sp_addextendedproperty 'MS_Description',  
   'TIPO_IDENTIFICACION', 
   'user', @CurrentUser, 'table', 'TIPO_IDENTIFICACION'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('TIPO_IDENTIFICACION')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'ID_TIPO_IDENTIFICACION')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'TIPO_IDENTIFICACION', 'column', 'ID_TIPO_IDENTIFICACION'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_TIPO_IDENTIFICACION',
   'user', @CurrentUser, 'table', 'TIPO_IDENTIFICACION', 'column', 'ID_TIPO_IDENTIFICACION'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('TIPO_IDENTIFICACION')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'NOM_TIPO_IDENTIFICACION')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'TIPO_IDENTIFICACION', 'column', 'NOM_TIPO_IDENTIFICACION'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'NOM_TIPO_IDENTIFICACION',
   'user', @CurrentUser, 'table', 'TIPO_IDENTIFICACION', 'column', 'NOM_TIPO_IDENTIFICACION'
go

/*==============================================================*/
/* Table: TIPO_PRODUCTO                                         */
/*==============================================================*/
create table TIPO_PRODUCTO (
   ID_TIPO_PRODUCTO     numeric              identity(1,1),
   NOM_TIPO_PRODUCTO    varchar(100)         not null,
   constraint PK_TIPO_PRODUCTO primary key nonclustered (ID_TIPO_PRODUCTO),
   constraint AK_NOM_TIPO_PRODUCTO_TIPO_PRO unique (NOM_TIPO_PRODUCTO)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('TIPO_PRODUCTO') and minor_id = 0)
begin 
   declare @CurrentUser sysname 
select @CurrentUser = user_name() 
execute sp_dropextendedproperty 'MS_Description',  
   'user', @CurrentUser, 'table', 'TIPO_PRODUCTO' 
 
end 


select @CurrentUser = user_name() 
execute sp_addextendedproperty 'MS_Description',  
   'TIPO_PRODUCTO', 
   'user', @CurrentUser, 'table', 'TIPO_PRODUCTO'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('TIPO_PRODUCTO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'ID_TIPO_PRODUCTO')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'TIPO_PRODUCTO', 'column', 'ID_TIPO_PRODUCTO'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_TIPO_PRODUCTO',
   'user', @CurrentUser, 'table', 'TIPO_PRODUCTO', 'column', 'ID_TIPO_PRODUCTO'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('TIPO_PRODUCTO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'NOM_TIPO_PRODUCTO')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'TIPO_PRODUCTO', 'column', 'NOM_TIPO_PRODUCTO'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'NOM_TIPO_PRODUCTO',
   'user', @CurrentUser, 'table', 'TIPO_PRODUCTO', 'column', 'NOM_TIPO_PRODUCTO'
go

/*==============================================================*/
/* Table: TIPO_RED_SOCIAL                                       */
/*==============================================================*/
create table TIPO_RED_SOCIAL (
   ID_TIPO_RED_SOCIAL   numeric              identity(1,1),
   ID_IMAGEN            numeric              null,
   NOM_TIPO_RED_SOCIAL  varchar(100)         not null,
   constraint PK_TIPO_RED_SOCIAL primary key nonclustered (ID_TIPO_RED_SOCIAL),
   constraint AK_NOM_TIPO_RED_SOCIA_TIPO_RED unique (NOM_TIPO_RED_SOCIAL)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('TIPO_RED_SOCIAL') and minor_id = 0)
begin 
   declare @CurrentUser sysname 
select @CurrentUser = user_name() 
execute sp_dropextendedproperty 'MS_Description',  
   'user', @CurrentUser, 'table', 'TIPO_RED_SOCIAL' 
 
end 


select @CurrentUser = user_name() 
execute sp_addextendedproperty 'MS_Description',  
   'TIPO_RED_SOCIAL', 
   'user', @CurrentUser, 'table', 'TIPO_RED_SOCIAL'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('TIPO_RED_SOCIAL')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'ID_TIPO_RED_SOCIAL')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'TIPO_RED_SOCIAL', 'column', 'ID_TIPO_RED_SOCIAL'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_TIPO_RED_SOCIAL',
   'user', @CurrentUser, 'table', 'TIPO_RED_SOCIAL', 'column', 'ID_TIPO_RED_SOCIAL'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('TIPO_RED_SOCIAL')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'ID_IMAGEN')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'TIPO_RED_SOCIAL', 'column', 'ID_IMAGEN'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_IMAGEN',
   'user', @CurrentUser, 'table', 'TIPO_RED_SOCIAL', 'column', 'ID_IMAGEN'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('TIPO_RED_SOCIAL')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'NOM_TIPO_RED_SOCIAL')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'TIPO_RED_SOCIAL', 'column', 'NOM_TIPO_RED_SOCIAL'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'NOM_TIPO_RED_SOCIAL',
   'user', @CurrentUser, 'table', 'TIPO_RED_SOCIAL', 'column', 'NOM_TIPO_RED_SOCIAL'
go

/*==============================================================*/
/* Index: TIPO_RED_SOCIAL_IMAGEN_FK                             */
/*==============================================================*/
create index TIPO_RED_SOCIAL_IMAGEN_FK on TIPO_RED_SOCIAL (
ID_IMAGEN ASC
)
go

/*==============================================================*/
/* Table: "TOP"                                                 */
/*==============================================================*/
create table "TOP" (
   ID_TOP               numeric              identity(1,1),
   ID_EMPRESA           numeric              not null,
   ID_IMAGEN            numeric              null,
   NOM_TOP              varchar(100)         not null,
   URL                  varchar(500)         not null,
   constraint PK_TOP primary key nonclustered (ID_TOP),
   constraint AK_NOM_TOP_TOP unique (NOM_TOP)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('"TOP"') and minor_id = 0)
begin 
   declare @CurrentUser sysname 
select @CurrentUser = user_name() 
execute sp_dropextendedproperty 'MS_Description',  
   'user', @CurrentUser, 'table', 'TOP' 
 
end 


select @CurrentUser = user_name() 
execute sp_addextendedproperty 'MS_Description',  
   'TOP', 
   'user', @CurrentUser, 'table', 'TOP'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('"TOP"')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'ID_TOP')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'TOP', 'column', 'ID_TOP'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_TOP',
   'user', @CurrentUser, 'table', 'TOP', 'column', 'ID_TOP'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('"TOP"')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'ID_EMPRESA')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'TOP', 'column', 'ID_EMPRESA'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_EMPRESA',
   'user', @CurrentUser, 'table', 'TOP', 'column', 'ID_EMPRESA'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('"TOP"')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'ID_IMAGEN')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'TOP', 'column', 'ID_IMAGEN'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_IMAGEN',
   'user', @CurrentUser, 'table', 'TOP', 'column', 'ID_IMAGEN'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('"TOP"')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'NOM_TOP')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'TOP', 'column', 'NOM_TOP'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'NOM_TOP',
   'user', @CurrentUser, 'table', 'TOP', 'column', 'NOM_TOP'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('"TOP"')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'URL')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'TOP', 'column', 'URL'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'URL',
   'user', @CurrentUser, 'table', 'TOP', 'column', 'URL'
go

/*==============================================================*/
/* Index: EMPRESA_TOP_FK                                        */
/*==============================================================*/
create index EMPRESA_TOP_FK on "TOP" (
ID_EMPRESA ASC
)
go

/*==============================================================*/
/* Index: TOP_IMAGEN_FK                                         */
/*==============================================================*/
create index TOP_IMAGEN_FK on "TOP" (
ID_IMAGEN ASC
)
go

/*==============================================================*/
/* Table: USUARIO                                               */
/*==============================================================*/
create table USUARIO (
   ID_USUARIO           numeric              identity(1,1),
   ID_TIPO_IDENTIFICACION numeric              not null,
   ID_EMPRESA           numeric              not null,
   ID_IMAGEN            numeric              null,
   ID_ROL               numeric              not null,
   IDENTIFICACION       varchar(50)          not null,
   NOMBRES              varchar(50)          not null,
   APELLIDOS            varchar(50)          not null,
   CORREO               varchar(100)         not null,
   DIRECCION            varchar(300)         null,
   TELEFONO             varchar(100)         null,
   LOGIN                varchar(500)         not null,
   PASSWORD             varchar(100)         not null,
   FECHA_NACIMIENTO     datetime             null,
   SEXO                 DOMAIN_SEXO          null,
   ESTADO               DOMAIN_ESTADO_DOMICILIO not null,
   FECHA_INGRESO        datetime             not null,
   FECHA_RETIRO         datetime             null,
   constraint PK_USUARIO primary key nonclustered (ID_USUARIO),
   constraint AK_IDENTIFICACION_USUARIO unique (ID_TIPO_IDENTIFICACION, IDENTIFICACION),
   constraint AK_LOGIN_USUARIO unique (LOGIN)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('USUARIO') and minor_id = 0)
begin 
   declare @CurrentUser sysname 
select @CurrentUser = user_name() 
execute sp_dropextendedproperty 'MS_Description',  
   'user', @CurrentUser, 'table', 'USUARIO' 
 
end 


select @CurrentUser = user_name() 
execute sp_addextendedproperty 'MS_Description',  
   'USUARIO', 
   'user', @CurrentUser, 'table', 'USUARIO'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('USUARIO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'ID_USUARIO')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'USUARIO', 'column', 'ID_USUARIO'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_USUARIO',
   'user', @CurrentUser, 'table', 'USUARIO', 'column', 'ID_USUARIO'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('USUARIO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'ID_TIPO_IDENTIFICACION')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'USUARIO', 'column', 'ID_TIPO_IDENTIFICACION'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_TIPO_IDENTIFICACION',
   'user', @CurrentUser, 'table', 'USUARIO', 'column', 'ID_TIPO_IDENTIFICACION'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('USUARIO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'ID_EMPRESA')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'USUARIO', 'column', 'ID_EMPRESA'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_EMPRESA',
   'user', @CurrentUser, 'table', 'USUARIO', 'column', 'ID_EMPRESA'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('USUARIO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'ID_IMAGEN')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'USUARIO', 'column', 'ID_IMAGEN'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_IMAGEN',
   'user', @CurrentUser, 'table', 'USUARIO', 'column', 'ID_IMAGEN'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('USUARIO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'ID_ROL')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'USUARIO', 'column', 'ID_ROL'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_ROL',
   'user', @CurrentUser, 'table', 'USUARIO', 'column', 'ID_ROL'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('USUARIO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'IDENTIFICACION')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'USUARIO', 'column', 'IDENTIFICACION'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'IDENTIFICACION',
   'user', @CurrentUser, 'table', 'USUARIO', 'column', 'IDENTIFICACION'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('USUARIO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'NOMBRES')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'USUARIO', 'column', 'NOMBRES'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'NOMBRES',
   'user', @CurrentUser, 'table', 'USUARIO', 'column', 'NOMBRES'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('USUARIO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'APELLIDOS')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'USUARIO', 'column', 'APELLIDOS'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'APELLIDOS',
   'user', @CurrentUser, 'table', 'USUARIO', 'column', 'APELLIDOS'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('USUARIO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'CORREO')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'USUARIO', 'column', 'CORREO'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'CORREO',
   'user', @CurrentUser, 'table', 'USUARIO', 'column', 'CORREO'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('USUARIO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'DIRECCION')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'USUARIO', 'column', 'DIRECCION'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'DIRECCION',
   'user', @CurrentUser, 'table', 'USUARIO', 'column', 'DIRECCION'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('USUARIO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'TELEFONO')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'USUARIO', 'column', 'TELEFONO'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'TELEFONO',
   'user', @CurrentUser, 'table', 'USUARIO', 'column', 'TELEFONO'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('USUARIO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'LOGIN')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'USUARIO', 'column', 'LOGIN'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'LOGIN',
   'user', @CurrentUser, 'table', 'USUARIO', 'column', 'LOGIN'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('USUARIO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'PASSWORD')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'USUARIO', 'column', 'PASSWORD'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'PASSWORD',
   'user', @CurrentUser, 'table', 'USUARIO', 'column', 'PASSWORD'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('USUARIO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'FECHA_NACIMIENTO')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'USUARIO', 'column', 'FECHA_NACIMIENTO'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'FECHA_NACIMIENTO',
   'user', @CurrentUser, 'table', 'USUARIO', 'column', 'FECHA_NACIMIENTO'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('USUARIO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'SEXO')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'USUARIO', 'column', 'SEXO'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'SEXO',
   'user', @CurrentUser, 'table', 'USUARIO', 'column', 'SEXO'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('USUARIO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'ESTADO')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'USUARIO', 'column', 'ESTADO'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ESTADO',
   'user', @CurrentUser, 'table', 'USUARIO', 'column', 'ESTADO'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('USUARIO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'FECHA_INGRESO')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'USUARIO', 'column', 'FECHA_INGRESO'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'FECHA_INGRESO',
   'user', @CurrentUser, 'table', 'USUARIO', 'column', 'FECHA_INGRESO'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('USUARIO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'FECHA_RETIRO')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'USUARIO', 'column', 'FECHA_RETIRO'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'FECHA_RETIRO',
   'user', @CurrentUser, 'table', 'USUARIO', 'column', 'FECHA_RETIRO'
go

/*==============================================================*/
/* Index: USUARIO_TIPO_IDENTIFICACION_FK                        */
/*==============================================================*/
create index USUARIO_TIPO_IDENTIFICACION_FK on USUARIO (
ID_TIPO_IDENTIFICACION ASC
)
go

/*==============================================================*/
/* Index: EMPRESA_USUARIO_FK                                    */
/*==============================================================*/
create index EMPRESA_USUARIO_FK on USUARIO (
ID_EMPRESA ASC
)
go

/*==============================================================*/
/* Index: USUARIO_IMAGEN_FK                                     */
/*==============================================================*/
create index USUARIO_IMAGEN_FK on USUARIO (
ID_IMAGEN ASC
)
go

/*==============================================================*/
/* Index: USUARIO_ROL_FK                                        */
/*==============================================================*/
create index USUARIO_ROL_FK on USUARIO (
ID_ROL ASC
)
go

/*==============================================================*/
/* View: VIEW_EMPRESA                                           */
/*==============================================================*/
create view VIEW_EMPRESA as
SELECT
EMPRESA.ID_EMPRESA,
EMPRESA.ID_MUNICIPIO,
EMPRESA.ID_IMAGEN,
EMPRESA.NIT,
EMPRESA.RAZON_SOCIAL,
EMPRESA.DIRECCION_CLIENTE,
EMPRESA.TELEFONO,
EMPRESA.SLOGAN,
EMPRESA.LATITUD,
EMPRESA.LONGITUD,
EMPRESA.SUCURSAL,
MUNICIPIO.NOM_MUNICIPIO,
IMAGEN.IMAGEN
FROM
EMPRESA LEFT JOIN MUNICIPIO 
ON (EMPRESA.ID_MUNICIPIO = MUNICIPIO.ID_MUNICIPIO) LEFT JOIN IMAGEN 
ON (EMPRESA.ID_IMAGEN = IMAGEN.ID_IMAGEN)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('VIEW_EMPRESA') and minor_id = 0)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'view', 'VIEW_EMPRESA'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'VIEW_EMPRESA',
   'user', @CurrentUser, 'view', 'VIEW_EMPRESA'
go

alter table ACTIVIDAD
   add constraint FK_ACTIVIDA_ACTIVIDAD_TIPO_ACT foreign key (ID_TIPO_ACTIVIDAD)
      references TIPO_ACTIVIDAD (ID_TIPO_ACTIVIDAD)
go

alter table ACTIVIDAD
   add constraint FK_ACTIVIDA_EMPRESA_A_EMPRESA foreign key (ID_EMPRESA)
      references EMPRESA (ID_EMPRESA)
go

alter table ACTIVIDAD_IMAGEN
   add constraint FK_ACTIVIDA_ACTIVIDAD_ACTIVIDA foreign key (ID_ACTIVIDAD)
      references ACTIVIDAD (ID_ACTIVIDAD)
go

alter table ACTIVIDAD_IMAGEN
   add constraint FK_ACTIVIDA_ACTIVIDAD_IMAGEN foreign key (ID_IMAGEN)
      references IMAGEN (ID_IMAGEN)
go

alter table CLIENTE
   add constraint FK_CLIENTE_CLIENTE_C_CODIGO_Q foreign key (ID_CODIGO_QR)
      references CODIGO_QR (ID_CODIGO_QR)
go

alter table CLIENTE
   add constraint FK_CLIENTE_CLIENTE_I_IMAGEN foreign key (ID_IMAGEN)
      references IMAGEN (ID_IMAGEN)
go

alter table CLIENTE
   add constraint FK_CLIENTE_CLIENTE_T_TIPO_IDE foreign key (ID_TIPO_IDENTIFICACION)
      references TIPO_IDENTIFICACION (ID_TIPO_IDENTIFICACION)
go

alter table CLIENTE
   add constraint FK_CLIENTE_EMPRESA_C_EMPRESA foreign key (ID_EMPRESA)
      references EMPRESA (ID_EMPRESA)
go

alter table DESCUENTO
   add constraint FK_DESCUENT_EMPRESA_D_EMPRESA foreign key (ID_EMPRESA)
      references EMPRESA (ID_EMPRESA)
go

alter table DETALLE_DOMICILIO
   add constraint FK_DETALLE__DOMICILIO_DOMICILI foreign key (ID_DOMICILIO)
      references DOMICILIO (ID_DOMICILIO)
go

alter table DETALLE_DOMICILIO
   add constraint FK_DETALLE__PRODUCTO__PRODUCTO foreign key (ID_PRODUCTO)
      references PRODUCTO (ID_PRODUCTO)
go

alter table DOMICILIO
   add constraint FK_DOMICILI_CLIENTE_D_CLIENTE foreign key (ID_CLIENTE)
      references CLIENTE (ID_CLIENTE)
go

alter table DOMICILIO
   add constraint FK_DOMICILI_USUARIO_D_USUARIO foreign key (ID_USUARIO)
      references USUARIO (ID_USUARIO)
go

alter table EMPRESA
   add constraint FK_EMPRESA_EMPRESA_L_IMAGEN foreign key (ID_IMAGEN)
      references IMAGEN (ID_IMAGEN)
go

alter table EMPRESA
   add constraint FK_EMPRESA_EMPRESA_M_MUNICIPI foreign key (ID_MUNICIPIO)
      references MUNICIPIO (ID_MUNICIPIO)
go

alter table HISTORIAL
   add constraint FK_HISTORIA_CLIENTE_H_CLIENTE foreign key (ID_CLIENTE)
      references CLIENTE (ID_CLIENTE)
go

alter table HISTORIAL
   add constraint FK_HISTORIA_HISTORIAL_HISTORIA foreign key (ID_HISTORIAL_DESCUENTO)
      references HISTORIAL_DESCUENTO (ID_HISTORIAL_DESCUENTO)
go

alter table HISTORIAL
   add constraint FK_HISTORIA_HISTORIAL_IMAGEN foreign key (ID_IMAGEN)
      references IMAGEN (ID_IMAGEN)
go

alter table HISTORIAL
   add constraint FK_HISTORIA_USUARIO_H_USUARIO foreign key (ID_USUARIO)
      references USUARIO (ID_USUARIO)
go

alter table HISTORIAL_DESCUENTO
   add constraint FK_HISTORIA_DESCUENTO_DESCUENT foreign key (ID_DESCUENTO)
      references DESCUENTO (ID_DESCUENTO)
go

alter table HISTORIAL_DESCUENTO
   add constraint FK_HISTORIA_HISTORIAL_USUARIO foreign key (ID_USUARIO)
      references USUARIO (ID_USUARIO)
go

alter table HISTORIAL_DESCUENTO
   add constraint FK_HISTORIA_IMAGEN_HI_IMAGEN foreign key (ID_IMAGEN)
      references IMAGEN (ID_IMAGEN)
go

alter table MUNICIPIO
   add constraint FK_MUNICIPI_MUNICIPIO_DEPARTAM foreign key (ID_DEPARTAMENTO)
      references DEPARTAMENTO (ID_DEPARTAMENTO)
go

alter table PRODUCTO
   add constraint FK_PRODUCTO_EMPRESA_P_EMPRESA foreign key (ID_EMPRESA)
      references EMPRESA (ID_EMPRESA)
go

alter table PRODUCTO
   add constraint FK_PRODUCTO_PRODUCTO__IMAGEN foreign key (ID_IMAGEN)
      references IMAGEN (ID_IMAGEN)
go

alter table PRODUCTO
   add constraint FK_PRODUCTO_PRODUCTO__TIPO_PRO foreign key (ID_TIPO_PRODUCTO)
      references TIPO_PRODUCTO (ID_TIPO_PRODUCTO)
go

alter table REDES_SOCIALES
   add constraint FK_REDES_SO_EMPRESA_R_EMPRESA foreign key (ID_EMPRESA)
      references EMPRESA (ID_EMPRESA)
go

alter table REDES_SOCIALES
   add constraint FK_REDES_SO_RED_SOCIA_TIPO_RED foreign key (ID_TIPO_RED_SOCIAL)
      references TIPO_RED_SOCIAL (ID_TIPO_RED_SOCIAL)
go

alter table ROL_OPCION
   add constraint FK_ROL_OPCI_ROL_ROL_O_ROL foreign key (ID_ROL)
      references ROL (ID_ROL)
go

alter table TIPO_RED_SOCIAL
   add constraint FK_TIPO_RED_TIPO_RED__IMAGEN foreign key (ID_IMAGEN)
      references IMAGEN (ID_IMAGEN)
go

alter table "TOP"
   add constraint FK_TOP_EMPRESA_T_EMPRESA foreign key (ID_EMPRESA)
      references EMPRESA (ID_EMPRESA)
go

alter table "TOP"
   add constraint FK_TOP_TOP_IMAGE_IMAGEN foreign key (ID_IMAGEN)
      references IMAGEN (ID_IMAGEN)
go

alter table USUARIO
   add constraint FK_USUARIO_EMPRESA_U_EMPRESA foreign key (ID_EMPRESA)
      references EMPRESA (ID_EMPRESA)
go

alter table USUARIO
   add constraint FK_USUARIO_USUARIO_I_IMAGEN foreign key (ID_IMAGEN)
      references IMAGEN (ID_IMAGEN)
go

alter table USUARIO
   add constraint FK_USUARIO_USUARIO_R_ROL foreign key (ID_ROL)
      references ROL (ID_ROL)
go

alter table USUARIO
   add constraint FK_USUARIO_USUARIO_T_TIPO_IDE foreign key (ID_TIPO_IDENTIFICACION)
      references TIPO_IDENTIFICACION (ID_TIPO_IDENTIFICACION)
go


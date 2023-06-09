﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class CineEntities1 : DbContext
    {
        public CineEntities1()
            : base("name=CineEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cine> Cines { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Zona> Zonas { get; set; }
    
        public virtual int CineAdd(string nombre, string direccion, Nullable<decimal> venta, Nullable<int> idZona, Nullable<double> latitud, Nullable<double> longitud)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var direccionParameter = direccion != null ?
                new ObjectParameter("Direccion", direccion) :
                new ObjectParameter("Direccion", typeof(string));
    
            var ventaParameter = venta.HasValue ?
                new ObjectParameter("Venta", venta) :
                new ObjectParameter("Venta", typeof(decimal));
    
            var idZonaParameter = idZona.HasValue ?
                new ObjectParameter("IdZona", idZona) :
                new ObjectParameter("IdZona", typeof(int));
    
            var latitudParameter = latitud.HasValue ?
                new ObjectParameter("Latitud", latitud) :
                new ObjectParameter("Latitud", typeof(double));
    
            var longitudParameter = longitud.HasValue ?
                new ObjectParameter("Longitud", longitud) :
                new ObjectParameter("Longitud", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CineAdd", nombreParameter, direccionParameter, ventaParameter, idZonaParameter, latitudParameter, longitudParameter);
        }
    
        public virtual int CineDelete(Nullable<int> idCine)
        {
            var idCineParameter = idCine.HasValue ?
                new ObjectParameter("IdCine", idCine) :
                new ObjectParameter("IdCine", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CineDelete", idCineParameter);
        }
    
        public virtual ObjectResult<CineGetAll_Result> CineGetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CineGetAll_Result>("CineGetAll");
        }
    
        public virtual ObjectResult<CineGetById_Result> CineGetById(Nullable<int> idCine)
        {
            var idCineParameter = idCine.HasValue ?
                new ObjectParameter("IdCine", idCine) :
                new ObjectParameter("IdCine", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CineGetById_Result>("CineGetById", idCineParameter);
        }
    
        public virtual ObjectResult<VentaZona_Result> VentaZona()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<VentaZona_Result>("VentaZona");
        }
    
        public virtual ObjectResult<VentaZona2_Result> VentaZona2()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<VentaZona2_Result>("VentaZona2");
        }
    
        public virtual ObjectResult<VentaZona3_Result> VentaZona3()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<VentaZona3_Result>("VentaZona3");
        }
    
        public virtual ObjectResult<VentaZona4_Result> VentaZona4()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<VentaZona4_Result>("VentaZona4");
        }
    
        public virtual int ZonaAdd(string nombre)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ZonaAdd", nombreParameter);
        }
    
        public virtual ObjectResult<ZonaGetAll_Result> ZonaGetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ZonaGetAll_Result>("ZonaGetAll");
        }
    
        public virtual ObjectResult<ZonaGetById_Result> ZonaGetById(Nullable<int> idZona)
        {
            var idZonaParameter = idZona.HasValue ?
                new ObjectParameter("IdZona", idZona) :
                new ObjectParameter("IdZona", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ZonaGetById_Result>("ZonaGetById", idZonaParameter);
        }
    
        public virtual int CineUpdate(Nullable<int> idCine, string nombre, string direccion, Nullable<decimal> venta, Nullable<int> idZona, Nullable<double> longitud, Nullable<double> latitud)
        {
            var idCineParameter = idCine.HasValue ?
                new ObjectParameter("IdCine", idCine) :
                new ObjectParameter("IdCine", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var direccionParameter = direccion != null ?
                new ObjectParameter("Direccion", direccion) :
                new ObjectParameter("Direccion", typeof(string));
    
            var ventaParameter = venta.HasValue ?
                new ObjectParameter("Venta", venta) :
                new ObjectParameter("Venta", typeof(decimal));
    
            var idZonaParameter = idZona.HasValue ?
                new ObjectParameter("IdZona", idZona) :
                new ObjectParameter("IdZona", typeof(int));
    
            var longitudParameter = longitud.HasValue ?
                new ObjectParameter("Longitud", longitud) :
                new ObjectParameter("Longitud", typeof(double));
    
            var latitudParameter = latitud.HasValue ?
                new ObjectParameter("Latitud", latitud) :
                new ObjectParameter("Latitud", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CineUpdate", idCineParameter, nombreParameter, direccionParameter, ventaParameter, idZonaParameter, longitudParameter, latitudParameter);
        }
    
        public virtual int AddUsuario(string nombre, string apellidoPaterno, string apellidoMaterno, string email, string userName, byte[] password)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var apellidoPaternoParameter = apellidoPaterno != null ?
                new ObjectParameter("ApellidoPaterno", apellidoPaterno) :
                new ObjectParameter("ApellidoPaterno", typeof(string));
    
            var apellidoMaternoParameter = apellidoMaterno != null ?
                new ObjectParameter("ApellidoMaterno", apellidoMaterno) :
                new ObjectParameter("ApellidoMaterno", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddUsuario", nombreParameter, apellidoPaternoParameter, apellidoMaternoParameter, emailParameter, userNameParameter, passwordParameter);
        }
    
        public virtual ObjectResult<UsuarioGetByEmail_Result> UsuarioGetByEmail(string email)
        {
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UsuarioGetByEmail_Result>("UsuarioGetByEmail", emailParameter);
        }
    
        public virtual ObjectResult<UsuarioGetByUserName_Result> UsuarioGetByUserName(string userName)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UsuarioGetByUserName_Result>("UsuarioGetByUserName", userNameParameter);
        }
    }
}

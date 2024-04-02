﻿using Dapper;
using ManejoPresupuesto.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace ManejoPresupuesto.Servicios
{
    public interface IRepositorioTiposCuentas
    {
        Task Crear(TipoCuenta tipoCuenta);
    }

    public class RepositorioTiposCuentas: IRepositorioTiposCuentas
    {
        private readonly string connectionString;
        public RepositorioTiposCuentas(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public async Task Crear(TipoCuenta tipoCuenta)
        {
            using var connection = new SqlConnection(connectionString);
            var id = await connection.QuerySingleAsync<int>($@"INSERT INTO TipoCuenta (Nombre, UsuarioId, Orden)
                                                    values (@Nombre, @UsuarioId, 0);
                                                    SELECT SCOPE_IDENTITY()", tipoCuenta);
            tipoCuenta.Id = id;
        }
    }
}

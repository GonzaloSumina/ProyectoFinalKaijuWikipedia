using System;
using System.Collections.Generic;
using System.Text;
using ProyectoFinalKaijuWikipedia.Modelo;
using ProyectoFinalKaijuWikipedia.Conexion;
using Firebase.Database.Query;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinalKaijuWikipedia.Datos
{
    public class Dkaiju
    {
        public async Task Insertarkaiju(MKaiju parametros)
        {
            await Cconexion.firebase.Child("Kaiju").PostAsync(new MKaiju()
            {
                Alias = parametros.Alias,
                Descripcion = parametros.Descripcion,
                Icono = parametros.Icono,
                Nombre = parametros.Nombre,
                Altura = parametros.Altura,
                Peso = parametros.Peso,
                IdKaiju = parametros.IdKaiju
            });
        }
        public async Task<List<MKaiju>> Mostrarkaiju()
        {
            return (await Cconexion.firebase.Child("Kaiju").OnceAsync<MKaiju>()).Select(item => new MKaiju
            {
                IdKaiju=item.Key,
                Nombre=item.Object.Nombre,
                Descripcion=item.Object.Descripcion,
                Icono=item.Object.Icono,
                Alias = item.Object.Alias,
                Altura=item.Object.Altura,
                Peso=item.Object.Peso,
            }).ToList();
        }
    }
}

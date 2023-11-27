using System;
using System.Collections.Generic;
using System.Text;
using Firebase.Database;

namespace ProyectoFinalKaijuWikipedia.Conexion
{
    public class Cconexion
    {
        public static FirebaseClient firebase = new FirebaseClient("https://proyectofinalpokedex-985bd-default-rtdb.firebaseio.com/");
    }
}

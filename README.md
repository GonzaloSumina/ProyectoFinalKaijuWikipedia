# Kaiju Enciclopedia
## Integrantes
- Renato Oscar Corrales Peña
- Gonzalo Sumina Quispe
- Santiago Daniel Salas Sotillo
- Franco Sebastián Zegarra Puma

### Descripción
El proyecto "ProyectoFinalKaijuWikipedia" es una aplicación Xamarin.Forms diseñada para proporcionar información detallada sobre monstruos ficticios conocidos como "Kaiju". La aplicación presenta una lista que puede llevar a una interfaz de usuario que muestra datos como el nombre, alias, altura, peso y descripción de cada Kaiju.

### Interfaz de usuario
Al iniciar la aplicación se muestra una pantalla con los Kaijus existentes, un modelo base y una opción para agregar más (esta última añadirá directamente a la base de datos de Firebase). Al seleccionar un Kaiju, nos mostrará una ventana con los detalles almacenados en la base de datos. Al seleccionar la opción de añadir, nos dará una ventana que solicitará los datos del Kaiju que queramos agregar para enviarlos a la base de datos.

### Problemas Detectados

1. **Firebase Database Exception**
   - *Descripción:* Se encontró un error al acceder a la base de datos de Firebase. La traza de la pila no proporciona detalles específicos sobre la excepción.
   - *Solución Propuesta:* Verificar la conexión a Internet, confirmar permisos en Firebase y asegurarse de que la configuración de Firebase esté inicializada correctamente.

### Tecnologías Utilizadas

1. **Xamarin.Forms**
   - *Descripción:* Utilizado para desarrollar la interfaz de usuario multiplataforma, permitiendo compartir código entre Android e iOS.

2. **Firebase Database**
   - *Descripción:* Sirve como el backend para almacenar y recuperar datos sobre los Kaiju.

3. **XAML**
   - *Descripción:* Empleado para definir la interfaz de usuario de manera declarativa.

4. **C#**
   - *Descripción:* Lenguaje de programación utilizado para la lógica de la aplicación y la interacción con Firebase Database.

5. **GitHub**
   - *Descripción:* Plataforma de control de versiones utilizada para colaborar en el desarrollo del proyecto y realizar un seguimiento de los cambios.

### Conclusiones

En resumen, el proyecto ha sido un aprendizaje valioso, destacando áreas clave para el desarrollo futuro. La resolución de los problemas identificados y la implementación de mejoras sugeridas contribuirán a la creación de una aplicación más robusta y satisfactoria para los usuarios.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        // Crear instancias de las notificaciones concretas
        INotificacionPorEmail notificacionPorEmail = new NotificacionPorEmail();
        INotificacionPorSms notificacionPorSms = new NotificacionPorSms();

        // Crear el servicio de notificaciones con las dependencias
        ServicioDeNotificaciones servicioDeNotificaciones = new ServicioDeNotificaciones(notificacionPorEmail, notificacionPorSms);

        // Enviar una notificación por email
        servicioDeNotificaciones.NotificarPorEmail("ejemplo@correo.com", "¡Hola! Este es un mensaje de prueba.");

        // Enviar una notificación por SMS
        servicioDeNotificaciones.NotificarPorSms("123-456-7890", "¡Hola! Este es un mensaje de prueba.");
    }
}

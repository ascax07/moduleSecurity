using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ServicioDeNotificaciones
{
    private readonly INotificacionPorEmail _notificacionPorEmail;
    private readonly INotificacionPorSms _notificacionPorSms;

    // Constructor que recibe las interfaces de notificación por email y SMS
    public ServicioDeNotificaciones(INotificacionPorEmail notificacionPorEmail, INotificacionPorSms notificacionPorSms)
    {
        _notificacionPorEmail = notificacionPorEmail;
        _notificacionPorSms = notificacionPorSms;
    }

    // Método para enviar notificaciones por correo electrónico
    public void NotificarPorEmail(string email, string mensaje)
    {
        _notificacionPorEmail.EstablecerEmailDestinatario(email);
        _notificacionPorEmail.Enviar(mensaje);
    }

    // Método para enviar notificaciones por SMS
    public void NotificarPorSms(string numeroTelefono, string mensaje)
    {
        _notificacionPorSms.EstablecerNumeroTelefonoDestinatario(numeroTelefono);
        _notificacionPorSms.Enviar(mensaje);
    }
}


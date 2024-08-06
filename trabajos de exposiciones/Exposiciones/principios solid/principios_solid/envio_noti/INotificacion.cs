// Interfaz general para todas las notificaciones
public interface INotificacion
{
    void Enviar(string mensaje);
}

// Interfaz para notificaciones por correo electrónico
public interface INotificacionPorEmail : INotificacion
{
    void EstablecerEmailDestinatario(string email);
}

// Interfaz para notificaciones por SMS
public interface INotificacionPorSms : INotificacion
{
    void EstablecerNumeroTelefonoDestinatario(string numeroTelefono);
}

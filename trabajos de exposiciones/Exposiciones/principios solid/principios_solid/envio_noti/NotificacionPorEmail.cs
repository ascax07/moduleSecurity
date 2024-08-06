// Implementación para enviar notificaciones por correo electrónico
public class NotificacionPorEmail : INotificacionPorEmail
{
    private string _emailDestinatario;

    public void EstablecerEmailDestinatario(string email)
    {
        _emailDestinatario = email;
    }

    public void Enviar(string mensaje)
    {
        // Aquí se implementaría la lógica para enviar un correo electrónico
        Console.WriteLine($"Enviando email a {_emailDestinatario}: {mensaje}");
    }
}

// Implementación para enviar notificaciones por SMS
public class NotificacionPorSms : INotificacionPorSms
{
    private string _numeroTelefonoDestinatario;

    public void EstablecerNumeroTelefonoDestinatario(string numeroTelefono)
    {
        _numeroTelefonoDestinatario = numeroTelefono;
    }

    public void Enviar(string mensaje)
    {
        // Aquí se implementaría la lógica para enviar un SMS
        Console.WriteLine($"Enviando SMS a {_numeroTelefonoDestinatario}: {mensaje}");
    }
}

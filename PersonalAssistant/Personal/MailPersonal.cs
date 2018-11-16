using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Net;
using System.Net.Mail;


namespace Personal
{
    public class MailPersonal
    {
        /*CONFIGURACIÓN SMTP:
         ---------------------------------------------------------
         * OUTLOOK -->
           servidor SMTP: smtp-mail.outlook.com
           puerto: 587   
         ---------------------------------------------------------
         * GMAIL -->         
           servidor SMTP: smtp.gmail.com
         * puerto: 465 (SSL); 587 (TLS)
         ---------------------------------------------------------
         * YAHOO! -->
           servidor SMTP: smtp.mail.yahoo.com
           puerto: 25 ó 265
        */
        //personal.assistant.v01@gmail.com  PersonalAssistant2018

        private string host = "smtp.gmail.com";
        private int puerto = 587;

        public void enviarCorreo(string usuario)
        {
            SmtpClient cliente;
            MailMessage mensaje;
            Encrypt desencripta;
            Usuario user;
            UsuariosPersonal usuarios;
            try
            {
                cliente = new SmtpClient(host, puerto);
                mensaje = new MailMessage();
                desencripta = new Encrypt();
                user = new Usuario();
                usuarios = new UsuariosPersonal();

                user = usuarios.llenarUsuario(usuario);
                user.Password = desencripta.DecryptKey(user.Password);

                mensaje.From = new MailAddress("personal.assistant.v01@gmail.com", "Personal Assistant");
                mensaje.Subject = "Recupero de contraseña";
                mensaje.To.Add(user.Mail);
                mensaje.Body = "Su contraseña es: " + user.Password;

                cliente.Credentials = new NetworkCredential("personal.assistant.v01@gmail.com", "PersonalAssistant2018");
                cliente.EnableSsl = true;
                cliente.Send(mensaje);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}

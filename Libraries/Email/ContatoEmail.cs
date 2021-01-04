using System.Net;
using System.Net.Mail;
using LojaVirtual.Models;

namespace LojaVirtual.Libraries.Email
{
    public class ContatoEmail
    {
        public static void EnviarContatoPorEmail(Contato contato)
        {

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);

            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("flaviosalgado2@gmail.com", "tec$$$16101990-");
            smtp.EnableSsl = true;

            //mengagem
            string corpoMsg = string.Format("<h2>Contato - Loja Virtual</h2>" +
            "<b>Nome: </b> {0} <br>" +
            "<b>E-mail: </b> {1} <br>" +
            "<b>Texto: </b> {2} <br>" +
            "<br> E-mail enviado automaticamente do site LojaVirtual.",
            contato.Nome,
            contato.Email,
            contato.Texto
            );

            MailMessage mensagem = new MailMessage();
            mensagem.From = new MailAddress("flaviosalgado2@gmail.com");
            mensagem.To.Add("flaviosalgado2@gmail.com");
            mensagem.Subject = "Contato - LojaVirtual - E-mail " + contato.Email;
            mensagem.Body = corpoMsg;
            mensagem.IsBodyHtml = true;

            smtp.Send(mensagem);

        }
    }
}
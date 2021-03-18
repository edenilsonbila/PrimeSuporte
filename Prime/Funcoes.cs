using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Mail;
using System.Windows.Forms;

namespace Prime
{
    class Funcoes
    {

        public static Boolean verificaArquivo(String diretorio)
        {
            Boolean existe = false;
            DirectoryInfo dri = new DirectoryInfo(diretorio);
            if (dri.Exists)
            {
                existe = true;
            }
            else
            {
                existe = false;
            }
            return existe;
        }

        public static Boolean enviarEmail()
        {
            Boolean retorno = false;

            //Define os dados do e-mail
            string nomeRemetente = "Seu Nome";
            string emailRemetente = "email@seudominio.com.br";
            string senha = "Sua senha de email";

            //Host da porta SMTP
            string SMTP = "smtp.dominio.com.br";

            string emailDestinatario = "email@destinatario.com.br";
            //string emailComCopia        = "email@comcopia.com.br";
            //string emailComCopiaOculta  = "email@comcopiaoculta.com.br";

            string assuntoMensagem = "Teste de envio de emails usando System.Net.Mail em C#";
            string conteudoMensagem = "Teste de envio de emails usando System.Net.Mail em C#";

            //Cria objeto com dados do e-mail.
            MailMessage objEmail = new MailMessage();

            //Define o Campo From e ReplyTo do e-mail.
            objEmail.From = new System.Net.Mail.MailAddress(nomeRemetente + "<" + emailRemetente + ">");

            //Define os destinatários do e-mail.
            objEmail.To.Add(emailDestinatario);

            //Enviar cópia para.
            //objEmail.CC.Add(emailComCopia);

            //Enviar cópia oculta para.
            //objEmail.Bcc.Add(emailComCopiaOculta);

            //Define a prioridade do e-mail.
            objEmail.Priority = System.Net.Mail.MailPriority.Normal;

            //Define o formato do e-mail HTML (caso não queira HTML alocar valor false)
            objEmail.IsBodyHtml = true;

            //Define título do e-mail.
            objEmail.Subject = assuntoMensagem;

            //Define o corpo do e-mail.
            objEmail.Body = conteudoMensagem;


            //Para evitar problemas de caracteres "estranhos", configuramos o charset para "ISO-8859-1"
            objEmail.SubjectEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1");
            objEmail.BodyEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1");


            // Caso queira enviar um arquivo anexo
            //Caminho do arquivo a ser enviado como anexo
            //string arquivo = Server.MapPath("arquivo.jpg");

            // Ou especifique o caminho manualmente
            //string arquivo = @"e:\home\LoginFTP\Web\arquivo.jpg";

            // Cria o anexo para o e-mail
            //Attachment anexo = new Attachment(arquivo, System.Net.Mime.MediaTypeNames.Application.Octet);

            // Anexa o arquivo a mensagem
            //objEmail.Attachments.Add(anexo);

            //Cria objeto com os dados do SMTP
            System.Net.Mail.SmtpClient objSmtp = new System.Net.Mail.SmtpClient();

            //Alocamos o endereço do host para enviar os e-mails  
            objSmtp.Credentials = new System.Net.NetworkCredential(emailRemetente, senha);
            objSmtp.Host = SMTP;
            objSmtp.Port = 587;
            //Caso utilize conta de email do exchange da locaweb deve habilitar o SSL
            //objEmail.EnableSsl = true;

            //Enviamos o e-mail através do método .send()
            try
            {
                objSmtp.Send(objEmail);
                msgInfo("E-mail enviado com sucesso!");
            }
            catch (Exception ex)
            {
                msgErro("Ocorreram problemas no envio do e-mail. Erro = " + ex.Message);
            }
            finally
            {
                //excluímos o objeto de e-mail da memória
                objEmail.Dispose();
                //anexo.Dispose();
            }

            return retorno;
        }


        public static void msgInfo(String mensagem)
        {
            MessageBox.Show(mensagem, "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void msgAlerta(String mensagem)
        {
            MessageBox.Show(mensagem, "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static void msgErro(String mensagem)
        {
            MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult msgQuestion(String mensagem)
        {
           DialogResult resultado = MessageBox.Show(mensagem, "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
           return resultado;
        }

        public static bool ValidarEmail(string email)
        {
            bool validEmail = false;
            int indexArr = email.IndexOf('@');
            if (indexArr > 0)
            {
                int indexDot = email.IndexOf('.', indexArr);
                if (indexDot - 1 > indexArr)
                {
                    if (indexDot + 1 < email.Length)
                    {
                        string indexDot2 = email.Substring(indexDot + 1, 1);
                        if (indexDot2 != ".")
                        {
                            validEmail = true;
                        }
                    }
                }
            }
            return validEmail;
        }


        public static void gravaLog(String erro)
        {
            //Verifica se existe a pasta LOGS
            if (!Directory.Exists(Application.StartupPath.ToString() + @"\logs"))
            {
                Directory.CreateDirectory(Application.StartupPath.ToString() + @"\logs");

            }

            if (!File.Exists(Application.StartupPath.ToString() + @"\logs\" + DateTime.Now.ToString("ddMMyyyy") + ".txt"))
            {
                StreamWriter sw = new StreamWriter(Application.StartupPath.ToString() + @"\logs\" + DateTime.Now.ToString("ddMMyyyy") + ".txt");
                sw.AutoFlush = true;
                sw.WriteLine(erro);
                sw.Flush();
                sw.Close();
            }
            else {
  
                
            
            }


        }


    }
}

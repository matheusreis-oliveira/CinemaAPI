using MimeKit;
using System.Collections.Generic;
using System.Linq;

namespace UsuariosApi.Models
{
    public class MensagemModel
    {
        public List<MailboxAddress> Destinatario { get; set; }
        public string Assunto { get; set; }
        public string Conteudo { get; set; }

        public MensagemModel(IEnumerable<string> destinatario, string assunto,
            int usuarioId, string codigo)
        {
            Destinatario = new List<MailboxAddress>();
            Destinatario.AddRange(destinatario.Select(d => new MailboxAddress(d)));
            Assunto = assunto;
            Conteudo = $"http://localhost:6000/ativa?UsuarioId={usuarioId}&CodigoDeAtivacao={codigo}";
        }
    }
}

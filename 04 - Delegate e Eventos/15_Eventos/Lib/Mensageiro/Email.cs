using System;

namespace Eventos.Lib.Mensageiro
{
	public class Email
	{
		public void EnviarMensagem(object sender, VideoEventArgs args)
		{
			Console.WriteLine("E-mail enviado para o vídeo: " + args.Video.Nome);
		}
	}
}

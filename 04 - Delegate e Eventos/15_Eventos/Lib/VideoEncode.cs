using System;
using System.Threading;

namespace Eventos.Lib
{
	public class VideoEncode
	{
		// public delegate void VideoEncodeHandler(Video video);
		// public event VideoEncodeHandler Encoded;

		public event EventHandler<VideoEventArgs> Encoded;

		public void Encode(Video video)
		{
			Console.WriteLine("Convertendo o vídeo...");
			Thread.Sleep(2000);
			Console.WriteLine("Vídeo convertido!");

			Encoded(this, new VideoEventArgs() { Video = video });
		}
	}

	public class VideoEventArgs : EventArgs{
		public Video Video { get; set; }
	}
}

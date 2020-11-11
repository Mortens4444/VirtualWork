using System.Speech.Synthesis;

namespace VirtualWork.Service.Utils
{
	public class Speech
	{
		private readonly SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();

		public void Say(string message)
		{
			speechSynthesizer.SpeakAsync(message);
		}
	}
}

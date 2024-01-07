
using IBM.Watson.SpeechToText.v1;
using IBM.Watson.SpeechToText.v1.Model;

namespace IBM {
    public class SpeechToText{

        private SpeechToTextService _service;
        private string _pathAudio;

        public SpeechToText(AuthenticatorIBM authenticator, string url, string pathAudio)
        {
            _service = new SpeechToTextService(authenticator.GetAuthenticator());
            _pathAudio = pathAudio;
            _service.SetServiceUrl(url);
        }

        public void transcription()
        {
            var audioStream = new MemoryStream();

            using (var fileStream = File.OpenRead(_pathAudio))
            {
                fileStream.CopyTo(audioStream);
                audioStream.Seek(0, SeekOrigin.Begin);
            }

            var result = _service.Recognize(
                audio: audioStream,
                contentType: "audio/wav",
                model: "pt-BR_NarrowbandModel"
            );

            var speechRecognitionResults = new List<SpeechRecognitionResult>();

            if(result != null )
            {
                foreach (var item in result.Result.Results)
                {
                    foreach (var alternative in item.Alternatives)
                    {
                        Console.WriteLine(alternative.Transcript);
                    }
                }
            }
     
        }
    }
}
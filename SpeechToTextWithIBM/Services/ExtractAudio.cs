using System.Diagnostics;

namespace Services
{
    public class ExtractAudio{

        private string _pathLocal;
        private string _audioName;
        private string _nameVideo;
        private Process process;
        
        public ExtractAudio(string path, string audioName, string nameVideo )
        {
            _pathLocal = path;
            _audioName = audioName;
            _nameVideo = nameVideo;
            process = new Process();
        }

        public void ProcessAudioExtract()
        {
            process.StartInfo.FileName = @"ffmpeg";
            process.StartInfo.Arguments = $"-i \"{this._nameVideo}\" -vn -acodec pcm_s16le -ar 44100 -ac 2 \"{this._audioName}\"";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            process.WaitForExit();
        }
    }
}
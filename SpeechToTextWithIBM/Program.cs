using IBM;
using Microsoft.Extensions.Configuration;

// See https://aka.ms/new-console-template for more information
    var builder = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("AppSettings.json", false, reloadOnChange: true)
    .Build();

    string key = builder["AppSettings:key"];
    string url = builder["AppSettings:url_speech_to_text_ibm"];
    var teste = Directory.GetFiles("C:\\COLOCA O CAMINHO DA PASTA COM OS AUDIOS AQUI");
    var authenticator = new AuthenticatorIBM(key);
    var speech = new SpeechToText(authenticator,url, teste[0]);

    speech.transcription();
            //var myFirstClass = config.GetSection("MyFirstClass").Get<MyFirstClass>();
            //var mySecondClass = config.GetSection("MySecondClass").Get:\Users\vitor\OneDrive\Documentos\work-project\SpeechToTextWithIBM\SpeechToTextWithIBM\bin\Debug\net6.0\AppSettings<MySecondClass>();
            //Console.WriteLine($"The answer is always {myFirstClass.Option2}");
using Microsoft.Extensions.Configuration;

// See https://aka.ms/new-console-template for more information
    var builder = new ConfigurationBuilder();

            IConfiguration config = builder.Build();

            //var myFirstClass = config.GetSection("MyFirstClass").Get<MyFirstClass>();
            //var mySecondClass = config.GetSection("MySecondClass").Get<MySecondClass>();
            //Console.WriteLine($"The answer is always {myFirstClass.Option2}");
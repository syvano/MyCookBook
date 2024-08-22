using CookBook.UI;
using DataAccessLayer.Contracts;
using DataAccessLayer.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using System.ServiceProcess;

namespace CookBook
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           
            ApplicationConfiguration.Initialize();

            //create an instance of ServiceCollection
            //and call it services and store our configurations in it
            //from our ConfigureServices function
            ServiceCollection services = ConfigureServices();

            //create instance of ServiceProvider 
            //and call it serviceProvider
            //use it to store our services.BuildServiceProvider function
            ServiceProvider serviceProvider = services.BuildServiceProvider();

            //now we create our form using serviceProvider
            //and tell it to get all of the required services for this IngredientsForm
            //store that inside startForm
            var startForm = serviceProvider.GetRequiredService<IngredientsForm>();

            //and then run the startForm
            Application.Run(startForm);



            
        }

        //ConfigureServices function for our DependencyInjection
        //which will configure everything that we need in order for DI to work
         static ServiceCollection ConfigureServices()
        {
            //create services which for now will be empty
            ServiceCollection services = new ServiceCollection();

            //provide and configure all of the dependencies
            //please read from our config file
            {
                //otherwise if the config file says anything else besides txt
                //please create our default sql repository
                services.AddTransient<IIngredientsRepository>(_ => new IngredientsRepository());
            }

            //all of the forms that we want to register for DI
            //forms that need DI that need something injected in them
            services.AddTransient<IngredientsForm>();

            //return services
            return services;


        }

    }
}
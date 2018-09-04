using Autofac;
using System.Reflection;
using Traveller.Commands.Contracts;
using Traveller.Commands.Creating;
using Traveller.Core;
using Traveller.Core.Database;
using Traveller.Core.Factories;
using Traveller.Core.Providers;
using System.Diagnostics;
using System;

namespace Traveller
{
    public class Startup
    {
        public static void Main(string[] args)
        {
            var builder = new ContainerBuilder();           

            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly()).AsImplementedInterfaces();

            builder.RegisterType<TravellerFactory>().As<ITravellerFactory>().SingleInstance();
            builder.RegisterType<CommandParser>().As<ICommandParser>();
            builder.RegisterType<Data>().As<IData>().SingleInstance();

            builder.RegisterType<CreateAirplaneCommand>().Named<ICommand>("createairplane");
            builder.RegisterType<CreateBusCommand>().Named<ICommand>("createbus");
            builder.RegisterType<CreateJourneyCommand>().Named<ICommand>("createjourney");
            builder.RegisterType<CreateTicketCommand>().Named<ICommand>("createticket");
            builder.RegisterType<CreateTrainCommand>().Named<ICommand>("createtrain");
            builder.RegisterType<ListJourneysCommand>().Named<ICommand>("listjourneys");
            builder.RegisterType<ListTicketsCommand>().Named<ICommand>("listtickets");
            builder.RegisterType<ListVehiclesCommand>().Named<ICommand>("listvehicles");

            var container = builder.Build();
            Console.WriteLine("The Engine is starting...");

            var engine = container.Resolve<IEngine>();
            var watch = Stopwatch.StartNew();

            engine.Start();
            watch.Stop();
            Console.WriteLine("The Engine worked for {0} milliseconds.", watch.ElapsedMilliseconds);
        }
    }
}

using Autofac;
using FurnitureManufacturer.Commands;
using FurnitureManufacturer.Commands.Contracts;
using FurnitureManufacturer.Data1;
using FurnitureManufacturer.Engine;
using FurnitureManufacturer.Engine.Factories;
using FurnitureManufacturer.Interfaces.Engine;

namespace FurnitureManufacturer
{
    public class FurnitureProgram
    {
        public static void Main()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<CompanyFactory>().As<iCommandFactory>();
            builder.RegisterType<FurnitureFactory>().As<IFurnitureFactory>();
            builder.RegisterType<CommandFactory>().As<ICommandFactory>();
            builder.RegisterType<ConsoleRenderer>().As<IRenderer>();
            builder.RegisterType<FurnitureManufacturerEngine>().As<IFurnitureManufacturerEngine>();
            builder.RegisterType<Data>().As<IData>().SingleInstance();

            builder.RegisterType<CreateCompanyCommand>().Named<ICreatCommand>(EngineConstants.CreateCompanyCommand.ToLower());
            builder.RegisterType<AddFurnitureToCompanyCommand>().Named<ICreatCommand>(EngineConstants.AddFurnitureToCompanyCommand.ToLower());


            var container = builder.Build();

            var engine = container.Resolve<IFurnitureManufacturerEngine>();

            engine.Start();            
        }
    }
}

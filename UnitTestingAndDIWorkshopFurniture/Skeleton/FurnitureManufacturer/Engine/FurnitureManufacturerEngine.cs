using FurnitureManufacturer.Data1;
using FurnitureManufacturer.Engine.Factories;
using FurnitureManufacturer.Interfaces;
using FurnitureManufacturer.Interfaces.Engine;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FurnitureManufacturer.Engine
{
    public sealed class FurnitureManufacturerEngine : IFurnitureManufacturerEngine
    {      
        private readonly iCommandFactory commandFactory;      
        private readonly IRenderer renderer;

        public FurnitureManufacturerEngine(iCommandFactory commandFactory, IRenderer renderer)
        {
            this.commandFactory = commandFactory;            
            this.renderer = renderer;
            
        }       

        public void Start()
        {
            var commandResults = new List<string>();

            try
            {
                var commands = this.renderer.Input();
                commandResults = this.ProcessCommands(commands).ToList();
            }
            catch (Exception ex)
            {
                commandResults.Add(ex.Message);
            }

            this.RenderCommandResults(commandResults);

        }        

        private IEnumerable<string> ProcessCommand(IEnumerable<string> commands)
        {
            foreach (string commandLine in commands)
            {
                var splittedCommand = commandLine.Split();
                var commandName = splittedCommand[0];
                var commandParams = splittedCommand.Skip(1).ToList();

                var factory = this.commandFactory.

            }
        }      

        private void RenderCommandResults(IEnumerable<string> output)
        {
            this.renderer.Output(output);
        }       
    }
}

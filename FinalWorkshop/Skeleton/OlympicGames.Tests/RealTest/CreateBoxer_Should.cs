using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace OlympicGames.Tests.RealTest
{
    [TestClass]
    class CreateBoxer_Should
    {
        //string firstName;
        //string lastName;
        //string country;
        //string category;
        //int wins;
        //int losses;

        [TestMethod]
        private void Execute()
        {
            List<string> parameters = new List<string>
                            {
                                "Vladimir",
                                "Klichko",
                                "Ukrain",
                                "Heavyweight",
                                "40",
                                "2"
                            };
            var firstName = parameters[0];
            var lastName = parameters[1];
            var country = parameters[2];
            var category = parameters[3];
            var wins = parameters[4];
            var losses = parameters[5];

            



        }



    }
}

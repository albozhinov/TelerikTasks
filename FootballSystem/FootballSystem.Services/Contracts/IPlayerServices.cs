using FootballSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FootballSystem.Services.Contracts
{
    public interface IPlayerServices
    {
        IEnumerable<Player> GetAllPlayers();

        Player GetPlayerById(int Id);

        Player CreatePlayer(string firstName, string lastName);
    }
}

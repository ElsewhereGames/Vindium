using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elsewhere.Vindinium.Model.HTTP.Contract
{
    public static class DataContractExtensions
    {

        internal static HTTPGameModel ToModel(this Game contract)
        {
            HTTPGameModel model = new HTTPGameModel()
            {
                Id = contract.id,
                TotalTurns = contract.maxTurns,
                Turn = contract.turn,
                Finished = contract.finished,
                Board = contract.board.ToModel()
            };

            foreach (Hero hero in contract.heroes)
            {
                model.AddHero(hero.ToModel());
            }

            return model;
        }

        internal static BoardModel ToModel(this Board contract)
        {
            return new BoardModel()
            {
                Size = contract.size,
                Tiles = contract.tiles
            };
        }

        internal static HeroModel ToModel(this Hero contract)
        {
            return new HeroModel()
            {
                Id = contract.id,
                Name = contract.name,
                Rating = contract.elo,
                Life = contract.life,
                Gold = contract.gold,
                MineCount = contract.mineCount,
                Crashed = contract.crashed,
                StartLocation = contract.spawnPos.ToModel(),
                CurrentLocation = contract.pos.ToModel()
            };
        }

        internal static LocationModel ToModel(this Pos contract)
        {
            return new LocationModel()
            {
                X = contract.x,
                Y = contract.y
            };
        }

    }
}

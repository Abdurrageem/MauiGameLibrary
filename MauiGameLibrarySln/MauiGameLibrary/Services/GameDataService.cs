using MauiGameLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MauiGameLibrary.Services
{
    public class GameDataService
    {
        private List<GameInformation> _gameInformation = new List<GameInformation>();

        public List<GameInformation> GetAllGameInformation()
        {
            return _gameInformation;
        }
        public void CreateFakeGameInformation()
        {
            _gameInformation.Add(new GameInformation
            {
                Id = Guid.NewGuid().ToString(),
                Title = "The Legend of Zelda: Breath of the Wild",
                GameType = "Action-Adventure",
                CompanyName = "Nintendo",
                Genre = "Adventure",
                AgeRestriction = "E10+",
                Multiplayer = false,
                Description = "An open-world action-adventure game set in the kingdom of Hyrule.",
                Image = "zelda.jpg",
                YearPublished = new DateTime(2017, 3, 3)
            });
            _gameInformation.Add(new GameInformation
            {
                Id = Guid.NewGuid().ToString(),
                Title = "Super Mario Odyssey",
                GameType = "Platformer",
                CompanyName = "Nintendo",
                Genre = "Platformer",
                AgeRestriction = "E",
                Multiplayer = false,
                Description = "A 3D platformer where Mario travels across various kingdoms to rescue Princess Peach.",
                Image = "mario.jpg",
                YearPublished = new DateTime(2017, 10, 27)
            });
        }



        public void UpdateGameInformation(GameInformation gameInformation)
        {   //For updating the list
            if (!string.IsNullOrEmpty(gameInformation.Id))
            {
                var uniqueGame = GetGameInformationById(gameInformation.Id);

                int position = _gameInformation.IndexOf(uniqueGame);

                _gameInformation[position] = gameInformation;
            }
            else
            {//For inserting into the list
                string Id = Guid.NewGuid().ToString();
                gameInformation.Id = Id;
                _gameInformation.Add(gameInformation);
            }
        }
        public GameInformation GetGameInformationById(string Id)
        {   //=> is Lambda(fancy "if" statement)
            var uniqueGame = _gameInformation.Where(gameid => gameid.Id == Id).FirstOrDefault();
                return uniqueGame;
        }
        public List<GameInformation> GetGameInformationByTitle(string Title)
        {
         return  _gameInformation.Where(gametitle => gametitle.Title == Title).ToList();

        }

    }
}

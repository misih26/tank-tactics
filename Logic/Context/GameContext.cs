using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Tank_Tactics.Logic.Factory;
using Tank_Tactics.Models.Enums;
using Tank_Tactics.Models.Maps;
using Tank_Tactics.Models.Players;

namespace Tank_Tactics.Logic.Context
{
    public class GameContext: INotifyPropertyChanged
    {
        public Map Map { get; set; }
        PlayerFactory playerFactory = new PlayerFactory(new TankFactory());
        public GameContext() 
        {
            Player[] players = new Player[2];
            playerFactory.PlayerName = "John";
            playerFactory.tank = playerFactory.TankFactory.BuildTank(Tanks.Tiger);
            players[0] = playerFactory.BuildPlayer();

            playerFactory.PlayerName = "Peter";
            playerFactory.tank = playerFactory.TankFactory.BuildTank(Tanks.Leopard);
            players[1] = playerFactory.BuildPlayer();
            
            this.Map = new Map("The dust 2", players, "", new List<MapElement>());
        }

        public string Player1TankPositionTop
        {
            get { return Map.Players[0].ChosenTank.PositionTop.ToString(); }
            set
            {
                Map.Players[0].ChosenTank.PositionTop = double.Parse(value);
                OnPropertyChanged();
            }
        }

        public double Player1TankPositionLeft
        {
            get { return Map.Players[0].ChosenTank.PositionLeft; }
            set
            {
                Map.Players[0].ChosenTank.PositionLeft = value;
                OnPropertyChanged();
            }
        }

        public string Player1TankImage
        {
            get { return Map.Players[0].ChosenTank.Image; }
           
        }

        public string Player1TankDirection
        {
            get { return Map.Players[0].ChosenTank.Direction.ToString(); }
            set
            {
                if (Enum.TryParse(value, out Direction newDirection))
                {
                    Map.Players[0].ChosenTank.Direction = newDirection;
                    OnPropertyChanged();
                }
            }
        }

        public double Player1TankShield
        {
            get { return Map.Players[0].ChosenTank.Shield; }
            set
            {
                Map.Players[0].ChosenTank.Shield = value;
                OnPropertyChanged();
            }
        }

        public string Player1Name
        {
            get { return Map.Players[0].Name; }
        }
        public int Player1TankWidth
        {
            get { return Map.Players[0].ChosenTank.Width; }
        }
        public int Player1TankHeight
        {
            get { return Map.Players[0].ChosenTank.Height; }
        }

        public double Player2TankPositionTop
        {
            get { return Map.Players[1].ChosenTank.PositionTop; }
            set
            {
                Map.Players[1].ChosenTank.PositionTop = value;
                OnPropertyChanged();
            }
        }

        public double Player2TankPositionLeft
        {
            get { return Map.Players[1].ChosenTank.PositionLeft; }
            set
            {
                Map.Players[1].ChosenTank.PositionLeft = value;
                OnPropertyChanged();
            }
        }

        public string Player2TankImage
        {
            get { return Map.Players[1].ChosenTank.Image; }
        }

        public string Player2TankDirection
        {
            get { return Map.Players[1].ChosenTank.Direction.ToString(); }
            set
            {
                if (Enum.TryParse(value, out Direction newDirection))
                {
                    Map.Players[1].ChosenTank.Direction = newDirection;
                    OnPropertyChanged();
                }
            }
        }

        public double Player2TankShield
        {
            get { return Map.Players[1].ChosenTank.Shield; }
            set
            {
                Map.Players[1].ChosenTank.Shield = value;
                OnPropertyChanged();
            }
        }

        public string Player2Name
        {
            get { return Map.Players[1].Name; }
        }
        public int Player2TankWidth
        {
            get { return Map.Players[1].ChosenTank.Width; }
        }
        public int Player2TankHeight
        {
            get { return Map.Players[1].ChosenTank.Height; }
        }

        public string MapBackground
        {
            get { return Map.Background; }
        }


        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

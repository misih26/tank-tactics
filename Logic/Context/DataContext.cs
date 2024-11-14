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
    public class DataContext: INotifyPropertyChanged
    {
        Map map;
        PlayerFactory playerFactory = new PlayerFactory(new TankFactory());
        public DataContext() 
        {
            Player[] players = new Player[2];
            playerFactory.PlayerName = "John";
            playerFactory.tank = playerFactory.TankFactory.BuildTank(Tanks.Tiger);
            players[0] = playerFactory.BuildPlayer();

            playerFactory.PlayerName = "Peter";
            playerFactory.tank = playerFactory.TankFactory.BuildTank(Tanks.Leopard);
            players[1] = playerFactory.BuildPlayer();
            
            Map map = new Map("The dust 2", players, "", new List<MapElement>());
        }

        public double Player1TankPositionTop 
        {
            get 
            { 
            return map.Players[0].ChosenTank.PositionTop;
            }
            set 
            {
                map.Players[0].ChosenTank.PositionTop = value; 
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

using System;
using System.Collections.Generic;
using FootballTeamApp.Funtionality;
using FootballTeamApp.Model;
using FootballTeamApp.Operations;

namespace FootballTeamApp.Funtionality
{
    public interface FuntionalityInterface
    {
        List<PlayerVar> CreatePlayer(PlayerVar plr);
        List<PlayerVar> GetPlayerList();
        //List<PlayerVar> RemovePlayer(int a);
        void RemovePlayer(int a);
        void UpdatePlayer(int a);
        void FindPlayer(int a);



    }
}

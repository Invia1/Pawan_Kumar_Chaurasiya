using System;
using System.Collections.Generic;
using FootballTeamApp.Model;
using FootballTeamApp.Operations;
using FootballTeamApp.Funtionality;


namespace FootballTeamApp.PlayersNew
{
    class Newplayer
    {
 
            public static void Main()
            {

            Console.WriteLine("List after adding the Player Name\n");


            //  Adding the data unsing class 

                //PlayerVar obj = new PlayerVar();
                //obj.Player_No = 1;
                //obj.Player_name = "Deepa";
                //obj.Players_Age = 21;
                //obj.Player_Address = "Spain ";
                //obj.Player_CarrstartYear = 2020;
                //Football es = new Football();                     //creating object with the help of class
                //es.CreatePlayer(obj);





                 PlayerVar obj = new PlayerVar();
                 obj.Player_No = 1;
                 obj.Player_name = "Ayush";
                 obj.Players_Age = 21;
                 obj.Player_Address = "Kerla";
                 obj.Player_CarrstartYear = 2020;
                 FuntionalityInterface es = new Football();             //creating object with the help of interface
                 es.CreatePlayer(obj);


                PlayerVar obj1 = new PlayerVar();
                obj1.Player_No = 2;
                obj1.Player_name = "Sanky";
                obj1.Players_Age = 21;
                obj1.Player_Address = "Mumbai";
                obj1.Player_CarrstartYear = 2019;
                es.CreatePlayer(obj1);

                PlayerVar obj2 = new PlayerVar();
                obj2.Player_No = 3;
                obj2.Player_name = "Akash";
                obj2.Players_Age = 20;
                obj2.Player_Address = "Assam";
                obj2.Player_CarrstartYear = 2022;
                es.CreatePlayer(obj2);

                PlayerVar obj3 = new PlayerVar();
                obj3.Player_No = 4;
                obj3.Player_name = "Umesh";
                obj3.Players_Age = 28;
                obj3.Player_Address = "Delhi";
                obj3.Player_CarrstartYear = 2019;
                es.CreatePlayer(obj3);


                List<PlayerVar> objList = es.GetPlayerList();
                    foreach (var data in objList)
                        {
                            Console.WriteLine(data.Player_No + " " + data.Player_name + " " + data.Players_Age + " " + data.Player_Address + " " +data.Player_CarrstartYear );
                        }
                Console.WriteLine();


                es.UpdatePlayer(4);
                Console.WriteLine("Player name after Updation\n");
                    foreach (var data in objList)
                        {
                            Console.WriteLine(data.Player_No + " " + data.Player_name + " " + data.Players_Age + " " + data.Player_Address + " " + data.Player_CarrstartYear );
                        }

                es.RemovePlayer(3);
                Console.WriteLine("Player Name after deletion with the help of Serial No.\n");
                    foreach (var data in objList)
                        {
                            Console.WriteLine(data.Player_No + " " + data.Player_name + " " + data.Players_Age + " " + data.Player_Address + " " +data.Player_CarrstartYear );
                        }

                es.FindPlayer(2);
                Console.WriteLine("Player Name is Finding with the help of Serial No.\n");
                    foreach (var data in objList)
                        {
                            Console.WriteLine(data.Player_No + " " + data.Player_name + " " + data.Players_Age + " " + data.Player_Address + " " + data.Player_CarrstartYear);
                         }

                Console.ReadLine();
            }      
    }
}


using System;
using FriendApp.Models;
using System.Collections.Generic;

namespace FriendApp.Type
{ public class TypeFriend
    { List<Friend> objList = new List<Friend>(); 
        public List<Friend> CreateFriend(Friend frd)
        { 
            objList.Add(frd);
            return objList;
        }

        public void RemoveFriend(int a)
        {
            int b = 0;
            
            foreach (var item in objList)
            {

                if (item.Sno==a)
                {
                    objList.Remove(item);
                    b++;
                    
                    Console.Write("\nThe Element is deleted from the list and ");
                    
                    break;
                }
               

            }
             if(b==0)
            {
               
                Console.WriteLine("Entered Element is not found");
                Console.WriteLine();
            }


        }

        public void UpdateFriend(int a)
        {
            int b = 0;

            foreach (var item in objList)
            {

                if (item.Sno == a)
                {
                    item.Fname = "Sandy";
                    b++;
                    Console.Write("\nThe Element has been updated in the list and");
                    break;
                }


            }
            if (b == 0)
            {

                Console.WriteLine("Entered Element is not found");
                Console.WriteLine();
            }


        }


        public List<Friend> GetFriendList() 
        { 
            return objList;
        }

      
    } 
}
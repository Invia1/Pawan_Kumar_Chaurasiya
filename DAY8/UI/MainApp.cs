using System;
using System.Collections.Generic;
using FriendApp.Models;
using FriendApp.Type;

namespace FriendApp.UI 
{ 
    public class MainApp 
    {
                public static void Main() 
        {

            Console.WriteLine("After adding the element\n");
            
            Friend obj = new Friend();
            obj.Sno = 1;
            obj.Fname = "Deepa";
            obj.Fage = 21;
            obj.Faddress = "Spain ";
            obj.Ftype = "College Friend";
            TypeFriend es = new TypeFriend();
            es.CreateFriend(obj);

            Friend obj1 = new Friend();
            obj1.Sno = 2;
            obj1.Fname = "Pawan";
            obj1.Fage = 21;
            obj1.Faddress = " Pune  ";
            obj1.Ftype = "School Friend";
            es.CreateFriend(obj1);

            Friend obj2 = new Friend();
            obj2.Sno = 3;
            obj2.Fname = "Akash";
            obj2.Fage = 20;
            obj2.Faddress = "India ";
            obj2.Ftype = "College Friend";
            es.CreateFriend(obj2);

            Friend obj3 = new Friend();
            obj3.Sno = 4;
            obj3.Fname = "Umesh";
            obj3.Fage = 28;
            obj3.Faddress = "Europe";
            obj3.Ftype = "Best Friend";
            es.CreateFriend(obj3);

            
            List<Friend> objList = es.GetFriendList(); 
            foreach (var data in objList)
            {
                Console.WriteLine(data.Fname + " " + data.Fage + " " + data.Faddress+" "+data.Ftype);
                
            }
            Console.WriteLine();


            es.UpdateFriend(4);
            Console.WriteLine("Elements after Updation\n");


            foreach (var data in objList)
            {
                Console.WriteLine(data.Fname + " " + data.Fage + " " + data.Faddress + " " + data.Ftype);

            }

            es.RemoveFriend(3);
            Console.WriteLine("Elements after deletion with the help of Serial No.\n");
            foreach (var data in objList)
            {
                Console.WriteLine(data.Fname + " " + data.Fage + " " + data.Faddress + " " + data.Ftype);

            }

            Console.ReadLine();
        }
    }
}
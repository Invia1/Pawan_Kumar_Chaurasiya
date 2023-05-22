using System;

namespace GetSet
{
    class Pvt
    {
        int id;
        string name;
        public string pname
        {
            get
            {
                return name; 
            }
            set
            {
                name = value;  
            }
        }
        public int pid
        {
            get
            {
                return id; 
            
            }
            set 
            {
                id = value;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Pvt obj = new Pvt();
            obj.pid = 23;
            Console.WriteLine(obj.pid);

            Pvt obj1 = new Pvt();
            obj1.pname = "subodh";
            Console.WriteLine(obj1.pname);
            Console.ReadLine();            

        }
    }
}

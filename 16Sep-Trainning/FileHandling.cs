using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _16Sep_Trainning
{
    internal class FileHandling
    {
        public static void Execute()
        {
            //Console.WriteLine("Hello");
            //Console.ReadLine();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            path = path + "\\abc.txt";
            Console.WriteLine("how many user want to add");
            File.WriteAllText(path, "");
            // int value = Custom.isIntegerOrNot();
            int value = Convert.ToInt32(Console.ReadLine());
            List<User> list = new List<User>();
            for (int i = 0; i < value; i++)
            {
                Console.WriteLine("enter the name");
                String name = Console.ReadLine();
                File.AppendAllText(path, name);
                Console.WriteLine("enter id");
                int id = int.Parse(Console.ReadLine());
                File.AppendAllText(path, "=" + id + "\r\n");
            }
            string[] line = File.ReadAllLines(path);
            Console.WriteLine("name       id");
            Console.WriteLine("===================");
            foreach (string x in line)
            {
                string[] arr = x.Split('=');
                list.Add(new User(arr[1], int.Parse(arr[0])));
                //list.Add(new User() { name=Console.ReadLine(), id=Console.ReadLine() });
            }

            foreach (User user in list)
            {
                Console.WriteLine(user);
            }
        }
    }
}

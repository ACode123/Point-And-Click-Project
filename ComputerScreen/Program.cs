using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization.Formatters.Soap;
using System.Diagnostics;
using HintsDLLproj;
namespace ComputerScreen
{
    internal class Program
    {
        //this console app represents the computer accessed in the game 
        static void Main(string[] args)
        {
            
            string password;
            Hints H = new Hints();
            H.hint = "You caNnot eScapE";
            //serialized all the hints 
            Console.WriteLine("Please enter the password");
            password = Console.ReadLine();
            if(password=="oldjacob" || password=="OldJacob")
            {
                #region binary hint
                Console.WriteLine("Correct password was entered, here is a hint to get the door code");
                FileStream fileStream = new FileStream(@"C:\Files\binaryProjectt.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fileStream, H);
                fileStream.Close();
                //Process.Start(@"C:\Files\jsonProject.txt");
                string[] texts = File.ReadAllLines(@"C:\Files\binaryProjectt.txt");
                foreach (string line in texts)
                {
                    Console.WriteLine("\t" + line);
                }
                #endregion
                
               


                Console.WriteLine("you will need to find a cipher decoder in order to " +
                    "crack the code ");

                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("Incorrect Password");
            }
            Console.ReadLine();

        }
        
    }
}

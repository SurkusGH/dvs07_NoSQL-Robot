using dvs07_lecture_NoSQL_Robot.DataTypes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dvs07_lecture_NoSQL_Robot.Functions
{
    // Sukurkite kitą servisą, kuris:
    // (2) Galės išsaugoti robotą į mongodb duomenų bazę.
    public class WriterToDb
    {
        public static void AddRobotToDb(Robot robot)
        {
            // (1) pridedinės naujus knygos įrašus
            Console.WriteLine("Adding Book and Pages!!!");
            MongoClient client = new MongoClient("mongodb+srv://Vytautas:g4X9cfNafH5gbht@minimongodb." +
                                                 "8nxkf.mongodb.net/myFirstDatabase?retryWrites=true&w=majority");
            var collection = client.GetDatabase("Robots").GetCollection<Robot>("Robot");

            collection.InsertOne(robot);
        }
    }
}

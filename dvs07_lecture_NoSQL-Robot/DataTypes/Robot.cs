using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dvs07_lecture_NoSQL_Robot.DataTypes
{
    #region Assignment
    // Sukurkite Robot modelį, su properties:
    // (A) Id
    // (B) List<Arm>:
    //      Material
    //      NumberOfJoints
    //      NumberOfFingers
    // (C) List<Leg>:
    //      Material
    //      NumberOfJoints
    //      SizeOfFoot
    // (D) Torso
    //      ChestMeasurements
    //      WaistMeasurements
    // (E) Head:
    //      Enum - HeadType
    #endregion
    public class Robot
    {
        public ObjectId Id { get; set; }
        public List<Arm> Arm { get; set; }
        public List<Leg> Leg { get; set; }
        public Torso Torso { get; set; }
        public Head Head { get; set; }

        public Robot(List<Arm> arm = null, List<Leg> leg = null, Torso torso = null, Head head = null)
        {
            Id = ObjectId.GenerateNewId();
            Arm = new List<Arm>();
            Leg = new List<Leg>();
            Torso = torso;
            Head = head;
        }

        public void Print()
        {
            Console.WriteLine($"\nID: {Id}");
            Console.WriteLine("\n[ArmData]");
            Console.WriteLine($"Material -> {Arm[0].Material}");
            Console.WriteLine($"NumberOfJoints -> {Arm[0].NumberOfJoints}");
            Console.WriteLine($"NumberOfFingers -> {Arm[0].NumberOfFingers}");
            Console.WriteLine("\n[LegData]");
            Console.WriteLine($"Material -> {Leg[0].Material}");
            Console.WriteLine($"NumberOfJoints -> {Leg[0].NumberOfJoints}");
            Console.WriteLine($"SizeOfFoot -> {Leg[0].SizeOfFoot}");
            Console.WriteLine("\n[TorsoData]");
            Console.WriteLine(Torso.ChestMeasurements);
            Console.WriteLine(Torso.WaistMeasurements);
            Console.WriteLine("\n[HeadData]");
            Console.WriteLine(Head.HeadType);
        }
    }
}

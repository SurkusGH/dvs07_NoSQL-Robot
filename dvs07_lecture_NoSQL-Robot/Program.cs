using dvs07_lecture_NoSQL_Robot.DataTypes;
using dvs07_lecture_NoSQL_Robot.Functions;
using System;

namespace dvs07_lecture_NoSQL_Robot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("dvs07_lecture_NoSQL_Robot!");

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

            // Sukurkite servisą, kuris:
            // (1) Ims duomenis apie robotą iš tekstinio failo ir grąžins roboto objektą.
            // Sukurkite kitą servisą, kuris:
            // (2) Galės išsaugoti robotą į mongodb duomenų bazę.
            // (3) Galės išsaugoti sąrašą robotų.
            // (4) Galės surasti robotą pagal jo Id.
            // (5) Galės surasti robotą pagal kitą vartotojo įvestą parametrą ir jo reikšmę.
            // (6) Galės ištrinti robotą pagal Id.
            // (7) Galės paupdatinti duomenis apie robotą.

            // (!) Bonus: Paimtą robotą(us) iš duomenų bazės, surašys į atskirą failą.

            #endregion

            #region OTHER

            // Install-Package MongoDB.Driver -Version 2.14.1
            // Vytautas - g4X9cfNafH5gbht

            #endregion

            var Johny3000 = new Robot();
            Johny3000 = Parser.ParseRobotData();
            Johny3000.Print();

            WriterToDb.AddRobotToDb(Johny3000);
        }
    }
}

using dvs07_lecture_NoSQL_Robot.DataTypes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dvs07_lecture_NoSQL_Robot.Functions
{
    // Sukurkite servisą, kuris:
    // (1) Ims duomenis apie robotą iš tekstinio failo ir grąžins roboto objektą.
    public class Parser
    {
        public static Robot ParseRobotData()
        {
            //WinOS
            //var csvLineReader = new StreamReader($@"D:\GitHub\dvs07_lecture_NoSQL-Robot\dvs07_lecture_NoSQL-Robot\Files\RobotValues.csv");
            //MacOS
            var csvLineReader = new StreamReader($@"/Users/surkus/GitHub/dvs07_lecture_NoSQL-Robot/dvs07_lecture_NoSQL-Robot/Files/RobotValues.csv");
            var robotArm = new Arm();
            var robotLeg = new Leg();
            var robotTorso = new Torso();
            var robotHead = new Head();
            var robot = new Robot();


            while (!csvLineReader.EndOfStream)
            {
                var line = csvLineReader.ReadLine();
                string[] tempCache = line.Split(", ");

                robotArm.Material = tempCache[0];
                robotArm.NumberOfJoints = int.Parse(tempCache[1]);
                robotArm.NumberOfFingers = int.Parse(tempCache[2]);

                robotLeg.Material = tempCache[3];
                robotLeg.NumberOfJoints = int.Parse(tempCache[4]);
                robotLeg.SizeOfFoot = float.Parse(tempCache[5]);

                robotTorso.ChestMeasurements = int.Parse(tempCache[6]);
                robotTorso.WaistMeasurements = int.Parse(tempCache[7]);

                robot.Arm.Add(robotArm);
                robot.Arm.Add(robotArm);
                robot.Leg.Add(robotLeg);
                robot.Leg.Add(robotLeg);
                robot.Torso = robotTorso;

                robotHead.HeadType = Enum.TryParse($"{tempCache[8]}", out HeadType head).ToString();

                robot.Head = robotHead;
            }
            return robot;
        }
    }
}

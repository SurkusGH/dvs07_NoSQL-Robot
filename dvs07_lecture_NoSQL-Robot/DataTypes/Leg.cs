using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dvs07_lecture_NoSQL_Robot.DataTypes
{
    #region Assignment
    // (C) List<Leg>:
    //      Material
    //      NumberOfJoints
    //      SizeOfFoot
    #endregion
    public class Leg
    {
        public string Material { get; set; }
        public int NumberOfJoints { get; set; }
        public float SizeOfFoot { get; set; }

        public Leg(string material = "", int numberOfJoints = 0, float sizeOfFoot = 0f)
        {
            Material = material;
            NumberOfJoints = numberOfJoints;
            SizeOfFoot = sizeOfFoot;
        }
    }
}

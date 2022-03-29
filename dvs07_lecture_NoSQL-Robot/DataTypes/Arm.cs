using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dvs07_lecture_NoSQL_Robot.DataTypes
{
    #region Assignment
    // (B) List<Arm>:
    //      Material
    //      NumberOfJoints
    //      NumberOfFingers
    #endregion
    public class Arm
    {
        public string Material { get; set; }
        public int NumberOfJoints { get; set; }
        public int NumberOfFingers { get; set; }

        public Arm(string material = "", int numberOfJoints = 0, int numberOfFingers = 0)
        {
            Material = material;
            NumberOfJoints = numberOfJoints;
            NumberOfFingers = numberOfFingers;
        }
    }
}

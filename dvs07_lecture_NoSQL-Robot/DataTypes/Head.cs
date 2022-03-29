using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dvs07_lecture_NoSQL_Robot.DataTypes
{
    #region Assignment
    // (E) Head:
    //      Enum - HeadType
    #endregion
    public class Head
    {
        public string HeadType { get; set; }

        public Head(string headType = "")
        {
            HeadType = headType;
        }
    }

    public enum HeadType
    {
        EnhancedVision,
        IncreasedProcessingPower,
        ReducedLatency
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dvs07_lecture_NoSQL_Robot.DataTypes
{
    #region Assignment
    // (D) Torso
    //      ChestMeasurements
    //      WaistMeasurements
    #endregion
    public class Torso
    {
        public float ChestMeasurements { get; set; }
        public float WaistMeasurements { get; set; }

        public Torso(float chestMeasurements = 0f, float waistMeasurements = 0f)
        {
            ChestMeasurements = chestMeasurements;
            WaistMeasurements = waistMeasurements;
        }
    }
}

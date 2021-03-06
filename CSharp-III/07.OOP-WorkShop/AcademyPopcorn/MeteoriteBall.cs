﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class MeteoriteBall : Ball
    {
        public MeteoriteBall(MatrixCoords topLeft, MatrixCoords speed) : base (topLeft, speed) 
        {
        }
        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<TrailObject> newTrailObject = new List<TrailObject>();
            newTrailObject.Add(new TrailObject(this.TopLeft, new char[,] {{'*'}}, 3));
            return newTrailObject;
        }
    }
}

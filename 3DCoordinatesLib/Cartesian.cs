using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DCoordinatesLibrary
{
        /// <summary>
        /// The class Cartesian, used to represent a Cartesian coordinates.
        /// </summary>
        public class Cartesian
        {
            /// <summary>
            /// The variable the used to represent Cartesian coordinate.
            /// </summary>
            double _X;  //properties
            double _Y;
            double _Z;

            /// <summary>
            /// The variable X in cartesian coordinate.
            /// </summary>
            public double X //setter and getter
             {
                get
                {
                    return _X;
                }
                set
                {
                    _X = value;
                }
            }

            /// <summary>
            /// The variable Y in cartesian coordinate.
            /// </summary>
            public double Y
            {
                get
                {
                    return _Y;
                }
                set
                {
                    _Y = value;
                }
            }

            /// <summary>
            /// The variable Z in cartesian coordinate.
            /// </summary>
            public double Z
            {
                get
                {
                    return _Z;
                }
                set
                {
                    _Z = value;
                }
            }

            /// <summary>
            /// The three parameter constructor with X, Y and Z variable.
            /// </summary>
            public Cartesian()//constructor
            {
                _X = 0;
                _Y = 0;
                _Z = 0;
            }

            /// <summary>
            /// The three parameter constructor with X, Y and Z variable.
            /// </summary>
            /// <param name="P1"></param>
            /// <param name="P2"></param>
            /// <param name="P3"></param>
            public Cartesian(double P1, double P2, double P3)
            {
                _X = P1;
                _Y = P2;
                _Z = P3;
            }

            /// <summary>
            /// The Cartesian to Cylindrical coordinates conversion formula.
            /// </summary>
            //for Cylindrical
            public Cylindrical ToCylindrical() //type and methodname 

            {
                Cylindrical temp = new Cylindrical();

                temp.R = Math.Sqrt((_X * _X + _Y * _Y));
                temp.ThetaC = Math.Atan(_Y / _X);
                temp.Z = _Z;
                return temp;

            }

            /// <summary>
            /// The Cartesian to Spherical coordinates conversion formula.
            /// </summary>
            //for Spehrical
            public Spherical ToSpherical() //type class and method name
            {
                Spherical temp = new Spherical();

                temp.Rho = Math.Sqrt(_X * _X + _Y * _Y + _Z * _Z);
                temp.ThetaS = Math.Atan(_Y / _X);
                temp.Phi = Math.Atan((Math.Sqrt(_X * _X + _Y * _Y)) / _Z);

                return temp;

            }

            /// <summary>
            /// Operation for Unit test (distance between 2 point)
            /// </summary>
            /// <param name="P1"></param>
            /// <param name="P2"></param>
            /// <returns></returns>
            static public double operator -(Cartesian P1, Cartesian P2)
            {
               double temp;
               double dx = P1._X - P2._X;
               double dy = P1._Y - P2._Y; 
               double dz = P1._Z - P2._Z;

               temp = Math.Sqrt(dx*dx + dy*dy + dz*dz);

              return temp;
            }


    }
}

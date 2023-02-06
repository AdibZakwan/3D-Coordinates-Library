using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DCoordinatesLibrary
{
        /// <summary>
        /// The class Cylindrical, used to represent a Cylindrical coordinates.
        /// </summary>
        public class Cylindrical
        {
            /// <summary>
            /// The variable that used to represent Cylindrical coordinate.
            /// </summary>
            double _R;  //properties
            double _ThetaC;
            double _Z;

            /// <summary>
            /// The variable R in Cylindrical coordinate.
            /// </summary>
            public double R //setter and getter
            {
                get
                {
                    return _R;
                }
                set
                {
                    _R = value;
                }
            }

            /// <summary>
            /// The variable Theta in Cylindrical coordinate.
            /// </summary>
            public double ThetaC
            {
                get
                {
                    return _ThetaC;
                }
                set
                {
                    _ThetaC = value;
                }
            }

            /// <summary>
            /// The variable Z in Cylindrical coordinate.
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
            /// The three parameter constructor with R, Theta and Z variable.
            /// </summary>
            //constructer
            public Cylindrical()
            {
                _R = 0;
                _ThetaC = 0;
                _Z = 0;
            }

             /// <summary>
             /// The three parameter constructor with R, Theta and Z variable.
             /// </summary>
             /// <param name="P1"></param>
             /// <param name="P2"></param>
             /// <param name="P3"></param>
             public Cylindrical(double P1, double P2, double P3)  //constructer
             {
                 _R = P1;
                 _ThetaC = P2;
                 _Z = P3;
             }



            /// <summary>
            /// The Cylindrical to Cartesian coordinates conversion formula.
            /// </summary>
            public Cartesian ToCartesian() //type and methodname
            {
                Cartesian temp = new Cartesian();

                temp.X = _R * Math.Cos(_ThetaC);
                temp.Y = _R * Math.Sin(_ThetaC);
                temp.Z = _Z;
                return temp;


            }

            /// <summary>
            /// The Cylindrical to Spherical coordinates conversion formula.
            /// </summary>
            //for Spehrical
            public Spherical ToSpherical() //type and methodname
            {
                Spherical temp = new Spherical();

                temp.Rho = Math.Sqrt(_R * _R + _Z * _Z);
                temp.ThetaS = _ThetaC;
                temp.Phi = Math.Atan(_R / _Z);

                return temp;

            }

        }
    
}

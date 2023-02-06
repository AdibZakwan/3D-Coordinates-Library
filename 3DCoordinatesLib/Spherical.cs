using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DCoordinatesLibrary
{
        /// <summary>
        /// The class Spherical, used to represent a Spherical coordinates.
        /// </summary>
        public class Spherical
        {
            /// <summary>
            /// The variable that used to represent Spherical coordinate.
            /// </summary>
            double _Rho;  //properties
            double _ThetaS;
            double _Phi;

            /// <summary>
            /// The variable Rho in spherical coordinate.
            /// </summary>
            public double Rho //setter and getter
            {
                get
                {
                    return _Rho;
                }
                set
                {
                    _Rho = value;
                }
            }

            /// <summary>
            /// The variable Theta in spherical coordinate.
            /// </summary>
            public double ThetaS
            {
                get
                {
                    return _ThetaS;
                }
                set
                {
                    _ThetaS = value;
                }
            }

            /// <summary>
            /// The variable Phi in spherical coordinate.
            /// </summary>      
            public double Phi
            {
                get
                {
                    return _Phi;
                }
                set
                {
                    _Phi = value;
                }
            }

            /// <summary>
            /// The three parameter constructor with Rho, Theta and Phi variable.
            /// </summary>
            //constructer
            public Spherical()
            {
                _Rho = 0;
                _ThetaS = 0;
                _Phi = 0;
            }

            /// <summary>
            /// The three parameter constructor with Rho, Theta and Phi variable.
            /// </summary>
            /// <param name="P1"></param>
            /// <param name="P2"></param>
            /// <param name="P3"></param>
            public Spherical(double P1, double P2, double P3)
            {
               _Rho = P1;
               _ThetaS = P2;
               _Phi = P3;
            }

            /// <summary>
            /// The Spherical to Cartesian coordinates conversion formula.
            /// </summary>
            public Cartesian ToCartesian() //type and methodnameB
            {
                Cartesian temp = new Cartesian();

                temp.X = (_Rho * (Math.Sin(_Phi)) * (Math.Cos(_ThetaS)));
                temp.Y = (_Rho * (Math.Sin(_Phi)) * (Math.Sin(_ThetaS)));
                temp.Z = (_Rho * (Math.Cos(_Phi)));
                return temp;

            }

            /// <summary>
            /// The Spherical to Cylindrical coordinates conversion formula.
            /// </summary>
            //for Cylindrical
            public Cylindrical ToCylindrical() //type and methodname 

            {
                Cylindrical temp = new Cylindrical();

                temp.R = _Rho * Math.Sin(_Phi);
                temp.ThetaC = _ThetaS;
                temp.Z = _Rho * Math.Cos(_Phi);
                return temp;

            }
        }
}

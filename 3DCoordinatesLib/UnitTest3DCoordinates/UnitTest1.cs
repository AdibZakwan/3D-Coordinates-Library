using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using _3DCoordinatesLibrary;


namespace UnitTest3DCoordinates
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PropertiesTest() // constructurs
        {
            Cartesian Cood = new Cartesian();

            Cood.X = 10;
            Cood.Y = 20;
            Cood.Z = 30;

            Assert.AreEqual(10, Cood.X);
            Assert.AreEqual(20, Cood.Y);
            Assert.AreEqual(30, Cood.Z);

        }

        public void PropertiesTest2()
        {
            Cylindrical Cood = new Cylindrical();

            Cood.R = 10;
            Cood.ThetaC = 20;
            Cood.Z = 30;

            Assert.AreEqual(10, Cood.R);
            Assert.AreEqual(20, Cood.ThetaC);
            Assert.AreEqual(30, Cood.Z);

        }
        public void PropertiesTest3()
        {
            Spherical Cood = new Spherical();

            Cood.Rho = 10;
            Cood.ThetaS = 20;
            Cood.Phi = 30;

            Assert.AreEqual(10, Cood.Rho);
            Assert.AreEqual(20, Cood.ThetaS);
            Assert.AreEqual(30, Cood.Phi);

        }

        [TestMethod]
        public void SetterGetterTest()
        {
            Cartesian Cood = new Cartesian();

            Cood.X = 10;
            Cood.Y = 20;
            Cood.Z = 30;

            Assert.AreEqual(10, Cood.X);
            Assert.AreEqual(20, Cood.Y);
            Assert.AreEqual(30, Cood.Z);
        }
        public void SetterGetterTest2()
        {
            Cylindrical Cood = new Cylindrical();

            Cood.R = 10;
            Cood.ThetaC = 20;
            Cood.Z = 30;

            Assert.AreEqual(10, Cood.R);
            Assert.AreEqual(20, Cood.ThetaC);
            Assert.AreEqual(30, Cood.Z);

        }
        public void SetterGetterTest3()
        {
            Spherical Cood = new Spherical();

            Cood.Rho = 10;
            Cood.ThetaS = 20;
            Cood.Phi = 30;

            Assert.AreEqual(10, Cood.Rho);
            Assert.AreEqual(20, Cood.ThetaS);
            Assert.AreEqual(30, Cood.Phi);

        }

        [TestMethod]
        public void ConversionTest1() // For Cartesian to Cylinrical and Spherical
        {
            Cartesian Cood = new Cartesian();

            Cood.X = 30;
            Cood.Y = 40;
            Cood.Z = 50;

            Cylindrical CoordCyl = Cood.ToCylindrical();

            Assert.AreEqual(50, CoordCyl.R);
            Assert.AreEqual(0.927295218001612, CoordCyl.ThetaC);
            Assert.AreEqual(50 , CoordCyl.Z);

            Spherical CoordSphe = Cood.ToSpherical();

            Assert.AreEqual(70.7106781186548, CoordSphe.Rho);
            Assert.AreEqual(0.927295218001612, CoordSphe.ThetaS);
            Assert.AreEqual(0.785398163397448, CoordSphe.Phi);

        }

        [TestMethod]
        public void ConversionTest2() // For Cylindrical to Cartesian and Spherical
        {
            Cylindrical Cood = new Cylindrical();

            Cood.R = 30;
            Cood.ThetaC = 40;
            Cood.Z = 50;

            Cartesian CoordCart = Cood.ToCartesian();

            Assert.AreEqual(-20.0081418495679, CoordCart.X);
            Assert.AreEqual(22.3533948143805, CoordCart.Y);
            Assert.AreEqual(50, CoordCart.Z);

            Spherical CoordSphe = Cood.ToSpherical();

            Assert.AreEqual(58.309518948453, CoordSphe.Rho);
            Assert.AreEqual(40, CoordSphe.ThetaS);
            Assert.AreEqual(0.540419500270584, CoordSphe.Phi);

        }

        [TestMethod]
        public void ConversionTest3() // For Spherical to Cylindrical and Cartesian
        {
            Spherical Cood = new Spherical();

            Cood.Rho = 30;
            Cood.ThetaS = 40;
            Cood.Phi = 50;

            Cylindrical CoordCyl = Cood.ToCylindrical();

            Assert.AreEqual(-7.87124561111786, CoordCyl.R);
            Assert.AreEqual(40, CoordCyl.ThetaC);
            Assert.AreEqual(28.9489808547634, CoordCyl.Z);

            Cartesian CoordCart = Cood.ToCartesian();

            Assert.AreEqual(5.24963329066782, CoordCart.X);
            Assert.AreEqual(-5.86496869420923, CoordCart.Y);
            Assert.AreEqual(28.9489808547634, CoordCart.Z);

        }


        [TestMethod]
        public void SubtractionTest() // For distance
        {
            Cartesian P1 = new Cartesian();
            Cartesian P2 = new Cartesian();
            double result;

            P1.X = 1;
            P1.Y = 1;
            P1.Z = 1;

            P2.X = 2;
            P2.Y = 2;
            P2.Z = 2;


            result = P1 - P2;

            Assert.AreEqual(result, 1.7320508075688772935274463415059);
        }

    }


}

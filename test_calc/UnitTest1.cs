using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using calculator;

namespace test_calc
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Sum_5and4retern9()
        {
            // test example with inrut data

            int dn1 = 5, dn2 = 4;

            string excpected = $"{9:F2}";

            Form1 f = new Form1();

            f.N1 = dn1.ToString();

            f.textBox1.Text = dn2.ToString();

            f.D = "+";

            f.button2_Click(new object(), new EventArgs());

            string actual = f.textBox1.Text;

            Assert.AreEqual(excpected, actual, "test is not correct");
        }

        [TestMethod]
        public void Minus_5and4retern1()
        {
            // test example with inrut data

            int dn1 = 5, dn2 = 4;

            string excpected = $"{1:F2}";

            Form1 f = new Form1();

            f.N1 = dn1.ToString();

            f.textBox1.Text = dn2.ToString();

            f.D = "-";

            f.button2_Click(new object(), new EventArgs());

            string actual = f.textBox1.Text;

            Assert.AreEqual(excpected, actual, "test is not correct");
        }

        [TestMethod]
        public void Umnozhenie_5and4retern20()
        {
            // test example with inrut data

            int dn1 = 5, dn2 = 4;

            string excpected = $"{20:F2}";

            Form1 f = new Form1();

            f.N1 = dn1.ToString();

            f.textBox1.Text = dn2.ToString();

            f.D = "×";

            f.button2_Click(new object(), new EventArgs());

            string actual = f.textBox1.Text;

            Assert.AreEqual(excpected, actual, "test is not correct");
        }
        [TestMethod]
        public void Delenie_20and5retern4()
        {
            // test example with inrut data

            int dn1 = 20, dn2 = 5;

            string excpected = $"{4:F2}";

            Form1 f = new Form1();

            f.N1 = dn1.ToString();

            f.textBox1.Text = dn2.ToString();

            f.D = "÷";

            f.button2_Click(new object(), new EventArgs());

            string actual = f.textBox1.Text;

            Assert.AreEqual(excpected, actual, "test is not correct");

        }
    }
 }
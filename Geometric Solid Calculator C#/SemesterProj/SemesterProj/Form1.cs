/* Program Name:            Semester Project: Geometric Solids Calculator
 * Description:             This program allows users to insert the dimensions of a variety of solids, and calculate the surface area and volume of them.
 * Author:                  Jacob Mitchell
 * Date:                    9/25/2019
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemesterProj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ChooseSolid_Click(object sender, EventArgs e)
        {
            inputLabel.Visible = true;
            ClearAfterSelect(); //Ensures user doesn't change shape after selecting their solid.
            if (sphereBtn.Checked)
            {
                ClearAll();
                radiusLabel.Visible = true;
                radiusInput.Visible = true;
            }else if(roundConeBtn.Checked)
            {
                ClearAll();
                radiusInput.Visible = true;
                radiusLabel.Visible = true;
                heightInput.Visible = true;
                heightLabel.Visible = true;
            }else if(boxBtn.Checked)
            {
                ClearAll();
                heightLabel.Visible = true;
                heightInput.Visible = true;
                widthInput.Visible = true;
                widthLabel.Visible = true;
                lengthInput.Visible = true;
                lengthLabel.Visible = true;
            }else if (pyramidBtn.Checked)
            {
                ClearAll();
                lengthLabel.Visible = true;
                lengthInput.Visible = true;
                heightLabel.Visible = true;
                heightInput.Visible = true;
                widthInput.Visible = true;
                widthLabel.Visible = true;
            }else if (cylinderBtn.Checked)
            {
                ClearAll();
                radiusLabel.Visible = true;
                radiusInput.Visible = true;
                heightLabel.Visible = true;
                heightInput.Visible = true;
            }
            else
            {
                MessageBox.Show("Please make a selection.");
            }

            calculate.Visible = true;

        }

        private void ClearAll() //Method that clears all buttons labels and textboxes on the screen 
        {
            radiusInput.Visible = false;
            radiusLabel.Visible = false;
            heightInput.Visible = false;
            heightLabel.Visible = false;
            lengthInput.Visible = false;
            lengthLabel.Visible = false;
            widthInput.Visible = false;
            widthLabel.Visible = false;
            calculate.Visible = false;
            resultsPanel.Visible = false;
            volumeOutputLabel.Text = "";
            sAreaOutputLabel.Text = "";
        }
        private void ClearAfterSelect() //Method that clears all radio buttons after one is chosen
        {
            sphereBtn.Enabled = false;
            boxBtn.Enabled = false;
            pyramidBtn.Enabled = false;
            roundConeBtn.Enabled = false;
            cylinderBtn.Enabled = false;
            chooseSolid.Enabled = false;
        }
        private void ReEnable() //Method that reenables radio button to allow reselection
        {

            sphereBtn.Enabled = true;
            boxBtn.Enabled = true;
            pyramidBtn.Enabled = true;
            roundConeBtn.Enabled = true;
            cylinderBtn.Enabled = true;
            chooseSolid.Enabled = true;
        }

        private void Calculate_Click(object sender, EventArgs e) //Logic behind the calculate button, commits correct calculations based off user selection
        {
            double height, length, width, radius, checkVal;
            bool check = false;
            string radiusMessage = "Please enter values in the 'Radius' form of a numeric value that is greater than 0.",
                   heightMessage = "Please enter values in the 'Height' form of a numeric value that is greater than 0. ",
                   lenghtMessage = "Please enter values in the 'Length' form of a numeric value that is greater than 0.",
                   widthMessage = "Please enter values in the 'Width' form of a numeric value that is greater than 0.";

            Application.DoEvents();
            resultsPanel.Visible = true;

            if (sphereBtn.Checked) //Processing if sphere option is chosen
            {
                check = double.TryParse(radiusInput.Text, out radius); //Data validation
                checkVal = radius;
                if (!check || checkVal <= 0) {
                    resultsPanel.Visible = false;
                    MessageBox.Show(radiusMessage);
                }
                sAreaOutputLabel.Text = SphereSACalculation(radius).ToString("N3"); //call to SA Method w display
                volumeOutputLabel.Text = SphereVolumeCalculation(radius).ToString("N3"); //call to Vol Method w display

            }else if (boxBtn.Checked) // Processing if box/cube option is chosen
            {
                check = double.TryParse(heightInput.Text, out height); //Data validation
                checkVal = height;
                if (!check || checkVal <= 0)
                {
                    resultsPanel.Visible = false;
                    MessageBox.Show(heightMessage);
                }
                check = double.TryParse(lengthInput.Text, out length); //Data validation
                checkVal = length;
                if (!check || checkVal <= 0)
                {
                    resultsPanel.Visible = false;
                    MessageBox.Show(lenghtMessage);
                }
                check = double.TryParse(widthInput.Text, out width); //Data validation
                checkVal = width;
                if (!check || checkVal <= 0)
                {
                    resultsPanel.Visible = false;
                    MessageBox.Show(widthMessage);
                }
                sAreaOutputLabel.Text = BoxSACalculation(length, width, height).ToString("N3");
                volumeOutputLabel.Text = BoxVolumeCalculation(length, width, height).ToString("N3");
            }else if (roundConeBtn.Checked) //Processing if round bottom cone option is chosen
            {
                check = double.TryParse(radiusInput.Text, out radius); //Data validation
                checkVal = radius;
                if (!check || checkVal <= 0)
                {
                    resultsPanel.Visible = false;
                    MessageBox.Show(radiusMessage);
                }
                check = double.TryParse(heightInput.Text, out height); //Data validation
                checkVal = height;
                if (!check || checkVal <= 0)
                {
                    resultsPanel.Visible = false;
                    MessageBox.Show(heightMessage);
                }
                sAreaOutputLabel.Text = ConeSACalculation(radius, height).ToString("N3");
                volumeOutputLabel.Text = ConeVolumeCalculation(radius, height).ToString("N3");
            }else if (pyramidBtn.Checked)
            {
                check = double.TryParse(heightInput.Text, out height); //Data validation
                checkVal = height;
                if (!check || checkVal <= 0)
                {
                    resultsPanel.Visible = false;
                    MessageBox.Show(heightMessage);
                }
                check = double.TryParse(lengthInput.Text, out length); //Data validation
                checkVal = length;
                if (!check || checkVal <= 0)
                {
                    resultsPanel.Visible = false;
                    MessageBox.Show(lenghtMessage);
                }
                check = double.TryParse(widthInput.Text, out width); //Data validation
                checkVal = width;
                if (!check || checkVal <= 0)
                {
                    resultsPanel.Visible = false;
                    MessageBox.Show(widthMessage);
                }
                sAreaOutputLabel.Text = PyramidSACalculation(length, width, height).ToString("N3");
                volumeOutputLabel.Text = PyramidVolumeCalculation(length, width, height).ToString("N3");
            }else if (cylinderBtn.Checked)
            {
                check = double.TryParse(radiusInput.Text, out radius); //Data validation
                checkVal = radius;
                if (!check || checkVal <= 0)
                {
                    resultsPanel.Visible = false;
                    MessageBox.Show(radiusMessage);
                }
                check = double.TryParse(heightInput.Text, out height); //Data validation
                checkVal = height;
                if (!check || checkVal <= 0)
                {
                    resultsPanel.Visible = false;
                    MessageBox.Show(heightMessage);
                }
                sAreaOutputLabel.Text = CylinderSACalculation(radius, height).ToString("N3");
                volumeOutputLabel.Text = CylinderVolumeCalculation(radius, height).ToString("N3");
            }

        }

        private double SphereSACalculation(double radiusArg) //Method that contains logic to calculate Surface area of a sphere
        {
            double surfaceArea;
            surfaceArea = 4 * Math.PI * Math.Pow(radiusArg, 2); //SA of a sphere = 4 x pi x r^2
            return surfaceArea;
        }

        private double SphereVolumeCalculation(double radiusArg) //Method that contains logic to calculate the Volume of a sphere
        {
            double volume;
            volume = (4 / 3) * Math.PI * Math.Pow(radiusArg, 3); //(4 / 3) * Pi * R3.
            return volume;
        }

        private double BoxSACalculation(double lengthArg, double widthArg, double heightArg) //Method that contains logic to calculate Surface area of a cube/box
        {
            double surfaceArea;
            // 2wl + 2lh + 2hw
            surfaceArea = (2 * lengthArg) + (2 * widthArg) + (2 * heightArg);
            return surfaceArea;
        }

        private double BoxVolumeCalculation(double lengthArg, double widthArg, double heightArg) //Method that contains logic to calculate the Volume of a box/cube
        {
            double volume;
            //V = l x w x h.
            volume = lengthArg * widthArg * heightArg;
            return volume;
        }

        private double ConeSACalculation(double radiusArg, double heightArg) //Method that contains logic to calculate Surface area of a Cone
        {
            double surfaceArea = 0;
            surfaceArea = Math.PI * radiusArg * (radiusArg + Math.Sqrt(Math.Pow(heightArg, 2.0) + Math.Pow(radiusArg, 2.0)));
            return surfaceArea;
        }

        private double ConeVolumeCalculation(double radiusArg, double heightArg) //Method that contains logic to calculate the Volume of a cone
        {
            double volume;
            volume = Math.PI * Math.Pow(radiusArg, 2) * (heightArg / 3);
            return volume;
        }

        private double PyramidSACalculation(double lengthArg, double widthArg, double heightArg) //Method that contains logic to calculate Surface area of a Pyramid
        {
            double surfaceArea;
            surfaceArea = lengthArg * widthArg + lengthArg * Math.Sqrt((Math.Pow((widthArg / 2), 2)) + Math.Pow(heightArg, 2)) + widthArg * Math.Sqrt(Math.Pow((lengthArg / 2), 2) + Math.Pow(heightArg, 2)); //I regret this assignment, this was sooooo hard to write
            return surfaceArea;
        }

        private double PyramidVolumeCalculation(double lengthArg, double widthArg, double heightArg) //Method that contains logic to calculate the Volume of a Pyramid
        {
            double volume;
            volume = (lengthArg * widthArg * heightArg) / 3;
            return volume;
        }

        private double CylinderSACalculation(double radiusArg, double heightArg) //Method that contains logic to calculate Surface area of a cylinder
        {
            double surfaceArea;
            surfaceArea = 2 * Math.PI * radiusArg * heightArg + 2 * Math.PI * Math.Pow(radiusArg, 2);
            return surfaceArea;
        }

        private double CylinderVolumeCalculation(double radiusArg, double heightArg) //Method that contains logic to calculate the Volume of a cylinder
        {
            double volume;
            volume = Math.PI * Math.Pow(radiusArg, 2) * heightArg;
            return volume;
        }

        private void RestartBtn_Click(object sender, EventArgs e) //Clears all forms and restarts whole application
        {
            ReEnable();
            ClearAll();
            inputLabel.Visible = false;
        }
    }
}

// Fyzzy Set sample application
// AForge.NET framework
// http://www.aforgenet.com/framework/
//
// Copyright © AForge.NET, 2005-2011
// contacts@aforgenet.com
//

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Accord.Fuzzy;
using Accord.Controls;
using Accord;

namespace SampleApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            chart.RangeX = new Range(0, 50);
            chart.AddDataSeries("Humidity", Color.CornflowerBlue, Chart.SeriesType.Line, 3, true);
            chart.AddDataSeries("AC", Color.LightBlue, Chart.SeriesType.Line, 3, true);
            chart.AddDataSeries("Light Intensity", Color.LightCoral, Chart.SeriesType.Line, 3, true);
            chart.AddDataSeries("Heat", Color.Firebrick, Chart.SeriesType.Line, 3, true);
            chart.AddDataSeries("Soil Moister", Color.RosyBrown, Chart.SeriesType.Line, 3, true);
            chart.AddDataSeries("Leaf Zone Temperature", Color.ForestGreen, Chart.SeriesType.Line, 3, true);
        }

        // Testing basic functionality of fuzzy sets
        private void runFuzzySetTestButton_Click(object sender, EventArgs e)
        {
            ClearDataSeries();

            // create 2 fuzzy sets to represent the Cool and Warm temperatures
            FuzzySet fsAC = new FuzzySet("AC", new TrapezoidalFunction(13, 18, 23, 28));
            FuzzySet fsLightIntensity = new FuzzySet("Light Intensity", new TrapezoidalFunction(23, 28, 33, 38));

            // get membership of some points to the cool fuzzy set
            double[,] acValues = new double[20, 2];
            for (int i = 10; i < 30; i++)
            {
                acValues[i - 10, 0] = i;
                acValues[i - 10, 1] = fsAC.GetMembership(i);
            }

            // getting memberships of some points to the warm fuzzy set
            double[,] lightintensityValues = new double[20, 2];
            for (int i = 20; i < 40; i++)
            {
                lightintensityValues[i - 20, 0] = i;
                lightintensityValues[i - 20, 1] = fsLightIntensity.GetMembership(i);
            }

            // plot membership to a chart
            chart.UpdateDataSeries("AC", acValues);
            chart.UpdateDataSeries("Light Intensity", lightintensityValues);
        }


        // Testing basic functionality of linguistic variables
        private void runLingVarTestButton_Click(object sender, EventArgs e)
        {
            ClearDataSeries();

            // create a linguistic variable to represent temperature
            LinguisticVariable lvTemperature = new LinguisticVariable("Temperature", 0, 80);

            // create the linguistic labels (fuzzy sets) that compose the temperature 
            FuzzySet fsHumidity = new FuzzySet("Humidity", new TrapezoidalFunction(10, 15, TrapezoidalFunction.EdgeType.Right));
            FuzzySet fsAC = new FuzzySet("AC", new TrapezoidalFunction(10, 15, 20, 25));
            FuzzySet fsLightIntensity = new FuzzySet("Light Intensity", new TrapezoidalFunction(20, 25, 30, 35));
            FuzzySet fsHeat = new FuzzySet("Heat", new TrapezoidalFunction(30, 35, TrapezoidalFunction.EdgeType.Left));
            FuzzySet fsSoilMoister = new FuzzySet("Soil Moister", new TrapezoidalFunction(15,25, TrapezoidalFunction.EdgeType.Right));
            FuzzySet fsLeafZoneTemperature = new FuzzySet("Leaf Zone Temperature", new TrapezoidalFunction(30, 35, TrapezoidalFunction.EdgeType.Left));
            // adding labels to the variable
            lvTemperature.AddLabel(fsHumidity);
            lvTemperature.AddLabel(fsAC);
            lvTemperature.AddLabel(fsLightIntensity);
            lvTemperature.AddLabel(fsHeat);
            lvTemperature.AddLabel(fsSoilMoister);
            lvTemperature.AddLabel(fsLeafZoneTemperature);

            // get membership of some points to the cool fuzzy set
            double[][,] chartValues = new double[6][,];
            for (int i = 0; i < 6; i++)
                chartValues[i] = new double[160, 2];

            // showing the shape of the linguistic variable - the shape of its labels memberships from start to end
            int j = 0;
            for (float x = 0; x < 80; x += 0.5f, j++)
            {
                double y1 = lvTemperature.GetLabelMembership("Humidity", x);
                double y2 = lvTemperature.GetLabelMembership("AC", x);
                double y3 = lvTemperature.GetLabelMembership("Light Intensity", x);
                double y4 = lvTemperature.GetLabelMembership("Heat", x);
                double y5 = lvTemperature.GetLabelMembership("Soil Moister", x);
                double y6 = lvTemperature.GetLabelMembership("Leaf Zone Temperature", x);

                chartValues[0][j, 0] = x;
                chartValues[0][j, 1] = y1;
                chartValues[1][j, 0] = x;
                chartValues[1][j, 1] = y2;
                chartValues[2][j, 0] = x;
                chartValues[2][j, 1] = y3;
                chartValues[3][j, 0] = x;
                chartValues[3][j, 1] = y4;
                chartValues[3][j, 0] = x;
                chartValues[3][j, 1] = y5;
                chartValues[3][j, 0] = x;
                chartValues[3][j, 1] = y6;

            }

            // plot membership to a chart
            chart.UpdateDataSeries("Humidity", chartValues[0]);
            chart.UpdateDataSeries("AC", chartValues[1]);
            chart.UpdateDataSeries("Light Intensity", chartValues[2]);
            chart.UpdateDataSeries("Heat", chartValues[3]);
            chart.UpdateDataSeries("Soil Moister", chartValues[4]);
            chart.UpdateDataSeries("Leaf Zone Temperature", chartValues[5]);
        }

        // Clear all data series data
        private void ClearDataSeries()
        {
            chart.UpdateDataSeries("Humidity", null);
            chart.UpdateDataSeries("AC", null);
            chart.UpdateDataSeries("Light Intensity", null);
            chart.UpdateDataSeries("Heat", null);
            chart.UpdateDataSeries("Soil Moister", null);
            chart.UpdateDataSeries("Leaf Zone Temperature", null);
        }
    }
}
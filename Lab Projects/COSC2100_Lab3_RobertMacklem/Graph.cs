using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace COSC2100_Lab3_RobertMacklem
{
    public partial class Graph : Form
    {
        public Graph(BindingList<Expense> expenseList)
        {
            InitializeComponent();


            // Build the series (line) for the chart
            Series series = new Series
            {
                Name = "Daily Expenses",

                // Set the data types
                ChartType = SeriesChartType.Line,
                XValueType = ChartValueType.DateTime,
                YValueType = ChartValueType.Double,
            };

            chrGraph.Series.Add(series);

            // Label axes and format amount as currency
            chrGraph.ChartAreas[0].AxisX.Title = "Date";
            chrGraph.ChartAreas[0].AxisY.Title = "Amount";
            chrGraph.ChartAreas[0].AxisY.LabelStyle.Format = "C";

            // Populate the data series
            foreach (Expense expense in expenseList)
            {
                series.Points.AddXY(expense.Date.Date, expense.Amount);
            }
        }

        /// <summary>
        /// Closes the form on click.
        /// </summary>
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

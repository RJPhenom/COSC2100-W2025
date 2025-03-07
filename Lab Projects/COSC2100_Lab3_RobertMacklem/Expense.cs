using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COSC2100_Lab3_RobertMacklem
{
    public class Expense
    {
        // VARS
        private DateTime date;
        private string description;
        private double amount;

        // PROPERTIES
        public DateTime Date { get { return date; } }
        public string Description { get { return description; } }
        public double Amount { get { return amount; } }

        // Note: setters not needed. Class instances are not altered after initialization.

        // CONSTRUCTOR
        public Expense(DateTime date, string description, double amount)
        {
            this.date = date;
            this.description = description;
            this.amount = amount;
        }

    }
}

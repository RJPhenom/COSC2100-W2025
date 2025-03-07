using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COSC2100_Lab3_RobertMacklem
{
    public partial class frmMain : Form
    {
        // VARS
        BindingList<Expense> expenseList = new BindingList<Expense>();

        // CONSTRUCTOR
        public frmMain()
        {
            InitializeComponent();

            // Fill the table with example data
            AddExpense(new Expense(DateTime.Now, "Dunkaroos", 5.64));
            AddExpense(new Expense(DateTime.Now.AddDays(-1), "Lay's Ketchup Chips", 3.38));
            AddExpense(new Expense(DateTime.Now.AddDays(-2), "Coke Zero", 2.81));
            AddExpense(new Expense(DateTime.Now.AddDays(-3), "Jamaican Beef Patties", 12.42));


            // Bind the data grid view data set to the expense list and format the date column
            dgvExpenseData.DataSource = expenseList;
            dgvExpenseData.Columns[0].DefaultCellStyle.Format = "MM/dd/yyyy";
            dgvExpenseData.Columns[2].DefaultCellStyle.Format = "C";
        }

        // METHODS

        /// <summary>
        /// Custom add method to both append to the data array and call
        /// the update balances function to ensure output tbx's are responsive.
        /// </summary>
        public void AddExpense(Expense expense)
        {
            expenseList.Add(expense);
            UpdateBalances();
        }

        /// <summary>
        /// Updates the Expenses and Net Balance output boxes with formatted
        /// values calulated based off of expense data in the table.
        /// </summary>
        private void UpdateBalances()
        {
            // Init local expense sum var
            double sumExpense = 0;

            // Loop to calculate sum of expenses
            foreach (Expense expense in expenseList)
            {
                sumExpense += expense.Amount;
            }

            // Calculate net balance
            double netBal = (double)nudBudget.Value - sumExpense;

            // Set display on controls
            tbxExpenses.Text = sumExpense.ToString("C");
            tbxNetBal.Text = netBal.ToString("C");
        }

        // EVENTS

        /// <summary>
        /// Opens the AddExpense modal form for user to input an expense into the data set.
        /// </summary>
        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            AddExpense addExpense = new AddExpense(this);
            addExpense.ShowDialog();
        }

        /// <summary>
        /// Removes the currently selected expense from the data set, or warns the user
        /// if there is none. Once a removal is processed, output tbx's are updated.
        /// </summary>
        private void btnRemoveExpense_Click(object sender, EventArgs e)
        {
            // If the list is empty, show a warning
            if (expenseList.Count <= 0)
            {
                MessageBox.Show("Expenses table is already empty.", "Empty Table");
            }

            // Otherwise, remove at the matching index and update balances.
            else
            {
                expenseList.RemoveAt(dgvExpenseData.CurrentRow.Index);
                UpdateBalances();
            }
        }

        /// <summary>
        /// Event raised when user modifies the budget. Calls UpdateBalances().
        /// </summary>
        private void nudBudget_ValueChanged(object sender, EventArgs e)
        {
            UpdateBalances();
        }

        /// <summary>
        /// Constructs and shows the details window on click.
        /// </summary>
        private void btnDetails_Click(object sender, EventArgs e)
        {
            // Get the relevant expenses using custom methods
            Expense mostExpense = GetMostExpensiveExpense();
            Expense leastExpense = GetLeastExpensiveExpense();
            Expense mostRecentExepnse = GetMostRecentExpense();
            Expense leastRecentExpense = GetLeastRecentExpense();

            // Convert their relevant properties into the display strings
            string mostAmount = (mostExpense == null) ? "" : $"{mostExpense.Description} for {mostExpense.Amount.ToString("C")}";
            string leastAmount = (leastExpense == null) ? "" : $"{leastExpense.Description} for {leastExpense.Amount.ToString("C")}"; ;
            string mostDate = (mostRecentExepnse == null) ? "" : mostRecentExepnse.Date.ToString("MM/dd/yyyy");
            string leastDate = (leastRecentExpense == null) ? "" : leastRecentExpense.Date.ToString("MM/dd/yyyy");

            // Pass strings into constructor for the details window
            Details details = new Details(
                mostAmount,
                leastAmount,
                mostDate,
                leastDate
            );

            // Show it as modal window.
            details.ShowDialog();
        }

        /// <summary>
        /// Returns the most expensive item in the expense list.
        /// </summary>
        private Expense GetMostExpensiveExpense()
        {
            // return null if empty list.
            if (expenseList.Count == 0) return null;

            // Loop and track lowest expense
            Expense currMostExpense = expenseList[0];
            foreach (Expense expense in expenseList)
            {
                if (expense.Amount > currMostExpense.Amount) currMostExpense = expense;
            }

            // return the result in our temp var
            return currMostExpense;
        }

        /// <summary>
        /// Returns the least expensive item in the expense list.
        /// </summary>
        private Expense GetLeastExpensiveExpense()
        {
            // return null if empty list.
            if (expenseList.Count == 0) return null;

            // Loop and track lowest expense
            Expense currLeastExpense = expenseList[0];
            foreach (Expense expense in expenseList)
            {
                if (expense.Amount < currLeastExpense.Amount) currLeastExpense = expense;
            }

            // return the result in our temp var
            return currLeastExpense;
        }

        /// <summary>
        /// Returns the most expensive item in the expense list.
        /// </summary>
        private Expense GetMostRecentExpense()
        {
            // return null if empty list.
            if (expenseList.Count == 0) return null;

            // Loop and track lowest expense
            Expense currMostExpense = expenseList[0];
            foreach (Expense expense in expenseList)
            {
                if (expense.Date > currMostExpense.Date) currMostExpense = expense;
            }

            // return the result in our temp var
            return currMostExpense;
        }

        /// <summary>
        /// Returns the most expensive item in the expense list.
        /// </summary>
        private Expense GetLeastRecentExpense()
        {
            // return null if empty list.
            if (expenseList.Count == 0) return null;

            // Loop and track lowest expense
            Expense currLeastExpense = expenseList[0];
            foreach (Expense expense in expenseList)
            {
                if (expense.Date < currLeastExpense.Date) currLeastExpense = expense;
            }

            // return the result in our temp var
            return currLeastExpense;
        }

        /// <summary>
        /// Shows the graph view on click.
        /// </summary>
        private void btnVisualize_Click(object sender, EventArgs e)
        {
            Graph graph = new Graph(expenseList);
            graph.ShowDialog();
        }
    }
}

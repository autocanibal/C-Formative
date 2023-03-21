namespace C_Formative
{
    internal class Money
    {
        private double grossIncome, monthlyDeductions, monthlyExpense, rentalAmount, purchasePrice, interestRate, deposit;

        public void setMonthlyDeductions(double monthlyDeductions)
        {
            this.monthlyDeductions = monthlyDeductions;
        }

        public void setGrossIncome(double grossIncome)
        {
            this.grossIncome = grossIncome;
        }

        private int repaymentMonths;
        private bool rent, buy;

        
    }
}

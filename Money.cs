namespace C_Formative
{
    internal class Money
    {
        private double grossIncome, monthlyDeductions, monthlyExpense, rentalAmount, purchasePrice, interestRate, deposit;
        private double incomeAfterTax, remainingMoney;



        public void setGrossIncome(double grossIncome){ this.grossIncome = grossIncome; }

        public void setMonthlyDeductions(double monthlyDeductions){ this.monthlyDeductions = monthlyDeductions; }

        public double setIncomeAfterTax(double grossIncome, double monthlyDeductions) { incomeAfterTax = grossIncome - monthlyDeductions; return incomeAfterTax; }
        
        public void setMonthlyExpenses(double monthlyExpense){ this.monthlyExpense = monthlyExpense; }
        
        public void setRemainingMoney(double incomeAfterTax, double monthlyExpense) { remainingMoney = incomeAfterTax - monthlyExpense; }

        public void setInterestRate(double interestRate){ this.interestRate = interestRate; }

        public void setDeposit(double deposit){ this.deposit = deposit; }

        private int repaymentMonths;
        private bool rent, buy;

        public void setRepaymentMonths(int repaymentMonths){ this.repaymentMonths = repaymentMonths; }

        public void setType(int type)
        {
            if (type == 1)
            {
                buy = true;
                rent = false;
                rentalAmount = 0;
                Console.WriteLine("Please enter the purchase amount: ");
                purchasePrice = double.Parse(Console.ReadLine());

                
            }
            else if (type == 0)
            {
                rent = true;
                buy = false;
                purchasePrice = 0;
                Console.WriteLine("Please enter your rental amount: ");
                rentalAmount = double.Parse(Console.ReadLine());
                double availableFunds = remainingMoney - rentalAmount;
                Console.WriteLine("Your available funds after rent is: R"+availableFunds);

                
            }
        }

        
    }
}

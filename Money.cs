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

        private int repaymentMonths;

        public void setType(int type)
        {
            if (type == 1)
            {
                Console.WriteLine("Please enter the purchase amount: ");
                purchasePrice = double.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the deposit amount: ");
                deposit = double.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the interest rate in decimal form: ");
                interestRate = double.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the length of repayment in months: ");
                repaymentMonths = int.Parse(Console.ReadLine());

                double homeLoanAmount = purchasePrice - deposit;
                double totalLoanAmount = homeLoanAmount * (1 + interestRate * (repaymentMonths / 12));
                double monthlyLoanAmount = totalLoanAmount / repaymentMonths;
                double availableFunds = remainingMoney - monthlyLoanAmount;
                if (monthlyLoanAmount > (grossIncome / 3)) { 
                    Console.WriteLine("You will likely be rejected as the repayment is more than a third of your income");
                    Console.WriteLine("Your monthly repayments would be :R"+monthlyLoanAmount);
                    Console.WriteLine("Your available funds after loan repayment is: R" + availableFunds);

                }
                else { 
                    Console.WriteLine("Your monthly repayments will be :R"+monthlyLoanAmount);
                    Console.WriteLine("Your available funds after loan repayment is: R" + availableFunds);
                }

            }
            else if (type == 0)
            {
                Console.WriteLine("Please enter your rental amount: ");
                rentalAmount = double.Parse(Console.ReadLine());
                double availableFunds = remainingMoney - rentalAmount;
                Console.WriteLine("Your available funds after rent is: R"+availableFunds);

                
            }
        }

        
    }
}

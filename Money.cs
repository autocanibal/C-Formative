namespace C_Formative
{
    internal class Money
    {
        private double grossIncome, monthlyDeductions, monthlyExpense, rentalAmount, purchasePrice, interestRate, deposit;

        public void setGrossIncome(double grossIncome)
        {
            this.grossIncome = grossIncome;
        }

        public void setMonthlyDeductions(double monthlyDeductions)
        {
            this.monthlyDeductions = monthlyDeductions;
        }
        
        public void setRentalAmount(double rentalAmount)
        {
            this.rentalAmount = rentalAmount;
        }
        
        public void setPurchasePrice(double purchasePrice)
        {
            this.purchasePrice = purchasePrice;
        }
        
        public void setInterestRate(double interestRate)
        {
            this.interestRate = interestRate;
        }
        
        public void setDeposit(double deposit)
        {
            this.deposit = deposit;
        }

        private int repaymentMonths;
        private bool rent, buy;
        
        public void setRepaymentMonths(int repaymentMonths)
        {
            this.repaymentMonths = repaymentMonths;
        }
        public void setPurchasePrice(double purchasePrice)
        {
            this.purchasePrice = purchasePrice;
        }

        public void setType(int type)
        {
            if (type == 1)
            {
                buy = true;
                rent = false;
                rentalAmount = 0;
            }
            else if(type == 0)
            {
                rent = true;
                buy = false;
                purchasePrice = 0;
            }
        }

        
    }
}

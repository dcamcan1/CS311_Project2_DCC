namespace CS311_Project2_DCC
{
    public partial class Craps : Form
    {
        private int point, gameRound, diceSum;
        private float balance, bet;

        public Craps()
        {
            InitializeComponent();
            balance = 100;
            gameRound = 1;
            point = 0;
        }//end constructor

        //Verifies that user has entered a valid bet & has money in the bank.
        private bool checkBalance()
        {
            if (balance == 0)
            {
                MessageBox.Show("You are out of money. Please click the reset button.");
                return false;
            }//end if
            else if (txtBet.Text == "")
            {
                MessageBox.Show("You must enter a bet. Please try again.");
                return false;
            }//end else-if
            else
            {
                try
                {
                    bet = float.Parse(txtBet.Text);
                }
                catch (FormatException e)
                {
                    MessageBox.Show("Invalid input. Please try again.");
                    txtBet.Text = "";
                    return false;
                }
                if (bet > balance)
                {
                    MessageBox.Show("Insufficient funds. Please enter a new bet.");
                    txtBet.Text = "";
                    return false;
                }//end if
                else if (bet <= 0)
                {
                    MessageBox.Show("Bet must be greater than 0. Please try again.");
                    return false;
                }//end else if
                else
                {
                    lblBetStatus.Text = "You bet " + bet.ToString("C") + " this round.";
                    return true;
                }
            }//end else
        }//end checkBalance

        private void displayBalance()
        {
            lblBankBalance.Text = "Bank Balance: " + balance.ToString("C");
        }//end displayBalance

        private void displayRound()
        {
            lblRound.Text = "Round " + gameRound;
        }//end displayRound

        private void winDisplay()
        {
            lblResult.Text = "You win! Roll to start a new round.";
            balance += bet;
            point = 0;
            displayBalance();
            gameRound++;
            displayRound();
            txtBet.Text = "";
        }//end winDisplay

        private void loseDisplay()
        {
            lblResult.Text = "You lose! Roll to start a new round.";
            balance -= bet;
            point = 0;
            displayBalance();
            gameRound++;
            displayRound();
            txtBet.Text = "";
        }//end loseDisplay

        private void btnRoll_Click(object sender, EventArgs e)
        {
            calculate_score();
        }//end btnRoll_Click

        private int diceRoll()
        {
            int die1, die2;
            //Generate two random numbers, one for each die
            Random rnd = new Random();
            die1 = rnd.Next(1, 7);
            lblDie1.Text = die1.ToString();
            die2 = rnd.Next(1, 7);
            lblDie2.Text = die2.ToString();

            //Calculate the sum of the dice
            diceSum = die1 + die2;
            return diceSum;
        }//end diceRoll

        /** Determines if this is the initial roll, then calculates if the
         *  player won or lost the round.
         */
        private void calculate_score()
        {
            if (point != 0)
            {
                diceRoll();
                if (diceSum == point)
                {
                    winDisplay();
                }//end if
                else if (diceSum == 7)
                {
                    loseDisplay();
                }//end else if
                else
                {
                    lblResult.Text = "Point is " + point + ". Please roll again.";
                }
            }//end if
            else
            {
                if (!checkBalance())
                {
                    return;
                }//end if
                diceRoll();
                switch (diceSum)
                {
                    case 2:
                    case 3:
                    case 12:
                        loseDisplay();
                        break;
                    case 7:
                    case 11:
                        winDisplay();
                        break;
                    default:
                        lblResult.Text = "Point is " + diceSum + ". Please roll again.";
                        point = diceSum;
                        break;
                }//end switch
            }//end else
        }//end calculate_score

        //Resets form to defaults
        private void btnReset_Click(object sender, EventArgs e)
        {
            balance = 100;
            displayBalance();
            point = 0;
            lblResult.Text = "";
            lblDie1.Text = "";
            lblDie2.Text = "";
            gameRound = 1;
            displayRound();
            lblBetStatus.Text = "";
            txtBet.Text = "";
        }//end btnReset_Click

        private void Craps_Load(object sender, EventArgs e)
        {

        }

        private void btnRules_Click(object sender, EventArgs e)
        {
            String rules = "You roll two 6-sided standard dice. After the dice have come to rest, the sum of the dice is calculated. \n\n" +
                "If the sum is 7 or 11 on the first throw, you win.  If the sum is 2,3, or 12 on the first throw (called \"craps\"), you lose.\n\n" +
                "If the sum is 4, 5, 6, 8, 9, 10 on the first throw that sum becomes your \"point\".\n\n" +
                "To win, you must continue rolling the dice until you \"make your point\" (roll the same value).\n\n" +
                "You lose by rolling a 7 before making your point.";
            String title = "Craps Rules";
            MessageBox.Show(rules, title);
        }
    }//end form
}//end namespace
namespace Treehouse.MediaLibrary
{
    class Album : MediaType
    {
        public readonly string Artist;
        public string Loanee;
        public bool OnLoan;

        public Album(string title, string artist) 
            : base(title)
        {
            Artist = artist;
        }

        public void Loan()
        {
            OnLoan = true;

        }

        public void Loan(string loanee)
        {
            Loanee = loanee;
            Loan();
        }

        public void Return()
        {
            Loanee = null;
            OnLoan = false;
        }

        public string GetDisplayText()
        {
            string text = "Album: " + Title + " by " + Artist;

            if (OnLoan)
            {
                if (!string.IsNullOrEmpty(Loanee))
                {
                    text += " (Currently on loan to " + Loanee + ")";
                }
                else
                {
                    text += " (Currently on Loan)";
                }

            }

            return text;
        }
    }
}
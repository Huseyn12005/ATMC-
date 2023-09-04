namespace ATMC_
{
    internal class BankCard
    {
        private string Bankname;
        public string BankName { get { return Bankname; } set { Bankname = value; } }

        private string Fullname;
        public string FullName { get { return Fullname; } set { Fullname = value; } }

        private string PAN;
        public string Pan 
        { get { return PAN; }
          set 
          {
                if (value.Length == 16 && Int64.TryParse(value, out _))
                    PAN = value;
                else
                {
                    throw new Exception("PAN 16 reqemnen ibaret olmalidir !!!");
                }
          }
        }

        private string PIN;
        public string Pin 
        { 
            get { return PIN; } 
            set
            {
                if(value.Length==4 && Int64.TryParse(value, out _)) PIN = value;
                else
                    throw new Exception("PIN 4 reqemden ibaret olmalidir !!!");
            }
        }

        private string CVC;
        public string cvc { get; set; }

        private DateOnly ExpireDate;

        private int Balance;
        public int balance { get; set; }

        public BankCard(string bankname,string fullname,string pan,string pin,int year,int month)
        {
            BankName = bankname;
            FullName = fullname;
            Pan = pan;
            Pin = pin;
            cvc = Convert.ToString(Random.Shared.Next(100, 999));
            ExpireDate = new DateOnly(year, month, 1);
            balance = Random.Shared.Next(1500, 3000);

        }
    }
}

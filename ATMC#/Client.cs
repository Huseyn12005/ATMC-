namespace ATMC_
{
    internal class Client
    {

        public Guid Id { get; set; }

        private string name;
        public string Name { get { return name; } set { name = value; } }

        private string surname;
        public string Surname { get { return surname; } set { surname = value; } }

        private int age;
        public int Age { get { return age; } set { age = value; } }

        private BankCard card;
        public BankCard Card { get {  return card; } set { card = value; } }

        public Client(string name_,string surname_,int age,BankCard card_ )
        {
            this.Id = Guid.NewGuid();
            this.name = name_;
            this.surname = surname_;
            this.age = age;
            this.card = card_;
            
        }
    }
}

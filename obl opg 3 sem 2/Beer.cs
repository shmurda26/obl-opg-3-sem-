namespace obl_opg_3_sem_2_
{
    public class Beer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Abv { get; set; }

        public override string ToString()
        {
            return $"Beers ID {Id}, Navn: {Name} , Abv {Abv}%";
        }
        public void ValidateName()
        {
            {
                if (Name == null)
                {
                    throw new ArgumentNullException("name cant be null");
                }
                if (Name.Length < 3)
                {
                    throw new ArgumentException("Name cant be less than 3 charechters ");
                }
            }

        }
        public void ValidateAbv()
        {
            if (Abv < 0 || Abv > 67)
            {
                throw new ArgumentOutOfRangeException(nameof(Abv), "ABV Needs to be between 0 & 67");

            }

        }
    }
  }

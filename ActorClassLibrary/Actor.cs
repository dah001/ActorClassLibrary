namespace ActorClassLibrary
{
    public class Actor
    {
        public Actor(string name, int id, int birthYear)
        {
            Name = name;
            Id = id;
            BirthYear = birthYear;
            Validate();//Validere ved oprettelse
        }

        /// <summary>
        /// Henter eller indstiller personens navn.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Henter eller indstiller personens ID.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Henter eller indstiller personens fødselsår.
        /// </summary>
        public int BirthYear { get; set; }

        /// <summary>
        /// Returnerer en streng, der repræsenterer personen.
        /// </summary>
        /// <returns>En streng, der indeholder navn, ID og fødselsår.</returns>
        public override string ToString()
        {
            return $"{Name} {Id} {BirthYear}";
        }

        /// <summary>
        /// Validerer personens navn.
        /// </summary>
        /// <exception cref="ArgumentNullException">Kastes hvis navn er null.</exception>
        /// <exception cref="ArgumentException">Kastes hvis navn har mindre end 4 tegn.</exception>
        public void ValidateName()
        {
            if (Name == null)
            {
                throw new ArgumentNullException(nameof(Name), "Name cannot be null");
            }
            if (Name.Length < 4)
            {
                throw new ArgumentException("Name must be at least 4 characters", nameof(Name));
            }
        }

        /// <summary>
        /// Validerer personens fødselsår.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Kastes hvis fødselsår er tidligere end 1820.</exception>
        public void ValidateBirthYear()
        {
            if (BirthYear <= 1820)
            {
                throw new ArgumentOutOfRangeException(nameof(BirthYear), "BirthYear must be at least 1820");
            }
        }

        /// <summary>
        /// Validerer personens navn og fødselsår.
        /// </summary>
        public void Validate()
        {
            ValidateName();
            ValidateBirthYear();
        }
    }
}

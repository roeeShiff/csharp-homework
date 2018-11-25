
namespace Homework
{
    class Cookie
    {
        //  gluten get+set
        private bool gluten;

        public bool Gluten
        {
            get { return gluten; }
            set{
                if(!gluten)
                gluten =value;
            }
        }

        //  eggs get+set
        private int eggs;

        public int Eggs
        {
            get { return eggs; }
            set {
                if(value>0 || value<=50)
                eggs = value;
            }
        }

        //  suger get+set
        private double sugar;

        public double Suger
        {
            get { return sugar; }
            set
            {
                if (value > 0 || value <= 50)
                    sugar = value;
            }
        }

        //  flour get+set
        private double flour;

        public double Flour
        {
            get { return flour; }
            set {
                if (value > 0 || value <= 50)
                    flour = value;
            }
        }

        public string GetDescription()
        {
            return $"#Gluten- {Gluten}\n#Eggs- {Eggs}\n#Suger- {Suger}\n#Flour- {Flour}" ;
        }

    }
}

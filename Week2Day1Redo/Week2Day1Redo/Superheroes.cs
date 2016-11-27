using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day1Redo
{
    class Superheroes
    {
        private bool hasPowers = true;
        private int numCape;
        private bool hasAlterEgo;
        private bool hasSuperHeroCar;
        private bool hasLoveInterest;
        private bool hasCape;
        private string clarkKent;

        public Superheroes()
        {
        }

        public Superheroes(string supermanName)
        {
            clarkKent = supermanName;
        }

        public int NumCape
        {
            get
            {
                return numCape;
            }

            set
            {
                if (value < 1)
                {
                    numCape = 1;
                }
                else
                {
                    numCape = value;
                }
            }
        }

        public bool HasPowers
        {
            get
            {
                return HasPowers;
            }
            set
            {
                hasPowers = true;
            }
        }

        public int NumCapes
        {
            get
            {
                return numCape;
            }

            set
            {
                if (value <= 0)
                {
                    numCape = 0;
                }
                else
                {
                    numCape = value;
                }
            }
        }
        public bool HasAlterEgo
        {
            get
            {
                return hasAlterEgo;
            }
            set
            {
                hasAlterEgo = value;
            }
        }
        public bool HasSuperHeroCar
        {
            get
            {
                return hasSuperHeroCar;
            }
            set
            {
                hasSuperHeroCar = value;
            }
        }
        public bool HasLoveInterest
        {
            get
            {
                return hasLoveInterest;
            }
            set
            {
                hasLoveInterest = value;
            }
        }
        public bool HasCape
        {
            get
            {
                return hasCape;
            }
            set
            {
                hasCape = value;
            }
        }
        public string Clarkkent
        {
            get
            {
                return clarkKent;
            }
            set
            {
                clarkKent = value;
            }
        }
    }
}

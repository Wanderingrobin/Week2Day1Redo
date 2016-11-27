using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day1Redo
{
    class HorrorVillans
    {
        private bool hasMovies = true;
        private int numMovies;
        private bool hasMask;
        private bool hasSharpWepons;
        private bool hasMagicalProperties;
        private bool hasHerorinesThatDontDie;
        private string ghostFace;

        public HorrorVillans()
        {
        }

        public bool HasMovies
        {
            get
            {
                return hasMovies;
            }
            set
            {
                hasMovies = true;
            }
        }

        public int NumMovies
        {
            get
            {
                return numMovies;
            }

            set
            {
                if (value < 1)
                {
                    numMovies = 3;
                }
                else
                {
                    numMovies = value;
                }
            }
        }
        public bool HasMask
        {
            get
            {
                return hasMask;
            }
            set
            {
                hasMask = true;
            }
        }
        public bool HasSharpWepons
        {
            get
            {
                return hasSharpWepons;
            }
            set
            {
                hasSharpWepons = true;
            }
        }
        public bool HasMagicalProperties
        {
            get
            {
                return hasMagicalProperties;
            }
            set
            {
                hasMagicalProperties = true;
            }
        }
        public bool HasHerorinesThatDontDie
        {
            get
            {
                return hasHerorinesThatDontDie;
            }
            set
            {
                hasHerorinesThatDontDie = true;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day1Redo
{
    class VideoGameSystems
    {
        private bool hasControllers = true;
        private int numControllers;
        private bool hasWifi;
        private bool hasCartridges;
        private bool hasCD;
        private bool hasDigitalDownload;
        private string NintendoSwitch;

      
        public VideoGameSystems(string myNintendo)
        {
            NintendoSwitch = myNintendo;
        }

        public VideoGameSystems(int initialNumControllers)
        {
            numControllers = initialNumControllers;
        }

        public VideoGameSystems()
        {
        }

        public bool HasControllers
        {
            get
            {
                return hasControllers;
            }
            set
            {
                hasControllers = value;
            }
        }

        public int NumControllers
        {
            get
            {
                return numControllers;
            }

            set
            {
                if (value < 1)
                {
                    numControllers = 2;
                }
                else
                {
                    numControllers = value;
                }
            }
        }
        public bool HasWifi
        {
            get
            {
                return hasWifi;
            }
            set
            {
                hasWifi = value;
            }
        }
        public bool HasCartridges
        {
            get
            {
                return hasCartridges;
            }
            set
            {
                hasCartridges = value;
            }
        }
        public bool HasCD
        {
            get
            {
                return hasCD;
            }
            set
            {
                hasCD = value;
            }
        }
        public bool HasDigitalDownload
        {
            get
            {
                return hasDigitalDownload;
            }
            set
            {
                hasDigitalDownload = value;
            }
        }
    }
}

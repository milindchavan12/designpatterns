using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    public class SerialNumberGenerator
    {
        private static volatile SerialNumberGenerator instance;

        public static SerialNumberGenerator Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SerialNumberGenerator();
                }
                return instance;
            }
        }

        //create instance variable
        private int count;

        //private constructor
        private SerialNumberGenerator()
        {

        }

        //instance method
        public virtual int NextSerial 
        {
            get
            {
                return ++count;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingAbrstractInterface
{
    public abstract class File
    {
        public abstract void Save();
        public void Modify() 
        {
            Console.WriteLine("The file was modified.");
        }

        
    }
}

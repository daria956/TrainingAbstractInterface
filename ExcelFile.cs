using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingAbrstractInterface
{
    class ExcelFile : IFile, IPaint
    {
        public string FileName { get; set; }
        public int Size { get; set; }
        public  DateTime CreatedOn { get; set; }

        public void Remove()
        {
            Console.WriteLine("File was removed");
        }

        void IFile.Compress()
        {
            Console.WriteLine("Compressing from IFile"); ;
        }
        void IPaint.Compress()
        {
            Console.WriteLine("Compressing from IPaint"); ;
        }
    }
}

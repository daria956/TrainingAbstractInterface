using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingAbrstractInterface
{
    class WordFile : File,IFile
    {
        public string FileName { get; set; }
        public int Size { get; set; }
        public DateTime CreatedOn { get; set; }
        public void Compress()
        {
            Console.WriteLine("Compressing WordDocumentFile"); ;
        }

        public override void Save()
        {
            Console.WriteLine();
        }
    }
}

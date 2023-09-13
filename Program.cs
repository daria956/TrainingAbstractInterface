namespace TrainingAbrstractInterface
{
    class Program
    {
         static void Main(string[] args)
        {
            ExcelFile excelFile = new ExcelFile();
            excelFile.FileName = "NewFile";
            ((IFile)excelFile).Compress();
            ((IPaint)excelFile).Compress();
            excelFile.Remove();

        }

    }

}
using System;

namespace LinqToSqlCRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            DataAccessLayer Dal = new DataAccessLayer();

            Directory directory = new Directory
            { Firstname="Mihriban",LastName="Karakılıç",Telepone1="5300000000",Telepone2="5420000000",Telepone3="5420000000"};
           
            Dal.Add(directory);

            Console.WriteLine("Kayıt başarıyla eklendi.");

            Directory directory2 = new Directory
            { DirectoryId=1,Firstname = "Asya Mira", LastName = "Karakılıç", Telepone1 = "5300000000", Telepone2 = "5420000000", Telepone3 = "5420000000",EmailAddress="asya@hotmail.com" };
            Dal.Update(directory2);

            Console.WriteLine("Güncelleme yapıldı.");

            Dal.Delete(3);
            Console.WriteLine("Kayıt silindi.");


            Console.Read();
        }
    }
}
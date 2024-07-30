using OOP1;

class Program
{
    public static void Main(string[] args)
    {
        //nesnemizi oluşturuyoruz
        //we are creating our object
        Person person = new Person();

        //Tanımlamaları yapıyoruz
        //we are defining the properties
        person.Name = "Sertan";
        person.Surname = "Bozkuş";
        person.DateOfBirth = 1993;
        person.Role = "Öğrenci";
        person.ListPeople();
        


        person.Name = "Aleyna";
        person.Surname = "Avcı";
        person.DateOfBirth = 1995;
        person.Role = "Öğrenci";
        person.ListPeople();
        

        person.Name = "Murat";
        person.Surname = "Gögebakan";
        person.DateOfBirth = 1970;
        person.Role = "Öğrenci";
        person.ListPeople();

        person.Name = "Hayri";
        person.Surname = "Tutucu";
        person.DateOfBirth = 1985;
        person.Role = "Öğretmen";
        person.ListPeople();

        person.Name = "Mahmut";
        person.Surname = "Tuncer";
        person.DateOfBirth = 1970;
        person.Role = "Öğretmen";
        person.ListPeople();

       



    }
}
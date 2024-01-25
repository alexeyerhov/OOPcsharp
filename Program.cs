class Person 
{ 
    public string Name { get; set; } 
    public string Gender { get; set; } 
    public int Age { get; set; } 
    public List<Person> Parents { get; set; } 
    public Person Spouse { get; set; } // добавлен атрибут spouse для хранения информации о супруге/супруге

    public void SetSpouse(Person spouse) 
    { 
        Spouse = spouse; 
        spouse.Spouse = this; // установить взаимную ссылку
    } 
} 
 
class Family 
{ 
    public List<Person> Members { get; set; }

    public Family() 
    { 
        Members = new List<Person>(); 
    }

    public void AddMember(Person person) 
    { 
        Members.Add(person); 
    } 
 
    public List<Person> GetCloseRelatives(Person person) 
    { 
        List<Person> relatives = new List<Person>(); 
        // Логика для определения близких родственников, включая супруга/супругу
        // Пример: relatives.Add(person.Spouse); 
        return relatives; 
    } 
 
    public void PrintFamilyTree() 
    { 
        // Логика для вывода генеалогического дерева, включая супругов
    } 
}
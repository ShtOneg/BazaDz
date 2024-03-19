using static System.Runtime.InteropServices.JavaScript.JSType;

void Square(int n, string symbol) {
    for (int i = 0; i < n; i++) {
        for (int j = 0; j < n; j++) {
            Console.Write(symbol);
        }
        Console.WriteLine();
    }
}

Square(5, "&");

bool Palindrom(int integer) {
    string t_integer = integer.ToString();
    int temp = 0;
    for (int i = 0; i < t_integer.Length / 2; i++) {
        if (t_integer[i] == t_integer[t_integer.Length - 1 - i]) {
            temp++;
        }
    }
    if (temp == t_integer.Length / 2) {
        return true;
    }
    return false;
}

if (Palindrom(12321))
{
    Console.WriteLine("Число палиндром");
}
else {
    Console.WriteLine("Число не полиндром");
}

int[] Filter(int[] integers, int[] filters) {
    List<int> temp = new List<int>(); ;
    int l = 0;
    foreach (int i in integers) {
            if (!filters.Contains(i)) {
            temp.Add(i);
            }
    }


    return temp.ToArray();
}

foreach (int i in Filter(new int[] { 1, 2, 6, -1, 88, 7, 6 }, new int[] { 6, 88, 7 })) {
Console.Write($"{i} ");
}

public class Website {
    private int ip;
    private string name;
    private string path;
    private string description;

    public int Ip { get => ip; set => ip = value; }
    public string Name { get => name; set => name = value; }
    public string Path { get => path; set => path = value; }
    public string Description { get => description; set => description = value; }

    public Website(int ip, string name, string path, string description)
    {
        Ip = ip;
        Name = name;
        Path = path;
        Description = description;
    }

    public void print() {
        Console.WriteLine(this.name, this.description, this.path);
        Console.WriteLine(this.ip);
    }
}

public class Magazine {
    private string name;
    private string date;
    private string description;
    private int phone_number;
    private string email;

    public string Name { get => name; set => name = value; }
    public string Date { get => date; set => date = value; }
    public string Description { get => description; set => description = value; }
    public int Phone_number { get => phone_number; set => phone_number = value; }
    public string Email { get => email; set => email = value; }

    public Magazine(string name, string date, string description, int phone_number, string email)
    {
        this.Name = name;
        this.Date = date;
        this.Description = description;
        this.Phone_number = phone_number;
        this.Email = email;
    }

    public void print() {
        Console.WriteLine(name, date, description, email);
        Console.WriteLine(phone_number);
    }
}

public class Shop {
    private string name;
    private string adress;
    private string description;
    private int phone_number;
    private string email;

    public Shop(string name, string dadress, string description, int phone_number, string email)
    {
        this.Name = name;
        this.Adress = adress;
        this.Description = description;
        this.Phone_number = phone_number;
        this.Email = email;
    }

    public string Name { get => name; set => name = value; }
    public string Adress { get => adress; set => adress = value; }
    public string Description { get => description; set => description = value; }
    public int Phone_number { get => phone_number; set => phone_number = value; }
    public string Email { get => email; set => email = value; }

    public void print()
    {
        Console.WriteLine(name, adress, description, email);
        Console.WriteLine(phone_number);
    }
}
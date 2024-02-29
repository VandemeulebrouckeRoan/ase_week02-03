public class Person{
    #region Fields 
    private string _name;
    private string _lastname;
    private int _age;
    private List<Address> _address;
    private List<string> _email;
    private List<string> _phone;
    #endregion


    #region Constructor
    public Person(string name, string lastname, int age, List<Address> address, List<string> email, List<string>phone){
        _name = name;
        _lastname = lastname;
        _age = age;    
        _address = address;
        _email = email;
        _phone = phone;
    }
    #endregion
    

    #region Properties
    public string Name{
        get{
            return _name;
        }
        set{
            _name = value;
        }
    }

    public string Lastname{
        get{
            return _lastname;
        }
        set{
            _lastname = value;
        }
    }

    public int Age{
        get{
            return _age;
        }
        set{
            _age = value;
        }
    }

    public List<Address> Addresses{
        get{
            return _address;
        }
        set{
            _address = value;
        }
    }

    public List<string> Email{
        get{
            return _email;
        }
        set{
            _email = value;
        }
    }

    public List<string> Phone{
        get{
            return _phone;
        }
        set{
            _phone = value;
        }
    }
    #endregion


    #region Method


    public override string ToString(){
        string x = "";
        x += $"Person Information: \n";
        x += $"Name: {Name} \n";
        x += $"Last name: {Lastname} \n";
        x += $"Age: {Age} \n";
        foreach(Address adrs in Addresses){
            x += $"Address: {adrs}\n";
        }
        foreach(string e_m in Email){
            x += $"Email: {e_m}\n";
        }
        foreach(string p in Phone){ 
        x += $"Phone: {p}\n";
        }
        return x;

    }

    #endregion
}

public class Address{
    #region Fields;
    private string _street;
    private int _house_n;
    private int _zipcode;
    private string _city;
    private string _country;

    #endregion

    #region Constructor
    public Address(string street, int house_n, int zipcode,string city, string country){
        _street = street;
        _house_n = house_n;
        _zipcode = zipcode;    
        _city = city;
        _country = country;
    }
    #endregion

    #region Properties
    public string Street{
        get{
            return _street;
        }
        set{
            _street = value;
        }
    }

    public int House_n{
        get{
            return _house_n;
        }
        set{
            _house_n = value;
        }
    }

    public int Zipcode{
        get{
            return _zipcode;
        }
        set{
            _zipcode = value;
        }
    }

    public string City{
        get{
            return _city;
        }
        set{
            _city = value;
        }
    }

    public string Country{
        get{
            return _country;
        }
        set{
            _country = value;
        }
    }

    #endregion


    #region Method


    public override string ToString(){
        return $"{Street}, {House_n}, {Zipcode}, {City}, {Country}";
    }
    #endregion

} 
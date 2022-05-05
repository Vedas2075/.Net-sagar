
using System;

public class Person
{//full property syntax;
    public string name
    {
        get
        {
            return name;
        }
        set
        {
            if (value.length >2 )
            name = value;
        }
    }

     string name;
     //auto implemented property.
    public DateTime dob{get; set;} 

    //readonly property
    public string address{get;}

public Gender Sex(get; Private set;) =  Gender.Female;

   
}


public enum Gender
{
    Male,
    Female,
    Others
}
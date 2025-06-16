using System.Collections.Generic;
using System;
using UnityEngine;


[Serializable]
public class Country
{
    public Name name;
    public long population;
}

[Serializable]
public class Name
{
    public string common;
}


[Serializable]
public class CountryList
{
    public List<Country> countries;
}

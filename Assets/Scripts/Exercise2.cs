using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise2 : MonoBehaviour
{
    public int year = 0;
    public string zodiac = "";

    private void Start()
    {
        if (year == 1971 || year == 1983 || year == 1995 || year == 2007 || year == 2019)
        {
            Debug.Log($"You were born in {year} so your Chinese zodiac is Pig");
        }
        else if (year == 1970 || year == 1982 || year == 1994 || year == 2006 || year == 2018)
        {
            Debug.Log($"You were born in {year} so your Chinese zodiac is Dog");
        }
        else if (year == 1969 || year == 1981 || year == 1993 || year == 2005 || year == 2017)
        {
            Debug.Log($"You were born in {year} so your Chinese zodiac is Rooster");
        }
        else if (year == 1968 || year == 1980 || year == 1992 || year == 2004 || year == 2016)
        {
            Debug.Log($"You were born in {year} so your Chinese zodiac is Monkey");
        }
        else if (year == 1965 || year == 1974 || year == 1986 || year == 2001 || year == 2013)
        {
            Debug.Log($"You were born in {year} so your Chinese zodiac is Sheep");
        }
        else if (year == 1966 || year == 1978 || year == 1990 || year == 2002 || year == 2014)
        {
            Debug.Log($"You were born in {year} so your Chinese zodiac is Horse");
        }
        else if (year == 1965 || year == 1977 || year == 1989 || year == 2001 || year == 2013)
        {
            Debug.Log($"You were born in {year} so your Chinese zodiac is Snake");
        }
        else if (year == 1964 || year == 1976 || year == 1988 || year == 2000 || year == 2012)
        {
            Debug.Log($"You were born in {year} so your Chinese zodiac is Dragon");
        }
        else if (year == 1963 || year == 1975 || year == 1987 || year == 1999 || year == 2011)
        {
            Debug.Log($"You were born in {year} so your Chinese zodiac is Rabbit");
        }
        else if (year == 1974 || year == 1986 || year == 1998 || year == 2010 || year == 2022)
        {
            Debug.Log($"You were born in {year} so your Chinese zodiac is Tiger");
        }
        else if (year == 1973 || year == 1985 || year == 1997 || year == 2009 || year == 2021)
        {
            Debug.Log($"You were born in {year} so your Chinese zodiac is Ox");
        }
        else if (year == 1967 || year == 1979 || year == 1991 || year == 2003 || year == 2015)
        {
            Debug.Log($"You were born in {year} so your Chinese zodiac is Rat");
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class GradeSchool
{

    private readonly SortedDictionary<int, SortedSet<string>> gradeInformation = new SortedDictionary<int, SortedSet<string>>();
    public void Add(string name, int grade) 
    {
        if (gradeInformation.ContainsKey(grade))
            gradeInformation[grade].Add(name);
        else
            gradeInformation.Add(grade, new SortedSet<string> { name });
    }
    public IEnumerable<string> Roster() => gradeInformation.SelectMany(pair => pair.Value).AsEnumerable();
    public IEnumerable<string> Grade(int grade) => gradeInformation.Where(pair => pair.Key == grade).SelectMany(pair => pair.Value).AsEnumerable();
    
}

  
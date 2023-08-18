﻿namespace LeetCodePractices;

public class Solut
{
    public int RomanToInt(string s)
    {
        Dictionary<char, int> romanValues = new Dictionary<char, int>
        {
            {'I',1 },
            {'V',5},
            {'X',10},
            {'L',50 },
            {'C',100 },
            {'D',500 },
            {'M',1000 }
        };
        int result = 0;
        for(int i = 0; i < s.Length; i++)
        {
            if(i<s.Length-1&& romanValues[s[i]] < romanValues[s[i + 1]])
            {
                result -= romanValues[s[i]];
            }
            else
            {
                result += romanValues[s[i]];
            }
        }
        return result;
    }
}

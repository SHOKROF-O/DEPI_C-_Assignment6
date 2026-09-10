using System;
 
public enum Gender
{
    M,
    F
}
 
[Flags]
public enum SecurityLevel
{
    Guest = 1,
    Developer = 2,
    Secretary = 4,
    DBA = 8
}
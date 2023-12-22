using System;
using System.Collections.Generic;

public class VisualDaForca
{
    public static Dictionary<int, string> VisualDasVidas = new Dictionary<int, string>
    {
        { 5, @"
        _________
       | /       |
       |/      ( X) )
       |          
       |          
       |
    " },
        { 4, @"
        _________
       | /       |
       |/      ( :) )
       |          
       |          
       |
    " },
        { 3, @"
        _________
       | /       |
       |/      ( =/ )       
       |          
       |          
       |
    " },
        { 2, @"
        _________
       | /       |
       |/      ( =( )
       |          
       |          
       |
    " },
        { 1, @"
        _________
       | /       |
       |/      ( x'( )
       |         |
       |          
       |
    " },
        { 0, @"
        _________
       | /       |
       |/       ( XP )
       |         |
       |        / \\
       |
    " }
    };
}

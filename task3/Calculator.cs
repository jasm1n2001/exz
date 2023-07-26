namespace task3;

public class Calculator
{
    int firstnum;
    int secondnum;
     
     public Calculator(int _firstnum, int _secondnum)
     {
        firstnum = _firstnum;
        secondnum = _secondnum;
     }

     public string Sum(int firstnum, int secondnum)
     {
       return  $"{firstnum} + {secondnum} = {firstnum + secondnum}";
     }

     public string Subtract(int firstnum, int secondnum) 
     {
         return $"{firstnum} - {secondnum} = {firstnum - secondnum}";
     }

     public string Multiplication(int firstnum, int secondnum)
     {
         return $"{firstnum} * {secondnum} = {firstnum * secondnum}";
     }

     
      
    public string Division(int firstnum, int secondnum) 
     {
         return $"{firstnum} / {secondnum} = {firstnum / secondnum}";
     }


}

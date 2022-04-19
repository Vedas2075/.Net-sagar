
void comparision()
{
    byte a=20;
    byte b=30;
    byte c=41;

    if(a>b){
        if(a>c){
            Console.WriteLine("Number one is gretest");
        }
        else{
            Console.WriteLine("Number three is greater");
        }
        else if(b>c){
            Console.Write("Number two is the largest");
        else{
         Console.Write("Number three is the largest");
            }
        }
    }
}
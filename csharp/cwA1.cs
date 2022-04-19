
void comparision()
{
    byte a=20;
    byte b=30;
    byte c=41;

    if(a>b){
        if(a>c){
            Console.WriteLine("a is gretest");
        }
        else{
            Console.WriteLine("c is greater");
        }
        else if(b>c){
            Console.Write("b is the largest");
        else{
         Console.Write("c is the largest");
            }
        }
    }
}
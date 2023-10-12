namespace CircleAreaCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Skapa en ny klass som heter Circle
            //Skapa en konstruktor som tar in radien 
            //Skapa en metod som heter GetCircle och som räknar ut arean på en cirkel 
            //Räkan ut arean på en cirkel med radien 5 och en med radien 6 

            Circle firstCircle = new Circle(5);
            Circle secondCircle = new Circle(6);

            firstCircle.GetRadius();
            secondCircle.GetRadius();


        }
    }
}
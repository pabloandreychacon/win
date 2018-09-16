using System;

namespace ControlConsole.DependencyInjectionExample
{
    public class InjectedRepository : InterfaceDIRepository 
    {
        // deben implementarse todos los metodos de la Interface en esta clase
        public void getShit()
        {
            Console.WriteLine("getShit en la clase repository: " + this.GetType().FullName);
        }
    }
}

namespace ControlConsole.DependencyInjectionExample
{
    public class InjectedClaseFinal
    {
        private InterfaceDIRepository myObjectInterfacedRepository;

        public InjectedClaseFinal() { 
            myObjectInterfacedRepository = new InjectedRepository();
        }

        public InjectedClaseFinal (InterfaceDIRepository myObjectInterfacedParam)
	    {
            myObjectInterfacedRepository = myObjectInterfacedParam;
        }

        public void getShit() {
            myObjectInterfacedRepository.getShit();
        }
    }
}
using System ;
using System Threading;

namespace AdvancedTopics
{

	 internal class Program
	 {
      static  void Main(string[] args)
			{
				Thread t  = new  Thread(InvokeWorker);

				t.Start();

				Console.WriteLine("Writing to  console from  main  thead !");
			}

			public  static void InvokeWorker()
			{
				Console.WriteLine("Letting  worker  therad  to  sleep  10 seconds")
				Thead.Sleep(1000)
				Console.WriteLine("Worker thead  woke up")
			}
	 }
}
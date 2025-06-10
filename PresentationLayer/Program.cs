using System.Windows.Forms;
using System.Threading;

namespace PresentationLayer
{
    public static class Program
    {
		[STAThread]
		static void Main()
        {
            Display display = new Display();
        }
    }
}
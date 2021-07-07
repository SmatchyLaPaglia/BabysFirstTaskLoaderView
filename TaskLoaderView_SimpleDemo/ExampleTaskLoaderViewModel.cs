using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using Sharpnado;
using Sharpnado.Presentation.Forms;

namespace TaskLoaderView_SimpleDemo
{
    public class ExampleTaskLoaderViewModel
    {
        public ExampleTaskLoaderViewModel()
        {
            Loader = new TaskLoaderNotifier<string>();
        }

        public TaskLoaderNotifier<string> Loader { get; }

        public void Load()
        {
            //This is where you put the function for the async code that will run
            //inside the task notifier--for example, getting records of any kind
            //from an internet database.
            //Note that in this case the return value of that function is not used.
            //You can't use DBNull as a return value, however, because returning null
            //is interpreted by the notifier as "no result" and shows a failure screen.
            Loader.Load(_ => TestDownloadTask());

            //The Load() function can be called from anywhere; in this case it is called
            //from an override of OnAppearing in the code-behind of the MainPage
        }

        public async Task<string> TestDownloadTask()
        {
            Debug.WriteLine("running image getting");

            var httpClient = new HttpClient();
            for (int i = 0; i < 30; i++)
            {
                //just a time-consuming errand
                await httpClient.GetAsync("https://picsum.photos/200/300");
            }

            Debug.WriteLine("finished image getting");
            return "this string is returned but is meaningless in this example";
        }
    }
}

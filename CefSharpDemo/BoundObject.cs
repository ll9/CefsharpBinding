using CefSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CefSharpDemo
{
    public class BoundObject
    {
        public string MyProperty { get; set; }
        public string MyMethod()
        {
            MessageBox.Show("JS CALL");
            // Do something really cool here.
            return "C# stuff";
        }

        public void TestCallback(IJavascriptCallback javascriptCallback)
        {
            const int taskDelay = 1500;

            Task.Run(async () =>
            {
                await Task.Delay(taskDelay);

                using (javascriptCallback)
                {
                    //NOTE: Classes are not supported, simple structs are
                    var response = new CallbackResponseStruct("This callback from C# was delayed " + taskDelay + "ms");
                    await javascriptCallback.ExecuteAsync(response);
                }
            });
        }
    }
}

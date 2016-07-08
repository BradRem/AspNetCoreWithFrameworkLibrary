using System;

namespace FrameworkLibrary
{
    public class MyTest
    {
        public string HelloWorld()
        {
            return $"Hello, World! {DateTime.Now.ToString()}";
        }
    }
}

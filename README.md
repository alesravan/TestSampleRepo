To perform data-driven unit testing in C# using external files, you can leverage frameworks like NUnit or MSTest and read the test data from files such as CSV, JSON, or Excel.

Here's an example of how you can achieve this using NUnit and a CSV file:

Add the NUnit and CsvHelper packages to your project. You can install them via NuGet.

Create a CSV file with your test data. For example, let's assume we have a file named "testdata.csv" with the following content:

css
Copy code
Input,ExpectedOutput
1,2
3,6
5,10
Create a test class and method in your C# project using NUnit. In this example, we'll use the TestCaseSource attribute to read the test data from the CSV file:
csharp
Copy code
using NUnit.Framework;
using CsvHelper;
using System.Collections;
using System.Collections.Generic;
using System.IO;

public class MyTestClass
{
    private static IEnumerable TestData()
    {
        using (var reader = new StreamReader("testdata.csv"))
        using (var csv = new CsvReader(reader))
        {
            csv.Configuration.HasHeaderRecord = true;
            csv.Read();
            csv.ReadHeader();

            while (csv.Read())
            {
                var input = csv.GetField<int>("Input");
                var expectedOutput = csv.GetField<int>("ExpectedOutput");
                yield return new object[] { input, expectedOutput };
            }
        }
    }

    [TestCaseSource(nameof(TestData))]
    public void MyTestMethod(int input, int expectedOutput)
    {
        // Your test code here using the input and verifying against the expected output
        Assert.AreEqual(expectedOutput, YourMethodUnderTest(input));
    }

    private int YourMethodUnderTest(int input)
    {
        // Your implementation here
        return input * 2;
    }
}
Run the tests using your chosen test runner (such as NUnit Console Runner or Visual Studio's Test Explorer), and the test cases will be executed using the data read from the CSV file.
This approach allows you to separate your test data from the test code, making it easier to maintain and update the test data as needed. You can also adapt this approach to read data from JSON, Excel, or other file formats by using the appropriate libraries and parsing techniques.

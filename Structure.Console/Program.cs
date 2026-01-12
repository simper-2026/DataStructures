
using Stopwatch = System.Diagnostics.Stopwatch;

int count = 1;

Stopwatch sw = new Stopwatch();

// sw = Stopwatch.StartNew();
// StringConcatentation(count);
// sw.Stop();
// Console.WriteLine($"Time in ms: {sw.ElapsedMilliseconds}");
sw = Stopwatch.StartNew();
StringBuilder(count);
sw.Stop();
Console.WriteLine($"Time in ms: {sw.ElapsedMilliseconds}");
sw = Stopwatch.StartNew();
ListAdd(count);
sw.Stop();
Console.WriteLine($"Time in ms: {sw.ElapsedMilliseconds}");


void StringConcatentation(int count)
{
    string result = "";

    for (int i = 0; i < count; i++)
    {
        result = result + ".";
    }
}

void StringBuilder(int count)
{
    var sb = new System.Text.StringBuilder();

    for (int i = 0; i < count; i++)
    {
        sb.Append(".");
    }

    string result = sb.ToString();
}

void ListAdd(int count)
{
    var list = new List<char>();

    for (int i = 0; i < count; i++)
    {
        list.Add('.');
    }
    string result = new string(list.ToArray());
}
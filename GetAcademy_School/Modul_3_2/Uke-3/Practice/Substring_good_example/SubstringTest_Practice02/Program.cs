// Todo substring the text inside ()
string text = "whatever...(i)..fdaf(would)  adsffa(like)adlfadf(to)a-lfa  (have)adfa (this)adfkam (text).";
var results = new List<string>();
while (true)
{
    int count = 0;
    int openingPosition = text.IndexOf('(');

    if (openingPosition == -1) break;

    int closingPosition = text.IndexOf(')');

    openingPosition += 1;

    int length = closingPosition - openingPosition;

    Console.WriteLine(text.Substring(openingPosition, length));
    var substring = text.Substring(openingPosition, length);
    results.Add(substring);

    text = text.Substring(closingPosition + 1);

    count++;
}
Console.ReadLine();






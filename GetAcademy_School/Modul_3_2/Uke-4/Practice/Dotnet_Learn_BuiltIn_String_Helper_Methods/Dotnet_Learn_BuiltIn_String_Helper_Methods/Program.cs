string message = "(inside parentheses_1) and som text (inside parentheses_2) even more text (inside parentheses_3).";

while (true)
{
    // find the first position of "("
    int openingPosition = message.IndexOf('(');
    // if it finds more then one , break the loop
    if (openingPosition == -1) break; // -1 means it didnt find any -> so it have found the last one.(this case it can find 3 opening positions)

    int closingPosition = message.IndexOf(')');

    openingPosition += 1; // to correcly position before subrtimming, else it will also take with "(" in the substring. 

    // Note. it is important to do the += 1 before the one below, else , it will only move the index start without count in the length correcly, result would be "inside parentheses_1)" keeping the ")".

    int length = closingPosition - openingPosition; // finding the length of the string : case: indexStart = 10, indexEnd = 20 -> indexEnd(20) - indexStart(10) = 10.
    Console.WriteLine(message.Substring(openingPosition, length));

    // without the code below it will loop endlessly, because it is starting the operation from the start every time.
    // so on the first loop we remove "(inside parentheses_1)", so on the next loop he will start looking for the next "openingPosition and closingPosition" til it doesnt find eny. 
    // it wil then reach the if statements above, breaking the loop.Done !
    // on the last iteration it is only left with the "."
    message = message.Substring(closingPosition +1);
    Console.WriteLine(message);


    Console.ReadLine();
}

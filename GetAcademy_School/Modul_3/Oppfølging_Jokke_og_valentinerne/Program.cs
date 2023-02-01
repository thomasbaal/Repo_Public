



using Jokke_og_valentinerne;

Console.Write("Gyldig tips: \r\n - H, U, B\r\n - halvgardering: HU, HB, UB\r\n - helgardering: HUB\r\nHva har du tippet for denne kampen? ");
var bet = Console.ReadLine();


var match = new Match(bet);

match.RunMatch();


match.BettingResult();




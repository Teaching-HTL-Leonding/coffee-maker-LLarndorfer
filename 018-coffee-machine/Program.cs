//*Coffee Machine
//*Lukas Larndorfer
Console.OutputEncoding = System.Text.Encoding.Default;
#region Define vars & Consts
decimal money = 0;
decimal choice = 0;
decimal twoeuropieces = 0;
decimal oneeuropieces = 0;
decimal fiftycentpieces = 0;
const int CAPPUCINO = 1;
const int TEA = 2;
const int CACAO = 3;
const int NOTHING_ELSE = 4;
const decimal PRICE_CAPPUCINO = 3.5m;
const decimal PRICE_TEA = 1.5m;
const decimal PRICE_CACAO = 2.5m;
const string NOT_ENOUGH_MONEY = "You got too less money. Try again:";
const string ERROR_MESSAGE = "You've entered something wrong. Please try again.";
const string REMINDER = " Please notice that the amount should be a multiple of 0.50€.";
const string LEAVE_MESSAGE = "Goodbye, have a nice day!👋";
const string NOCHANGE = "You have got no Change.❌";
const string MONEYINMACHINE = "How much money have you put into the vending machine? (multiple of 0.50€)💸";
#endregion
#region  While Loop Money put into machine
do
{
    Console.WriteLine(MONEYINMACHINE);
    money = decimal.Parse(Console.ReadLine()!);
    if (money % 0.5m != 0)
    {
        Console.WriteLine(ERROR_MESSAGE + REMINDER);
    }

} while (money % 0.5m != 0);
#endregion
#region While Loop Product Choosing
while (choice != 4 && money > PRICE_TEA)
{
    Console.Write("Which product do you want to buy?\n1)");
    Console.ForegroundColor = ConsoleColor.Yellow;
    System.Console.Write(" Cappucino☕ ");
    Console.ResetColor();
    System.Console.Write("(3.50€), 2) ");
    Console.ForegroundColor = ConsoleColor.Green;
    System.Console.Write("Tea🍵");
    Console.ResetColor();
    System.Console.Write("(1.50€), 3) ");
    Console.ForegroundColor = ConsoleColor.Blue;
    System.Console.Write("Cacao☕ ");
    Console.ResetColor();
    System.Console.Write("(2.50€), 4) Nothing else❌: ");
    choice = decimal.Parse(Console.ReadLine()!);
    switch (choice)
    {
        case CAPPUCINO:
            if (money < PRICE_CAPPUCINO)
            {
                Console.WriteLine(NOT_ENOUGH_MONEY);
            }
            else
            {
                money -= PRICE_CAPPUCINO;
            }
            break;

        case TEA:
            if (money < PRICE_TEA)
            {
                Console.WriteLine(NOT_ENOUGH_MONEY);
            }
            else
            {
                money -= PRICE_TEA;
            }
            break;

        case CACAO:
            if (money < PRICE_CACAO)
            {
                Console.WriteLine(NOT_ENOUGH_MONEY);
            }
            else
            {
                money -= PRICE_CACAO;
            }
            break;

        case NOTHING_ELSE:

            break;


        default:
            Console.WriteLine(ERROR_MESSAGE);
            break;
    }

}
#endregion
#region Change
twoeuropieces = (int)money / 2;
money = money % 2;
oneeuropieces = (int)money / 1;
money = money % 1;
fiftycentpieces = money / 0.50m;

if (money > 0 || fiftycentpieces > 0 || twoeuropieces > 0 || oneeuropieces > 0)
{
    Console.WriteLine($"In total you get back, {twoeuropieces * 2 + oneeuropieces + money}€.");
    if (twoeuropieces > 0)
    {
        System.Console.WriteLine($"You get {twoeuropieces}x2€ Pieces.");
    }
    if (oneeuropieces > 0)
    {
        System.Console.WriteLine($"You get {oneeuropieces}x1€ Pieces.");
    }
    if (fiftycentpieces > 0)
    {
        System.Console.WriteLine($"You get {fiftycentpieces}x0,50€ Piece back.");
    }
}
else
{
    Console.WriteLine(NOCHANGE);
}
#endregion
System.Console.WriteLine(LEAVE_MESSAGE);



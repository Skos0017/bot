using System;

public class TradeFuturesAi
{
    static void Main(string[] args)
    {
        // Define variables
        float currentPrice, priceChange;
        int numTrades;

        // Read information from the screen
        Console.WriteLine("Enter the current price of the asset:");
        currentPrice = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter the change in the asset's price:");
        priceChange = float.Parse(Console.ReadLine());

        // Logic to open/close trade
        if (priceChange > 0)
        {
            // Open trades based on current price
            int numTrades = (int)(currentPrice / priceChange);
            while (numTrades > 0)
            {
                // Open trade and reduce number of trades
                Console.WriteLine("Opening trade with price: " + currentPrice);
                currentPrice -= priceChange;
                numTrades -= 1;
            }
        }
        else
        {
            // Close trades based on current price
            int numTrades = (int)(currentPrice / priceChange);
            while (numTrades > 0)
            {
                // Close trade and reduce number of trades
                Console.WriteLine("Closing trade with price: " + currentPrice);
                currentPrice -= priceChange;
                numTrades -= 1;
            }
        }
    }
}
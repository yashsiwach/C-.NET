using System;
using System.Collections.Generic;
using System.Linq;

public interface IFinancialInstrument
{
    string Symbol { get; }
    decimal CurrentPrice { get; }
    InstrumentType Type { get; }
}

public enum InstrumentType { Stock, Bond, Option, Future }
public enum Trend { Upward, Downward, Sideways }

// 1. Generic Portfolio
public class Portfolio<T> where T : IFinancialInstrument
{
    private Dictionary<T, int> _holdings = new();

    public void Buy(T instrument, int quantity, decimal price)
    {
        if (quantity <= 0 || price <= 0) return;

        if (_holdings.ContainsKey(instrument))
            _holdings[instrument] += quantity;
        else
            _holdings[instrument] = quantity;
    }

    public decimal? Sell(T instrument, int quantity, decimal currentPrice)
    {
        if (!_holdings.ContainsKey(instrument)) return null;
        if (quantity <= 0 || quantity > _holdings[instrument]) return null;

        _holdings[instrument] -= quantity;
        if (_holdings[instrument] == 0)
            _holdings.Remove(instrument);

        return quantity * currentPrice;
    }

    public decimal CalculateTotalValue()
    {
        decimal total = 0;
        foreach (var h in _holdings)
            total += h.Value * h.Key.CurrentPrice;
        return total;
    }

    public (T instrument, decimal returnPercentage)? GetTopPerformer(Dictionary<T, decimal> purchasePrices)
    {
        T best = default;
        decimal bestReturn = decimal.MinValue;

        foreach (var h in _holdings)
        {
            if (!purchasePrices.ContainsKey(h.Key)) continue;

            decimal purchasePrice = purchasePrices[h.Key];
            decimal currentPrice = h.Key.CurrentPrice;

            decimal returnPct = ((currentPrice - purchasePrice) / purchasePrice) * 100;

            if (returnPct > bestReturn)
            {
                bestReturn = returnPct;
                best = h.Key;
            }
        }

        if (best == null) return null;
        return (best, bestReturn);
    }

    public IEnumerable<T> GetInstruments()
    {
        return _holdings.Keys;
    }
}

// 2. Specialized instruments
public class Stock : IFinancialInstrument
{
    public string Symbol { get; set; }
    public decimal CurrentPrice { get; set; }
    public InstrumentType Type => InstrumentType.Stock;
    public string CompanyName { get; set; }
    public decimal DividendYield { get; set; }
}

public class Bond : IFinancialInstrument
{
    public string Symbol { get; set; }
    public decimal CurrentPrice { get; set; }
    public InstrumentType Type => InstrumentType.Bond;
    public DateTime MaturityDate { get; set; }
    public decimal CouponRate { get; set; }
}

// 3. Trading Strategy
public class TradingStrategy<T> where T : IFinancialInstrument
{
    public void Execute(Portfolio<T> portfolio,IEnumerable<T> marketData,Func<T, bool> buyCondition,Func<T, bool> sellCondition)
    {
        foreach (var instrument in marketData)
        {
            if (buyCondition(instrument))
                portfolio.Buy(instrument, 10, instrument.CurrentPrice);

            if (sellCondition(instrument))
                portfolio.Sell(instrument, 5, instrument.CurrentPrice);
        }
    }

    public Dictionary<string, decimal> CalculateRiskMetrics(IEnumerable<T> instruments)
    {
        var prices = instruments.Select(i => i.CurrentPrice).ToList();

        if (prices.Count == 0)
            return new Dictionary<string, decimal>();

        decimal avg = prices.Average();
        decimal variance = prices.Sum(p => (p - avg) * (p - avg)) / prices.Count;
        decimal volatility = (decimal)Math.Sqrt((double)variance);

        return new Dictionary<string, decimal>
        {
            { "Volatility", volatility },
            { "Beta", 1.0m },
            { "SharpeRatio", volatility == 0 ? 0 : avg / volatility }
        };
    }
}

// 4. Price History
public class PriceHistory<T> where T : IFinancialInstrument
{
    private Dictionary<T, List<(DateTime time, decimal price)>> _history = new();

    public void AddPrice(T instrument, DateTime timestamp, decimal price)
    {
        if (!_history.ContainsKey(instrument))
            _history[instrument] = new List<(DateTime, decimal)>();

        _history[instrument].Add((timestamp, price));
    }

    public decimal? GetMovingAverage(T instrument, int days)
    {
        if (!_history.ContainsKey(instrument)) return null;

        var recent = _history[instrument]
            .OrderByDescending(x => x.time)
            .Take(days)
            .Select(x => x.price)
            .ToList();

        if (recent.Count == 0) return null;
        return recent.Average();
    }

    public Trend DetectTrend(T instrument, int period)
    {
        if (!_history.ContainsKey(instrument)) return Trend.Sideways;

        var data = _history[instrument]
            .OrderByDescending(x => x.time)
            .Take(period)
            .Select(x => x.price)
            .ToList();

        if (data.Count < 2) return Trend.Sideways;

        if (data.First() > data.Last()) return Trend.Upward;
        if (data.First() < data.Last()) return Trend.Downward;

        return Trend.Sideways;
    }
}

// 5. TEST SCENARIO
public class Program
{
    public static void Main()
    {
        var stock1 = new Stock { Symbol = "AAPL", CurrentPrice = 180, CompanyName = "Apple" };
        var stock2 = new Stock { Symbol = "MSFT", CurrentPrice = 320, CompanyName = "Microsoft" };
        var bond1 = new Bond { Symbol = "BOND1", CurrentPrice = 105 };

        var portfolio = new Portfolio<IFinancialInstrument>();

        portfolio.Buy(stock1, 10, 170);
        portfolio.Buy(stock2, 5, 300);
        portfolio.Buy(bond1, 20, 100);

        Console.WriteLine("Portfolio Value: " + portfolio.CalculateTotalValue());

        var purchasePrices = new Dictionary<IFinancialInstrument, decimal>
        {
            { stock1, 170 },
            { stock2, 300 },
            { bond1, 100 }
        };

        var top = portfolio.GetTopPerformer(purchasePrices);
        if (top.HasValue)
            Console.WriteLine("Top Performer: " + top.Value.instrument.Symbol + 
                              " Return: " + top.Value.returnPercentage + "%");

        var strategy = new TradingStrategy<IFinancialInstrument>();

        strategy.Execute(
            portfolio,
            new List<IFinancialInstrument> { stock1, stock2, bond1 },
            x => x.CurrentPrice < 200,
            x => x.CurrentPrice > 300
        );

        var history = new PriceHistory<IFinancialInstrument>();
        history.AddPrice(stock1, DateTime.Now.AddDays(-3), 170);
        history.AddPrice(stock1, DateTime.Now.AddDays(-2), 175);
        history.AddPrice(stock1, DateTime.Now.AddDays(-1), 180);

        Console.WriteLine("Moving Avg: " + history.GetMovingAverage(stock1, 3));
        Console.WriteLine("Trend: " + history.DetectTrend(stock1, 3));

        var risk = strategy.CalculateRiskMetrics(new List<IFinancialInstrument> { stock1, stock2, bond1 });

        foreach (var r in risk)
            Console.WriteLine(r.Key + ": " + r.Value);
    }
}
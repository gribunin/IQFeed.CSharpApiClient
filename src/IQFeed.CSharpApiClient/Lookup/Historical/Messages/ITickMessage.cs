﻿namespace IQFeed.CSharpApiClient.Lookup.Historical.Messages
{
    public interface ITickMessage : IHistoricalMessage
    {
        double Ask { get; }
        char BasisForLast { get; }
        double Bid { get; }
        double Last { get; }
        int LastSize { get; }
        long TotalVolume { get; }
        long TickId { get; }
        string TradeConditions { get; }
        int TradeMarketCenter { get; }
    }
}
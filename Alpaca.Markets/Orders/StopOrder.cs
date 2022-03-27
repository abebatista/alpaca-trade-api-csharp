﻿namespace Alpaca.Markets;

/// <summary>
/// Encapsulates data required for placing the stop order on the Alpaca REST API.
/// </summary>
public sealed class StopOrder : SimpleOrderBase
{
    internal StopOrder(
        String symbol,
        OrderQuantity quantity,
        OrderSide side,
        Decimal stopPrice
    )
        : base(
            symbol, quantity, side,
            OrderType.Stop) =>
        StopPrice = stopPrice;

    /// <summary>
    /// Gets or sets the new order stop price.
    /// </summary>
    [UsedImplicitly]
    public Decimal StopPrice { get; }

    /// <summary>
    /// Creates new buy stop order using specified symbol and quantity.
    /// </summary>
    /// <param name="symbol">Order asset name.</param>
    /// <param name="quantity">Order quantity.</param>
    /// <param name="stopPrice">Order stop price.</param>
    /// <returns>The new <see cref="StopOrder"/> object instance.</returns>
    [UsedImplicitly]
    public static StopOrder Buy(
        String symbol,
        OrderQuantity quantity,
        Decimal stopPrice) =>
        new(
            symbol, quantity, OrderSide.Buy, stopPrice);

    /// <summary>
    /// Creates new sell buy order using specified symbol and quantity.
    /// </summary>
    /// <param name="symbol">Order asset name.</param>
    /// <param name="quantity">Order quantity.</param>
    /// <param name="stopPrice">Order stop price.</param>
    /// <returns>The new <see cref="StopOrder"/> object instance.</returns>
    [UsedImplicitly]
    public static StopOrder Sell(
        String symbol,
        OrderQuantity quantity,
        Decimal stopPrice) =>
        new(
            symbol, quantity, OrderSide.Sell, stopPrice);

    internal override JsonNewOrder GetJsonRequest() =>
        base.GetJsonRequest()
            .WithStopPrice(StopPrice);
}

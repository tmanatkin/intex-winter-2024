﻿using System;
using System.Collections.Generic;

namespace Intex.Models;

public partial class Orders
{
    public int? TransactionId { get; set; }

    public int? CustomerId { get; set; }

    public DateTime? Date { get; set; }

    public string? DayOfWeek { get; set; }

    public byte? Time { get; set; }

    public string? EntryMode { get; set; }

    public short? Amount { get; set; }

    public string? TypeOfTransaction { get; set; }

    public string? CountryOfTransaction { get; set; }

    public string? ShippingAddress { get; set; }

    public string? Bank { get; set; }

    public string? TypeOfCard { get; set; }

    public string? Fraud { get; set; }
}
